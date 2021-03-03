namespace GameCaro1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnMain = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlayMan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMark = new System.Windows.Forms.PictureBox();
            this.pgbCoolDown = new System.Windows.Forms.ProgressBar();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btnLan = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.pnAvatar = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.pnMess = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbMess = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnInforPlayer = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).BeginInit();
            this.pnAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.pnMess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnInforPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.label6);
            this.pnMain.Controls.Add(this.tbPlayMan);
            this.pnMain.Controls.Add(this.label5);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.ptbMark);
            this.pnMain.Controls.Add(this.pgbCoolDown);
            this.pnMain.Controls.Add(this.tbPlayerName);
            this.pnMain.Location = new System.Drawing.Point(739, 470);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(386, 204);
            this.pnMain.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Người Chơi";
            // 
            // tbPlayMan
            // 
            this.tbPlayMan.Location = new System.Drawing.Point(81, 9);
            this.tbPlayMan.Name = "tbPlayMan";
            this.tbPlayMan.ReadOnly = true;
            this.tbPlayMan.Size = new System.Drawing.Size(163, 20);
            this.tbPlayMan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lượt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời Gian";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // ptbMark
            // 
            this.ptbMark.Location = new System.Drawing.Point(248, 6);
            this.ptbMark.Name = "ptbMark";
            this.ptbMark.Size = new System.Drawing.Size(129, 128);
            this.ptbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMark.TabIndex = 2;
            this.ptbMark.TabStop = false;
            // 
            // pgbCoolDown
            // 
            this.pgbCoolDown.BackColor = System.Drawing.Color.DarkGray;
            this.pgbCoolDown.ForeColor = System.Drawing.Color.Red;
            this.pgbCoolDown.Location = new System.Drawing.Point(83, 92);
            this.pgbCoolDown.Name = "pgbCoolDown";
            this.pgbCoolDown.Size = new System.Drawing.Size(163, 23);
            this.pgbCoolDown.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbCoolDown.TabIndex = 1;
            this.pgbCoolDown.Click += new System.EventHandler(this.pgbCoolDown_Click);
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(82, 48);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.ReadOnly = true;
            this.tbPlayerName.Size = new System.Drawing.Size(163, 20);
            this.tbPlayerName.TabIndex = 0;
            // 
            // btnLan
            // 
            this.btnLan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLan.ForeColor = System.Drawing.Color.Red;
            this.btnLan.Location = new System.Drawing.Point(449, 278);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(102, 35);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "LAN";
            this.btnLan.UseVisualStyleBackColor = false;
            this.btnLan.Click += new System.EventHandler(this.btnLan_Click);
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.ForeColor = System.Drawing.Color.Red;
            this.tbIP.Location = new System.Drawing.Point(53, 281);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(193, 26);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "127.0.0.1";
            this.tbIP.TextChanged += new System.EventHandler(this.tbIP_TextChanged);
            // 
            // pnAvatar
            // 
            this.pnAvatar.Controls.Add(this.ptbAvatar);
            this.pnAvatar.Location = new System.Drawing.Point(739, 27);
            this.pnAvatar.Name = "pnAvatar";
            this.pnAvatar.Size = new System.Drawing.Size(389, 200);
            this.pnAvatar.TabIndex = 4;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbAvatar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ptbAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.BackgroundImage")));
            this.ptbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAvatar.Location = new System.Drawing.Point(3, 3);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(383, 196);
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
            this.ptbAvatar.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.Color.DarkGray;
            this.pnChessBoard.Location = new System.Drawing.Point(3, 26);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(735, 547);
            this.pnChessBoard.TabIndex = 3;
            this.pnChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnChessBoard_Paint);
            // 
            // pnMess
            // 
            this.pnMess.Controls.Add(this.btnHide);
            this.pnMess.Controls.Add(this.btnSend);
            this.pnMess.Controls.Add(this.lbMess);
            this.pnMess.Controls.Add(this.tbSend);
            this.pnMess.Controls.Add(this.tbMess);
            this.pnMess.Location = new System.Drawing.Point(739, 225);
            this.pnMess.Name = "pnMess";
            this.pnMess.Size = new System.Drawing.Size(389, 248);
            this.pnMess.TabIndex = 7;
            // 
            // btnHide
            // 
            this.btnHide.BackgroundImage = global::GameCaro1.Properties.Resources.FJ8X2T9IEMNIE391;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.Location = new System.Drawing.Point(361, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(28, 26);
            this.btnHide.TabIndex = 4;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click_1);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(314, 221);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSend_KeyPress);
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Location = new System.Drawing.Point(5, 224);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(31, 13);
            this.lbMess.TabIndex = 2;
            this.lbMess.Text = "Text:";
            // 
            // tbSend
            // 
            this.tbSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSend.ForeColor = System.Drawing.Color.Red;
            this.tbSend.Location = new System.Drawing.Point(37, 221);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(271, 24);
            this.tbSend.TabIndex = 1;
            this.tbSend.TextChanged += new System.EventHandler(this.tbSend_TextChanged);
            // 
            // tbMess
            // 
            this.tbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMess.ForeColor = System.Drawing.Color.Red;
            this.tbMess.Location = new System.Drawing.Point(3, 3);
            this.tbMess.Multiline = true;
            this.tbMess.Name = "tbMess";
            this.tbMess.ReadOnly = true;
            this.tbMess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMess.Size = new System.Drawing.Size(383, 212);
            this.tbMess.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.musicToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnInforPlayer
            // 
            this.pnInforPlayer.BackColor = System.Drawing.Color.AliceBlue;
            this.pnInforPlayer.Controls.Add(this.label7);
            this.pnInforPlayer.Controls.Add(this.btnUpdate);
            this.pnInforPlayer.Controls.Add(this.label4);
            this.pnInforPlayer.Controls.Add(this.btnLan);
            this.pnInforPlayer.Controls.Add(this.tbPlayer);
            this.pnInforPlayer.Controls.Add(this.tbIP);
            this.pnInforPlayer.Controls.Add(this.label2);
            this.pnInforPlayer.Location = new System.Drawing.Point(0, 26);
            this.pnInforPlayer.Name = "pnInforPlayer";
            this.pnInforPlayer.Size = new System.Drawing.Size(736, 547);
            this.pnInforPlayer.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "PHÒNG CHỜ.......";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(194, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(263, 57);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "BẮT ĐẦU";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(239, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "THÔNG TIN NGƯỜI CHƠI";
            // 
            // tbPlayer
            // 
            this.tbPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer.ForeColor = System.Drawing.Color.Red;
            this.tbPlayer.Location = new System.Drawing.Point(205, 132);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(423, 31);
            this.tbPlayer.TabIndex = 6;
            this.tbPlayer.TextChanged += new System.EventHandler(this.tbPlayer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(22, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "PLAYER NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = global::GameCaro1.Properties.Resources.download__1_;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.Location = new System.Drawing.Point(897, 316);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(77, 68);
            this.btnShow.TabIndex = 8;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::GameCaro1.Properties.Resources.giang_sinh_an_lanh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 676);
            this.Controls.Add(this.pnInforPlayer);
            this.Controls.Add(this.pnMess);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnAvatar);
            this.Controls.Add(this.pnChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " GAME CARO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).EndInit();
            this.pnAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.pnMess.ResumeLayout(false);
            this.pnMess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnInforPlayer.ResumeLayout(false);
            this.pnInforPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.PictureBox ptbMark;
        private System.Windows.Forms.ProgressBar pgbCoolDown;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Panel pnAvatar;
        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.Panel pnMess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnInforPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPlayMan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

