using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class AceVal : Form
    {
        public int AceValue { get; private set; }
        public AceVal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AceValue = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            AceValue = 11;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AceVal_Load(object sender, EventArgs e)
        {

        }
    }
}
