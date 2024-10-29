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
            //"Zähl" Schleife --> For-Loop, Perfekt für Loops in denen gezählt werden muss; fixxe dauer 
            label1.Text = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                label1.Text += i.ToString("00") + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //While Schleife für unbekannte dauer
            label2.Text = string.Empty;
            double x = 1;
            while (x < 1000)
            {
                x *= 2;
                label2.Text += x.ToString() + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Do While wenn IMMER ein Schleifen durchlauf passieren soll 
            //Oder BIS sich ein Status ändert 
            label3.Text = string.Empty;
            double x = 1000;
            do
            {
                x *= 1000;
                label3.Text += x.ToString() + "\n";

            } while (x < 1000);
        }
    }
}
