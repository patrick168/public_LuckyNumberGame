namespace GuestNumberAdv2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Answer = new System.Windows.Forms.Button();
            this.lbRange = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            this.lbRes = new System.Windows.Forms.Label();
            this.tbNO = new System.Windows.Forms.TextBox();
            this.Mytitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Answer.Location = new System.Drawing.Point(232, 318);
            this.Answer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(109, 43);
            this.Answer.TabIndex = 11;
            this.Answer.Text = "看答案";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbRange.Location = new System.Drawing.Point(250, 194);
            this.lbRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(77, 27);
            this.lbRange.TabIndex = 10;
            this.lbRange.Text = "Range";
            this.lbRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterbtn
            // 
            this.enterbtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterbtn.Location = new System.Drawing.Point(232, 249);
            this.enterbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(109, 43);
            this.enterbtn.TabIndex = 9;
            this.enterbtn.Text = "確認";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // lbRes
            // 
            this.lbRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRes.AutoSize = true;
            this.lbRes.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbRes.Location = new System.Drawing.Point(250, 145);
            this.lbRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(77, 27);
            this.lbRes.TabIndex = 8;
            this.lbRes.Text = "Result";
            this.lbRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNO
            // 
            this.tbNO.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbNO.Location = new System.Drawing.Point(265, 81);
            this.tbNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNO.Name = "tbNO";
            this.tbNO.Size = new System.Drawing.Size(44, 39);
            this.tbNO.TabIndex = 7;
            // 
            // Mytitle
            // 
            this.Mytitle.AutoSize = true;
            this.Mytitle.BackColor = System.Drawing.SystemColors.Control;
            this.Mytitle.Font = new System.Drawing.Font("PMingLiU", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Mytitle.ForeColor = System.Drawing.Color.Blue;
            this.Mytitle.Location = new System.Drawing.Point(90, 18);
            this.Mytitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mytitle.Name = "Mytitle";
            this.Mytitle.Size = new System.Drawing.Size(473, 38);
            this.Mytitle.TabIndex = 6;
            this.Mytitle.Text = "請輸入遊戲的最大數字範圍";
            this.Mytitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 413);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.lbRange);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.tbNO);
            this.Controls.Add(this.Mytitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.TextBox tbNO;     
        private System.Windows.Forms.Label Mytitle;
    }
}

