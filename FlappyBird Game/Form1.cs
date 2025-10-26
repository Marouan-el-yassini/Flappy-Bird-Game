namespace FlippyBird
{
    public partial class Form1 : Form
    {
        int PipleSpeed = 10;
        int gravity = 15;
        int score = 0;

        bool GameOver = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            RestartButton.Enabled = false;
            RestartButton.Visible = false;
            ExitButton.Enabled = false;
            ExitButton.Visible = false;
            InfoDisplayTxt.Enabled = false;
            InfoDisplayTxt.Visible = false;

            Bird.Top += gravity;
            pipTop.Left -= PipleSpeed;
            pipDown.Left -= PipleSpeed;
            ScoreText.Text = "Score : " + score;

            if (pipTop.Left < -150)
            {
                pipTop.Left = 800;
                score++;
            }
            if (pipDown.Left < -150)
            {
                pipDown.Left = 950;
                score++;
            }

            if (Bird.Bounds.IntersectsWith(pipTop.Bounds) ||
               Bird.Bounds.IntersectsWith(pipDown.Bounds) ||
               Bird.Bounds.IntersectsWith(downground.Bounds) || Bird.Top < -25)
            {
                endGame();
            }
            if (score > 5)
            {
                PipleSpeed = 15;
            }

        }
        private void endGame()
        {
            gmaeTimer.Stop();
            InfoDisplayTxt.Text = $"Game Over";
            GameOver = true;
            RestartButton.Enabled = true;
            RestartButton.Visible = true;
            ExitButton.Enabled = true;
            ExitButton.Visible = true;
            InfoDisplayTxt.Enabled = true;
            InfoDisplayTxt.Visible = true;
        }

        private void gameKeysDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            GameOver = false;
            Bird.Location = new Point(140, 255);
            pipTop.Left = 800;
            pipDown.Left = 1200;

            score = 0;
            PipleSpeed = 10;

            ScoreText.Text = "Score : 0";

            RestartButton.Enabled = false;
            RestartButton.Visible = false;
            ExitButton.Enabled = false;
            ExitButton.Visible = false;
            InfoDisplayTxt.Enabled=false;
            InfoDisplayTxt.Visible = false;

            gmaeTimer.Start();


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing Flippy Bird!");
            System.Environment.Exit(0);
        }
    }
}
