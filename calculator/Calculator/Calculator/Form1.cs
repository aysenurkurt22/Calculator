using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private char _islem;
        private bool _ekranSil;
        int _ilkSayi;
        bool rakamSil;

        public Calculator()
        {
            InitializeComponent();
        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if(ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "1" ;

            
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "2";
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e) 
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }

            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "4";
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }

            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "5";
        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
               
            } 
            ekranLabel1.Text += "6";
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "7";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
               
            } 
            ekranLabel1.Text += "8";
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
                
            }
            ekranLabel1.Text += "9";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_ekranSil)
            {
                ekranLabel1.Text = "";
                _ekranSil = false;
            }
            if (ekranLabel1.Text == "0")
            {
                ekranLabel1.Text = "";
               
            }
            ekranLabel1.Text += "0";
        }

        private void butonartı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranSil = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);

        }
        private void butoneksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranSil = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);
        }
        
        private void butoncarpı_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranSil = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);
        }

        private void butonbölme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranSil = true;
            _ilkSayi = Convert.ToInt32(ekranLabel1.Text);
        }
    

        private void butonesittir_Click(object sender, EventArgs e)
        {
            int _ikinciSayi = Convert.ToInt32(ekranLabel1.Text);
            int sonuc=0;
            switch (_islem) 
            {

                case '+':
                    sonuc = _ilkSayi + _ikinciSayi;
                    break;    

                case '-':
                    sonuc = _ilkSayi - _ikinciSayi;
                    break;

                case '*':
                    sonuc = _ilkSayi * _ikinciSayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / _ikinciSayi;
                    break;
            
            }
            ekranLabel1.Text = Convert.ToString(sonuc);
        }

        private void butonC_Click(object sender, EventArgs e)
        {
            ekranLabel1.Text = "0";
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (ekranLabel1.Text.Length > 0)
            {
                ekranLabel1.Text = ekranLabel1.Text.Substring(0, ekranLabel1.Text.Length-1 );
            }




        }
    }
}