
namespace Oceanic_Rise_Calc
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
            this.directionsLabel = new System.Windows.Forms.Label();
            this.oceanicRiseListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.directionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.directionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.directionsLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.directionsLabel.Location = new System.Drawing.Point(18, 25);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(519, 20);
            this.directionsLabel.TabIndex = 0;
            this.directionsLabel.Text = "Click \"Calculate\" to see the current estimated yearly Oceanic Rise Levels.\r\n";
            this.directionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oceanicRiseListBox
            // 
            this.oceanicRiseListBox.FormattingEnabled = true;
            this.oceanicRiseListBox.ItemHeight = 18;
            this.oceanicRiseListBox.Location = new System.Drawing.Point(13, 60);
            this.oceanicRiseListBox.Name = "oceanicRiseListBox";
            this.oceanicRiseListBox.Size = new System.Drawing.Size(525, 202);
            this.oceanicRiseListBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.calculateButton.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.calculateButton.Location = new System.Drawing.Point(64, 276);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(132, 54);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate Rise";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clearButton.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clearButton.Location = new System.Drawing.Point(210, 276);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 54);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Cle&ar";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.exitButton.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exitButton.Location = new System.Drawing.Point(355, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 54);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(550, 346);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.oceanicRiseListBox);
            this.Controls.Add(this.directionsLabel);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Oceanic Rise Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.ListBox oceanicRiseListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

