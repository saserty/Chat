using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Program prog;
        private void buttonSend_Click(object sender, EventArgs e)
        {
            listViewChat.Items.Add("You:", richTextBox.Text);

            var items = listViewChat.Items;
            var last = items[items.Count - 1];
            last.EnsureVisible();

            listViewChat.Items.Add(prog.Answers(richTextBox.Text));
            richTextBox.Text = null;
        }
    }
}
