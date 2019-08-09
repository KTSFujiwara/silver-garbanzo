using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電卓_ステートパターン_
{
    public class ResetState :  IState
    {
        public override IState NumClickEvent(string pushNum, ref float input1, ref float input2,ref string ope, ref string answer)
        {
            if (pushNum == "0")
                return this;
            else
                answer = pushNum;

            input1 = float.Parse(answer);
                return new Int1State();            
        }
        public override IState CommaClickEvent(ref string answer)
        {
            answer = "0.";
            return new Float1State();
        }
        public override IState OpeClickEvent(string newOperator, ref float input1, ref float input2, ref string currOperator, ref string answer)
        {
            currOperator = newOperator;
            return new Input2State();
        }
        public override IState EqualClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            return this;
        }
        public override IState ClearClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            return this;
        }
    }
}
