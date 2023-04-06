using System.Reflection.Metadata.Ecma335;

namespace Rock_Papar_Scissors
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int scorep1 = 0;
        private int scorep2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = true;
            Random rnd = new Random();

            label2.Text = String.Empty;
            label2.Visible = true;
                int Option = rnd.Next(3);
            if (Option == 0)
            {
                label2.Text += "ITS A TIE!";
            }
            else if(Option == 1)
            {
                label2.Text += "YOU LOST, LOSER!";
                score = score - 1;
            }
            else if (Option == 2)
            {
                label2.Text += "YOU WON, WINNER!";
                score = score + 1;
            }
            label5.Text = score.ToString();
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = true;
            Random rnd = new Random();

            label2.Text = String.Empty;
            label2.Visible = true;
            int Option = rnd.Next(3);
            if (Option == 0)
            {
                label2.Text += "YOU WON, WINNER!";
                score = score + 1;
            }
            else if (Option == 1)
            {
                label2.Text += "ITS A TIE!";
            }
            else if (Option == 2)
            {
                label2.Text += "YOU LOST, LOSER!";
                score = score - 1;
            }
            label5.Text = score.ToString();
            Application.DoEvents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = true;
            Random rnd = new Random();

            label2.Text = String.Empty;
            label2.Visible = true;
            int Option = rnd.Next(3);
            if (Option == 0)
            {
                label2.Text += "YOU LOST, LOSER!";
                score = score - 1;
            }
            else if (Option == 1)
            {
                label2.Text += "YOU WON, WINNER!";
                score = score + 1;
            }
            else if (Option == 2)
            {
                label2.Text += "ITS A TIE!";
            }
            label5.Text = score.ToString();
            Application.DoEvents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            label2.Text = String.Empty;
            label2.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label5.Text = score.ToString();
            button5.Visible = false;
            button6.Visible = false;
            label2.Text = String.Empty;
            label2.Visible = false;
            button1.Visible = true;
            button2.Visible = true; 
            button3.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            label3.Text = String.Empty;
            button5.Visible = false;
            button6.Visible = false;
            label2.Text = String.Empty;
            label2.Visible = true;
            label2.Text = "First player's turn";
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            label2.Text = String.Empty;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button11.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false; 
            label9.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == string.Empty)
            {
                label1.Text = String.Empty;
                label1.Text = "Rock";
                label2.Text = String.Empty;
                label2.Text = "Second player's turn";
            }
            else if (label3.Text == string.Empty)
            {
                label3.Text = String.Empty;
                label3.Text = "Rock";
                results();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == string.Empty)
            {
                label1.Text = String.Empty;
                label1.Text = "Paper";
                label2.Text = String.Empty;
                label2.Text = "Second player's turn";
            }
            else if (label3.Text == string.Empty)
            {
                label3.Text = String.Empty;
                label3.Text = "Paper";
                results();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == string.Empty)
            {
                label1.Text = String.Empty;
                label1.Text = "Scissors";
                label2.Text = String.Empty;
                label2.Text = "Second player's turn";
            }
            else if (label3.Text == string.Empty)
            {
                label3.Text = String.Empty;
                label3.Text = "Scissors";
                results();
            }
        }
        
        void results()
        {
            if(label1.Text == label3.Text)
            {
                label2.Text = String.Empty;
                label2.Text = "It's a tie";
            }
            else if (label1.Text == "Rock" && label3.Text == "Paper")
            {
                label2.Text = String.Empty;
                label2.Text = "Player 2 won";
                scorep2 = scorep2 + 1;
            }
            else if (label1.Text == "Rock" && label3.Text == "Scissors")
            {
                label2.Text = String.Empty;
                label2.Text = "Player 1 won";
                scorep1 = scorep1 + 1;
            }
            else if (label1.Text == "Paper" && label3.Text == "Rock")
            {
                label2.Text = String.Empty;
                label2.Text = "Player 1 won";
                scorep1 = scorep1 + 1;
            }
            else if (label1.Text == "Paper" && label3.Text == "Scissors")
            {
                label2.Text = String.Empty;
                label2.Text = "Player 2 won";
                scorep2 = scorep2 + 1;
            }
            else if (label1.Text == "Scissors" && label3.Text == "Rock")
            {
                label2.Text = String.Empty;
                label2.Text = "Player 2 won";
                scorep2 = scorep2 + 1;
            }
            else if (label1.Text == "Scissors" && label3.Text == "Paper")
            {
                label2.Text = String.Empty;
                label2.Text = "Player 1 won";
                scorep1 = scorep1 + 1;
            }
            else
            {
                label2.Text = String.Empty;
                label2.Text = "error";
            }
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Visible = true;
            label8.Text = scorep1.ToString();
            label9.Text = scorep2.ToString();
            Application.DoEvents();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            label2.Text = String.Empty;
            label2.Visible = true;
            label2.Text = "First player's turn";
            label1.Text = String.Empty;
            label3.Text = String.Empty;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}