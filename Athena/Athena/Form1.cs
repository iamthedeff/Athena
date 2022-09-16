namespace Athena
{
    public partial class Athena : Form
    {
        public Athena()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //START
        private void button1_Click(object sender, EventArgs e)
        {
            tmpSend.Enabled = true;

        }

        //STOP
        private void button2_Click(object sender, EventArgs e)
        {
            tmpSend.Enabled = false;

        }
        //TEXT
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //SENDER
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Athena_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Athena_Load(object sender, EventArgs e)
        {

        }
    }

 

}