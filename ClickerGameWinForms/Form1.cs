namespace ClickerGameWinForms
{
    public partial class Form1 : Form
    {

        int score = 0;
        int highScore = 0;
        int seconds = 10;
        bool gameStarted = false;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ClickMeButton.BackColor = Color.DarkOrange;
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            if(gameStarted == false)
            {
                GameTimer.Start();
                JumpTimer.Start();
                gameStarted = true;
            }

            RandomJump();
            score += 1;
            ClickMeButton.Text = score.ToString();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            TimerLabel.Text = seconds.ToString();
            if(seconds == 0)
            {
                GameOver();
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            seconds = 10;
            gameStarted = false;

            ClickMeButton.Text = score.ToString();
            ClickMeButton.Enabled = true;            
            TimerLabel.Text = seconds.ToString();            
            ButtonRestart.Visible = false;
        }

        private void JumpTimer_Tick(object sender, EventArgs e)
        {
            RandomJump();
        }

        private void RandomJump()
        {
            int maxTop = ClientRectangle.Height - ClickMeButton.Height;
            int maxLeft = ClientRectangle.Width - ClickMeButton.Width;

            ClickMeButton.Top = rand.Next(0, maxTop);
            ClickMeButton.Left = rand.Next(0, maxLeft);
        }

        private void SetHighScore()
        {
            if(score > highScore)
            {
                highScore = score;
                MessageBox.Show("You have set a new High Score!");
            }
        }

        private void GameOver()
        {
            GameTimer.Stop();
            JumpTimer.Stop();
            ClickMeButton.Enabled = false;
            ButtonRestart.Visible = true;
            SetHighScore();
        }
    }
}