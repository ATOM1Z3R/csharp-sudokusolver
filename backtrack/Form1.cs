using System;
using BackTrackClassLibrary;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace backtrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox t;
            int[,] sudoku = new int[9, 9];
            for (int i = 0, n = 1; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    t = Controls.Find("textBox" + n++, true)[0] as TextBox;
                    if (Regex.IsMatch(t.Text, @"^[0-9]+$") || t.Text == "")
                    {
                        t.ForeColor = Color.Black;
                        sudoku[i, j] = t.Text != "" ? Convert.ToInt32(t.Text) : 0;
                    }
                    else
                    {
                        t.ForeColor = Color.Red;
                        return;
                    }

                }
            FindSolution solve = new FindSolution();
            solve.Find(sudoku); //Run Algorithm
            for (int i = 0, n = 1; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    t = Controls.Find("textBox" + n++, true)[0] as TextBox;
                    t.Text = Convert.ToString(sudoku[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox t;
            for (int i = 1; i < 82; i++)
            {
                t = Controls.Find("textBox" + i, true)[0] as TextBox;
                t.Text = "";
            }
        }
    }
}