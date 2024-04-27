namespace Botao_fujao
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRejeitar_MouseEnter(object sender, EventArgs e)
        {
            int largura = this.Size.Width;
            int altura = this.Size.Height;

            int x = random.Next(0, (largura-btnRejeitar.Width));
            int y = random.Next(0, (altura - btnRejeitar.Height));

            btnRejeitar.Location = new Point(x, y);
        }
    }
}