namespace PTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)(13))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;   
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if ((textBox2.Text=="") || (textBox2.Text.Length<20)) 
            {
                MessageBox.Show("Endereço Inválido");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("E-mail Vazio");
                e.Cancel = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("celular-textbox4 perdeu o foco");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("CPF-textbox5 ganhou o foco");
        }
    }
}