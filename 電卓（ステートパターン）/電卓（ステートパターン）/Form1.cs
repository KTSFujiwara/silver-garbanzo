using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電卓_ステートパターン_
{
    public partial class Form1 : Form
    {
        public float _input1 = 0;
        public float _input2 = 0;
        public string _operator = "";
        public string _answer = "";
        private  IState state;

        public Form1()
        {
            InitializeComponent();
            resultTextBox.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            state = new ResetState();
        }
        public void NumClick(object sender, EventArgs e)
        {
            this.state= this.state.NumClickEvent(((Button)sender).Text,ref _input1,ref _input2, ref _operator, ref _answer);
            resultTextBox.Text = _answer;
        }
        public void CommaClick(object sender, EventArgs e)
        {
            this.state = this.state.CommaClickEvent(ref _answer);
        }
        public void OpeClick(object sender, EventArgs e)
        {
            this.state = this.state.OpeClickEvent(((Button)sender).Text, ref _input1, ref _input2, ref _operator, ref _answer);
            resultTextBox.Text = _answer;
        }
        public void EqualClick(object sender, EventArgs e)
        {
            this.state = this.state.EqualClickEvent(ref _input1, ref _input2, ref _operator, ref _answer);
            resultTextBox.Text = _answer;
        }
        public void ClearClick(object sender, EventArgs e)
        {
            this.state = this.state.ClearClickEvent(ref _input1, ref _input2, ref _operator, ref _answer);
            resultTextBox.Text = _answer;
        }
        
    }
}


