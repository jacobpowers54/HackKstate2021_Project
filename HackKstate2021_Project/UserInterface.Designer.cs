namespace HackKstate2021_Project
{
    partial class UserInterface
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
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxGearTB = new System.Windows.Forms.TextBox();
            this.uxPathOne = new System.Windows.Forms.Button();
            this.uxPathTwo = new System.Windows.Forms.Button();
            this.uxPathThree = new System.Windows.Forms.Button();
            this.uxGearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(7, 7);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ReadOnly = true;
            this.uxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(783, 231);
            this.uxTextBox.TabIndex = 0;
            // 
            // uxGearTB
            // 
            this.uxGearTB.Location = new System.Drawing.Point(9, 336);
            this.uxGearTB.Multiline = true;
            this.uxGearTB.Name = "uxGearTB";
            this.uxGearTB.ReadOnly = true;
            this.uxGearTB.Size = new System.Drawing.Size(781, 58);
            this.uxGearTB.TabIndex = 1;
            // 
            // uxPathOne
            // 
            this.uxPathOne.Location = new System.Drawing.Point(7, 244);
            this.uxPathOne.Name = "uxPathOne";
            this.uxPathOne.Size = new System.Drawing.Size(246, 45);
            this.uxPathOne.TabIndex = 2;
            this.uxPathOne.Text = "Path One";
            this.uxPathOne.UseVisualStyleBackColor = true;
            this.uxPathOne.Click += new System.EventHandler(this.uxPathOne_Click);
            // 
            // uxPathTwo
            // 
            this.uxPathTwo.Location = new System.Drawing.Point(269, 244);
            this.uxPathTwo.Name = "uxPathTwo";
            this.uxPathTwo.Size = new System.Drawing.Size(246, 45);
            this.uxPathTwo.TabIndex = 3;
            this.uxPathTwo.Text = "Path Two";
            this.uxPathTwo.UseVisualStyleBackColor = true;
            this.uxPathTwo.Click += new System.EventHandler(this.uxPathTwo_Click);
            // 
            // uxPathThree
            // 
            this.uxPathThree.Location = new System.Drawing.Point(542, 244);
            this.uxPathThree.Name = "uxPathThree";
            this.uxPathThree.Size = new System.Drawing.Size(246, 45);
            this.uxPathThree.TabIndex = 4;
            this.uxPathThree.Text = "Path Three";
            this.uxPathThree.UseVisualStyleBackColor = true;
            this.uxPathThree.Click += new System.EventHandler(this.uxPathThree_Click);
            // 
            // uxGearLabel
            // 
            this.uxGearLabel.AutoSize = true;
            this.uxGearLabel.Location = new System.Drawing.Point(12, 320);
            this.uxGearLabel.Name = "uxGearLabel";
            this.uxGearLabel.Size = new System.Drawing.Size(76, 13);
            this.uxGearLabel.TabIndex = 5;
            this.uxGearLabel.Text = "Gear Obtained";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxGearLabel);
            this.Controls.Add(this.uxPathThree);
            this.Controls.Add(this.uxPathTwo);
            this.Controls.Add(this.uxPathOne);
            this.Controls.Add(this.uxGearTB);
            this.Controls.Add(this.uxTextBox);
            this.Name = "UserInterface";
            this.Text = "Hack K-State: Sanderbatch Hack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.TextBox uxGearTB;
        private System.Windows.Forms.Button uxPathOne;
        private System.Windows.Forms.Button uxPathTwo;
        private System.Windows.Forms.Button uxPathThree;
        private System.Windows.Forms.Label uxGearLabel;
    }
}

