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
      this.components = new System.ComponentModel.Container();
      this.ListSelectionLabel = new System.Windows.Forms.Label();
      this.DisplaySelectedLabel = new System.Windows.Forms.Label();
      this.CancelButton = new System.Windows.Forms.Button();
      this.NextButton = new System.Windows.Forms.Button();
      this.SelectionDataGridView = new System.Windows.Forms.DataGridView();
      this.SelectedItemTextBox = new System.Windows.Forms.TextBox();
      this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dollarComputersDataSet = new Assignment5DollarComputers.dollarComputersDataSet();
      this.productsTableAdapter = new Assignment5DollarComputers.dollarComputersDataSetTableAdapters.productsTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.SelectionDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).BeginInit();
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
      this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
      this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
      // 
      // SelectionDataGridView
      // 
      this.SelectionDataGridView.AutoGenerateColumns = false;
      this.SelectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SelectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
      this.SelectionDataGridView.DataSource = this.productsBindingSource;
      this.SelectionDataGridView.Location = new System.Drawing.Point(7, 67);
      this.SelectionDataGridView.Name = "SelectionDataGridView";
      this.SelectionDataGridView.RowHeadersWidth = 62;
      this.SelectionDataGridView.RowTemplate.Height = 28;
      this.SelectionDataGridView.Size = new System.Drawing.Size(1012, 417);
      this.SelectionDataGridView.TabIndex = 8;
      this.SelectionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionDataGridView_CellClick);
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
      // productIDDataGridViewTextBoxColumn
      // 
      this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
      this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
      this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
      this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.productIDDataGridViewTextBoxColumn.Width = 150;
      // 
      // costDataGridViewTextBoxColumn
      // 
      this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
      this.costDataGridViewTextBoxColumn.HeaderText = "cost";
      this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
      this.costDataGridViewTextBoxColumn.Width = 150;
      // 
      // manufacturerDataGridViewTextBoxColumn
      // 
      this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
      this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
      this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
      this.manufacturerDataGridViewTextBoxColumn.Width = 150;
      // 
      // modelDataGridViewTextBoxColumn
      // 
      this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
      this.modelDataGridViewTextBoxColumn.HeaderText = "model";
      this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
      this.modelDataGridViewTextBoxColumn.Width = 150;
      // 
      // rAMtypeDataGridViewTextBoxColumn
      // 
      this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
      this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM_type";
      this.rAMtypeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
      this.rAMtypeDataGridViewTextBoxColumn.Width = 150;
      // 
      // rAMsizeDataGridViewTextBoxColumn
      // 
      this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
      this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM_size";
      this.rAMsizeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
      this.rAMsizeDataGridViewTextBoxColumn.Width = 150;
      // 
      // displaytypeDataGridViewTextBoxColumn
      // 
      this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
      this.displaytypeDataGridViewTextBoxColumn.HeaderText = "displaytype";
      this.displaytypeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
      this.displaytypeDataGridViewTextBoxColumn.Width = 150;
      // 
      // screensizeDataGridViewTextBoxColumn
      // 
      this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
      this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
      this.screensizeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
      this.screensizeDataGridViewTextBoxColumn.Width = 150;
      // 
      // resolutionDataGridViewTextBoxColumn
      // 
      this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
      this.resolutionDataGridViewTextBoxColumn.HeaderText = "resolution";
      this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
      this.resolutionDataGridViewTextBoxColumn.Width = 150;
      // 
      // cPUClassDataGridViewTextBoxColumn
      // 
      this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
      this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU_Class";
      this.cPUClassDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
      this.cPUClassDataGridViewTextBoxColumn.Width = 150;
      // 
      // cPUbrandDataGridViewTextBoxColumn
      // 
      this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
      this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU_brand";
      this.cPUbrandDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
      this.cPUbrandDataGridViewTextBoxColumn.Width = 150;
      // 
      // cPUtypeDataGridViewTextBoxColumn
      // 
      this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
      this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU_type";
      this.cPUtypeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
      this.cPUtypeDataGridViewTextBoxColumn.Width = 150;
      // 
      // cPUspeedDataGridViewTextBoxColumn
      // 
      this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
      this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU_speed";
      this.cPUspeedDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
      this.cPUspeedDataGridViewTextBoxColumn.Width = 150;
      // 
      // cPUnumberDataGridViewTextBoxColumn
      // 
      this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
      this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "CPU_number";
      this.cPUnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
      this.cPUnumberDataGridViewTextBoxColumn.Width = 150;
      // 
      // conditionDataGridViewTextBoxColumn
      // 
      this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
      this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
      this.conditionDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
      this.conditionDataGridViewTextBoxColumn.Width = 150;
      // 
      // oSDataGridViewTextBoxColumn
      // 
      this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
      this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
      this.oSDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
      this.oSDataGridViewTextBoxColumn.Width = 150;
      // 
      // platformDataGridViewTextBoxColumn
      // 
      this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
      this.platformDataGridViewTextBoxColumn.HeaderText = "platform";
      this.platformDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
      this.platformDataGridViewTextBoxColumn.Width = 150;
      // 
      // hDDsizeDataGridViewTextBoxColumn
      // 
      this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
      this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD_size";
      this.hDDsizeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
      this.hDDsizeDataGridViewTextBoxColumn.Width = 150;
      // 
      // hDDspeedDataGridViewTextBoxColumn
      // 
      this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
      this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD_speed";
      this.hDDspeedDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
      this.hDDspeedDataGridViewTextBoxColumn.Width = 150;
      // 
      // gPUTypeDataGridViewTextBoxColumn
      // 
      this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
      this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU_Type";
      this.gPUTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
      this.gPUTypeDataGridViewTextBoxColumn.Width = 150;
      // 
      // opticaldriveDataGridViewTextBoxColumn
      // 
      this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
      this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "optical_drive";
      this.opticaldriveDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
      this.opticaldriveDataGridViewTextBoxColumn.Width = 150;
      // 
      // audiotypeDataGridViewTextBoxColumn
      // 
      this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
      this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio_type";
      this.audiotypeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
      this.audiotypeDataGridViewTextBoxColumn.Width = 150;
      // 
      // lANDataGridViewTextBoxColumn
      // 
      this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
      this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
      this.lANDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
      this.lANDataGridViewTextBoxColumn.Width = 150;
      // 
      // wIFIDataGridViewTextBoxColumn
      // 
      this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
      this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
      this.wIFIDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
      this.wIFIDataGridViewTextBoxColumn.Width = 150;
      // 
      // widthDataGridViewTextBoxColumn
      // 
      this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
      this.widthDataGridViewTextBoxColumn.HeaderText = "width";
      this.widthDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
      this.widthDataGridViewTextBoxColumn.Width = 150;
      // 
      // heightDataGridViewTextBoxColumn
      // 
      this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
      this.heightDataGridViewTextBoxColumn.HeaderText = "height";
      this.heightDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
      this.heightDataGridViewTextBoxColumn.Width = 150;
      // 
      // depthDataGridViewTextBoxColumn
      // 
      this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
      this.depthDataGridViewTextBoxColumn.HeaderText = "depth";
      this.depthDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
      this.depthDataGridViewTextBoxColumn.Width = 150;
      // 
      // weightDataGridViewTextBoxColumn
      // 
      this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
      this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
      this.weightDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
      this.weightDataGridViewTextBoxColumn.Width = 150;
      // 
      // mousttypeDataGridViewTextBoxColumn
      // 
      this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
      this.mousttypeDataGridViewTextBoxColumn.HeaderText = "moust_type";
      this.mousttypeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
      this.mousttypeDataGridViewTextBoxColumn.Width = 150;
      // 
      // powerDataGridViewTextBoxColumn
      // 
      this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
      this.powerDataGridViewTextBoxColumn.HeaderText = "power";
      this.powerDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
      this.powerDataGridViewTextBoxColumn.Width = 150;
      // 
      // webcamDataGridViewTextBoxColumn
      // 
      this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
      this.webcamDataGridViewTextBoxColumn.HeaderText = "webcam";
      this.webcamDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
      this.webcamDataGridViewTextBoxColumn.Width = 150;
      // 
      // productsBindingSource
      // 
      this.productsBindingSource.DataMember = "products";
      this.productsBindingSource.DataSource = this.dollarComputersDataSet;
      // 
      // dollarComputersDataSet
      // 
      this.dollarComputersDataSet.DataSetName = "dollarComputersDataSet";
      this.dollarComputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // productsTableAdapter
      // 
      this.productsTableAdapter.ClearBeforeFill = true;
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
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
      this.Load += new System.EventHandler(this.SelectForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.SelectionDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).EndInit();
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
    private dollarComputersDataSet dollarComputersDataSet;
    private System.Windows.Forms.BindingSource productsBindingSource;
    private dollarComputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
  }
}