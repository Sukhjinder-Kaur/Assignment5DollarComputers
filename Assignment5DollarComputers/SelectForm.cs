using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5DollarComputers
{
  public partial class SelectForm : Form
  {
    public SelectForm()
    {
      InitializeComponent();
    }

    private void SelectForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
      this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

    }
    private int _columnCount;
    private int _columnIndex;

    private void SelectRowData(int rowIndex)
    { try
      {
        this.SelectionDataGridView.Rows[rowIndex].Selected = true;

        _columnCount = 0;
        _columnIndex = 0;

        _columnCount = this.SelectionDataGridView.Columns.Count;
         RowFields.dollarComputersRowFields = new List<string>();
         this.ClearRowFields();


        while (_columnIndex < _columnCount)
        {
          var rowValue = this.SelectionDataGridView.Rows[rowIndex].Cells[_columnIndex].Value;
          RowFields.dollarComputersRowFields.Add(Convert.ToString(rowValue).Trim());
          _columnIndex += 1;
        }
        this.PopulateRowFields(RowFields.dollarComputersRowFields);
        this.SelectedItemTextBox.Text = ($"{RowFields.Manufacturer} {RowFields.Model} Priced at: {Convert.ToDouble(RowFields.Cost).ToString("C2")}");
        this.NextButton.Enabled = true;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, "Dollar Computers", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.NextButton.Enabled = false;
      }

    }
    private void SelectionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.SelectRowData(e.RowIndex);
    }

    private void ClearRowFields()
    {
      RowFields.ProductID = string.Empty;
      RowFields.Condition = string.Empty;
      RowFields.Cost = string.Empty;
      RowFields.Platform = string.Empty;
      RowFields.OS = string.Empty;
      RowFields.Manufacturer = string.Empty;
      RowFields.Model = string.Empty;
      RowFields.Memory = string.Empty;
      RowFields.LCDSize = string.Empty;
      RowFields.HDD = string.Empty;
      RowFields.CPUBrand = string.Empty;
      RowFields.CPUNumber = string.Empty;
      RowFields.GPUType = string.Empty;
      RowFields.CPUType = string.Empty;
      RowFields.CPUSpeed = string.Empty;
      RowFields.WebCam = string.Empty;
    }

    private void PopulateRowFields(List<string> dollarComputersRowFields)
    {
      RowFields.ProductID = dollarComputersRowFields[0];
      RowFields.Condition = dollarComputersRowFields[14];
      RowFields.Cost = dollarComputersRowFields[1];
      RowFields.Platform = dollarComputersRowFields[16];
      RowFields.OS = dollarComputersRowFields[15];
      RowFields.Manufacturer = dollarComputersRowFields[2];
      RowFields.Model = dollarComputersRowFields[3];
      RowFields.Memory = dollarComputersRowFields[5];
      RowFields.LCDSize = dollarComputersRowFields[7];
      RowFields.HDD = dollarComputersRowFields[17];
      RowFields.CPUBrand = dollarComputersRowFields[10];
      RowFields.CPUNumber = dollarComputersRowFields[12];
      RowFields.GPUType = dollarComputersRowFields[19];
      RowFields.CPUType = dollarComputersRowFields[11];
      RowFields.CPUSpeed = dollarComputersRowFields[13];
      RowFields.WebCam = dollarComputersRowFields[30];
    }

    private void NextButton_Click(object sender, EventArgs e)
    {
      ProductInfoForm productInfoForm = new ProductInfoForm();
      productInfoForm.Show();
      this.Hide();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult =MessageBox.Show("Do you want to exit the program?", "Dollar Computers",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
     
      if (_dialogResult == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}