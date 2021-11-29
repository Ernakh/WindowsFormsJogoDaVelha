namespace WinFormsJogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            lblVez.Text = "X";

            botoesEnable();

            btnX.Enabled = false;
            btnO.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            lblVez.Text = "O";

            botoesEnable();

            btnX.Enabled = false;
            btnO.Enabled = false;
        }

        private void botoesEnable()
        {
            btnC1L1.Enabled = true;
            btnC2L1.Enabled = true;
            btnC3L1.Enabled = true;
            btnC1L2.Enabled = true;
            btnC2L2.Enabled = true;
            btnC3L2.Enabled = true;
            btnC1L3.Enabled = true;
            btnC2L3.Enabled = true;
            btnC3L3.Enabled = true;
        }

        private void botoesEnableF()
        {
            btnC1L1.Enabled = false;
            btnC2L1.Enabled = false;
            btnC3L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC2L2.Enabled = false;
            btnC3L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L3.Enabled = false;
        }

        private void btnRecomeçar_Click(object sender, EventArgs e)
        {
            btnC1L1.Enabled = false;
            btnC2L1.Enabled = false;
            btnC3L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC2L2.Enabled = false;
            btnC3L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L3.Enabled = false;

            btnC1L1.Text = "";
            btnC2L1.Text = "";
            btnC3L1.Text = "";
            btnC1L2.Text = "";
            btnC2L2.Text = "";
            btnC3L2.Text = "";
            btnC1L3.Text = "";
            btnC2L3.Text = "";
            btnC3L3.Text = "";

            lblVez.Text = " - ";
            lblVencedor.Text = " - ";

            btnX.Enabled = true;
            btnO.Enabled = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if(lblVez.Text == "X")
            {
                lblVez.Text = "O";
                btn.Text = "X";
                btn.Enabled = false;
            }
            else
            {
                lblVez.Text = "X";
                btn.Text = "O";
                btn.Enabled = false;
            }

            verificaVencedor();
        }

        private void verificaVencedor()
        {
            if(btnC1L1.Text == btnC2L1.Text && btnC1L1.Text == btnC3L1.Text 
                && btnC1L1.Text != "")
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if(btnC1L2.Text == btnC2L2.Text && btnC3L2.Text == btnC1L2.Text
                && btnC1L2.Text != "")
            {
                lblVencedor.Text = btnC1L2.Text;
                MessageBox.Show(btnC1L2.Text + " é o vencedor!");
                botoesEnableF();
            }
            
        }
    }
}