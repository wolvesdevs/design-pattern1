namespace A060
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightButton = new System.Windows.Forms.Button();
            this.AButton = new System.Windows.Forms.Button();
            this.MarioRadioButton = new System.Windows.Forms.RadioButton();
            this.LuigiRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 257);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(10, 330);
            this.RightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(135, 35);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "→";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // AButton
            // 
            this.AButton.Location = new System.Drawing.Point(161, 330);
            this.AButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(135, 35);
            this.AButton.TabIndex = 2;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // MarioRadioButton
            // 
            this.MarioRadioButton.AutoSize = true;
            this.MarioRadioButton.Checked = true;
            this.MarioRadioButton.Location = new System.Drawing.Point(10, 26);
            this.MarioRadioButton.Name = "MarioRadioButton";
            this.MarioRadioButton.Size = new System.Drawing.Size(63, 20);
            this.MarioRadioButton.TabIndex = 0;
            this.MarioRadioButton.TabStop = true;
            this.MarioRadioButton.Text = "マリオ";
            this.MarioRadioButton.UseVisualStyleBackColor = true;
            // 
            // LuigiRadioButton
            // 
            this.LuigiRadioButton.AutoSize = true;
            this.LuigiRadioButton.Location = new System.Drawing.Point(161, 26);
            this.LuigiRadioButton.Name = "LuigiRadioButton";
            this.LuigiRadioButton.Size = new System.Drawing.Size(79, 20);
            this.LuigiRadioButton.TabIndex = 1;
            this.LuigiRadioButton.Text = "ルイージ";
            this.LuigiRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 375);
            this.Controls.Add(this.LuigiRadioButton);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.MarioRadioButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.RadioButton MarioRadioButton;
        private System.Windows.Forms.RadioButton LuigiRadioButton;
    }
}

