namespace SkatingScoring
{
    partial class FormSkating
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
            this.BtnCalculateScore = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalculateScore
            // 
            this.BtnCalculateScore.Location = new System.Drawing.Point(61, 56);
            this.BtnCalculateScore.Name = "BtnCalculateScore";
            this.BtnCalculateScore.Size = new System.Drawing.Size(177, 58);
            this.BtnCalculateScore.TabIndex = 0;
            this.BtnCalculateScore.Text = "Calculate Score";
            this.BtnCalculateScore.UseVisualStyleBackColor = true;
            this.BtnCalculateScore.Click += new System.EventHandler(this.BtnCalculateScore_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(273, 56);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(441, 341);
            this.TxtResult.TabIndex = 1;
            // 
            // FormSkating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCalculateScore);
            this.Name = "FormSkating";
            this.Text = "Skating Scoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculateScore;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

