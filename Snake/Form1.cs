using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<image> Snake = new List<image>();
        private image food = new image();
        private image toxic = new image();
        private bool first = true;


        public Form1()
        {
            InitializeComponent();
            new Settings();

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            Settings.GameOver = true;

            if (Settings.GameOver == true)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
        }

        private void StartGame()
        {
            lblState.Visible = false;
            life_pic1.Visible = true;
            life_pic2.Visible = true;
            life_pic3.Visible = true;

            new Settings();

            Snake.Clear();
            image head = new image {X = 10, Y = 1};
            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            int xborder = pbCanvas.Size.Width / 32;
            int yborder = pbCanvas.Size.Height / 32;

            Random random = new Random();
            food = new image {X = random.Next(0, xborder), Y = random.Next(0, yborder) };
            toxic = new image { X = random.Next(0, xborder), Y = random.Next(0, yborder) };
        }

        private void GenerateToxic()
        {
            int xborder = pbCanvas.Size.Width / 32;
            int yborder = pbCanvas.Size.Height / 32;

            Random random = new Random();
            toxic = new image { X = random.Next(0, xborder), Y = random.Next(0, yborder) };
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            PictureBox snake_picture = new PictureBox();
            PictureBox food_picture = new PictureBox();
            PictureBox toxic_pircutre = new PictureBox();


            if (!Settings.GameOver)
            {
                
                for (int i = 0; i < Snake.Count; i++)
                {

                    if (i == 0)
                    {
                        switch (Settings.direction)
                        {
                            case Direction.Down:
                                snake_picture.Image = imglist.Images[1];
                                break;
                            case Direction.Right:
                                snake_picture.Image = imglist.Images[3];
                                break;
                            case Direction.Left:
                                snake_picture.Image = imglist.Images[2];
                                break;
                            case Direction.Up:
                                snake_picture.Image = imglist.Images[4];
                                break;
                        }
                    }
                    else
                    {
                        snake_picture.Image = imglist.Images[0];
                    }

                    canvas.DrawImage(snake_picture.Image, new Rectangle(Snake[i].X * 32, Snake[i].Y * 32, 32, 32));
                }


                food_picture.Image = imglist.Images[5];
                canvas.DrawImage(food_picture.Image, new Rectangle(food.X * 32,food.Y * 32, 32, 32));

                toxic_pircutre.Image = imglist.Images[6];
                canvas.DrawImage(toxic_pircutre.Image,new Rectangle(toxic.X * 32, toxic.Y * 32, 32, 32));


            }
            else if(first == false)
            {
                lblState.Text = "Game over \nScore : " + Settings.Score + "\nPress Enter to start"; ;
                lblState.Visible = true;
            }
            else
            {
                lblState.Text = "Press Enter to start";
                lblState.Visible = true;
            }
        }


        private void MovePlayer()
        {
            int xborder = pbCanvas.Size.Width / 32;
            int yborder = pbCanvas.Size.Height / 32;
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                   

                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= xborder || Snake[i].Y >= yborder)
                    {
                        life_pic1.Visible = false;
                        life_pic2.Visible = false;
                        life_pic3.Visible = false;
                        Die();
                    }


                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            life_pic1.Visible = false;
                            life_pic2.Visible = false;
                            life_pic3.Visible = false;
                            Die();
                        }
                    }

                    if (Snake[0].X == toxic.X && Snake[0].Y == toxic.Y)
                    {
                        decrease();
                    }

                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                  
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
       
        private void Eat()
        {
            image food = new image
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(food);

            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }
        private void decrease()
        {     
            if(Snake.Count>1)
            Snake.RemoveAt(Snake.Count - 1);

            Settings.Life -= 1;
            Settings.Score -= Settings.Points;
            lblScore.Text = Settings.Score.ToString();

            if (Settings.Life == 2)
            {
                life_pic1.Visible = false;
            }
            else if (Settings.Life == 1)
            {
                life_pic2.Visible = false;
            }
            else if (Settings.Life == 0)
            {
                life_pic3.Visible = false;
            }

            if (Settings.Life == 0)
            {
                Die();
            }

            GenerateToxic();
        }

        private void Die()
        {
            Settings.GameOver = true;
            first = false;
        }

        
    }
}
