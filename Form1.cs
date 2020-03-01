using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharAndFibonacci
{
    public partial class Form1 : Form
    {
        //List<int> t = new List<int>();
        bool elsoClick=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFibo_Click(object sender, EventArgs e)
        {
            textBoxFiboMegoldas.Text = "";
            string stringFibo = textBoxFibo.Text;
            int N = stringFibo.Length;
            
            if (N != 0)
            {
               


                //Fibonacci számsorozat kiszámítva 55-ig
                int[] t = new int[11];
                t[0] = 0;
                t[1] = 1;
                for (int i = 2; i < 11; i++)
                {
                    t[i] = (t[i - 2] + t[i - 1]);
                    //MessageBox.Show(t[i].ToString());
                }
                // fibonacci sorozat vége
                // Kis és nagybetűk megváltoztatása
                
                char[] charsFibo = stringFibo.ToCharArray();
                //MessageBox.Show(charsFibo.Length.ToString());
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < t.Length; j++)
                    { 
                        //textBoxFiboMegoldas.Text += t[j].ToString()+" " ;
                        if (i == t[j])
                        {
                            if (j==1)
                            {
                                j++;
                            }
                            if (char.IsLower(charsFibo[i]))
                            {
                                charsFibo[i] = char.ToUpper(charsFibo[i]);
                            }
                            else
                            {
                                charsFibo[i] = char.ToLower(charsFibo[i]);
                                

                            }

                        }
                    }
                    char.ToLower(charsFibo[i]);
                    //MessageBox.Show(charsFibo[i].ToString());
                    textBoxFiboMegoldas.Text += charsFibo[i].ToString();
                   

                }
            }
            else
            { MessageBox.Show("Kérem írjon be valamit a szövegdobozba"); }
            

        }

        private void textBoxFibo_Click(object sender, EventArgs e)
        {
            if (elsoClick)
            {
                textBoxFibo.Text = "";
                elsoClick = false;
            }
            
        }
    }
}
