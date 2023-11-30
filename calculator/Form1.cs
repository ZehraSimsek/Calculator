namespace calculator
{
    public partial class Form1 : Form
    {
        private int _ilksy;
        private bool _ekranitemizle;
        private char _islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle) {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text=="0") {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {   
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekranitemizle)
            {
                ekranlabel.Text = "";
                _ekranitemizle = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";
        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }

        private void toplabutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void cıkarbutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void carpmabutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void bolmebutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void yuzdebutton_Click(object sender, EventArgs e)
        {
            _islem = '%';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void parantezbutton_Click(object sender, EventArgs e)
        {
            _islem = ')';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void virgulbutton_Click(object sender, EventArgs e)
        {
            _islem = ',';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;
        }

        private void isaretbutton_Click(object sender, EventArgs e)
        {
            _islem = 'i';
            _ilksy = Convert.ToInt32(ekranlabel.Text);
            _ekranitemizle = true;

        }
    
        private void esittirbutton_Click(object sender, EventArgs e)
        {
            int ikincisy = Convert.ToInt32(ekranlabel.Text);
            int sonuc;

            switch (_islem) 
            {
                case '+':
                    sonuc = _ilksy + ikincisy;
                    break;
                case '-':
                    sonuc = _ilksy - ikincisy;
                    break;
                case '*':
                    sonuc = _ilksy * ikincisy;
                    break;
                case '/':
                    sonuc = _ilksy / ikincisy;
                    break;
                case '%':
                    int ilka = _ilksy * ikincisy;
                    sonuc = ilka / 100;
                    break;
                case ')':
                    sonuc = _ilksy + ')';
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranlabel.Text = Convert.ToString(sonuc);
        }
    }
}