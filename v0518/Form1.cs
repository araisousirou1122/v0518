namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1.Left = 0;

            label1.Top = label1.Top - 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            label1.Text = "ˆ¢";
            label2.Text = "™Ý";

        }
    }
}