using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Sharing_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Invitation = textBox1.Text;// "";// Interaction.InputBox("Insert Invitation ConnectionString", "Attention");
            axRDPViewer1.Connect(Invitation, "User1", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axRDPViewer1.Disconnect();
        }
    }
}
