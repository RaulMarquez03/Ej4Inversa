namespace Ej4Inversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                string[] numbers = textBox1.Text.Split(',');
                string output = "";
                for (int i = numbers.Length -1; i > 0; i--) {
                    output += numbers[i] + ",";
                    
                }
                output += numbers[0];
                label1.Text = output;
            }
        }
    }
    
}
