using System;
using System.Drawing;
using System.Windows.Forms;

namespace SUGEF.Helpers
{
     class SetPlaceholder
    {
        readonly TextBox textBox;
        readonly string placeholder;
   
        public SetPlaceholder(TextBox textBox,string placeholder)
        {
            this.textBox = textBox;
            this.placeholder = placeholder;
            textBox.LostFocus += AddText;
            textBox.GotFocus += RemoveText;
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

        }
        private void RemoveText(object sender, EventArgs e)
            {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

            private void AddText(object sender, EventArgs e)
            {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
