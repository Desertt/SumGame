namespace GuessGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonCreateRandomValue = new System.Windows.Forms.Button();
            this.labelGenerateResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Guess Number Between 1-100 ";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(95, 254);
            this.textBoxGuess.Multiline = true;
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(180, 58);
            this.textBoxGuess.TabIndex = 1;
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuess.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuess.Location = new System.Drawing.Point(296, 254);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(91, 58);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Guess It !";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonCreateRandomValue
            // 
            this.buttonCreateRandomValue.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCreateRandomValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCreateRandomValue.Location = new System.Drawing.Point(125, 29);
            this.buttonCreateRandomValue.Name = "buttonCreateRandomValue";
            this.buttonCreateRandomValue.Size = new System.Drawing.Size(202, 149);
            this.buttonCreateRandomValue.TabIndex = 3;
            this.buttonCreateRandomValue.Text = "Start Generator";
            this.buttonCreateRandomValue.UseVisualStyleBackColor = false;
            this.buttonCreateRandomValue.Click += new System.EventHandler(this.buttonCreateRandomValue_Click);
            // 
            // labelGenerateResult
            // 
            this.labelGenerateResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelGenerateResult.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGenerateResult.Location = new System.Drawing.Point(357, 143);
            this.labelGenerateResult.Name = "labelGenerateResult";
            this.labelGenerateResult.Size = new System.Drawing.Size(93, 35);
            this.labelGenerateResult.TabIndex = 4;
            this.labelGenerateResult.Text = ".";
            this.labelGenerateResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 361);
            this.Controls.Add(this.labelGenerateResult);
            this.Controls.Add(this.buttonCreateRandomValue);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonCreateRandomValue;
        private System.Windows.Forms.Label labelGenerateResult;
    }
}

