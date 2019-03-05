namespace DriveLicense
{
    partial class TestPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Question = new System.Windows.Forms.Label();
            this.QuestionImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.AnswerCount = new System.Windows.Forms.Label();
            this.CorrectAns = new System.Windows.Forms.Label();
            this.FalseAns = new System.Windows.Forms.Label();
            this.SeeDesc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DriveLicense.Properties.Resources.carImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 601);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(121, 9);
            this.Question.Name = "Question";
            this.Question.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Question.Size = new System.Drawing.Size(549, 74);
            this.Question.TabIndex = 1;
            this.Question.Text = "Question";
            // 
            // QuestionImage
            // 
            this.QuestionImage.Location = new System.Drawing.Point(121, 89);
            this.QuestionImage.Name = "QuestionImage";
            this.QuestionImage.Size = new System.Drawing.Size(549, 259);
            this.QuestionImage.TabIndex = 2;
            this.QuestionImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(397, 450);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(270, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 450);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(270, 81);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(398, 359);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(270, 81);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 359);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(270, 81);
            this.label4.TabIndex = 6;
            this.label4.Text = "Answer";
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(243, 544);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(148, 35);
            this.Prev.TabIndex = 7;
            this.Prev.Text = "წინა";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(397, 544);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(148, 35);
            this.Next.TabIndex = 8;
            this.Next.Text = "შემდეგი";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // AnswerCount
            // 
            this.AnswerCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AnswerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerCount.Location = new System.Drawing.Point(12, 11);
            this.AnswerCount.Name = "AnswerCount";
            this.AnswerCount.Size = new System.Drawing.Size(80, 27);
            this.AnswerCount.TabIndex = 9;
            this.AnswerCount.Text = "0/30";
            this.AnswerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectAns
            // 
            this.CorrectAns.BackColor = System.Drawing.Color.Green;
            this.CorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectAns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CorrectAns.Location = new System.Drawing.Point(12, 56);
            this.CorrectAns.Name = "CorrectAns";
            this.CorrectAns.Size = new System.Drawing.Size(40, 27);
            this.CorrectAns.TabIndex = 10;
            this.CorrectAns.Text = "0";
            this.CorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FalseAns
            // 
            this.FalseAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FalseAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FalseAns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FalseAns.Location = new System.Drawing.Point(52, 56);
            this.FalseAns.Name = "FalseAns";
            this.FalseAns.Size = new System.Drawing.Size(40, 27);
            this.FalseAns.TabIndex = 11;
            this.FalseAns.Text = "0";
            this.FalseAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeeDesc
            // 
            this.SeeDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SeeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeeDesc.Location = new System.Drawing.Point(674, 9);
            this.SeeDesc.Name = "SeeDesc";
            this.SeeDesc.Size = new System.Drawing.Size(108, 43);
            this.SeeDesc.TabIndex = 12;
            this.SeeDesc.Text = "განმარტების ნახვა";
            this.SeeDesc.UseVisualStyleBackColor = false;
            this.SeeDesc.Click += new System.EventHandler(this.SeeDesc_Click);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.SeeDesc);
            this.Controls.Add(this.FalseAns);
            this.Controls.Add(this.CorrectAns);
            this.Controls.Add(this.AnswerCount);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionImage);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TestPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.PictureBox QuestionImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label AnswerCount;
        private System.Windows.Forms.Label CorrectAns;
        private System.Windows.Forms.Label FalseAns;
        private System.Windows.Forms.Button SeeDesc;
    }
}