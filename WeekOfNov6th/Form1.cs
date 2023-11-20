using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (txtTempMoneyUnit.Text == "")
            {
                txtTempMoneyUnit.Text += "0";
            }
            string Value = txtTempMoneyUnit.Text;
            int intValue = int.Parse(Value);
            if (rdoTempConverter1.Checked == true)
            {
                rtbOutput.Text += $"{txtTempMoneyUnit.Text} to farenheit is {intValue *9/5+32}";
            }
            if (rdoTempConverter2.Checked == true)
            {
                rtbOutput.Text += $"{txtTempMoneyUnit.Text} to celcius is {(intValue- 32) * 5 / 9}";
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {   
            if (txtTempMoneyUnit.Text == "")
            {
                txtTempMoneyUnit.Text = "0";
            }
            string Value = txtTempMoneyUnit.Text;
            int intValue = int.Parse(Value);
            
            if (cmbMoneyConverter.SelectedIndex == 0)
            {
                if(txtTempMoneyUnit.Text != "")
                {
                txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}USD to Yen is {intValue *149.79}";
            }

            if (cmbMoneyConverter.SelectedIndex == 1)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}Yen to USD is {intValue * 0.0067}";
            }

            if (cmbMoneyConverter.SelectedIndex == 2)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}USD to Indian Rupee is {intValue * 83.22}";
            }

            if (cmbMoneyConverter.SelectedIndex == 3)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}Indian Rupee to USD is {intValue * 0.12}";
            }

            if (cmbMoneyConverter.SelectedIndex == 4)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}USD to Euro is {intValue * 0.93}";
            }

            if (cmbMoneyConverter.SelectedIndex == 5)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}Euro to USD is {intValue * 1.07}";
            }

            if (cmbMoneyConverter.SelectedIndex == 6)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}USD to Canadian Dollar is {intValue * 1.37}";
            }

            if (cmbMoneyConverter.SelectedIndex == 7)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue}Canadian Dollar to USD is {intValue * 0.73}";
            }

            if (cmbMoneyConverter.SelectedIndex == 8)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue} to Pesos is {intValue * 17.56}";
            }

            if (cmbMoneyConverter.SelectedIndex == 9)
            {
                if (txtTempMoneyUnit.Text != "")
                {
                    txtTempMoneyUnit.Text += "\n";
                }
                rtbOutput.Text += $"{intValue} to USD is {intValue * 0.057}";
            }
        }
    

    

        private void btnLarge_Click(object sender, EventArgs e)
        {
            if (txtDistanceUnit.Text == "")
            {
                txtDistanceUnit.Text += "0";
            }
            string kValue = txtDistanceUnit.Text;
            int intKValue = int.Parse(kValue);
            if (chkKiloToMiles.Checked == true)
            {
                rtbOutput.Text += $"{intKValue} to Miles is {intKValue / 1.609344}";
            }
            if (chkMileToKilo.Checked == true)
            {
                rtbOutput.Text += $"{intKValue} to Kilos is {intKValue * 1.609344}";
            }
            else
            {
                rtbOutput.Text += "Please enter something.";
            }
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            if (txtDistanceUnit.Text == "")
            {
                txtDistanceUnit.Text += "0";
            }
            string iValue = txtDistanceUnit.Text;
            int intIValue = int.Parse(iValue);
            if (chkInchToMeter.Checked == true)
            {
                rtbOutput.Text += $"{intIValue} to Miles is {intIValue / 1.609344}";
            }
            if (chkMeterToInch.Checked == true)
            {
                rtbOutput.Text += $"{intIValue} to celcius is {intIValue * 1.609344}";
            }
            else
            {
                rtbOutput.Text += "Please enter something.";
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string koob = @"C:\\Users\\zande\\source\\repos\\weekofnov6th-SofaPop\\WeekOfNov6th\\bin\\test.txt";
            string[] text = File.ReadAllLines(koob);
            for (var i=0; i < text.Length; i++)
            {
                rtbOutput.Text += text[i];
            }
        }

        private void btnNerdVSGeek_Click(object sender, EventArgs e)
        {
            if (txtTempMoneyUnit.Text == "")
            {
                txtTempMoneyUnit.Text = "1";
            }
            string u = txtTempMoneyUnit.Text;
            int iu = int.Parse(u);
            string toob = @"C:\\Users\\zande\\source\\repos\\weekofnov6th-SofaPop\\WeekOfNov6th\\bin\\test.txt";
            string text = File.ReadAllText(toob);
            string[] words = text.Split(' ');

            for (var i=0; i<= words.Length-1; i+=iu)
            {
                rtbOutput.Text += $"{words[i]} ";
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            int counter = 25;
            int switchd = 0;
            bool caseChange = false;




            char[] LowerCaseAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] UpperCaseAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i =0; i <= LowerCaseAlphabet.Length-1; i++)
            {
                if (LowerCaseAlphabet[i] == 'a' || LowerCaseAlphabet[i] == 'e' || LowerCaseAlphabet[i] == 'i' || LowerCaseAlphabet[i] == 'o' || LowerCaseAlphabet[i] == 'u')
                {
                    rtbOutput.Text += UpperCaseAlphabet[i];
                }
                else
                {
                    rtbOutput.Text += LowerCaseAlphabet[i];
                }
            }

            rtbOutput.Text += "\n";
            while(counter != 0) { 
            }
        } 
    }
}
