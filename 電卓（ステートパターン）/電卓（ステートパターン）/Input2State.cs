using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電卓_ステートパターン_
{
    class Input2State :  IState
    {
        public override IState NumClickEvent(string pushNum, ref float input1, ref float input2, ref string ope, ref string answer)
        {
            answer = pushNum;
            input2 = float.Parse(answer);
            return new Int2State();
        }
        public override IState CommaClickEvent(ref string answer)
        {
            answer = "0.";
            return new Float2State();
        }
        public override IState OpeClickEvent(string newOperator, ref float input1, ref float input2, ref string currOperator, ref string answer)
        {
            currOperator = newOperator;
            return this;
        }
        public override IState EqualClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            Calclation(ref input1, ref input2, ref ope, ref answer);
            return new CalcState();
        }
        public override IState ClearClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            Clear(ref input1, ref input2, ref ope, ref answer);
            return new ResetState();
        }
    }
}
