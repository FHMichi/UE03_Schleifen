namespace UE03_Schleifen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"Z�hl" Schleife --> For-Loop, Perfekt f�r Loops in denen gez�hlt werden muss 
            label1.Text = string.Empty; 
            for (int i = 0; i < 10; i++)
            {
                label1.Text += i.ToString("00") + "\n"; 
            }
        }
    }
}
