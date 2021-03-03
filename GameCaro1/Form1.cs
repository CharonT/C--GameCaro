using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;

namespace GameCaro1
{
    public partial class Form1 : Form
    {

        #region Properties
        ChessBoardManager chessBoard;
        private int tick;

        SocketManager socket;
        private Player play1;
        private Player play2;

        #endregion

        public Form1()
        {
            InitializeComponent();

            createPlayer();

        }
        private void createPlayer()
        {
            socket = new SocketManager();
            chessBoard = new ChessBoardManager(pnChessBoard, tbPlayerName, ptbMark);
            pnInforPlayer.BackColor = Color.FromArgb(0, 0, 0, 0);
            pnMess.Visible = false;
            pnMain.Visible = false;
            btnShow.Visible = false;
            pnInforPlayer.Visible = true;
            btnLan.Enabled = false;
            btnUpdate.Enabled = false;
            ptbAvatar.Visible = true;
            pnAvatar.Visible = true;
            tbPlayer.Text = "";


        }
        private void begin()
        {
            pnInforPlayer.Visible = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            chessBoard.EndedGame += ChessBoard_EndedGame;
            chessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            pgbCoolDown.Step = Cons.COOL_DOWN_STEP;
            pgbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            pgbCoolDown.Value = 0;
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;
            if (socket.isServer) tbPlayMan.Text = chessBoard.Player[0].Name;
            else tbPlayMan.Text = chessBoard.Player[1].Name;
            Custom.unmute();
            newGame();
            pnMess.Visible = false;
            pnMain.Visible = true;
            btnShow.Visible = true;
            newGameToolStripMenuItem.Enabled = false;
            tmCoolDown.Stop();
            pnAvatar.Visible = true;
            pnChessBoard.Visible = true;

        }
        private void ChessBoard_EndedGameLost(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ChessBoard_EndedGameWin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #region Methods
        private void notification()
        {
            tmCoolDown.Stop();
            pnChessBoard.Enabled = false;



        }

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            Custom.SetState(pgbCoolDown, 3);
            tmCoolDown.Start();
            pnChessBoard.Enabled = false;
           
            pgbCoolDown.Value = 0;
            tick = 0;
            socket.send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClikedPoint));
            listen();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {

            notification();
            socket.send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            listen();
            processWin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {

            tick += 10;
            pgbCoolDown.PerformStep();
            if (pgbCoolDown.Value >= pgbCoolDown.Maximum)
            {

                notification();
                socket.send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));

            }
            if (tick == 600 && pnChessBoard.Enabled == true)
            {
                SoundGame.soundGamePlay("\\sound\\timeoutmain.wav");
            }

        }
        void newGame()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                /* newGame();
                 pnChessBoard.Enabled = false;*/

                chessBoard.Matrix.Clear();
                pgbCoolDown.Value = 0;
                tmCoolDown.Stop();
                chessBoard.drawChessBoard();
                if (socket.isServer)
                    pnChessBoard.Enabled = true;
                else pnChessBoard.Enabled = false;


            }

            ));

        }
        void quit()
        {

            Application.Exit();
        }
        private void pgbCoolDown_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socket.send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            socket.close(socket);
            createPlayer();

            //  pnChessBoard.Enabled = true;
        }



        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundGame.soundGamePlay("\\sound\\timeoutmain.wav");
            SoundGame.soundGamePlay("\\sound\\bipmain.wav");
            Custom.unmute();
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SoundGame.soundGameStop("\\sound\\bipmain.wav");
            SoundGame.soundGameStop("\\sound\\timeoutmain.wav");
            Custom.mute();
            //socket.send(new SocketData((int)SocketCommand.MUSIC ,"", new Point()));

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        private void btnLan_Click(object sender, EventArgs e)
        {
            play1 = new Player();
            play1.Name = tbPlayer.Text;
            socket.IP = tbIP.Text;
            if (!socket.connectServer())
            {
                socket.isServer = true;
                //      pnChessBoard.Enabled = true;
                socket.createServer();
                Thread.Sleep(2000);
                listen();

            }
            else
            {

                socket.isServer = false;
                listen();
            }
            btnLan.Enabled = false;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            if (pnInforPlayer.Visible)
            {
                tbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
                if (string.IsNullOrEmpty(tbIP.Text))
                {
                    tbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
                }

            }

        }



        void listen()
        {

            Thread listenThread = new Thread(() =>
                {
                    try
                    {
                        SocketData data = (SocketData)socket.receive();
                        processData(data);
                    }
                    catch
                    {
                    }
                });
            listenThread.IsBackground = true;
            listenThread.Start();


        }

        private void processWin()
        {
            newGameToolStripMenuItem.Enabled = true;
            pgbCoolDown.Value = 0;
            tmCoolDown.Stop();
            pnChessBoard.Enabled = false;
            if (MessageBox.Show(tbPlayMan.Text + " Đã Thắng") == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(Application.StartupPath+ "\\PhaoHoaDemo02.exe");

            }

        }
        private void processLost()
        {
            newGameToolStripMenuItem.Enabled = true;
            pgbCoolDown.Value = 0;
            tmCoolDown.Stop();
            if (MessageBox.Show(tbPlayMan.Text + " Đã Thua :(:(:(:(:(:(:") == DialogResult.OK)
            {
                pnChessBoard.Enabled = false;
                pnChessBoard.Visible = false;
                pnAvatar.Visible = false;
                pnMain.Visible = false;
                btnHide.Visible = false;
                btnShow.Visible = false;
                pnMess.Visible = false;
            }

        }
        private void processData(SocketData data)
        {
            if (data != null)
            {
                switch (data.Command)
                {
                    case (int)SocketCommand.NOTIFY:
                        MessageBox.Show(data.Message);
                        break;
                    case (int)SocketCommand.NEW_GAME:
                        socket.close(socket);
                        /* newGame();
                         pnChessBoard.Enabled = false;*/
                        this.Invoke((MethodInvoker)(() =>
                        {
                            createPlayer();
                        }));


                        break;
                    case (int)SocketCommand.SEND_POINT:
                        this.Invoke((MethodInvoker)(() =>
                        {
                            pgbCoolDown.Value = 0;
                            pnChessBoard.Enabled = true;
                            tmCoolDown.Start();
                            tick = 0;
                            chessBoard.otherPlayerMark(data.Point);
                        }));
                        break;
                    case (int)SocketCommand.SEND_MESSAGE:
                        updateTbMess(data);
                        break;

                    case (int)SocketCommand.END_GAME:

                        processLost();

                        break;
                    case (int)SocketCommand.TIME_OUT:
                        MessageBox.Show("Hết giờ");
                        break;
                    case (int)SocketCommand.PLAY1:
                        chessBoard.Player[1].Name = data.Message;
                        chessBoard.Player[0].Name = tbPlayer.Text;

                        //  MessageBox.Show(chessBoard.Player[0].Name + chessBoard.Player[1].Name);
                        break;
                    case (int)SocketCommand.PLAY2:
                        chessBoard.Player[0].Name = data.Message;
                        chessBoard.Player[1].Name = tbPlayer.Text;

                        //  MessageBox.Show(chessBoard.Player[0].Name + chessBoard.Player[1].Name);
                        break;
                    case (int)SocketCommand.QUIT:
                        tmCoolDown.Stop();
                        MessageBox.Show("Người chơi đã thoát");
                        break;

                    default: break;

                }
            }
            listen();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {

        }
        private void btnHideShow()
        {
            if (pnMess.Visible)
            {
                pnMess.Visible = false;
                btnShow.Visible = true;
            }
            else
            {
                pnMess.Visible = true;
                btnShow.Visible = false;
            }

        }

        #endregion

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnHideShow();
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            btnHideShow();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendMessage();
        }
        private void sendMessage()
        {
            string tempText = " [" + tbPlayMan.Text + "] : " + tbSend.Text;
            socket.send(new SocketData((int)SocketCommand.SEND_MESSAGE, tempText, new Point()));

            tbMess.Text += " [" + tbPlayMan.Text + "] : " + tbSend.Text + System.Environment.NewLine;

            tbSend.Text = "";
        }
        private void updateTbMess(SocketData data)
        {

            tbMess.Text += data.Message + System.Environment.NewLine;

        }
        private void receiveMessage()
        {

            while (true)
            {
                try
                {
                    SocketData data = (SocketData)socket.receive();
                    processData(data);
                    if (data != null) break;

                }
                catch { }

            }

        }

        private void btnSend_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendMessage();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ptbPLayer_Click(object sender, EventArgs e)
        {

        }




        private void tbPlayer_TextChanged(object sender, EventArgs e)
        {
            if (tbPlayer.Text != "")
            {

                btnLan.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void tbIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (socket.isServer)
            {
                socket.send(new SocketData((int)SocketCommand.PLAY2, play1.Name, new Point()));

            }

            else socket.send(new SocketData((int)SocketCommand.PLAY1, play1.Name, new Point()));
            listen();
            if (socket.isServer) MessageBox.Show("CẬP NHẬT THÀNH CÔNG . BẠN LÀ X");
            else MessageBox.Show("CẬP NHẬT THÀNH CÔNG . BẠN LÀ O");
            begin();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tbSend_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
