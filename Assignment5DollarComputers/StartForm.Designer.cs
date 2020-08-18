namespace Assignment5DollarComputers
{
  partial class StartForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
      this.StartLabel = new System.Windows.Forms.Label();
      this.StartButton = new System.Windows.Forms.Button();
      this.OpenButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // StartLabel
      // 
      this.StartLabel.AutoSize = true;
      this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StartLabel.Location = new System.Drawing.Point(276, 38);
      this.StartLabel.Name = "StartLabel";
      this.StartLabel.Size = new System.Drawing.Size(428, 32);
      this.StartLabel.TabIndex = 0;
      this.StartLabel.Text = "Order Your Computers Today !";
      // 
      // StartButton
      // 
      this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StartButton.Location = new System.Drawing.Point(387, 356);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(226, 38);
      this.StartButton.TabIndex = 1;
      this.StartButton.Text = "Start a New Order";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // OpenButton
      // 
      this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OpenButton.Location = new System.Drawing.Point(387, 421);
      this.OpenButton.Name = "OpenButton";
      this.OpenButton.Size = new System.Drawing.Size(226, 38);
      this.OpenButton.TabIndex = 2;
      this.OpenButton.Text = "Open a Saved Order";
      this.OpenButton.UseVisualStyleBackColor = true;
      this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ExitButton.Location = new System.Drawing.Point(387, 479);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(226, 38);
      this.ExitButton.TabIndex = 3;
      this.ExitButton.Text = "Exit";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(387, 96);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(152, 152);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // StartForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1031, 595);
      this.ControlBox = false;
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.OpenButton);
      this.Controls.Add(this.StartButton);
      this.Controls.Add(this.StartLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "StartForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Welcome To Dollar Computers";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label StartLabel;
    private System.Windows.Forms.Button StartButton;
    private System.Windows.Forms.Button OpenButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

