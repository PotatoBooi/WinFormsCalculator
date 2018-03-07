using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        private double result = 0.0;
        private double firstNum = 0.0;
        private double secondNum = 0.0;


        private string operation ="";
        private bool operationPerformed = false;
        
        
        public Kalkulator()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            InitializeComponent();
            
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button buttons = (Button)sender;
            if((textBoxDisplay.Text == "0") || (operationPerformed))
            {
                textBoxDisplay.Text = "";
            }

            operationPerformed = false;
            if (textBoxDisplay.Text.Length < 14)
            {
              //  if (buttons.Text == ".")
              //  {
                //    if (!textBoxDisplay.Text.Contains("."))
                        //textBoxDisplay.Text += buttons.Text;
               // }
              //  else
              //  {
                    textBoxDisplay.Text += buttons.Text;
               // }
            }
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
           Button operationbtn = (Button)sender;
           operation = operationbtn.Text;

            if (textBoxDisplay.Text != "" && textBoxDisplay.Text !=".")
            {
                firstNum = Double.Parse(textBoxDisplay.Text);
                labelPreviousOperation.Text = textBoxDisplay.Text + " " + operationbtn.Text;
            }
           
          
            operationPerformed = true;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if(textBoxDisplay.Text.Length > 0 )
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }

            if (textBoxDisplay.Text == "" && !operationPerformed)
                textBoxDisplay.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            result = 0.0;
            if (textBoxDisplay.Text != "" && labelPreviousOperation.Text !="")
            {
                secondNum = Double.Parse(textBoxDisplay.Text);
               

                switch (operation)
                {
                    case "+":
                        result = firstNum + secondNum;
                       
                        break;
                    case "−":
                        result = firstNum - secondNum;
                      
                        break;
                    case "✕":
                        result = firstNum * secondNum;
                       
                        break;
                    case "÷":
                        if (secondNum != 0.0)
                        {
                            result = firstNum / secondNum;
                            
                        }
                        else
                        {
                            MessageBox.Show("You can't divide by 0!");
                          
                        }
                        break;
                    default:
                        break;

                }

                buttonC.PerformClick();
                if ((result < Double.MinValue) || (result >= Double.MaxValue))
                {
                    MessageBox.Show("Out of range!");
                    buttonC.PerformClick();
                }
               
                else
                {
                    
                        int whereisE = result.ToString().IndexOf("E");
                        string tmp = result.ToString();
                    if(whereisE > 0)
                    {
                        textBoxDisplay.Text = tmp.Remove(Math.Abs(whereisE - tmp.Length), whereisE - Math.Abs(whereisE - tmp.Length) - 4);
                    }
                    else
                    {
                        textBoxDisplay.Text = result.ToString();
                    }


                   


                }


                operationPerformed = false;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            labelPreviousOperation.Text = "";
            firstNum = 0.0;
            secondNum = 0.0;

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            
            textBoxDisplay.Text = "0";
                        
        }

        private void buttonDecSep_Click(object sender, EventArgs e)
        {
            Button decbtn = (Button)sender;

            if (!textBoxDisplay.Text.Contains("."))
                textBoxDisplay.Text += decbtn.Text;
        }
    }
}
