namespace HSAssignment1
{
    partial class Form2
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQ7 = new System.Windows.Forms.Label();
            this.lblQ6 = new System.Windows.Forms.Label();
            this.lblQ5 = new System.Windows.Forms.Label();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblQ7Points = new System.Windows.Forms.Label();
            this.lblQ6Points = new System.Windows.Forms.Label();
            this.lblQ5Points = new System.Windows.Forms.Label();
            this.lblQ4Points = new System.Windows.Forms.Label();
            this.lblQ3Points = new System.Windows.Forms.Label();
            this.lblQ2Points = new System.Windows.Forms.Label();
            this.lblQ1Points = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn5050 = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(26, 254);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(776, 61);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(122, 327);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(160, 57);
            this.btnOne.TabIndex = 2;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "button1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(515, 327);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(164, 57);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "button2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(122, 420);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(160, 57);
            this.btnThree.TabIndex = 4;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "button3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(515, 420);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(164, 57);
            this.btnFour.TabIndex = 5;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "button4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(16, 41);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(58, 41);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(94, 13);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Name Placeholder";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(16, 83);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "Points";
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.Location = new System.Drawing.Point(58, 83);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(13, 13);
            this.lblPlayerPoints.TabIndex = 9;
            this.lblPlayerPoints.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Q.No Points";
            // 
            // lblQ7
            // 
            this.lblQ7.AutoSize = true;
            this.lblQ7.Location = new System.Drawing.Point(644, 83);
            this.lblQ7.Name = "lblQ7";
            this.lblQ7.Size = new System.Drawing.Size(21, 13);
            this.lblQ7.TabIndex = 11;
            this.lblQ7.Text = "Q7";
            // 
            // lblQ6
            // 
            this.lblQ6.AutoSize = true;
            this.lblQ6.Location = new System.Drawing.Point(644, 96);
            this.lblQ6.Name = "lblQ6";
            this.lblQ6.Size = new System.Drawing.Size(21, 13);
            this.lblQ6.TabIndex = 12;
            this.lblQ6.Text = "Q6";
            // 
            // lblQ5
            // 
            this.lblQ5.AutoSize = true;
            this.lblQ5.Location = new System.Drawing.Point(644, 109);
            this.lblQ5.Name = "lblQ5";
            this.lblQ5.Size = new System.Drawing.Size(21, 13);
            this.lblQ5.TabIndex = 13;
            this.lblQ5.Text = "Q5";
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.Location = new System.Drawing.Point(644, 122);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(21, 13);
            this.lblQ4.TabIndex = 14;
            this.lblQ4.Text = "Q4";
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Location = new System.Drawing.Point(644, 135);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(21, 13);
            this.lblQ3.TabIndex = 15;
            this.lblQ3.Text = "Q3";
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Location = new System.Drawing.Point(644, 148);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(21, 13);
            this.lblQ2.TabIndex = 16;
            this.lblQ2.Text = "Q2";
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Location = new System.Drawing.Point(644, 161);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(21, 13);
            this.lblQ1.TabIndex = 17;
            this.lblQ1.Text = "Q1";
            // 
            // lblQ7Points
            // 
            this.lblQ7Points.AutoSize = true;
            this.lblQ7Points.Location = new System.Drawing.Point(666, 83);
            this.lblQ7Points.Name = "lblQ7Points";
            this.lblQ7Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ7Points.TabIndex = 18;
            this.lblQ7Points.Text = "0";
            // 
            // lblQ6Points
            // 
            this.lblQ6Points.AutoSize = true;
            this.lblQ6Points.Location = new System.Drawing.Point(666, 96);
            this.lblQ6Points.Name = "lblQ6Points";
            this.lblQ6Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ6Points.TabIndex = 19;
            this.lblQ6Points.Text = "0";
            // 
            // lblQ5Points
            // 
            this.lblQ5Points.AutoSize = true;
            this.lblQ5Points.Location = new System.Drawing.Point(666, 109);
            this.lblQ5Points.Name = "lblQ5Points";
            this.lblQ5Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ5Points.TabIndex = 20;
            this.lblQ5Points.Text = "0";
            // 
            // lblQ4Points
            // 
            this.lblQ4Points.AutoSize = true;
            this.lblQ4Points.Location = new System.Drawing.Point(666, 122);
            this.lblQ4Points.Name = "lblQ4Points";
            this.lblQ4Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ4Points.TabIndex = 21;
            this.lblQ4Points.Text = "0";
            // 
            // lblQ3Points
            // 
            this.lblQ3Points.AutoSize = true;
            this.lblQ3Points.Location = new System.Drawing.Point(666, 135);
            this.lblQ3Points.Name = "lblQ3Points";
            this.lblQ3Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ3Points.TabIndex = 22;
            this.lblQ3Points.Text = "0";
            // 
            // lblQ2Points
            // 
            this.lblQ2Points.AutoSize = true;
            this.lblQ2Points.Location = new System.Drawing.Point(666, 148);
            this.lblQ2Points.Name = "lblQ2Points";
            this.lblQ2Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ2Points.TabIndex = 23;
            this.lblQ2Points.Text = "0";
            this.lblQ2Points.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblQ1Points
            // 
            this.lblQ1Points.AutoSize = true;
            this.lblQ1Points.Location = new System.Drawing.Point(666, 161);
            this.lblQ1Points.Name = "lblQ1Points";
            this.lblQ1Points.Size = new System.Drawing.Size(13, 13);
            this.lblQ1Points.TabIndex = 24;
            this.lblQ1Points.Text = "0";
            this.lblQ1Points.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(389, 351);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(19, 13);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "00";
            // 
            // btn5050
            // 
            this.btn5050.Location = new System.Drawing.Point(515, 483);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(160, 23);
            this.btn5050.TabIndex = 26;
            this.btn5050.Text = "50:50";
            this.btn5050.UseVisualStyleBackColor = true;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(122, 483);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(160, 23);
            this.btnHint.TabIndex = 27;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(373, 420);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(96, 13);
            this.lblHint.TabIndex = 28;
            this.lblHint.Text = "Hhint Place Holder";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQ1Points);
            this.Controls.Add(this.lblQ2Points);
            this.Controls.Add(this.lblQ3Points);
            this.Controls.Add(this.lblQ4Points);
            this.Controls.Add(this.lblQ5Points);
            this.Controls.Add(this.lblQ6Points);
            this.Controls.Add(this.lblQ7Points);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.lblQ5);
            this.Controls.Add(this.lblQ6);
            this.Controls.Add(this.lblQ7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQ7;
        private System.Windows.Forms.Label lblQ6;
        private System.Windows.Forms.Label lblQ5;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblQ7Points;
        private System.Windows.Forms.Label lblQ6Points;
        private System.Windows.Forms.Label lblQ5Points;
        private System.Windows.Forms.Label lblQ4Points;
        private System.Windows.Forms.Label lblQ3Points;
        private System.Windows.Forms.Label lblQ2Points;
        private System.Windows.Forms.Label lblQ1Points;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblHint;
    }
}

