using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KifejezesKiertekelo
{
    public class Analyzer
    {
        private bool elfogad;
        private bool error = false;
        string vesszo = "'";
        string Eps = "Eps";
        MainForm mf;
        public Analyzer(MainForm mainForm)
        {
            mf = mainForm;
        }

        Stack<string> verem = new Stack<string>();

        public void fillStack(string expr)
        {
            while(verem.Count != 0)
            {
                verem.Pop();
            }
            for (int i = expr.Length - 1; i >= 0; i--)
            {
                verem.Push(expr[i].ToString());
            }
        }
        private string getContentOfStack()
        {
            IEnumerable<string> remainingExpressionsInEnumerable;
            remainingExpressionsInEnumerable = verem.ToArray();
            return string.Join("", remainingExpressionsInEnumerable.ToArray());
        }

        public bool Analyze(DataGridView dgw, Expression expr)
        {
            elfogad = false;
            try
            {
                while (!elfogad)
                {
                    if (error)
                    {
                        return false;
                    }
                    if (ItsFinished(expr))
                    {
                        AddToRichTextBox("Elfogad");
                        expr.FirstPart.Remove(0, 1);
                        expr.SecondPart.Remove(0, 1);
                        elfogad = true;
                        return true;

                    }
                    else if (ItsaPop(expr))
                    {
                        if (verem.Count != 0)
                        {
                            verem.Pop();
                            Expression newExpr = new Expression();
                            newExpr.FirstPart = getContentOfStack();
                            newExpr.SecondPart = string.Concat("", expr.SecondPart.Remove(0, 1));
                            newExpr.ThirdPart = expr.ThirdPart;

                            AddToRichTextBox(newExpr.ToString());
                            Analyze(dgw, newExpr);
                        }
                    }

                    else
                    {
                        string result = FindCellValue(dgw, expr);

                        if (result.Equals(string.Empty))
                        {
                            AddToRichTextBox("ERROR");
                            error = true;
                            return false;
                        }
                        else
                        {
                            string[] result_expr = result.Split(','); 

                            Expression newExp = new Expression();
                            newExp.FirstPart = expr.FirstPart;
                            
                            if (result_expr[0].ToString().Equals(Eps))
                            {
                                if (expr.SecondPart[1].ToString().Equals(vesszo)) 
                                {
                                    newExp.SecondPart = string.Concat("", expr.SecondPart.Remove(0, 2));
                                }
                                else 
                                {
                                    newExp.SecondPart = string.Concat("", expr.SecondPart.Remove(0, 1));
                                }
                            }
                            else 
                            {
                                if (expr.SecondPart.Length > 1 && expr.SecondPart[1].ToString().Equals(vesszo))
                                {
                                    newExp.SecondPart = string.Concat(result_expr[0], expr.SecondPart.Remove(0, 2));
                                }
                                else
                                {
                                    newExp.SecondPart = string.Concat(result_expr[0], expr.SecondPart.Remove(0, 1));
                                }
                            }

                            if (expr.ThirdPart.Equals(string.Empty))
                            {
                                newExp.ThirdPart = result_expr[1];
                            }
                            else
                            {
                                newExp.ThirdPart = expr.ThirdPart + result_expr[1];
                            }

                            string newExpression = newExp.ToString();

                            AddToRichTextBox(newExpression);
                            Analyze(dgw, newExp);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return true;
        }

        private bool ItsaPop(Expression expr)
        {
            return (expr.FirstPart[0].ToString() == expr.SecondPart[0].ToString()) ? true : false;
        }
        private bool ItsFinished(Expression expr)
        {
            return (expr.FirstPart[0].ToString() == "#" && expr.SecondPart[0].ToString() == "#") ? true : false;
        }
        private void AddToRichTextBox(string text)
        {
            mf.UpdateStepTextBox(text);
        }

        private string FindCellValue(DataGridView dgw, Expression expr)
        {
            int CellRowIndex = 0;
            int CellColumnIndex = 0;
            foreach (DataGridViewRow row in dgw.Rows) // végig iterálok a sorokon, az első sorban keresek egy elemet
            {
                foreach (DataGridViewCell cell in row.Cells) //végig iterálok az adott sor celláin
                {
                    if (expr.FirstPart[0].ToString().Equals(cell.Value.ToString())) //megkeresem azt a cellát, aminek az olszopa a firstpart[0]. eleme
                    {
                        CellColumnIndex = cell.ColumnIndex;
                        break;
                    }

                }
                break;
            }

            bool exit = false;
            
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells) //ide kéne a felsővesszőt is hozzáadni
                {
                    //if (expr.SecondPart[1].ToString().Equals(vesszo)) //ha a következő karakter egy felső vessző
                    if (expr.SecondPart.Length > 1 && expr.SecondPart[1].ToString().Equals(vesszo))
                    {
                        string VesszosKifejezes = string.Concat(expr.SecondPart[0] + "'");
                        if (VesszosKifejezes.Equals(cell.Value.ToString()))
                        {
                            CellRowIndex = cell.RowIndex;
                            exit = true;
                            break;
                        }
                    }
                    else if (expr.SecondPart[0].ToString().Equals(cell.Value.ToString()))
                    {
                        CellRowIndex = cell.RowIndex;
                        exit = true;
                        break;
                    }

                }
                if (exit)
                {
                    break;
                }
            }

            if (dgw.Rows[CellRowIndex].Cells[CellColumnIndex].Value.ToString().Equals(string.Empty))
            {
                return string.Empty;
            }
            else
            {
                string[] CellValue = dgw.Rows[CellRowIndex].Cells[CellColumnIndex].Value.ToString().Split(','); //zárójel még benne van
                string newFirstValue = CellValue[0].Remove(0, 1);
                string newSecondValue = CellValue[1].Remove(1); // sikeresek kiszedi a zárójeleket
                return string.Format(newFirstValue + "," + newSecondValue);
            }
        }
    }
}
