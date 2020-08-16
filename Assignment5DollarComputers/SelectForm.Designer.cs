namespace Assignment5DollarComputers
{
  partial class SelectForm
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
      this.ListSelectionLabel = new System.Windows.Forms.Label();
      this.DisplaySelectedLabel = new System.Windows.Forms.Label();
      this.CancelButton = new System.Windows.Forms.Button();
      this.NextButton = new System.Windows.Forms.Button();
      this.SelectionDataGridView = new System.Windows.Forms.DataGridView();
      this.SelectedItemTextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.SelectionDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ListSelectionLabel
      // 
      this.ListSelectionLabel.AutoSize = true;
      this.ListSelectionLabel.Location = new System.Drawing.Point(5, 24);
      this.ListSelectionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
      this.ListSelectionLabel.Name = "ListSelectionLabel";
      this.ListSelectionLabel.Size = new System.Drawing.Size(355, 29);
      this.ListSelectionLabel.TabIndex = 0;
      this.ListSelectionLabel.Text = "Dollar Computers Hardware List";
      // 
      // DisplaySelectedLabel
      // 
      this.DisplaySelectedLabel.AutoSize = true;
      this.DisplaySelectedLabel.Location = new System.Drawing.Point(2, 510);
      this.DisplaySelectedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
      this.DisplaySelectedLabel.Name = "DisplaySelectedLabel";
      this.DisplaySelectedLabel.Size = new System.Drawing.Size(177, 29);
      this.DisplaySelectedLabel.TabIndex = 1;
      this.DisplaySelectedLabel.Text = "Your Selection:";
      // 
      // CancelButton
      // 
      this.CancelButton.Location = new System.Drawing.Point(745, 510);
      this.CancelButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(105, 36);
      this.CancelButton.TabIndex = 3;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      // 
      // NextButton
      // 
      this.NextButton.Location = new System.Drawing.Point(877, 510);
      this.NextButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.NextButton.Name = "NextButton";
      this.NextButton.Size = new System.Drawing.Size(108, 36);
      this.NextButton.TabIndex = 4;
      this.NextButton.Text = "Next";
      this.NextButton.UseVisualStyleBackColor = true;
      // 
      // SelectionDataGridView
      // 
      this.SelectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SelectionDataGridView.Location = new System.Drawing.Point(7, 67);
      this.SelectionDataGridView.Name = "SelectionDataGridView";
      this.SelectionDataGridView.RowHeadersWidth = 62;
      this.SelectionDataGridView.RowTemplate.Height = 28;
      this.SelectionDataGridView.Size = new System.Drawing.Size(978, 416);
      this.SelectionDataGridView.TabIndex = 8;
      // 
      // SelectedItemTextBox
      // 
      this.SelectedItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SelectedItemTextBox.BackColor = System.Drawing.Color.White;
      this.SelectedItemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.SelectedItemTextBox.Enabled = false;
      this.SelectedItemTextBox.Location = new System.Drawing.Point(199, 503);
      this.SelectedItemTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SelectedItemTextBox.Multiline = true;
      this.SelectedItemTextBox.Name = "SelectedItemTextBox";
      this.SelectedItemTextBox.ReadOnly = true;
      this.SelectedItemTextBox.Size = new System.Drawing.Size(501, 46);
      this.SelectedItemTextBox.TabIndex = 7;
      // 
      // SelectForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1031, 595);
      this.ControlBox = false;
      this.Controls.Add(this.SelectionDataGridView);
      this.Controls.Add(this.SelectedItemTextBox);
      this.Controls.Add(this.NextButton);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.DisplaySelectedLabel);
      this.Controls.Add(this.ListSelectionLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.Name = "SelectForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Select Your Computer";
      ((System.ComponentModel.ISupportInitialize)(this.SelectionDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label ListSelectionLabel;
    private System.Windows.Forms.Label DisplaySelectedLabel;
    private System.Windows.Forms.Button CancelButton;
    private System.Windows.Forms.Button NextButton;
    private System.Windows.Forms.DataGridView SelectionDataGridView;
    private System.Windows.Forms.TextBox SelectedItemTextBox;
  }
}