using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro1
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get
            {
                return chessBoard;
            }

            set
            {
                chessBoard = value;
            }
        }
        private List<Player> player;
        public List<Player> Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public int CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }

            set
            {
                currentPlayer = value;
            }
        }

        public TextBox PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public PictureBox PlayerMark
        {
            get
            {
                return playerMark;
            }

            set
            {
                playerMark = value;
            }
        }

        public List<List<Button>> Matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                matrix = value;
            }
        }

        
       

       

        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;
        private List<List<Button>> matrix;
        private event EventHandler<ButtonClickEvent> playerMarked;
        
        public event EventHandler<ButtonClickEvent> PlayerMarked {
            add {
                playerMarked += value;
            }
            remove {
                playerMarked -= value;
            }
        }
        
        
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        private Stack<PlayInfo> playTimeLine;

        public Stack<PlayInfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }


        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark) {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;

            this.Player = new List<Player>()
                 {
                new Player("", Image.FromFile(Application.StartupPath + "\\image\\x.jpg")),
                new Player("", Image.FromFile(Application.StartupPath + "\\image\\o.png"))
            };
            Matrix = new List<List<Button>>();

        }

        #endregion
        #region Methods
        public void drawChessBoard()
        {
          
            chessBoard.Enabled = true;
            chessBoard.Controls.Clear();
            PlayTimeLine = new Stack<PlayInfo>();
            CurrentPlayer = 0;
            changePlayer();   
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.CHESS_BOARD_HEIGHT; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()

                    };
                    btn.Click += Btn_Click;
                    this.chessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;

                }

                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.CHESS_HEIGHT); //00
                oldBtn.Width = oldBtn.Height = 0;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
           
            
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            mark(btn);

           

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            changePlayer();
           
            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(getChessPoint(btn)));
            if (isEndGame(btn))
            {

                int size = PlayTimeLine.Count;
                if (size != 5) playTimeLine.Clear();
                else
                {
                    
                    for (int i = 0; i < size; i++)
                    {
                        PlayInfo oldPoint = PlayTimeLine.Pop();
                        Button oldBtn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

                        oldBtn.FlatStyle = FlatStyle.Flat;
                        oldBtn.FlatAppearance.BorderColor = Color.Red;
                        oldBtn.FlatAppearance.BorderSize = 1;

                    }

                    endGame();

                }

            }
            //  else endGameLost();
        }
        public void otherPlayerMark(Point point) {
           
            Button btn = Matrix[point.Y][point.X];
            if (btn.BackgroundImage != null)
                return;
            mark(btn);

            

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            changePlayer();
           
          /*  if (isEndGame(btn))
            {
               
                int size = PlayTimeLine.Count;
                if (size != 5) playTimeLine.Clear();
                else
                {
                    MessageBox.Show("95");
                    for (int i = 0; i < PlayTimeLine.Count; i++)
                    {
                        PlayInfo oldPoint = PlayTimeLine.Peek();
                        Button oldBtn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

                        oldBtn.FlatStyle = FlatStyle.Flat;
                        oldBtn.FlatAppearance.BorderColor = Color.Red;
                        oldBtn.FlatAppearance.BorderSize = 1;

                    }
                   
                    endGame();
                }
            }*/
         
        }
        
       
        public void endGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }

        }

        private Point getChessPoint(Button btn) {
            Point point = new Point();
            int ver = Convert.ToInt32(btn.Tag);
            int hor = Matrix[ver].IndexOf(btn);
            point.X = hor;
            point.Y = ver;
            return point;

        }
        private bool isEndGame(Button btn)
        {

            return isEndHor(btn) || isEndVer(btn) || isEndPri(btn) || isEndSub(btn);

        }
        private bool isEndHor(Button btn) {
            Point point = getChessPoint(btn);
            int countHeadLeft = 0;
            int countHeadRight = 0;
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--) {
               
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[point.Y][i])));
                    countLeft++;
                }
                else {
                    if (Matrix[point.Y][i].BackgroundImage!=null&&Matrix[point.Y][i].BackgroundImage != btn.BackgroundImage) {
                        if (countHeadLeft == 0) countHeadLeft++;
                    }

                    break;

                           
                } 
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[point.Y][i])));
                    countRight++;
                }
                else
                {
                    if (Matrix[point.Y][i].BackgroundImage != null && Matrix[point.Y][i].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadRight == 0) countHeadRight++;
                    }

                    break;


                }
            }
            if (countHeadLeft == 1 && countHeadRight == 1 && countHeadLeft + countHeadRight == 2) return false;
            int sum = 0;
            sum = countLeft + countRight;

            if (sum != 5) PlayTimeLine.Clear();
           
            return countLeft + countRight == 5;

        }
        private bool isEndVer(Button btn)
        {

            Point point = getChessPoint(btn);
            int countHeadTop = 0;
            int countHeadBottom = 0;
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[i][point.X])));
                    countTop++;
                }
                else
                {
                    if (Matrix[i][point.X].BackgroundImage != null && Matrix[i][point.X].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadTop == 0) countHeadTop++;
                    }

                    break;


                }
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[i][point.X])));
                    countBottom++;
                }
                else
                {
                    if (Matrix[i][point.X].BackgroundImage != null && Matrix[i][point.X].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadBottom == 0) countHeadBottom++;
                    }

                    break;


                }
            }
            if (countHeadTop == 1 && countHeadBottom == 1 && countHeadBottom + countHeadTop == 2) return false;
            int sum = 0;
            sum = countTop + countBottom;
            if (sum != 5) PlayTimeLine.Clear();
           
            return countTop + countBottom == 5;

        }
        private bool isEndPri(Button btn)
        {
            
            Point point = getChessPoint(btn);
            int countTop = 0;
            int countHeadTop = 0;
            int countHeadBottom = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[point.Y - i][point.X - i])));
                    countTop++;
                }
                else
                {
                    if (Matrix[point.Y - i][point.X - i].BackgroundImage != null && Matrix[point.Y - i][point.X - i].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadTop == 0) countHeadTop++;
                    }
                    break;
                }
               
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH) break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[point.Y + i][point.X + i])));
                    countBottom++;
                }
                else
                {
                    if (Matrix[point.Y + i][point.X + i].BackgroundImage != null && Matrix[point.Y + i][point.X + i].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadBottom == 0) countHeadBottom++;
                    }
                    break;
                }
            }
            if (countHeadTop == 1 && countHeadBottom == 1 && countHeadBottom + countHeadTop == 2) return false;
            int sum = 0;
            sum = countTop + countBottom;
            if (sum != 5) PlayTimeLine.Clear();
          
            return countTop + countBottom == 5;



        }
        private bool isEndSub(Button btn)
        {
            int sum = 0;
            Point point = getChessPoint(btn);
            int countTop = 0;
            int countHeadTop = 0;
            int countHeadBottom= 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i >Cons.CHESS_BOARD_WIDTH || point.Y - i < 0) break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[point.Y - i][point.X + i])));
                    countTop++;
                }
                else
                {
                    if (Matrix[point.Y - i][point.X + i].BackgroundImage != null && Matrix[point.Y - i][point.X + i].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadTop == 0) countHeadTop++;
                    }
                    break;
                }
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i<0) break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    PlayTimeLine.Push(new PlayInfo(getChessPoint(Matrix[point.Y + i][point.X - i])));
                    countBottom++;
                }
                else
                {
                    if (Matrix[point.Y + i][point.X - i].BackgroundImage != null && Matrix[point.Y + i][point.X - i].BackgroundImage != btn.BackgroundImage)
                    {
                        if (countHeadBottom == 0) countHeadBottom++;
                    }
                    break;
                }
            }
            if (countHeadTop == 1 && countHeadBottom == 1 && countHeadTop + countHeadBottom == 2) return false;
            sum = countTop + countBottom;
            if (sum != 5) PlayTimeLine.Clear();
           
            return countTop + countBottom == 5;


        }
        private void mark(Button btn) {

            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            SoundGame.soundGamePlay("\\sound\\bipmain.wav");
          
            //Image.FromFile(Application.StartupPath+"\\image\\x.jpg");
           

        }
        private void changePlayer() {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        
        #endregion

    }
    public class ButtonClickEvent : EventArgs {
        private Point clikedPoint;

        public Point ClikedPoint
        {
            get
            {
                return clikedPoint;
            }

            set
            {
                clikedPoint = value;
            }
        }
        public ButtonClickEvent(Point point) {
            this.ClikedPoint = point;
        }
    }
}
