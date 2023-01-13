using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSAssignment1
{

    public partial class Form2 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int totalQuestions;
        int playerScore;
        int percentage;
        int ticks = 60;


        MCQ q1 = new MCQ("What color combination makes green ? ", 1, "Blue is used", "Blue/Yellow", "Red/White", "Pink/Purple", "Orange/Blue");
        MCQ q2 = new MCQ("Which game did Riot Games make?", 2, "It is a first person shooter", "Fortnight", "Valorant", "Minecraft", "GTA V");
        MCQ q3 = new MCQ("What is the name of the show with the old meth dealer?", 3, "B__A__NG _A_", "Rick and Morty", "Avengers", "Breaking Bad", "Game of Thrones");
        MCQ q4 = new MCQ("What is the name of the main character from Breserk?", 1, "U in the name", "Gutts", "Gitts", "Gotts", "Gatts");
        MCQ q5 = new MCQ("How many sides does a cube have?", 4, "More than 4", "1", "2", "5", "6");
        MCQ q6 = new MCQ("Which game did Epic Games make?", 1, "It is a third person shooter", "Fortnight", "Valorant", "Minecraft", "GTA V");
        MCQ q7 = new MCQ("What is the name of the anime of the kid who w3ants to be Pirate King", 1, "Oda is the author", "One Piece", "Vinland Saga", "Naruto", "Dragon Ball");

        MCQ[] Questions = new MCQ[7];

        public Form2(string name)
        {
            InitializeComponent();
            lblTimer.Text = "";
            btnOne.Text = "";
            btnTwo.Text = "";
            btnThree.Text = "";
            btnFour.Text = "";
            lblQuestion.Text = "";
            lblHint.Text = "";
            lblPlayerName.Text = name;

            Questions = QuestionManager.QuestionsRandomizer(q1, q2, q3, q4, q5, q6, q7);

            AskQuestion(questionNumber);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFour.Visible = true;
            lblHint.Text = "";

            var senderObject = (Button)sender;

            int button = Convert.ToInt32(senderObject.Tag);

            if (button == correctAnswer)
            {
                MessageBox.Show("Congratulations!");
                if (questionNumber == 1)
                {
                    lblQ1Points.Text = "100";
                    playerScore += 100;
                }
                if (questionNumber == 2)
                {
                    lblQ2Points.Text = "200";
                    playerScore += 200;
                }
                if (questionNumber == 3)
                {
                    lblQ3Points.Text = "300";
                    playerScore += 300;
                }
                if (questionNumber == 4)
                {
                    lblQ4Points.Text = "400";
                    playerScore += 400;
                }
                if (questionNumber == 5)
                {
                    lblQ5Points.Text = "500";
                    playerScore += 500;
                }
                if (questionNumber == 6)
                {
                    lblQ6Points.Text = "600";
                    playerScore += 600;
                }
                if (questionNumber == 7)
                {
                    lblQ7Points.Text = "700";
                    playerScore += 700;
                }

                lblPoints.Text = playerScore.ToString();
            }

            else
            {
                if (correctAnswer == 1)
                {
                    btnOne.BackColor = Color.Green;
                    MessageBox.Show("HAHA Nice Try Better Luck Next Time!");
                }
                if (correctAnswer == 2)
                {
                    btnTwo.BackColor = Color.Green;
                    MessageBox.Show("HAHA Nice Try Better Luck Next Time!");
                }
                if (correctAnswer == 3)
                {
                    btnThree.BackColor = Color.Green;
                    MessageBox.Show("HAHA Nice Try Better Luck Next Time!");
                }
                if (correctAnswer == 4)
                {
                    btnFour.BackColor = Color.Green;
                    MessageBox.Show("HAHA Nice Try Better Luck Next Time!");
                }
            }

            if (questionNumber == totalQuestions)
            {
                timer1.Stop();
                Form3 f3 = new Form3(playerScore, lblPlayerName.Text);
                f3.Show();
                this.Hide();
            }

            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int qnum)
        {

            switch (questionNumber)
            {
                case 1:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[0].question;
                    btnOne.Text = Questions[0].op1;
                    btnTwo.Text = Questions[0].op2;
                    btnThree.Text = Questions[0].op3;
                    btnFour.Text = Questions[0].op4;

                    correctAnswer = Questions[0].answer;
                    break;

                case 2:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[1].question;
                    btnOne.Text = Questions[1].op1;
                    btnTwo.Text = Questions[1].op2;
                    btnThree.Text = Questions[1].op3;
                    btnFour.Text = Questions[1].op4;

                    correctAnswer = Questions[1].answer;
                    break;

                case 3:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[2].question;
                    btnOne.Text = Questions[2].op1;
                    btnTwo.Text = Questions[2].op2;
                    btnThree.Text = Questions[2].op3;
                    btnFour.Text = Questions[2].op4;

                    correctAnswer = Questions[2].answer;
                    break;

                case 4:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[3].question;
                    btnOne.Text = Questions[3].op1;
                    btnTwo.Text = Questions[3].op2;
                    btnThree.Text = Questions[3].op3;
                    btnFour.Text = Questions[3].op4;

                    correctAnswer = Questions[3].answer;
                    break;

                case 5:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[4].question;
                    btnOne.Text = Questions[4].op1;
                    btnTwo.Text = Questions[4].op2;
                    btnThree.Text = Questions[4].op3;
                    btnFour.Text = Questions[4].op4;

                    correctAnswer = Questions[4].answer;
                    break;

                case 6:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[5].question;
                    btnOne.Text = Questions[5].op1;
                    btnTwo.Text = Questions[5].op2;
                    btnThree.Text = Questions[5].op3;
                    btnFour.Text = Questions[5].op4;

                    correctAnswer = Questions[5].answer;
                    break;

                case 7:
                    ticks = 60;
                    timer1.Start();

                    lblQuestion.Text = Questions[6].question;
                    btnOne.Text = Questions[6].op1;
                    btnTwo.Text = Questions[6].op2;
                    btnThree.Text = Questions[6].op3;
                    btnFour.Text = Questions[6].op4;

                    correctAnswer = Questions[6].answer;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            lblTimer.Text = ticks.ToString();

            if (ticks == 0)
            {
                timer1.Stop();
                questionNumber++;
                AskQuestion(questionNumber);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnHint_Click(object sender, EventArgs e)
        {

            if (questionNumber == 1)
            {
                lblHint.Text = Questions[0].hint;
            }
            if (questionNumber == 2)
            {
                lblHint.Text = Questions[1].hint;
            }
            if (questionNumber == 3)
            {
                lblHint.Text = Questions[2].hint;
            }
            if (questionNumber == 4)
            {
                lblHint.Text = Questions[3].hint;
            }
            if (questionNumber == 5)
            {
                lblHint.Text = Questions[4].hint;
            }
            if (questionNumber == 5)
            {
                lblHint.Text = Questions[5].hint;
            }
            if (questionNumber == 7)
            {
                lblHint.Text = Questions[6].hint;
            }

            btnHint.Visible = false;
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            if (correctAnswer == 1)
            {
                btnTwo.Visible = false;
                btnThree.Visible = false;
            }
            if (correctAnswer == 2)
            {
                btnOne.Visible = false;
                btnThree.Visible = false;
            }
            if (correctAnswer == 3)
            {
                btnTwo.Visible = false;
                btnFour.Visible = false;
            }
            if (correctAnswer == 4)
            {
                btnThree.Visible = false;
                btnTwo.Visible = false;
            }

            btn5050.Visible = false;
        }
    }
}
