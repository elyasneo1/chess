namespace _008
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
            this.button_start = new System.Windows.Forms.Button();
            this.stausTextView = new System.Windows.Forms.TextBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(229, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start Game";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.buttonStart);
            // 
            // stausTextView
            // 
            this.stausTextView.Location = new System.Drawing.Point(658, 48);
            this.stausTextView.Multiline = true;
            this.stausTextView.Name = "stausTextView";
            this.stausTextView.Size = new System.Drawing.Size(183, 138);
            this.stausTextView.TabIndex = 1;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelCheck.ForeColor = System.Drawing.Color.Red;
            this.labelCheck.Location = new System.Drawing.Point(658, 209);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(89, 24);
            this.labelCheck.TabIndex = 2;
            this.labelCheck.Text = "Check!!!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 520);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.stausTextView);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox stausTextView;
        private System.Windows.Forms.Label labelCheck;
    }
}

