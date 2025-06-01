using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace NSBMExamBuddy
{
    public partial class Intro_Q_set1 : Form
    {
        private List<Question> questionList = new List<Question>();
        private int currentIndex = 0;
        //private int submoduleID;

        public Intro_Q_set1()
        {
            InitializeComponent();
        }
        private int score = 0;
        private int submoduleID;
        private int userID;

        public Intro_Q_set1(int submoduleID, int userID)
        {
            InitializeComponent();
            this.submoduleID = submoduleID;
            this.userID = userID;
            LoadQuestions(submoduleID);

            if (questionList.Count > 0)
            {
                DisplayQuestion(currentIndex);
            }
            else
            {
                MessageBox.Show("No questions found for this submodule.");
                this.Close();
            }
        }


        private void Intro_Q_set1_Load(object sender, EventArgs e)
        {
            // Optional if already loaded in constructor
        }

        private void LoadQuestions(int subID)
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            //string connStr = "server=localhost;user=root;database=examdb;port=3306;password=1234;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT * FROM Questions WHERE SubmoduleID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", subID);
                MessageBox.Show("You are attempting Submodule ID: " + subID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Question q = new Question
                        {
                            QuestionText = reader["QuestionText"].ToString(),
                            OptionA = reader["OptionA"].ToString(),
                            OptionB = reader["OptionB"].ToString(),
                            OptionC = reader["OptionC"].ToString(),
                            OptionD = reader["OptionD"].ToString(),
                            CorrectAnswer = reader["CorrectAnswer"].ToString()
                        };
                        questionList.Add(q);
                    }
                }
            }
        }

        private void DisplayQuestion(int index)
        {
            var q = questionList[index];
            label2.Text = q.QuestionText;
            answerRadio1btn.Text = q.OptionA;
            answerRadio2btn.Text = q.OptionB;
            answerRadio3btn.Text = q.OptionC;
            answerRadio4btn.Text = q.OptionD;
            progressBar1.Value = (index + 1) * 100 / questionList.Count;
        }

        private void nextbtnforQ_Click(object sender, EventArgs e)
        {
            string selectedOption = "";

            if (answerRadio1btn.Checked) selectedOption = "A";
            else if (answerRadio2btn.Checked) selectedOption = "B";
            else if (answerRadio3btn.Checked) selectedOption = "C";
            else if (answerRadio4btn.Checked) selectedOption = "D";

            if (selectedOption == questionList[currentIndex].CorrectAnswer.Trim())
            {
                score++;
            }


            currentIndex++;

            if (currentIndex < questionList.Count)
            {
                DisplayQuestion(currentIndex);
            }
            else
            {
                MessageBox.Show($"Quiz completed! You scored {score} out of {questionList.Count}");
                SaveScore(); // ✅ Save score to DB
                this.Close();
            }

        }

        private void SaveScore()
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO UserScores (ID, SubmoduleID, Score, DateTaken) VALUES (@userID, @submoduleID, @score, @date)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@submoduleID", submoduleID);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }


        private void answerRadio1btn_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: logic for selecting answer
        }

        private void answerRadio2btn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void answerRadio3btn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void answerRadio4btn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
