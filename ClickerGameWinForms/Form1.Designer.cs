namespace ClickerGameWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClickMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickMeButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickMeButton.ForeColor = System.Drawing.Color.White;
            this.ClickMeButton.Location = new System.Drawing.Point(322, 189);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(157, 143);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "0";
            this.ClickMeButton.UseVisualStyleBackColor = false;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(0, -2);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(197, 159);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "10";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.BackColor = System.Drawing.Color.White;
            this.ButtonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRestart.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRestart.ForeColor = System.Drawing.Color.Black;
            this.ButtonRestart.Location = new System.Drawing.Point(183, 41);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(328, 85);
            this.ButtonRestart.TabIndex = 2;
            this.ButtonRestart.Text = "Restart Game";
            this.ButtonRestart.UseVisualStyleBackColor = false;
            this.ButtonRestart.Visible = false;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(825, 492);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Clicker Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ClickMeButton;
        private Label TimerLabel;
        private System.Windows.Forms.Timer GameTimer;
        private Button ButtonRestart;
    }
}