namespace WindowsFormsApp1
{
    partial class Form26
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.friendNameInput = new System.Windows.Forms.TextBox();
            this.checkBottom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myMoneyLabel = new System.Windows.Forms.Label();
            this.friendMoneyLabel = new System.Windows.Forms.Label();
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.borrowBottom = new System.Windows.Forms.Button();
            this.repayBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入我的名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入朋友的名字:";
            // 
            // myNameInput
            // 
            this.myNameInput.Location = new System.Drawing.Point(195, 24);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(118, 27);
            this.myNameInput.TabIndex = 2;
            // 
            // friendNameInput
            // 
            this.friendNameInput.Location = new System.Drawing.Point(196, 68);
            this.friendNameInput.Name = "friendNameInput";
            this.friendNameInput.Size = new System.Drawing.Size(118, 27);
            this.friendNameInput.TabIndex = 3;
            // 
            // checkBottom
            // 
            this.checkBottom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBottom.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBottom.Location = new System.Drawing.Point(344, 24);
            this.checkBottom.Name = "checkBottom";
            this.checkBottom.Size = new System.Drawing.Size(116, 69);
            this.checkBottom.TabIndex = 4;
            this.checkBottom.Text = "確認";
            this.checkBottom.UseVisualStyleBackColor = false;
            this.checkBottom.Click += new System.EventHandler(this.checkBottom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名字:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "我的$$:";
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameLabel.Location = new System.Drawing.Point(116, 139);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(72, 25);
            this.myNameLabel.TabIndex = 7;
            this.myNameLabel.Text = "無名氏";
            // 
            // myMoneyLabel
            // 
            this.myMoneyLabel.AutoSize = true;
            this.myMoneyLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLabel.Location = new System.Drawing.Point(116, 175);
            this.myMoneyLabel.Name = "myMoneyLabel";
            this.myMoneyLabel.Size = new System.Drawing.Size(24, 25);
            this.myMoneyLabel.TabIndex = 8;
            this.myMoneyLabel.Text = "0";
            // 
            // friendMoneyLabel
            // 
            this.friendMoneyLabel.AutoSize = true;
            this.friendMoneyLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendMoneyLabel.Location = new System.Drawing.Point(326, 175);
            this.friendMoneyLabel.Name = "friendMoneyLabel";
            this.friendMoneyLabel.Size = new System.Drawing.Size(84, 25);
            this.friendMoneyLabel.TabIndex = 12;
            this.friendMoneyLabel.Text = "200000";
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendNameLabel.Location = new System.Drawing.Point(326, 139);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(72, 25);
            this.friendNameLabel.TabIndex = 11;
            this.friendNameLabel.Text = "無名氏";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(203, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "朋友的$$:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(203, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名字:";
            // 
            // borrowBottom
            // 
            this.borrowBottom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.borrowBottom.Enabled = false;
            this.borrowBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrowBottom.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.borrowBottom.Location = new System.Drawing.Point(18, 220);
            this.borrowBottom.Name = "borrowBottom";
            this.borrowBottom.Size = new System.Drawing.Size(442, 45);
            this.borrowBottom.TabIndex = 13;
            this.borrowBottom.Text = "跟xxx借1000$";
            this.borrowBottom.UseVisualStyleBackColor = false;
            this.borrowBottom.Click += new System.EventHandler(this.borrowBottom_Click);
            // 
            // repayBottom
            // 
            this.repayBottom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.repayBottom.Enabled = false;
            this.repayBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.repayBottom.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.repayBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.repayBottom.Location = new System.Drawing.Point(18, 283);
            this.repayBottom.Name = "repayBottom";
            this.repayBottom.Size = new System.Drawing.Size(442, 45);
            this.repayBottom.TabIndex = 14;
            this.repayBottom.Text = "還給xxx1000$";
            this.repayBottom.UseVisualStyleBackColor = false;
            this.repayBottom.Click += new System.EventHandler(this.repayBottom_Click);
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 343);
            this.Controls.Add(this.repayBottom);
            this.Controls.Add(this.borrowBottom);
            this.Controls.Add(this.friendMoneyLabel);
            this.Controls.Add(this.friendNameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.myMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBottom);
            this.Controls.Add(this.friendNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form26";
            this.Text = "借錢還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.TextBox friendNameInput;
        private System.Windows.Forms.Button checkBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label myMoneyLabel;
        private System.Windows.Forms.Label friendMoneyLabel;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button borrowBottom;
        private System.Windows.Forms.Button repayBottom;
    }
}