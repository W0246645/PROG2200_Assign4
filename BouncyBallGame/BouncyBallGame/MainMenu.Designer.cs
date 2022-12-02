namespace BouncyBallGame
{
    partial class MainMenu
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.txt_help = new System.Windows.Forms.RichTextBox();
            this.txt_results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(508, 604);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(209, 49);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start Game";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(1047, 12);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // txt_help
            // 
            this.txt_help.Location = new System.Drawing.Point(1015, 52);
            this.txt_help.Name = "txt_help";
            this.txt_help.ReadOnly = true;
            this.txt_help.Size = new System.Drawing.Size(137, 267);
            this.txt_help.TabIndex = 2;
            this.txt_help.Text = "W0246645\nDestroy the bricks with the ball.\nUse the left and right arrow keys to m" +
    "ove paddle.\nSpace bar to start ball moving.\nEsc to quit.";
            // 
            // txt_results
            // 
            this.txt_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_results.Location = new System.Drawing.Point(396, 264);
            this.txt_results.Name = "txt_results";
            this.txt_results.ReadOnly = true;
            this.txt_results.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_results.Size = new System.Drawing.Size(443, 221);
            this.txt_results.TabIndex = 3;
            this.txt_results.Text = "Text";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.txt_results);
            this.Controls.Add(this.txt_help);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_start);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.RichTextBox txt_help;
        private System.Windows.Forms.RichTextBox txt_results;
    }
}