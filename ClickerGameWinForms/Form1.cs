namespace ClickerGameWinForms
{
    public partial class Form1 : Form
    {

        int score = 0;
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
                gameStarted = true;
            }       

            int maxTop = ClientRectangle.Height - ClickMeButton.Height;
            int maxLeft = ClientRectangle.Width - ClickMeButton.Width;
            
            ClickMeButton.Top = rand.Next(0, maxTop);
            ClickMeButton.Left = rand.Next(0, maxLeft);

            score += 1;
            ClickMeButton.Text = score.ToString();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            TimerLabel.Text = seconds.ToString();
            if(seconds == 0)
            {
                GameTimer.Stop();
                ClickMeButton.Enabled = false;
                ButtonRestart.Visible = true;
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            ClickMeButton.Text = score.ToString();
            ClickMeButton.Enabled = true;
            seconds = 10;
            TimerLabel.Text = seconds.ToString();
            gameStarted = false;
            ButtonRestart.Visible = false;
        }
    }
}