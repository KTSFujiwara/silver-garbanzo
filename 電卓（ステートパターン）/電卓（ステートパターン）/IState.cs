using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電卓_ステートパターン_
{
    public abstract class  IState
    {
        abstract public  IState NumClickEvent(string pushNum, ref float input1, ref float input2, ref string ope, ref string answer);
        abstract public  IState CommaClickEvent(ref string answer);
        abstract public  IState OpeClickEvent(string newOperator, ref float input1, ref float input2, ref string currOperator, ref string answer);
        abstract public  IState EqualClickEvent(ref float input1, ref float input2, ref string ope, ref string answer);
        abstract public  IState ClearClickEvent(ref float input1, ref float input2, ref string ope, ref string answer);
        
        public void Calclation(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            if (ope == "+")
            {
                answer = (input1 + input2).ToString();
            }
            else if (ope == "-")
            {
                answer = (input1 - input2).ToString();
            }
            else if (ope == "×")
            {
                answer = (input1 * input2).ToString();
            }
            else if (ope == "÷" && input2 != 0)
            {
                answer = (input1 / input2).ToString();
            }
            input1 = float.Parse(answer);
        }
        public void Clear(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            input1 = 0;
            input2 = 0;
            ope = "";
            answer = "0";
        }
    }
}
