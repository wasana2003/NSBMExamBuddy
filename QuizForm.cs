using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        private int currentQuestion = 0;
        private int score = 0;
        private int timeLeft = 20;
        private Timer quizTimer;
        private List<Question> quizQuestions;
        private string username = "User";
        private int subPartId = 1; // You can set this dynamically

        public QuizForm(string user)
        {
            InitializeComponent();
            username = user;
            LoadQuestions();
            LoadQuestion();
            SetupTimer();
        }

        private void SetupTimer()
        {
            quizTimer = new Timer();
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = $"Time Left: {timeLeft}s";
            if (timeLeft <= 0)
            {
                quizTimer.Stop();
                NextQuestion();
            }
        }

        private void LoadQuestions()
        {
            // Replace with your DB connection logic
            quizQuestions = new List<Question>
            {
                new Question("What does HTML stand for?", "Hyper Trainer Marking Language", "Hyper Text Markup Language", "Hyper Text Marketing Language", "Hyper Tool Multi Language", "Hyper Text Markup Language"),
                new Question("Which language is used to style web pages?", "HTML", "JQuery", "CSS", "XML", "CSS"),
                new Question("Inside which HTML element do we put JavaScript code?", "js", "scripting", "script", "javascript", "script"),
                new Question("Which tag is used to define an image in HTML?", "img", "image", "pic", "src", "img"),
                new Question("Which property is used to change background color in CSS?", "color", "bgcolor", "background-color", "backgroundColor", "background-color")
            };
        }

        private void LoadQuestion()
        {
            var q = quizQuestions[currentQuestion];
            lblQuestion.Text = q.QuestionText;
            rbA.Text = q.OptionA;
            rbB.Text = q.OptionB;
            rbC.Text = q.OptionC;
            rbD.Text = q.OptionD;
            timeLeft = 20;
            lblTimer.Text = $"Time Left: {timeLeft}s";
            quizTimer.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            quizTimer.Stop();
            NextQuestion();
        }

        private void NextQuestion()
        {
            var selected = GetSelectedAnswer();
            if (selected == quizQuestions[currentQuestion].CorrectAnswer)
                score++;

            currentQuestion++;
            if (currentQuestion < quizQuestions.Count)
            {
                LoadQuestion();
                ClearSelection();
            }
            else
            {
                ShowResult();
            }
        }

        private string GetSelectedAnswer()
        {
            if (rbA.Checked) return rbA.Text;
            if (rbB.Checked) return rbB.Text;
            if (rbC.Checked) return rbC.Text;
            if (rbD.Checked) return rbD.Text;
            return "";
        }

        private void ClearSelection()
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
        }

        private void ShowResult()
        {
            MessageBox.Show($"Thank you, {username}\nYour Score: {score} / {quizQuestions.Count}");
            SaveScoreToDatabase(score, subPartId, username);
        }

        private void SaveScoreToDatabase(int score, int subPartId, string user)
        {
            // Replace with your connection string
            string connectionString = "YourConnectionStringHere";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserScores (UserID, SubPartID, Score, DateTaken) VALUES (@UserID, @SubPartID, @Score, @DateTaken)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", user);
                cmd.Parameters.AddWithValue("@SubPartID", subPartId);
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.Parameters.AddWithValue("@DateTaken", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class Question
    {
        public string QuestionText;
        public string OptionA, OptionB, OptionC, OptionD;
        public string CorrectAnswer;

        public Question(string q, string a, string b, string c, string d, string correct)
        {
            QuestionText = q;
            OptionA = a;
            OptionB = b;
            OptionC = c;
            OptionD = d;
            CorrectAnswer = correct;
        }
    }
}