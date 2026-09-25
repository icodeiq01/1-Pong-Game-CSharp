using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class Form1 : Form
    {
        // (Constants)
        private const int WinningScore = 15;
        private const int BallSpeed = 4;
        private const int PlayerSpeed = 8;
        private const int EnemyTimer = 50;

        // Randomarray speed
        private readonly int[] _enemySpeeds = { 5, 6, 8, 9 };
        private readonly int[] _ballSpeeds = { 8, 9, 10, 11, 12 };

        // (Game State)
        private bool _isMovingUp;
        private bool _isMovingDown;

        private int _ballSpeedX = BallSpeed;
        private int _ballSpeedY = BallSpeed;
        private int _enemySpeed = 2;
        private int _enemySpeedCounter = EnemyTimer;

        private int _playerScore = 0;
        private int _computerScore = 0;

        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Pong Game"; 
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            SetupEvents();
        }

        private void SetupEvents()
        {
            this.KeyPreview = true;
            this.Focus();

            this.KeyDown += OnKeyDown;
            this.KeyUp += OnKeyUp;
        }

        //Game Loop
        private void GameTimerEvent(object sender, EventArgs e)
        {
            MoveBall();
            CheckWalls();
            CheckScoring();

            MoveEnemy();
            MovePlayerPaddle();

            CheckHits();
            ShowScore();
            CheckGameWinner();
        }
         
        //(Clean Methods) 
        private void MoveBall()
        {
            pball.Top -= _ballSpeedY;
            pball.Left -= _ballSpeedX;
        }

        private void CheckWalls()
        {
            if (pball.Top <= 0 || pball.Bottom >= this.ClientSize.Height)
            {
                _ballSpeedY = -_ballSpeedY;
            }
        }

        private void CheckScoring()
        {
            int resetPositionX = this.ClientSize.Width / 2;

            // Score for computer
            if (pball.Left < 0)
            {
                ResetBallPosition(resetPositionX);
                _computerScore++;
            }
            // Score for player
            else if (pball.Right > this.ClientSize.Width)
            {
                ResetBallPosition(resetPositionX);
                _playerScore++;
            }
        }

        private void ResetBallPosition(int positionX)
        {
            pball.Left = positionX;
            _ballSpeedX = -_ballSpeedX;
        }

        private void MoveEnemy()
        {
            //Restrict enemy movement
            if (pComputer.Top <= 0)
            {
                pComputer.Top = 0;
            }
            else if (pComputer.Bottom >= this.ClientSize.Height)
            {
                pComputer.Top = this.ClientSize.Height - pComputer.Height;
            }

            // Track ball when across mid-screen
            int paddleCenter = pComputer.Top + (pComputer.Height / 2);
            int screenCenter = this.ClientSize.Width / 2;

            if (pball.Left > screenCenter)
            {
                if (pball.Top < paddleCenter) pComputer.Top -= _enemySpeed;
                if (pball.Top > paddleCenter) pComputer.Top += _enemySpeed;
            }
            //Set random enemy speed
            _enemySpeedCounter--;
            if (_enemySpeedCounter < 0)
            {
                _enemySpeed = _enemySpeeds[_random.Next(_enemySpeeds.Length)];
                _enemySpeedCounter = EnemyTimer;
            }
        }

        private void MovePlayerPaddle()
        {
            if (_isMovingDown && pPlayer.Bottom < this.ClientSize.Height)
            {
                pPlayer.Top += PlayerSpeed;
            }

            if (_isMovingUp && pPlayer.Top > 0)
            {
                pPlayer.Top -= PlayerSpeed;
            }
        }

        private void CheckHits()
        {
            ProcessCollision(pball, pPlayer, pPlayer.Right + 5);
            ProcessCollision(pball, pComputer, pComputer.Left - pball.Width - 5);
        }

        private void ProcessCollision(PictureBox ball, PictureBox paddle, int resetXPosition)
        {
            if (!ball.Bounds.IntersectsWith(paddle.Bounds)) return;

            ball.Left = resetXPosition;

            int newSpeedX = _ballSpeeds[_random.Next(_ballSpeeds.Length)];
            int newSpeedY = _ballSpeeds[_random.Next(_ballSpeeds.Length)];

            _ballSpeedX = (_ballSpeedX < 0) ? newSpeedX : -newSpeedX;
            _ballSpeedY = (_ballSpeedY < 0) ? -newSpeedY : newSpeedY;
        }

      
        private void ShowScore()
        {
            lblPlayerScore.Text = _playerScore.ToString();
            lblComputerScore.Text = _computerScore.ToString();
        } //score labels

        private void CheckGameWinner()
        {
            if (_computerScore >= WinningScore)
            {
                EndGame("Sorry, you lost the game!");
            }
            else if (_playerScore >= WinningScore)
            {
                EndGame("Congratulations! You won the game!");
            }
        }

        // --- User Input ---
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) _isMovingDown = true;
            if (e.KeyCode == Keys.Up) _isMovingUp = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) _isMovingDown = false;
            if (e.KeyCode == Keys.Up) _isMovingUp = false;
        }

        // --- Game State & Game Over ---
        private void EndGame(string message)
        {
            gtimer.Stop();
            MessageBox.Show(message, "Pong Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestartGame();
        }

        private void RestartGame()
        {
            _playerScore = 0;
            _computerScore = 0;

            _ballSpeedX = BallSpeed;
            _ballSpeedY = BallSpeed;
            _enemySpeedCounter = EnemyTimer;

            pball.Left = this.ClientSize.Width / 2;
            pball.Top = this.ClientSize.Height / 2;

            gtimer.Start();
            ShowScore();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw solid continuous center line
            using (Pen dashPen = new Pen(Color.DimGray, 1))
            {
                int middleX = this.ClientSize.Width / 2;

                e.Graphics.DrawLine(dashPen, middleX, 80, middleX, 105);
                e.Graphics.DrawLine(dashPen, middleX, 105, middleX, 150);
                e.Graphics.DrawLine(dashPen, middleX, 150, middleX, 195);
                e.Graphics.DrawLine(dashPen, middleX, 195, middleX, 240);
            }
        }


    }
}