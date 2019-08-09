using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電卓_ステートパターン_
{
    class Float2State :  IState
    {
        public override IState NumClickEvent(string pushNum, ref float input1, ref float input2, ref string ope, ref string answer)
        {
            answer += pushNum;
            input2 = float.Parse(answer);
            return this;
        }
        public override IState CommaClickEvent(ref string answer)
        {
            return this;
        }
        public override IState OpeClickEvent(string newOperator, ref float input1, ref float input2, ref string currOperator, ref string answer)
        {
            Calclation(ref input1, ref input2, ref currOperator, ref answer);
            input1 = float.Parse(answer);
            currOperator = newOperator;
            return new Input2State();
        }
        public override IState EqualClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            Calclation(ref input1, ref input2, ref ope, ref answer);
            input1 = float.Parse(answer);
            return new CalcState();
        }
        public override IState ClearClickEvent(ref float input1, ref float input2, ref string ope, ref string answer)
        {
            input2 = 0;
            return new Input2State();
        }
    }
}
