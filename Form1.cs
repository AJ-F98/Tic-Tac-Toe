using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        int count = 0;
        int counter = 0;
        string[] names = new string[10];
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            richTextBox4.Text = "0";
            richTextBox5.Text = "0";
            richTextBox4.Enabled = false;
            richTextBox5.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox3.Enabled = false;
            names = Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            count++;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(count%2 != 0)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }
            count++;
            counter++;
            button1.Enabled = false;
            Validate(names, button1.Name, counter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }
            count++;
            counter++;
            button2.Enabled = false;
            Validate(names, button2.Name, counter);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }
            count++;
            counter++;
            button3.Enabled = false;
            Validate(names, button3.Name, counter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }
            count++;
            counter++;
            button4.Enabled = false;
            Validate(names, button4.Name, counter);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }
            count++;
            counter++;
            button5.Enabled = false;
            Validate(names, button5.Name, counter);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }
            count++;
            counter++;
            button6.Enabled = false;
            Validate(names, button6.Name, counter);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }
            count++;
            counter++;
            button7.Enabled = false;
            Validate(names, button7.Name, counter);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }
            count++;
            counter++;
            button8.Enabled = false;
            Validate(names, button8.Name, counter);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }
            count++;
            counter++;
            button9.Enabled = false;
            Validate(names, button9.Name, counter);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            count = 0;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            richTextBox4.Text = "0";
            richTextBox5.Text = "0";

        }

        public String[] Check()
        {
            int counter = 0;
            int i = 0;
            string[] names = new string[10];
            foreach (Button p in panel2.Controls.OfType<Button>())
            {
                counter++;
                if(p.Name.Contains("button")==true)
                {
                    names[i++] = p.Name; // getting the name of each buttons
                }                
            }

            Array.Sort(names, StringComparer.Ordinal);
            names = names.Skip(1).ToArray(); // skips the first element of the array and add the rest to an array
            string x = "";
            string y;
            int[] z = new int[10];
            for(i=0;i<9;i++)
            {
                x += names[i] + Environment.NewLine;
                y = names[i].Replace("button", "");
                z[i] = int.Parse(y);
            }
            //MessageBox.Show(x);
            return names;
        }

        public void Validate(string[] names, string name, int counter)
        {
            // create the code to validate
            int[] pos = new int[10];
            foreach (Button p in panel2.Controls.OfType<Button>())
            {
                if (p.Name == name)
                {
                    if (names.Contains(p.Name) == true && p.Text == "X")
                    {
                        //MessageBox.Show("Player 1 played");
                        break;
                    }
                    else if (names.Contains(p.Name) == true && p.Text == "O")
                    {
                        //MessageBox.Show("player 2 played");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if(counter >= 5)
            {
                Check(counter);
            }
        }

        public void Check(int z)
        {
            string a = "button";
            string b = "button";
            string c = "button";
            string q="", r="",s="";
            int f = 0;

            for(int i=0;i<8;i++)
            {
                int count = 0;
                a = "button";
                b = "button";
                c = "button";
                switch (i)
                {
                    case 0: 
                        a = a + 1.ToString();
                        b = b + 2.ToString();
                        c = c + 3.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if(p.Name == a || p.Name == b || p.Name == c)
                            {
                                if(count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if(count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if(count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 1:
                        a = a + 4.ToString();
                        b = b + 5.ToString();
                        c = c + 6.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        { 
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 2:
                        a = a + 7.ToString();
                        b = b + 8.ToString();
                        c = c + 9.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 3:
                        a = a + 1.ToString();
                        b = b + 4.ToString();
                        c = c + 7.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 4:
                        a = a + 2.ToString();
                        b = b + 5.ToString();
                        c = c + 8.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 5:
                        a = a + 3.ToString();
                        b = b + 6.ToString();
                        c = c + 9.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 6:
                        a = a + 1.ToString();
                        b = b + 5.ToString();
                        c = c + 9.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 7:
                        a = a + 3.ToString();
                        b = b + 5.ToString();
                        c = c + 7.ToString();
                        foreach (Button p in panel2.Controls.OfType<Button>())
                        {
                            if (p.Name == a || p.Name == b || p.Name == c)
                            {
                                if (count == 0)
                                {
                                    q = p.Text;
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    r = p.Text;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    s = p.Text;
                                    count++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        if (q == "X" && r == "X" && s == "X")
                        {
                            f = 1;
                        }
                        else if (q == "O" && r == "O" && s == "O")
                        {
                            f = 2;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    default: continue;
                }                
            }

            if(f==0 && z==9)
            {
                MessageBox.Show("Draw");
                MessageBox.Show("Press Start to continue");
                count = 0;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = true;

                counter = 0;
            }
            if(f==1)
            {
                MessageBox.Show("X Wins");
                MessageBox.Show("Press Start to continue");
                count = 0;
                string u;
                int v;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = true;

                u = richTextBox4.Text;
                v = Convert.ToInt32(u);
                v++;
                richTextBox4.Text = v.ToString();
                counter = 0;

            }
            if(f==2)
            {
                MessageBox.Show("O Wins");
                MessageBox.Show("Press Start to continue");
                count = 0;
                string u;
                int v;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = true;

                u = richTextBox5.Text;
                v = Convert.ToInt32(u);
                v++;
                richTextBox5.Text = v.ToString();
                counter = 0;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
