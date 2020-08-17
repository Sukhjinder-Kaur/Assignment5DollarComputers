namespace Assignment5DollarComputers
{
  partial class SplashForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
      this.SplashFormLabel = new System.Windows.Forms.Label();
      this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
      this.PictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // SplashFormLabel
      // 
      this.SplashFormLabel.AutoSize = true;
      this.SplashFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SplashFormLabel.ForeColor = System.Drawing.Color.LightCoral;
      this.SplashFormLabel.Location = new System.Drawing.Point(323, 31);
      this.SplashFormLabel.Name = "SplashFormLabel";
      this.SplashFormLabel.Size = new System.Drawing.Size(405, 58);
      this.SplashFormLabel.TabIndex = 0;
      this.SplashFormLabel.Text = "Welcome to the Dollar Computers\r\n               We sell for less !";
      // 
      // SplashFormTimer
      // 
      this.SplashFormTimer.Enabled = true;
      this.SplashFormTimer.Interval = 3000;
      this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
      // 
      // PictureBox
      // 
      this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
      this.PictureBox.Location = new System.Drawing.Point(339, 132);
      this.PictureBox.Name = "PictureBox";
      this.PictureBox.Size = new System.Drawing.Size(300, 300);
      this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.PictureBox.TabIndex = 1;
      this.PictureBox.TabStop = false;
      // 
      // SplashForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1053, 651);
      this.ControlBox = false;
      this.Controls.Add(this.PictureBox);
      this.Controls.Add(this.SplashFormLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "SplashForm";
      this.Opacity = 0.9D;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label SplashFormLabel;
    private System.Windows.Forms.Timer SplashFormTimer;
    private System.Windows.Forms.PictureBox PictureBox;
  }
}