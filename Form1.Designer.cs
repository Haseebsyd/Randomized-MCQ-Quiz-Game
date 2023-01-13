namespace HSAssignment1
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
            this.lblQuizGameTitle = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblEnterNameBelow = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuizGameTitle
            // 
            this.lblQuizGameTitle.AutoSize = true;
            this.lblQuizGameTitle.Location = new System.Drawing.Point(362, 229);
            this.lblQuizGameTitle.Name = "lblQuizGameTitle";
            this.lblQuizGameTitle.Size = new System.Drawing.Size(73, 13);
            this.lblQuizGameTitle.TabIndex = 0;
            this.lblQuizGameTitle.Text = "QUIZ GAME!!";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(353, 287);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(91, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblEnterNameBelow
            // 
            this.lblEnterNameBelow.AutoSize = true;
            this.lblEnterNameBelow.Location = new System.Drawing.Point(350, 258);
            this.lblEnterNameBelow.Name = "lblEnterNameBelow";
            this.lblEnterNameBelow.Size = new System.Drawing.Size(95, 13);
            this.lblEnterNameBelow.TabIndex = 2;
            this.lblEnterNameBelow.Text = "Enter Name Below";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(360, 338);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEnterNameBelow);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblQuizGameTitle);
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizGameTitle;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblEnterNameBelow;
        private System.Windows.Forms.Button btnStart;
    }
}