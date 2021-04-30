using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN1.GUI
{
    public partial class CreateInputDialog : Form
    {
        GUIMediator GUIMediator;
        public CreateInputDialog(GUIMediator GUIMediator)
        {
            InitializeComponent();
            this.GUIMediator = GUIMediator;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            GUIMediator.N = int.Parse( NTextBox.Text);
            GUIMediator.M = int.Parse(MTextBox.Text);
            GUIMediator.createTestVectors();
            this.Close();
        }
    }
}
