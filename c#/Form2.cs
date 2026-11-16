
using System;
using System.Drawing;
using System.Windows.Forms;

namespace windowsform
{
    public class Form2 : Form
    {
        Label lblResult;

        public Form2()
        {
            this.Text = "Event App";
            this.Size = new Size(300, 400);
            this.KeyPreview = true;

            lblResult = new Label();
            lblResult.Text = "Event Click";
            lblResult.Size = new Size(250, 40);
            lblResult.Location = new Point(30, 40);

            this.Controls.Add(lblResult);

            this.MouseClick += Form2_MouseClick;
            this.KeyDown += Form2_KeyDown;
        }

        private void Form2_MouseClick(object? sender, MouseEventArgs e)
        {
            lblResult.Text = "Mouse Click Event";
        }

        private void Form2_KeyDown(object? sender, KeyEventArgs e)
        {
            lblResult.Text = "Key Pressed: " + e.KeyCode;
        }
    }
}