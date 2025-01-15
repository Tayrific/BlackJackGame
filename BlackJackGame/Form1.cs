namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            SinglePlayerForm singlePlayerForm = new SinglePlayerForm();
            singlePlayerForm.Show();
            FormClosing += Form1_FormClosing;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();



        }
    }
}
