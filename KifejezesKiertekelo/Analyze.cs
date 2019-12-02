using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KifejezesKiertekelo
{
    public class Analyzer
    {
        private MainForm form;
        private bool elfogad = false;

        public Analyzer(MainForm form)
        {
            this.form = form;
        }

        Stack<string> verem = new Stack<string>();

        public void fillStack(string expr)
        {
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
            while (!elfogad)
            {
                if (ItsFinished(expr))
                {
                    AddToRichTextBox("Elfogad");
                    elfogad = true;
                    return true;

                }
                else if (ItsaPop(expr))
                {
                    if(verem.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        this.verem.Pop();
                        string newSecondPart = expr.SecondPart.Remove(0);
                        string addValue = "(" + getContentOfStack() + "," + newSecondPart + "," + expr.ThirdPart + ")";
                        AddToRichTextBox(addValue);
                    }
                    
                }
                else if (ItsAnError(dgw, expr))
                {

                }
                else // ha változtatni kell
                {

                    AddToRichTextBox("senem pop, senem finish");
                    break;
                }
                
            }
            return false;
        }

        private bool ItsaPop(Expression expr)
        {
            //az első feltétel vizsgálat nem biztos hogy kell, mert az Analyze függvényben először azt vizsgáljuk, hogy #-e mind a két érték

            return (!expr.FirstPart[0].ToString().Equals("#") && expr.FirstPart[0].ToString() == expr.SecondPart[0].ToString()) ? true : false;
        }
        private bool ItsFinished(Expression expr)
        {
            return (expr.FirstPart[0].ToString() == "#" && expr.SecondPart[0].ToString() == "#") ? true : false;
        }

        private void AddToRichTextBox(string text)      // gyászkeret
        {
            MainForm.ActiveForm.Controls["richTextBox_steps"].Text += text + "\n";
        }

        //private bool ItsAnError(DataGridView dgw, Expression expr)
        //{
        //    foreach (DataGridViewRow row in dgw.Rows)
        //    {
        //        if(expr.FirstPart[0].ToString())
        //    }
        //}

    }
}
