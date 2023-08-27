namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.a.Text);
            int b = int.Parse(this.b.Text);
            int c = int.Parse(this.c.Text);

            if (a > b & a > c)
            {
                resultado.Text = a.ToString();
            }
            if (b > a & b > c)
            {
                resultado.Text = b.ToString();
            }
            if (c > a & c > b)
            {
                resultado.Text = c.ToString();
            }
        }
    }
}