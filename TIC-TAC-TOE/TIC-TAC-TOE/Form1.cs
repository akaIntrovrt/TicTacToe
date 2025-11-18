using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        Button button7 = new Button();
        Button button8 = new Button();
        Button button9 = new Button();

        Button ChoiceX = new Button();
        Button ChoiceO = new Button();

        Label choiceLabel = new Label();
        public Form1()
        {
            InitializeComponent();
            this.button1.Text = "";
            this.button1.Size = new Size(50, 50);
            button1.Click += Button1_Click;
            button1.Location = new Point(500, 300);
            this.Controls.Add(button1);

            this.button2.Text = "";
            this.button2.Size = new Size(50, 50);
            button2.Click += Button2_Click;
            button2.Location = new Point(450, 300);
            this.Controls.Add(button2);

            this.button3.Text = "";
            this.button3.Size = new Size(50, 50);
            button3.Click += Button3_Click;
            button3.Location = new Point(550, 300);
            this.Controls.Add(button3);

            this.button4.Text = "";
            this.button4.Size = new Size(50, 50);
            button4.Click += Button4_Click;
            button4.Location = new Point(550, 350);
            this.Controls.Add(button4);

            this.button5.Text = "";
            this.button5.Size = new Size(50, 50);
            button5.Click += Button5_Click;
            button5.Location = new Point(450, 350);
            this.Controls.Add(button5);

            this.button6.Text = "";
            this.button6.Size = new Size(50, 50);
            button6.Click += Button6_Click;
            button6.Location = new Point(500, 350);
            this.Controls.Add(button6);

            this.button7.Text = "";
            this.button7.Size = new Size(50, 50);
            button7.Click += Button7_Click;
            button7.Location = new Point(450, 400);
            this.Controls.Add(button7);

            this.button8.Text = "";
            this.button8.Size = new Size(50, 50);
            button8.Click += Button8_Click;
            button8.Location = new Point(500, 400);
            this.Controls.Add(button8);

            this.button9.Text = "";
            this.button9.Size = new Size(50, 50);
            button9.Click += Button9_Click;
            button9.Location = new Point(550, 400);
            this.Controls.Add(button9);

            choiceLabel.Text = "Now: O";
            choiceLabel.Location = new Point(500, 270);
            choiceLabel.Font = new Font("Arial", 10);
            this.Controls.Add(choiceLabel);

        }

        private async void Button9_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button9.Text = "X";
            }
            else
            {
                this.button9.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
            if (this.button1.Text == "O" && this.button3.Text == "O" && this.button3.Text == "O")
            {
                this.button1.Font = new Font(this.button1.Font, FontStyle.Underline);
                this.button2.Font = new Font(this.button2.Font, FontStyle.Underline);
                this.button3.Font = new Font(this.button2.Font, FontStyle.Underline);
                this.choiceLabel.Text = "O - WON!";
            }
        }

        private async void Button8_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button8.Text = "X";
            }
            else
            {
                this.button8.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button7_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button7.Text = "X";
            }
            else
            {
                this.button7.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button6_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button6.Text = "X";
            }
            else
            {
                this.button6.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button4_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button4.Text = "X";
            }
            else
            {
                this.button4.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button5_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button5.Text = "X";
            }
            else
            {
                this.button5.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button3.Text = "X";
            }
            else
            {
                this.button3.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button2.Text = "X";
            }
            else
            {
                this.button2.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if (this.choiceLabel.Text == "Now: X")
            {
                this.button1.Text = "X";
            }
            else
            {
                this.button1.Text = "O";
            }

            await Task.Delay(2000);
            if (this.choiceLabel.Text == "Now: X")
            {
                this.choiceLabel.Text = "Now: O";
            }
            else
            {
                this.choiceLabel.Text = "Now: X";
            }
        }
    }
}
