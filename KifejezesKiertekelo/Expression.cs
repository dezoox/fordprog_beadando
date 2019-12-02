using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifejezesKiertekelo
{
    public class Expression
    {
        private string firstPart;
        private string secondPart;
        private string thirdPart;

        public string FirstPart
        {
            get { return firstPart; }
            set { firstPart = value; }
        }

        public string SecondPart
        {
            get { return secondPart; }
            set { secondPart = value; }
        }
        public string ThirdPart
        {
            get { return thirdPart; }
            set { thirdPart = value; }
        }

        public Expression()
        {

        }
        /// <summary>
        /// Add the expression one by one. 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public Expression(string first, string second, string third)
            : this()
        {
            this.FirstPart = first;
            this.SecondPart = second;
            this.ThirdPart = third;
        }

        /// <summary>
        /// Divide the expression's parts with commas or dots.
        /// </summary>
        /// <param name="expression"></param>
        public Expression(string expression)
            : this()
        {
            //string[] splitted = expression.Split(',', '.');
            this.FirstPart = expression + "#";
            this.SecondPart = "E#";
            this.ThirdPart = string.Empty;
        }

        /// <summary>
        /// formats the Expression like (string#,string#,string)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           return string.Format("(" + FirstPart + "," + SecondPart + "," + ThirdPart + ")");
        }
    }
}
