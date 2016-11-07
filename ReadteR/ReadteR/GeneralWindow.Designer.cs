namespace ReadteR
{
    partial class GeneralWindow
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
            this.tweetBox = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.newsBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.news = new System.Windows.Forms.Label();
            this.someoneProfile = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tweetBox
            // 
            this.tweetBox.Location = new System.Drawing.Point(3, 3);
            this.tweetBox.Multiline = true;
            this.tweetBox.Name = "tweetBox";
            this.tweetBox.Size = new System.Drawing.Size(235, 348);
            this.tweetBox.TabIndex = 0;
            this.tweetBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(12, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(155, 31);
            this.userName.TabIndex = 1;
            this.userName.Text = "Your Profile";
            // 
            // newsBox
            // 
            this.newsBox.Location = new System.Drawing.Point(248, 3);
            this.newsBox.Multiline = true;
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(235, 348);
            this.newsBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(493, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 348);
            this.textBox2.TabIndex = 3;
            // 
            // news
            // 
            this.news.AutoSize = true;
            this.news.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.news.Location = new System.Drawing.Point(265, 9);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(83, 31);
            this.news.TabIndex = 4;
            this.news.Text = "News";
            // 
            // someoneProfile
            // 
            this.someoneProfile.AutoSize = true;
            this.someoneProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.someoneProfile.Location = new System.Drawing.Point(526, 9);
            this.someoneProfile.Name = "someoneProfile";
            this.someoneProfile.Size = new System.Drawing.Size(129, 31);
            this.someoneProfile.TabIndex = 5;
            this.someoneProfile.Text = "Someone";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.Controls.Add(this.tweetBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.newsBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 354);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.someoneProfile);
            this.Controls.Add(this.news);
            this.Controls.Add(this.userName);
            this.Name = "GeneralWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tweetBox;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox newsBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label news;
        private System.Windows.Forms.Label someoneProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}