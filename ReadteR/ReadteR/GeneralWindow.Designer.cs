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
            this.components = new System.ComponentModel.Container();
            this.userName = new System.Windows.Forms.Label();
            this.news = new System.Windows.Forms.Label();
            this.generationPanel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newsBox = new System.Windows.Forms.RichTextBox();
            this.tweetBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.generationBox = new System.Windows.Forms.RichTextBox();
            this.tweetButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(3, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(155, 31);
            this.userName.TabIndex = 1;
            this.userName.Text = "Your Profile";
            // 
            // news
            // 
            this.news.AutoSize = true;
            this.news.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.news.Location = new System.Drawing.Point(296, 0);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(233, 31);
            this.news.TabIndex = 4;
            this.news.Text = "Последние твиты";
            // 
            // generationPanel
            // 
            this.generationPanel.AutoSize = true;
            this.generationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generationPanel.Location = new System.Drawing.Point(596, 0);
            this.generationPanel.Name = "generationPanel";
            this.generationPanel.Size = new System.Drawing.Size(272, 31);
            this.generationPanel.TabIndex = 5;
            this.generationPanel.Text = "Сгенерировать твит!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.newsBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tweetBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 403);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // newsBox
            // 
            this.newsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsBox.Location = new System.Drawing.Point(298, 3);
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(286, 397);
            this.newsBox.TabIndex = 9;
            this.newsBox.Text = "";
            // 
            // tweetBox
            // 
            this.tweetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tweetBox.Location = new System.Drawing.Point(3, 3);
            this.tweetBox.Name = "tweetBox";
            this.tweetBox.Size = new System.Drawing.Size(286, 397);
            this.tweetBox.TabIndex = 8;
            this.tweetBox.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.generationBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tweetButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.generateButton, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(593, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 397);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // generationBox
            // 
            this.generationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generationBox.Location = new System.Drawing.Point(3, 3);
            this.generationBox.Name = "generationBox";
            this.generationBox.Size = new System.Drawing.Size(285, 311);
            this.generationBox.TabIndex = 0;
            this.generationBox.Text = "";
            // 
            // tweetButton
            // 
            this.tweetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tweetButton.Location = new System.Drawing.Point(3, 359);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(285, 35);
            this.tweetButton.TabIndex = 1;
            this.tweetButton.Text = "Твитнуть!";
            this.tweetButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(3, 320);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(285, 33);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Сгенерировать!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.40577F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.59423F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel2.Controls.Add(this.news, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.userName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.generationPanel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 39);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 468);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GeneralWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label news;
        private System.Windows.Forms.Label generationPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox newsBox;
        private System.Windows.Forms.RichTextBox tweetBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox generationBox;
        private System.Windows.Forms.Button tweetButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Timer Timer1;
    }
}