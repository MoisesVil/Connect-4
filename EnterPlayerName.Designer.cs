namespace TempName
{
    partial class EnterPlayerName
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
            this.GetNameLabel = new System.Windows.Forms.Label();
            this.GetNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetNameLabel
            // 
            this.GetNameLabel.AutoSize = true;
            this.GetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNameLabel.Location = new System.Drawing.Point(12, 39);
            this.GetNameLabel.Name = "GetNameLabel";
            this.GetNameLabel.Size = new System.Drawing.Size(224, 25);
            this.GetNameLabel.TabIndex = 0;
            this.GetNameLabel.Text = "Enter Name for Player 1:";
            // 
            // GetNameTextBox
            // 
            this.GetNameTextBox.Location = new System.Drawing.Point(258, 42);
            this.GetNameTextBox.Name = "GetNameTextBox";
            this.GetNameTextBox.Size = new System.Drawing.Size(134, 22);
            this.GetNameTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(307, 115);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 29);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButtonOnClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(17, 115);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 29);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonOnClick);
            // 
            // EnterPlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 156);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.GetNameTextBox);
            this.Controls.Add(this.GetNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EnterPlayerName";
            this.Text = "Enter Player Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GetNameLabel;
        private System.Windows.Forms.TextBox GetNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}