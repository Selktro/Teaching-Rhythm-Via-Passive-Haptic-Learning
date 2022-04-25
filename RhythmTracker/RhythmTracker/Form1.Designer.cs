
namespace RhythmTracker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.recLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(117, 90);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Recording";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPressed);
            this.startButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonLifted);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(117, 169);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(136, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop Recording";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // recLabel
            // 
            this.recLabel.AutoSize = true;
            this.recLabel.ForeColor = System.Drawing.Color.Red;
            this.recLabel.Location = new System.Drawing.Point(114, 116);
            this.recLabel.Name = "recLabel";
            this.recLabel.Size = new System.Drawing.Size(71, 13);
            this.recLabel.TabIndex = 2;
            this.recLabel.Text = "Not recording";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter ID:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(117, 38);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(136, 20);
            this.idBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 284);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Rhythm Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonLifted);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label recLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
    }
}

