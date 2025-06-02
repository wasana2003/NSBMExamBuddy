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
        private Dictionary<int, Func<Form>> moduleNavigationMap;
        //private int moduleID;
        //public Intro_Q_set1()
        //{
        //    InitializeComponent();
        //}
        private int score = 0;
        private int submoduleID;
        private int userID;
        private int moduleID;

        public Intro_Q_set1(int submoduleID, int userID , int moduleID)
        {
            InitializeComponent();
            this.submoduleID = submoduleID;
            this.userID = userID;
            this.moduleID = moduleID;
            moduleNavigationMap = new Dictionary<int, Func<Form>>()
{
    { 1, () => new PF_Form1(userID) },
    { 2, () => new PF_Form2(userID) },
    { 3, () => new PF_Form3(userID) },
    { 4, () => new PF_Form4(userID) },
    { 5, () => new PF_Form5(userID) },
    { 6, () => new PF_Form6(userID) },
    { 7, () => new PF_Form7(userID) },
    { 8, () => new PF_Form8(userID) },
    { 9, () => new PF_Form9(userID) },
    { 10, () => new Maths_Form1(userID) },
    { 11, () => new Maths_Form2(userID) },
    { 12, () => new MATHS_Form3(userID) },
    { 13, () => new MATHS_Form4(userID) },
    { 14, () => new MATHS_Form5(userID) },
    { 15, () => new ALGO_Form1(userID) },
    { 16, () => new Algo_Form2(userID) },
    { 17, () => new Algo_Form3(userID) },
    { 18, () => new Algo_Form4(userID) },
    { 19, () => new Algo_Form5(userID) },
    { 20, () => new Algo_Form6(userID) },
                { 21, () => new Web_Form1(userID) },
                { 22, () => new Web_Form2(userID) },
                { 23, () => new Web_Form3(userID) },
                { 24, () => new Web_Form4(userID) },
                { 25, () => new Web_Form5(userID) },

                { 26, () => new Intro_Form1(userID) },
                { 27, () => new Intro_Form2(userID) },
                { 28, () => new Intro_Form3(userID) },
                {29 , () => new Intro_Form4(userID) },
                {30 , () => new Intro_Form5(userID) },
                {31 , () => new Intro_Form6(userID) },
                {32 , () => new Intro_Form7(userID) },

                {33 , () => new DBMS_Form1(userID) },
                {34 , () => new DBMS_Form2(userID) },//DBMS
                {35 , () => new DBMS_Form3(userID) },
                {36 , () => new DBMS_Form4(userID) },
                {37 , () => new DBMS_Form5(userID) },
                {38 , () => new DBMS_Form6(userID) },

                {39 , () => new CA_Form1(userID) },
                {40 , () => new CA_Form2(userID) },//CA
                {41 , () => new CA_Form3(userID) },
                {42 , () => new CA_Form4(userID) },
                {43 , () => new CA_Form5(userID) },
                {44 , () => new CA_Form6(userID) },
                {45 , () => new CA_Form7(userID) },
                {46 , () => new CA_Form8(userID) },

                {47 , () => new CSharpe_Form1(userID) },//C#
                {48 , () => new CSharpe_Form2(userID) },
                {49 , () => new CSharpe_Form3(userID) },
                {50 , () => new CSharpe_Form4(userID) },
                {51 , () => new CSharpe_Form5(userID) },
                {52 , () => new CSharpe_Form6(userID) },
                {53 , () => new CSharpe_Form7(userID) },

                {54 , () => new SAD_Form1(userID) },//SAD
                {55 , () => new SAD_Form2(userID) },
                {56 , () => new SAD_Form3(userID) },
                {57 , () => new SAD_Form4(userID) },
                {58, () => new SAD_Form5(userID) },
                {59 , () => new SAD_Form6(userID) },

    // 🔁 Add as many as you define forms for.
};

            this.submoduleID = submoduleID;
            this.userID = userID;
            this.moduleID = moduleID;
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

        public Intro_Q_set1(int submoduleID, int userID)
        {
            this.submoduleID = submoduleID;
            this.userID = userID;
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

                if (moduleNavigationMap.ContainsKey(moduleID))
                {
                    Form subForm = moduleNavigationMap[moduleID].Invoke();
                    subForm.Show();
                }
                else
                {
                    MessageBox.Show("No matching submodule interface. Redirecting to Dashboard.");
                    new MainDashboard(userID).Show();
                }

                //Form subFormToShow = null;

                //switch (moduleID)
                //{
                //    case 1:
                //        subFormToShow = new PythonSubmoduleForm(userID); break;
                //    case 2:
                //        subFormToShow = new LoopsSubmoduleForm(userID); break;
                //    case 3:
                //        subFormToShow = new FunctionsSubmoduleForm(userID); break;
                //    case 4:
                //        subFormToShow = new LoopsAdvancedSubmoduleForm(userID); break;
                //    // Add more cases for other module IDs as needed
                //    default:
                //        MessageBox.Show("Unknown Module. Returning to Dashboard.");
                //        subFormToShow = new DashboardForm(userID); break;
                //}

                //subFormToShow.Show();
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
