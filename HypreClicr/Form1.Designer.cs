namespace HypreClicr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            upgradeIncomeButton = new Button();
            upgradeClickButton = new Button();
            tabPage2 = new TabPage();
            incomeSpeedButton = new Button();
            clickButton = new Button();
            pointsLabel = new Label();
            progressBar1 = new ProgressBar();
            powerLabel = new Label();
            levelLabel = new Label();
            incomeTimer = new System.Windows.Forms.Timer(components);
            incomeLabel = new Label();
            clickCostButton = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(403, 56);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(385, 382);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(upgradeIncomeButton);
            tabPage1.Controls.Add(upgradeClickButton);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(377, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // upgradeIncomeButton
            // 
            upgradeIncomeButton.Location = new Point(7, 75);
            upgradeIncomeButton.Name = "upgradeIncomeButton";
            upgradeIncomeButton.Size = new Size(365, 56);
            upgradeIncomeButton.TabIndex = 1;
            upgradeIncomeButton.Text = "Upgrade Passive Income: 50";
            upgradeIncomeButton.UseVisualStyleBackColor = true;
            upgradeIncomeButton.Click += upgradeIncomeButton_Click;
            // 
            // upgradeClickButton
            // 
            upgradeClickButton.Location = new Point(7, 13);
            upgradeClickButton.Name = "upgradeClickButton";
            upgradeClickButton.Size = new Size(365, 56);
            upgradeClickButton.TabIndex = 0;
            upgradeClickButton.Text = "Upgrade Click Power: 10";
            upgradeClickButton.UseVisualStyleBackColor = true;
            upgradeClickButton.Click += upgradeClickButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(clickCostButton);
            tabPage2.Controls.Add(incomeSpeedButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(377, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // incomeSpeedButton
            // 
            incomeSpeedButton.Location = new Point(6, 6);
            incomeSpeedButton.Name = "incomeSpeedButton";
            incomeSpeedButton.Size = new Size(365, 56);
            incomeSpeedButton.TabIndex = 7;
            incomeSpeedButton.Text = "Upgrade Income Speed: 2000";
            incomeSpeedButton.UseVisualStyleBackColor = true;
            incomeSpeedButton.Click += incomeSpeedButton_Click;
            // 
            // clickButton
            // 
            clickButton.Cursor = Cursors.Hand;
            clickButton.Location = new Point(12, 339);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(385, 95);
            clickButton.TabIndex = 1;
            clickButton.Text = "Clicr\r\n";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.MouseClick += clickButton_Click;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new Point(405, 15);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(63, 20);
            pointsLabel.TabIndex = 2;
            pointsLabel.Text = "Points: 0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 15);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(385, 42);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 3;
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Location = new Point(549, 15);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new Size(99, 20);
            powerLabel.TabIndex = 4;
            powerLabel.Text = "Click Power: 1";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(721, 15);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(58, 20);
            levelLabel.TabIndex = 5;
            levelLabel.Text = "Level: 0";
            // 
            // incomeTimer
            // 
            incomeTimer.Interval = 3000;
            incomeTimer.Tick += incomeTimer_Tick;
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new Point(12, 85);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new Size(123, 20);
            incomeLabel.TabIndex = 6;
            incomeLabel.Text = "Passive Income: 0";
            // 
            // clickCostButton
            // 
            clickCostButton.Location = new Point(6, 68);
            clickCostButton.Name = "clickCostButton";
            clickCostButton.Size = new Size(365, 56);
            clickCostButton.TabIndex = 8;
            clickCostButton.Text = "Lower Click Upgrade Cost: 500";
            clickCostButton.UseVisualStyleBackColor = true;
            clickCostButton.Click += clickCostButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(incomeLabel);
            Controls.Add(levelLabel);
            Controls.Add(powerLabel);
            Controls.Add(progressBar1);
            Controls.Add(pointsLabel);
            Controls.Add(clickButton);
            Controls.Add(tabControl);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += main_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button clickButton;
        private Label pointsLabel;
        private ProgressBar progressBar1;
        private Button upgradeClickButton;
        private Label powerLabel;
        private Label levelLabel;
        private Button upgradeIncomeButton;
        private System.Windows.Forms.Timer incomeTimer;
        private Label incomeLabel;
        private Button incomeSpeedButton;
        private Button clickCostButton;
    }
}
