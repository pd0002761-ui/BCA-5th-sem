using System;
using System.Windows.Forms;

public class Program14 : Form
{
    public Program14()
    {
        Text = "Program 14 - Form Controls";
        Width = 350;
        Height = 250;

        Label l = new Label();
        l.Text = "Enter Name";
        l.SetBounds(30, 30, 100, 25);

        TextBox t = new TextBox();
        t.SetBounds(130, 30, 150, 25);

        RadioButton rb1 = new RadioButton();
        rb1.Text = "Male";
        rb1.SetBounds(30, 70, 80, 25);

        RadioButton rb2 = new RadioButton();
        rb2.Text = "Female";
        rb2.SetBounds(120, 70, 80, 25);

        CheckBox cb = new CheckBox();
        cb.Text = "Agree to Terms";
        cb.SetBounds(30, 105, 150, 25);

        Button b = new Button();
        b.Text = "Submit";
        b.SetBounds(130, 145, 100, 30);

        b.Click += (s, e) =>
        {
            string gender = rb1.Checked ? "Male" :
                            (rb2.Checked ? "Female" : "Not Selected");

            string status = cb.Checked ? "Agreed" : "Not Agreed";

            MessageBox.Show("Welcome " + t.Text +
                            "\nGender: " + gender +
                            "\nTerms: " + status);
        };

        Controls.AddRange(new Control[] { l, t, rb1, rb2, cb, b });
    }
}