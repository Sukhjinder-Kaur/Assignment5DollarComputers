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
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 18/08/2020
 *Section- 001
 *Program description= Select Form  Use the Products Table as a DataSource form the localDB in the DataGridView to offer
 *product selection for the order*/
namespace Assignment5DollarComputers
{
  public partial class SelectForm : Form
  {
    public SelectForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// This method loads the data from the database -dollarcomputer(product table)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SelectForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
      this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

    }

    private int _columnCount;
    private int _columnIndex;
    /// <summary>
    /// This method populates the dollarComputersRowFields  list  with the product info and 
    /// also populates the YourSelection textbox with the product selected.
    /// </summary>
    /// <param name="rowIndex"></param>
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
    /// <summary>
    /// This method selects all the columns from a selected cell
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SelectionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.SelectRowData(e.RowIndex);
    }
    /// <summary>
    /// this method clears the rows
    /// </summary>
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
    /// <summary>
    /// This method manages the List (dollarComputersRowFields) and adds the corresponding 
    /// output to the textboxes from the selected row.
    /// </summary>
    /// <param name="dollarComputersRowFields"></param>
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
    /// <summary>
    /// this method takes the user to the next form (Productinfoform)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NextButton_Click(object sender, EventArgs e)
    {
      ProductInfoForm productInfoForm = new ProductInfoForm();
      productInfoForm.Show();
      this.Hide();
    }
    /// <summary>
    /// this methods opens a dialog box that exits the user from the program and
    /// also gives the otion to stay on the appp if the user press okay
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult =MessageBox.Show("Do you want to exit the program?", "Dollar Computers",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
     
      if (_dialogResult == DialogResult.Yes)
      {
        this.Close();
      }
    }
    /// <summary>
    /// This method closes the application completely
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}