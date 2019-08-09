using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電卓_ステートパターン_
{
    class CalcState :  IState
    {
        public override IState NumClickEvent(string pushNum, ref float input1, ref float input2, ref string ope, ref string answer)
        {
            Clear(ref input1, ref input2, ref ope, ref answer);
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
            input1 = float.Parse(answer);
            currOperator = newOperator;
            return new Input2State();
        }
        public override IState EqualClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            Calclation(ref input1, ref input2, ref ope, ref answer);
            input1 = float.Parse(answer);
            return this;
        }
        public override IState ClearClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            Clear(ref input1, ref input2, ref ope, ref answer);
            return new ResetState();
        }
    }
}
