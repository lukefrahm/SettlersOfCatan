namespace SettlersOfCatan
{
    partial class SettlersStartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.numSelectPlayers = new System.Windows.Forms.NumericUpDown();
            this.tipBegin = new System.Windows.Forms.ToolTip(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tipExit = new System.Windows.Forms.ToolTip(this.components);
            this.tipPlayers = new System.Windows.Forms.ToolTip(this.components);
            this.tipOptions = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Players:";
            this.tipPlayers.SetToolTip(this.label1, "Select how many players for this game");
            // 
            // numSelectPlayers
            // 
            this.numSelectPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numSelectPlayers.Location = new System.Drawing.Point(11, 97);
            this.numSelectPlayers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSelectPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSelectPlayers.Name = "numSelectPlayers";
            this.numSelectPlayers.Size = new System.Drawing.Size(118, 23);
            this.numSelectPlayers.TabIndex = 2;
            this.tipPlayers.SetToolTip(this.numSelectPlayers, "Select how many players for this game");
            this.numSelectPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackgroundImage = global::SettlersOfCatan.Properties.Resources.GUIBackground;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGame.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.DimGray;
            this.btnStartGame.Location = new System.Drawing.Point(136, 12);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(165, 110);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "B e g i n \r\nG a m e !";
            this.tipBegin.SetToolTip(this.btnStartGame, "Click to start game!");
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SettlersOfCatan.Properties.Resources.CatanLogo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SettlersStartScreen
            // 
            this.AcceptButton = this.btnStartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(312, 133);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numSelectPlayers);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.Name = "SettlersStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.numSelectPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSelectPlayers;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ToolTip tipPlayers;
        private System.Windows.Forms.ToolTip tipOptions;
        private System.Windows.Forms.ToolTip tipBegin;
        private System.Windows.Forms.ToolTip tipExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}