using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_3
{
    public enum Operators
    {
        Add,
        Sub,
        Multi,
        Div
    }

    public partial class Calculator : Form
    {
        public double Result = 0;
        public bool isNewNum = true;
        public Operators opt = Operators.Add;


        public Calculator()
        {
            InitializeComponent();
        }

        #region Button click
        //private void NumButton1_Click(object sender, EventArgs e)
        //{
        //    if (NumScreen.Text == "0")
        //    {NumScreen.Text = "1"; }
        //    else
        //    {NumScreen.Text = NumScreen.Text + "1";}
        //}

        //private void NumButton2_Click(object sender, EventArgs e)
        //{
        //    if (NumScreen.Text == "0")
        //    { NumScreen.Text = "2"; }
        //    else
        //    { NumScreen.Text = NumScreen.Text + "2"; }
        //}  
        #endregion

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        //버튼 클릭
        // 변수 = 0
        // 연산자 = +

        // 숫자입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.
        // 숫자 입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.
        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);
                if (opt == Operators.Add)
                {
                    Result = Result + num;
                }
                else if (opt == Operators.Sub)
                {
                    Result = Result - num;
                }
                else if (opt == Operators.Multi)
                {
                    Result = Result * num;
                }
                else if (opt == Operators.Div)
                {
                    Result = Result / num;
                }
                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
            {
                opt = Operators.Add;
            }
            else if (optButton.Text == "-")
            {
                opt = Operators.Sub;
            }
            else if (optButton.Text == "×")
            {
                opt = Operators.Multi;
            }
            else if (optButton.Text == "÷")
            {
                opt = Operators.Div;
            }

        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            opt = Operators.Add;
            NumScreen.Text = "0";
        }
       
    }
}
