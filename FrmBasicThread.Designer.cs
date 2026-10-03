namespace BasicThreading
{
	partial class FrmBasicThread
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
            btnRun = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Lime;
            btnRun.FlatAppearance.BorderSize = 0;
            btnRun.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.ForeColor = SystemColors.ControlText;
            btnRun.Location = new Point(119, 120);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(100, 35);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(85, 53);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(173, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Before starting thread-";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(341, 197);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBasicThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BasicThread";
            Load += FrmBasicThread_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRun;
        private Label lblStatus;
    }
}