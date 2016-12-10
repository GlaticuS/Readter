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
            this.userName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.Color.SteelBlue;
            this.userName.Location = new System.Drawing.Point(4, 0);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(170, 32);
            this.userName.TabIndex = 1;
            this.userName.Text = "Your Profile";
            // 
            // news
            // 
            this.news.AutoSize = true;
            this.news.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.news.ForeColor = System.Drawing.Color.SteelBlue;
            this.news.Location = new System.Drawing.Point(344, 0);
            this.news.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(252, 32);
            this.news.TabIndex = 4;
            this.news.Text = "Последние твиты";
            // 
            // generationPanel
            // 
            this.generationPanel.AutoSize = true;
            this.generationPanel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generationPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.generationPanel.Location = new System.Drawing.Point(693, 0);
            this.generationPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generationPanel.Name = "generationPanel";
            this.generationPanel.Size = new System.Drawing.Size(287, 32);
            this.generationPanel.TabIndex = 5;
            this.generationPanel.Text = "Сгенерировать твит";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 434);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // newsBox
            // 
            this.newsBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsBox.Location = new System.Drawing.Point(349, 3);
            this.newsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newsBox.Name = "newsBox";
            this.newsBox.ReadOnly = true;
            this.newsBox.Size = new System.Drawing.Size(333, 427);
            this.newsBox.TabIndex = 9;
            this.newsBox.Text = "";
            // 
            // tweetBox
            // 
            this.tweetBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tweetBox.Location = new System.Drawing.Point(4, 3);
            this.tweetBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tweetBox.Name = "tweetBox";
            this.tweetBox.ReadOnly = true;
            this.tweetBox.Size = new System.Drawing.Size(333, 427);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(694, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(337, 427);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // generationBox
            // 
            this.generationBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generationBox.Location = new System.Drawing.Point(4, 3);
            this.generationBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generationBox.Name = "generationBox";
            this.generationBox.ReadOnly = true;
            this.generationBox.Size = new System.Drawing.Size(329, 334);
            this.generationBox.TabIndex = 0;
            this.generationBox.Text = "";
            // 
            // tweetButton
            // 
            this.tweetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tweetButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tweetButton.Location = new System.Drawing.Point(4, 386);
            this.tweetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(329, 37);
            this.tweetButton.TabIndex = 1;
            this.tweetButton.Text = "Твитнуть";
            this.tweetButton.UseVisualStyleBackColor = true;
            this.tweetButton.Click += new System.EventHandler(this.tweetButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.generateButton.Location = new System.Drawing.Point(4, 344);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(329, 35);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.40577F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.59423F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel2.Controls.Add(this.news, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.userName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.generationPanel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 8);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1032, 42);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1063, 504);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GeneralWindow";
            this.Text = "ReadteR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralWindow_FormClosing);
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