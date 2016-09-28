namespace SettlersOfCatan
{
    partial class SettlersRollsGUI
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
            this.btnAuxDieBlack = new System.Windows.Forms.Button();
            this.btnAuxDieBlue = new System.Windows.Forms.Button();
            this.btnAuxDieGreen = new System.Windows.Forms.Button();
            this.btnAuxDieYellow = new System.Windows.Forms.Button();
            this.btnDiceRoll12 = new System.Windows.Forms.Button();
            this.btnDiceRoll11 = new System.Windows.Forms.Button();
            this.btnDiceRoll10 = new System.Windows.Forms.Button();
            this.btnDiceRoll9 = new System.Windows.Forms.Button();
            this.btnDiceRoll8 = new System.Windows.Forms.Button();
            this.btnDiceRoll7 = new System.Windows.Forms.Button();
            this.btnDiceRoll6 = new System.Windows.Forms.Button();
            this.btnDiceRoll5 = new System.Windows.Forms.Button();
            this.btnDiceRoll4 = new System.Windows.Forms.Button();
            this.btnDiceRoll3 = new System.Windows.Forms.Button();
            this.btnDiceRoll2 = new System.Windows.Forms.Button();
            this.lblRollCount2 = new System.Windows.Forms.Label();
            this.lblAuxCountBlue = new System.Windows.Forms.Label();
            this.lblAuxCountBlack = new System.Windows.Forms.Label();
            this.lblAuxCountGreen = new System.Windows.Forms.Label();
            this.lblRollCount12 = new System.Windows.Forms.Label();
            this.lblRollCount11 = new System.Windows.Forms.Label();
            this.lblRollCount10 = new System.Windows.Forms.Label();
            this.lblRollCount9 = new System.Windows.Forms.Label();
            this.lblRollCount8 = new System.Windows.Forms.Label();
            this.lblRollCount7 = new System.Windows.Forms.Label();
            this.lblRollCount6 = new System.Windows.Forms.Label();
            this.lblRollCount5 = new System.Windows.Forms.Label();
            this.lblRollCount4 = new System.Windows.Forms.Label();
            this.lblRollCount3 = new System.Windows.Forms.Label();
            this.lblAuxCountYellow = new System.Windows.Forms.Label();
            this.barRollCount2 = new System.Windows.Forms.ProgressBar();
            this.barAuxCountBlack = new System.Windows.Forms.ProgressBar();
            this.barAuxCountGreen = new System.Windows.Forms.ProgressBar();
            this.barAuxCountBlue = new System.Windows.Forms.ProgressBar();
            this.barAuxCountYellow = new System.Windows.Forms.ProgressBar();
            this.barRollCount12 = new System.Windows.Forms.ProgressBar();
            this.barRollCount11 = new System.Windows.Forms.ProgressBar();
            this.barRollCount10 = new System.Windows.Forms.ProgressBar();
            this.barRollCount9 = new System.Windows.Forms.ProgressBar();
            this.barRollCount8 = new System.Windows.Forms.ProgressBar();
            this.barRollCount7 = new System.Windows.Forms.ProgressBar();
            this.barRollCount6 = new System.Windows.Forms.ProgressBar();
            this.barRollCount5 = new System.Windows.Forms.ProgressBar();
            this.barRollCount4 = new System.Windows.Forms.ProgressBar();
            this.barRollCount3 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.staPlayerUp = new System.Windows.Forms.ToolStripStatusLabel();
            this.staLastMoveUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUpdates = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblBarbarianCounter = new System.Windows.Forms.Label();
            this.btnHelpGuidelines = new System.Windows.Forms.Button();
            this.tipSave = new System.Windows.Forms.ToolTip(this.components);
            this.tipLoad = new System.Windows.Forms.ToolTip(this.components);
            this.tipReset = new System.Windows.Forms.ToolTip(this.components);
            this.tipQuit = new System.Windows.Forms.ToolTip(this.components);
            this.tipUndo = new System.Windows.Forms.ToolTip(this.components);
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.tipRoll = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuxDieBlack
            // 
            this.btnAuxDieBlack.BackColor = System.Drawing.Color.Black;
            this.btnAuxDieBlack.Enabled = false;
            this.btnAuxDieBlack.ForeColor = System.Drawing.Color.White;
            this.btnAuxDieBlack.Location = new System.Drawing.Point(12, 516);
            this.btnAuxDieBlack.Name = "btnAuxDieBlack";
            this.btnAuxDieBlack.Size = new System.Drawing.Size(98, 30);
            this.btnAuxDieBlack.TabIndex = 0;
            this.btnAuxDieBlack.Text = "Barbarian";
            this.tipRoll.SetToolTip(this.btnAuxDieBlack, "Click if you rolled Barbarian");
            this.btnAuxDieBlack.UseVisualStyleBackColor = false;
            this.btnAuxDieBlack.Click += new System.EventHandler(this.btnAuxDieBlack_Click);
            // 
            // btnAuxDieBlue
            // 
            this.btnAuxDieBlue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAuxDieBlue.Enabled = false;
            this.btnAuxDieBlue.Location = new System.Drawing.Point(12, 444);
            this.btnAuxDieBlue.Name = "btnAuxDieBlue";
            this.btnAuxDieBlue.Size = new System.Drawing.Size(98, 30);
            this.btnAuxDieBlue.TabIndex = 1;
            this.btnAuxDieBlue.Text = "Blue";
            this.tipRoll.SetToolTip(this.btnAuxDieBlue, "Click if you rolled Blue");
            this.btnAuxDieBlue.UseVisualStyleBackColor = false;
            this.btnAuxDieBlue.Click += new System.EventHandler(this.btnAuxDieBlue_Click);
            // 
            // btnAuxDieGreen
            // 
            this.btnAuxDieGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAuxDieGreen.Enabled = false;
            this.btnAuxDieGreen.Location = new System.Drawing.Point(12, 480);
            this.btnAuxDieGreen.Name = "btnAuxDieGreen";
            this.btnAuxDieGreen.Size = new System.Drawing.Size(98, 30);
            this.btnAuxDieGreen.TabIndex = 2;
            this.btnAuxDieGreen.Text = "Blue";
            this.tipRoll.SetToolTip(this.btnAuxDieGreen, "Click if you rolled Green");
            this.btnAuxDieGreen.UseVisualStyleBackColor = false;
            this.btnAuxDieGreen.Click += new System.EventHandler(this.btnAuxDieGreen_Click);
            // 
            // btnAuxDieYellow
            // 
            this.btnAuxDieYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnAuxDieYellow.Enabled = false;
            this.btnAuxDieYellow.Location = new System.Drawing.Point(12, 408);
            this.btnAuxDieYellow.Name = "btnAuxDieYellow";
            this.btnAuxDieYellow.Size = new System.Drawing.Size(98, 30);
            this.btnAuxDieYellow.TabIndex = 3;
            this.btnAuxDieYellow.Text = "Yellow";
            this.tipRoll.SetToolTip(this.btnAuxDieYellow, "Click if you rolled Yellow");
            this.btnAuxDieYellow.UseVisualStyleBackColor = false;
            this.btnAuxDieYellow.Click += new System.EventHandler(this.btnAuxDieYellow_Click);
            // 
            // btnDiceRoll12
            // 
            this.btnDiceRoll12.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll12.Image = global::SettlersOfCatan.Properties.Resources.roll12;
            this.btnDiceRoll12.Location = new System.Drawing.Point(12, 372);
            this.btnDiceRoll12.Name = "btnDiceRoll12";
            this.btnDiceRoll12.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll12.TabIndex = 4;
            this.btnDiceRoll12.Text = "12  ";
            this.btnDiceRoll12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll12, "Click if you rolled a 12");
            this.btnDiceRoll12.UseVisualStyleBackColor = true;
            this.btnDiceRoll12.Click += new System.EventHandler(this.btnDiceRoll12_Click);
            // 
            // btnDiceRoll11
            // 
            this.btnDiceRoll11.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll11.Image = global::SettlersOfCatan.Properties.Resources.roll11;
            this.btnDiceRoll11.Location = new System.Drawing.Point(12, 336);
            this.btnDiceRoll11.Name = "btnDiceRoll11";
            this.btnDiceRoll11.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll11.TabIndex = 5;
            this.btnDiceRoll11.Text = "11  ";
            this.btnDiceRoll11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll11, "Click if you rolled an 11");
            this.btnDiceRoll11.UseVisualStyleBackColor = true;
            this.btnDiceRoll11.Click += new System.EventHandler(this.btnDiceRoll11_Click);
            // 
            // btnDiceRoll10
            // 
            this.btnDiceRoll10.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll10.Image = global::SettlersOfCatan.Properties.Resources.roll10;
            this.btnDiceRoll10.Location = new System.Drawing.Point(12, 300);
            this.btnDiceRoll10.Name = "btnDiceRoll10";
            this.btnDiceRoll10.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll10.TabIndex = 6;
            this.btnDiceRoll10.Text = "10  ";
            this.btnDiceRoll10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll10, "Click if you rolled a 10");
            this.btnDiceRoll10.UseVisualStyleBackColor = true;
            this.btnDiceRoll10.Click += new System.EventHandler(this.btnDiceRoll10_Click);
            // 
            // btnDiceRoll9
            // 
            this.btnDiceRoll9.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll9.Image = global::SettlersOfCatan.Properties.Resources.roll9;
            this.btnDiceRoll9.Location = new System.Drawing.Point(12, 264);
            this.btnDiceRoll9.Name = "btnDiceRoll9";
            this.btnDiceRoll9.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll9.TabIndex = 7;
            this.btnDiceRoll9.Text = "9   ";
            this.btnDiceRoll9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll9, "Click if you rolled a 9");
            this.btnDiceRoll9.UseVisualStyleBackColor = true;
            this.btnDiceRoll9.Click += new System.EventHandler(this.btnDiceRoll9_Click);
            // 
            // btnDiceRoll8
            // 
            this.btnDiceRoll8.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll8.Image = global::SettlersOfCatan.Properties.Resources.roll8;
            this.btnDiceRoll8.Location = new System.Drawing.Point(12, 228);
            this.btnDiceRoll8.Name = "btnDiceRoll8";
            this.btnDiceRoll8.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll8.TabIndex = 8;
            this.btnDiceRoll8.Text = "8   ";
            this.btnDiceRoll8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll8, "Click if you rolled an 8");
            this.btnDiceRoll8.UseVisualStyleBackColor = true;
            this.btnDiceRoll8.Click += new System.EventHandler(this.btnDiceRoll8_Click);
            // 
            // btnDiceRoll7
            // 
            this.btnDiceRoll7.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll7.Image = global::SettlersOfCatan.Properties.Resources.roll7;
            this.btnDiceRoll7.Location = new System.Drawing.Point(12, 192);
            this.btnDiceRoll7.Name = "btnDiceRoll7";
            this.btnDiceRoll7.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll7.TabIndex = 9;
            this.btnDiceRoll7.Text = "7   ";
            this.btnDiceRoll7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll7, "Click if you rolled a 7");
            this.btnDiceRoll7.UseVisualStyleBackColor = true;
            this.btnDiceRoll7.Click += new System.EventHandler(this.btnDiceRoll7_Click);
            // 
            // btnDiceRoll6
            // 
            this.btnDiceRoll6.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll6.Image = global::SettlersOfCatan.Properties.Resources.roll6;
            this.btnDiceRoll6.Location = new System.Drawing.Point(12, 156);
            this.btnDiceRoll6.Name = "btnDiceRoll6";
            this.btnDiceRoll6.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll6.TabIndex = 10;
            this.btnDiceRoll6.Text = "6   ";
            this.btnDiceRoll6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll6, "Click if you rolled a 6");
            this.btnDiceRoll6.UseVisualStyleBackColor = true;
            this.btnDiceRoll6.Click += new System.EventHandler(this.btnDiceRoll6_Click);
            // 
            // btnDiceRoll5
            // 
            this.btnDiceRoll5.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll5.Image = global::SettlersOfCatan.Properties.Resources.roll5;
            this.btnDiceRoll5.Location = new System.Drawing.Point(12, 120);
            this.btnDiceRoll5.Name = "btnDiceRoll5";
            this.btnDiceRoll5.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll5.TabIndex = 11;
            this.btnDiceRoll5.Text = "5   ";
            this.btnDiceRoll5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll5, "Click if you rolled a 5");
            this.btnDiceRoll5.UseVisualStyleBackColor = true;
            this.btnDiceRoll5.Click += new System.EventHandler(this.btnDiceRoll5_Click);
            // 
            // btnDiceRoll4
            // 
            this.btnDiceRoll4.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll4.Image = global::SettlersOfCatan.Properties.Resources.roll4;
            this.btnDiceRoll4.Location = new System.Drawing.Point(12, 84);
            this.btnDiceRoll4.Name = "btnDiceRoll4";
            this.btnDiceRoll4.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll4.TabIndex = 12;
            this.btnDiceRoll4.Text = "4   ";
            this.btnDiceRoll4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll4, "Click if you rolled a  4");
            this.btnDiceRoll4.UseVisualStyleBackColor = true;
            this.btnDiceRoll4.Click += new System.EventHandler(this.btnDiceRoll4_Click);
            // 
            // btnDiceRoll3
            // 
            this.btnDiceRoll3.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll3.Image = global::SettlersOfCatan.Properties.Resources.roll3;
            this.btnDiceRoll3.Location = new System.Drawing.Point(12, 48);
            this.btnDiceRoll3.Name = "btnDiceRoll3";
            this.btnDiceRoll3.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll3.TabIndex = 13;
            this.btnDiceRoll3.Text = "3   ";
            this.btnDiceRoll3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll3, "Click if you rolled a 3");
            this.btnDiceRoll3.UseVisualStyleBackColor = true;
            this.btnDiceRoll3.Click += new System.EventHandler(this.btnDiceRoll3_Click);
            // 
            // btnDiceRoll2
            // 
            this.btnDiceRoll2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiceRoll2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiceRoll2.Image = global::SettlersOfCatan.Properties.Resources.roll2;
            this.btnDiceRoll2.Location = new System.Drawing.Point(12, 12);
            this.btnDiceRoll2.Name = "btnDiceRoll2";
            this.btnDiceRoll2.Size = new System.Drawing.Size(98, 30);
            this.btnDiceRoll2.TabIndex = 14;
            this.btnDiceRoll2.Text = "2   ";
            this.btnDiceRoll2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipRoll.SetToolTip(this.btnDiceRoll2, "Click if you rolled a 2");
            this.btnDiceRoll2.UseVisualStyleBackColor = true;
            this.btnDiceRoll2.Click += new System.EventHandler(this.btnDiceRoll2_Click);
            // 
            // lblRollCount2
            // 
            this.lblRollCount2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount2.Location = new System.Drawing.Point(116, 9);
            this.lblRollCount2.Name = "lblRollCount2";
            this.lblRollCount2.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount2.TabIndex = 15;
            this.lblRollCount2.Text = "0";
            this.lblRollCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuxCountBlue
            // 
            this.lblAuxCountBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuxCountBlue.Location = new System.Drawing.Point(116, 441);
            this.lblAuxCountBlue.Name = "lblAuxCountBlue";
            this.lblAuxCountBlue.Size = new System.Drawing.Size(30, 30);
            this.lblAuxCountBlue.TabIndex = 16;
            this.lblAuxCountBlue.Text = "0";
            this.lblAuxCountBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuxCountBlack
            // 
            this.lblAuxCountBlack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuxCountBlack.Location = new System.Drawing.Point(116, 513);
            this.lblAuxCountBlack.Name = "lblAuxCountBlack";
            this.lblAuxCountBlack.Size = new System.Drawing.Size(30, 30);
            this.lblAuxCountBlack.TabIndex = 17;
            this.lblAuxCountBlack.Text = "0";
            this.lblAuxCountBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuxCountGreen
            // 
            this.lblAuxCountGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuxCountGreen.Location = new System.Drawing.Point(116, 477);
            this.lblAuxCountGreen.Name = "lblAuxCountGreen";
            this.lblAuxCountGreen.Size = new System.Drawing.Size(30, 30);
            this.lblAuxCountGreen.TabIndex = 18;
            this.lblAuxCountGreen.Text = "0";
            this.lblAuxCountGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount12
            // 
            this.lblRollCount12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount12.Location = new System.Drawing.Point(116, 369);
            this.lblRollCount12.Name = "lblRollCount12";
            this.lblRollCount12.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount12.TabIndex = 19;
            this.lblRollCount12.Text = "0";
            this.lblRollCount12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount11
            // 
            this.lblRollCount11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount11.Location = new System.Drawing.Point(116, 333);
            this.lblRollCount11.Name = "lblRollCount11";
            this.lblRollCount11.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount11.TabIndex = 20;
            this.lblRollCount11.Text = "0";
            this.lblRollCount11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount10
            // 
            this.lblRollCount10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount10.Location = new System.Drawing.Point(116, 297);
            this.lblRollCount10.Name = "lblRollCount10";
            this.lblRollCount10.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount10.TabIndex = 21;
            this.lblRollCount10.Text = "0";
            this.lblRollCount10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount9
            // 
            this.lblRollCount9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount9.Location = new System.Drawing.Point(116, 261);
            this.lblRollCount9.Name = "lblRollCount9";
            this.lblRollCount9.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount9.TabIndex = 22;
            this.lblRollCount9.Text = "0";
            this.lblRollCount9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount8
            // 
            this.lblRollCount8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount8.Location = new System.Drawing.Point(116, 225);
            this.lblRollCount8.Name = "lblRollCount8";
            this.lblRollCount8.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount8.TabIndex = 23;
            this.lblRollCount8.Text = "0";
            this.lblRollCount8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount7
            // 
            this.lblRollCount7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount7.Location = new System.Drawing.Point(116, 189);
            this.lblRollCount7.Name = "lblRollCount7";
            this.lblRollCount7.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount7.TabIndex = 24;
            this.lblRollCount7.Text = "0";
            this.lblRollCount7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount6
            // 
            this.lblRollCount6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount6.Location = new System.Drawing.Point(116, 153);
            this.lblRollCount6.Name = "lblRollCount6";
            this.lblRollCount6.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount6.TabIndex = 25;
            this.lblRollCount6.Text = "0";
            this.lblRollCount6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount5
            // 
            this.lblRollCount5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount5.Location = new System.Drawing.Point(116, 117);
            this.lblRollCount5.Name = "lblRollCount5";
            this.lblRollCount5.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount5.TabIndex = 26;
            this.lblRollCount5.Text = "0";
            this.lblRollCount5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount4
            // 
            this.lblRollCount4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount4.Location = new System.Drawing.Point(116, 81);
            this.lblRollCount4.Name = "lblRollCount4";
            this.lblRollCount4.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount4.TabIndex = 27;
            this.lblRollCount4.Text = "0";
            this.lblRollCount4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollCount3
            // 
            this.lblRollCount3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRollCount3.Location = new System.Drawing.Point(116, 45);
            this.lblRollCount3.Name = "lblRollCount3";
            this.lblRollCount3.Size = new System.Drawing.Size(30, 30);
            this.lblRollCount3.TabIndex = 28;
            this.lblRollCount3.Text = "0";
            this.lblRollCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuxCountYellow
            // 
            this.lblAuxCountYellow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuxCountYellow.Location = new System.Drawing.Point(116, 405);
            this.lblAuxCountYellow.Name = "lblAuxCountYellow";
            this.lblAuxCountYellow.Size = new System.Drawing.Size(30, 30);
            this.lblAuxCountYellow.TabIndex = 29;
            this.lblAuxCountYellow.Text = "0";
            this.lblAuxCountYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barRollCount2
            // 
            this.barRollCount2.Location = new System.Drawing.Point(152, 9);
            this.barRollCount2.Name = "barRollCount2";
            this.barRollCount2.Size = new System.Drawing.Size(500, 30);
            this.barRollCount2.TabIndex = 30;
            // 
            // barAuxCountBlack
            // 
            this.barAuxCountBlack.Location = new System.Drawing.Point(152, 513);
            this.barAuxCountBlack.Name = "barAuxCountBlack";
            this.barAuxCountBlack.Size = new System.Drawing.Size(500, 30);
            this.barAuxCountBlack.TabIndex = 31;
            // 
            // barAuxCountGreen
            // 
            this.barAuxCountGreen.Location = new System.Drawing.Point(152, 477);
            this.barAuxCountGreen.Name = "barAuxCountGreen";
            this.barAuxCountGreen.Size = new System.Drawing.Size(500, 30);
            this.barAuxCountGreen.TabIndex = 32;
            // 
            // barAuxCountBlue
            // 
            this.barAuxCountBlue.Location = new System.Drawing.Point(152, 441);
            this.barAuxCountBlue.Name = "barAuxCountBlue";
            this.barAuxCountBlue.Size = new System.Drawing.Size(500, 30);
            this.barAuxCountBlue.TabIndex = 33;
            // 
            // barAuxCountYellow
            // 
            this.barAuxCountYellow.Location = new System.Drawing.Point(152, 405);
            this.barAuxCountYellow.Name = "barAuxCountYellow";
            this.barAuxCountYellow.Size = new System.Drawing.Size(500, 30);
            this.barAuxCountYellow.TabIndex = 34;
            // 
            // barRollCount12
            // 
            this.barRollCount12.Location = new System.Drawing.Point(152, 369);
            this.barRollCount12.Name = "barRollCount12";
            this.barRollCount12.Size = new System.Drawing.Size(500, 30);
            this.barRollCount12.TabIndex = 35;
            // 
            // barRollCount11
            // 
            this.barRollCount11.Location = new System.Drawing.Point(152, 333);
            this.barRollCount11.Name = "barRollCount11";
            this.barRollCount11.Size = new System.Drawing.Size(500, 30);
            this.barRollCount11.TabIndex = 36;
            // 
            // barRollCount10
            // 
            this.barRollCount10.Location = new System.Drawing.Point(152, 297);
            this.barRollCount10.Name = "barRollCount10";
            this.barRollCount10.Size = new System.Drawing.Size(500, 30);
            this.barRollCount10.TabIndex = 37;
            // 
            // barRollCount9
            // 
            this.barRollCount9.Location = new System.Drawing.Point(152, 261);
            this.barRollCount9.Name = "barRollCount9";
            this.barRollCount9.Size = new System.Drawing.Size(500, 30);
            this.barRollCount9.TabIndex = 38;
            // 
            // barRollCount8
            // 
            this.barRollCount8.Location = new System.Drawing.Point(152, 225);
            this.barRollCount8.Name = "barRollCount8";
            this.barRollCount8.Size = new System.Drawing.Size(500, 30);
            this.barRollCount8.TabIndex = 39;
            // 
            // barRollCount7
            // 
            this.barRollCount7.Location = new System.Drawing.Point(152, 189);
            this.barRollCount7.Name = "barRollCount7";
            this.barRollCount7.Size = new System.Drawing.Size(500, 30);
            this.barRollCount7.TabIndex = 40;
            // 
            // barRollCount6
            // 
            this.barRollCount6.Location = new System.Drawing.Point(152, 153);
            this.barRollCount6.Name = "barRollCount6";
            this.barRollCount6.Size = new System.Drawing.Size(500, 30);
            this.barRollCount6.TabIndex = 41;
            // 
            // barRollCount5
            // 
            this.barRollCount5.Location = new System.Drawing.Point(152, 117);
            this.barRollCount5.Name = "barRollCount5";
            this.barRollCount5.Size = new System.Drawing.Size(500, 30);
            this.barRollCount5.TabIndex = 42;
            // 
            // barRollCount4
            // 
            this.barRollCount4.Location = new System.Drawing.Point(152, 81);
            this.barRollCount4.Name = "barRollCount4";
            this.barRollCount4.Size = new System.Drawing.Size(500, 30);
            this.barRollCount4.TabIndex = 43;
            // 
            // barRollCount3
            // 
            this.barRollCount3.Location = new System.Drawing.Point(152, 45);
            this.barRollCount3.Name = "barRollCount3";
            this.barRollCount3.Size = new System.Drawing.Size(500, 30);
            this.barRollCount3.TabIndex = 44;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staPlayerUp,
            this.staLastMoveUpdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 24);
            this.statusStrip1.TabIndex = 45;
            // 
            // staPlayerUp
            // 
            this.staPlayerUp.AutoSize = false;
            this.staPlayerUp.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.staPlayerUp.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.staPlayerUp.Name = "staPlayerUp";
            this.staPlayerUp.Size = new System.Drawing.Size(85, 19);
            this.staPlayerUp.Text = "Player 1\'s turn";
            this.staPlayerUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // staLastMoveUpdate
            // 
            this.staLastMoveUpdate.AutoSize = false;
            this.staLastMoveUpdate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.staLastMoveUpdate.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.staLastMoveUpdate.Name = "staLastMoveUpdate";
            this.staLastMoveUpdate.Size = new System.Drawing.Size(310, 19);
            this.staLastMoveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUpdates
            // 
            this.txtUpdates.Location = new System.Drawing.Point(659, 45);
            this.txtUpdates.Multiline = true;
            this.txtUpdates.Name = "txtUpdates";
            this.txtUpdates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUpdates.Size = new System.Drawing.Size(237, 426);
            this.txtUpdates.TabIndex = 46;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(820, 477);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.tipReset.SetToolTip(this.btnReset, "Click to reset all counters to 0. Can function as starting a new game");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(739, 477);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 30);
            this.btnSaveData.TabIndex = 48;
            this.btnSaveData.Text = "Save";
            this.tipSave.SetToolTip(this.btnSaveData, "Click to save rolls to file");
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(739, 513);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 30);
            this.btnQuit.TabIndex = 50;
            this.btnQuit.Text = "Quit";
            this.tipQuit.SetToolTip(this.btnQuit, "Click to exit application");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(820, 513);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 30);
            this.btnUndo.TabIndex = 51;
            this.btnUndo.Text = "Undo";
            this.tipUndo.SetToolTip(this.btnUndo, "Click to undo last move");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblBarbarianCounter
            // 
            this.lblBarbarianCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblBarbarianCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarbarianCounter.ForeColor = System.Drawing.Color.Black;
            this.lblBarbarianCounter.Location = new System.Drawing.Point(682, 518);
            this.lblBarbarianCounter.Name = "lblBarbarianCounter";
            this.lblBarbarianCounter.Size = new System.Drawing.Size(20, 20);
            this.lblBarbarianCounter.TabIndex = 52;
            this.lblBarbarianCounter.Text = "7";
            this.lblBarbarianCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHelpGuidelines
            // 
            this.btnHelpGuidelines.Location = new System.Drawing.Point(661, 9);
            this.btnHelpGuidelines.Name = "btnHelpGuidelines";
            this.btnHelpGuidelines.Size = new System.Drawing.Size(234, 30);
            this.btnHelpGuidelines.TabIndex = 53;
            this.btnHelpGuidelines.Text = "How to Use/HELP";
            this.tipHelp.SetToolTip(this.btnHelpGuidelines, "Click for help on how the program works");
            this.btnHelpGuidelines.UseVisualStyleBackColor = true;
            this.btnHelpGuidelines.Click += new System.EventHandler(this.btnHelpGuidelines_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "Rolls left until\r\nBarbarian hits:";
            // 
            // SettlersRollsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelpGuidelines);
            this.Controls.Add(this.lblBarbarianCounter);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtUpdates);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barRollCount3);
            this.Controls.Add(this.barRollCount4);
            this.Controls.Add(this.barRollCount5);
            this.Controls.Add(this.barRollCount6);
            this.Controls.Add(this.barRollCount7);
            this.Controls.Add(this.barRollCount8);
            this.Controls.Add(this.barRollCount9);
            this.Controls.Add(this.barRollCount10);
            this.Controls.Add(this.barRollCount11);
            this.Controls.Add(this.barRollCount12);
            this.Controls.Add(this.barAuxCountYellow);
            this.Controls.Add(this.barAuxCountBlue);
            this.Controls.Add(this.barAuxCountGreen);
            this.Controls.Add(this.barAuxCountBlack);
            this.Controls.Add(this.barRollCount2);
            this.Controls.Add(this.lblAuxCountYellow);
            this.Controls.Add(this.lblRollCount3);
            this.Controls.Add(this.lblRollCount4);
            this.Controls.Add(this.lblRollCount5);
            this.Controls.Add(this.lblRollCount6);
            this.Controls.Add(this.lblRollCount7);
            this.Controls.Add(this.lblRollCount8);
            this.Controls.Add(this.lblRollCount9);
            this.Controls.Add(this.lblRollCount10);
            this.Controls.Add(this.lblRollCount11);
            this.Controls.Add(this.lblRollCount12);
            this.Controls.Add(this.lblAuxCountGreen);
            this.Controls.Add(this.lblAuxCountBlack);
            this.Controls.Add(this.lblAuxCountBlue);
            this.Controls.Add(this.lblRollCount2);
            this.Controls.Add(this.btnDiceRoll2);
            this.Controls.Add(this.btnDiceRoll3);
            this.Controls.Add(this.btnDiceRoll4);
            this.Controls.Add(this.btnDiceRoll5);
            this.Controls.Add(this.btnDiceRoll6);
            this.Controls.Add(this.btnDiceRoll7);
            this.Controls.Add(this.btnDiceRoll8);
            this.Controls.Add(this.btnDiceRoll9);
            this.Controls.Add(this.btnDiceRoll10);
            this.Controls.Add(this.btnDiceRoll11);
            this.Controls.Add(this.btnDiceRoll12);
            this.Controls.Add(this.btnAuxDieYellow);
            this.Controls.Add(this.btnAuxDieGreen);
            this.Controls.Add(this.btnAuxDieBlue);
            this.Controls.Add(this.btnAuxDieBlack);
            this.Name = "SettlersRollsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settlers of Catan Dice Rolls";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuxDieBlack;
        private System.Windows.Forms.Button btnAuxDieBlue;
        private System.Windows.Forms.Button btnAuxDieGreen;
        private System.Windows.Forms.Button btnAuxDieYellow;
        private System.Windows.Forms.Button btnDiceRoll12;
        private System.Windows.Forms.Button btnDiceRoll11;
        private System.Windows.Forms.Button btnDiceRoll10;
        private System.Windows.Forms.Button btnDiceRoll9;
        private System.Windows.Forms.Button btnDiceRoll8;
        private System.Windows.Forms.Button btnDiceRoll7;
        private System.Windows.Forms.Button btnDiceRoll6;
        private System.Windows.Forms.Button btnDiceRoll5;
        private System.Windows.Forms.Button btnDiceRoll4;
        private System.Windows.Forms.Button btnDiceRoll3;
        private System.Windows.Forms.Button btnDiceRoll2;
        private System.Windows.Forms.Label lblRollCount2;
        private System.Windows.Forms.Label lblAuxCountBlue;
        private System.Windows.Forms.Label lblAuxCountBlack;
        private System.Windows.Forms.Label lblAuxCountGreen;
        private System.Windows.Forms.Label lblRollCount12;
        private System.Windows.Forms.Label lblRollCount11;
        private System.Windows.Forms.Label lblRollCount10;
        private System.Windows.Forms.Label lblRollCount9;
        private System.Windows.Forms.Label lblRollCount8;
        private System.Windows.Forms.Label lblRollCount7;
        private System.Windows.Forms.Label lblRollCount6;
        private System.Windows.Forms.Label lblRollCount5;
        private System.Windows.Forms.Label lblRollCount4;
        private System.Windows.Forms.Label lblRollCount3;
        private System.Windows.Forms.Label lblAuxCountYellow;
        private System.Windows.Forms.ProgressBar barRollCount2;
        private System.Windows.Forms.ProgressBar barAuxCountBlack;
        private System.Windows.Forms.ProgressBar barAuxCountGreen;
        private System.Windows.Forms.ProgressBar barAuxCountBlue;
        private System.Windows.Forms.ProgressBar barAuxCountYellow;
        private System.Windows.Forms.ProgressBar barRollCount12;
        private System.Windows.Forms.ProgressBar barRollCount11;
        private System.Windows.Forms.ProgressBar barRollCount10;
        private System.Windows.Forms.ProgressBar barRollCount9;
        private System.Windows.Forms.ProgressBar barRollCount8;
        private System.Windows.Forms.ProgressBar barRollCount7;
        private System.Windows.Forms.ProgressBar barRollCount6;
        private System.Windows.Forms.ProgressBar barRollCount5;
        private System.Windows.Forms.ProgressBar barRollCount4;
        private System.Windows.Forms.ProgressBar barRollCount3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtUpdates;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ToolStripStatusLabel staLastMoveUpdate;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblBarbarianCounter;
        private System.Windows.Forms.Button btnHelpGuidelines;
        private System.Windows.Forms.ToolTip tipReset;
        private System.Windows.Forms.ToolTip tipSave;
        private System.Windows.Forms.ToolTip tipLoad;
        private System.Windows.Forms.ToolTip tipQuit;
        private System.Windows.Forms.ToolTip tipUndo;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.ToolTip tipRoll;
        private System.Windows.Forms.ToolStripStatusLabel staPlayerUp;
        private System.Windows.Forms.Label label1;
    }
}

