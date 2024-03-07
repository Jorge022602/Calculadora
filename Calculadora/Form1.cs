namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cbasica calcub = new Cbasica();
            calcub.FormClosing += (s, args) => this.Show();
            calcub.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CCientifica calcuc = new CCientifica();
            calcuc.FormClosing += (s, args) => this.Show();
            calcuc.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
