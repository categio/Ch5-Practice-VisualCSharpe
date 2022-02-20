namespace Speed_Converter
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
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 151);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 37);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 151);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(63, 37);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "&Display Speeds";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(17, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(198, 134);
            this.outputListBox.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(83, 151);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 37);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 200);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Speed Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button clearButton;
    }
}

