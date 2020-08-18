using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5DollarComputers
{
  public partial class ProductInfoForm : Form
  {
    public ProductInfoForm()
    {
      InitializeComponent();
    }

    private void ProductAnotherProductSelectionButton_Click(object sender, EventArgs e)
    {
      Program.selectForm.Show();
      this.Hide();
    }

    private void ProductCancelButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult = MessageBox.Show("Do you want to exit the program?", "Dollar Computers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (_dialogResult == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void ProductNextButton_Click(object sender, EventArgs e)
    {
      OrderForm orderForm = new OrderForm();
      orderForm.Show();
      this.Hide();
    }

    private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void ProductOpenMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void ProductSaveMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      var saveFileDialogResult = SaveFileDialog.ShowDialog();
      if (saveFileDialogResult != DialogResult.Cancel)
      {
        using (StreamWriter streamWriter = new StreamWriter(SaveFileDialog.FileName))
        {
          streamWriter.WriteLine(this.ProductIDResultTextBox.Text);
          streamWriter.WriteLine(this.ConditionResultTextBox.Text);
          streamWriter.WriteLine(this.CostResultTextBox.Text);
          streamWriter.WriteLine(this.PlatformResultTextBox.Text);
          streamWriter.WriteLine(this.ManufResultTextBox.Text);
          streamWriter.WriteLine(this.OSResultTextBox.Text);
          streamWriter.WriteLine(this.ModelResultTextBox.Text);
          streamWriter.WriteLine(this.MemoryResultTextBox.Text);
          streamWriter.WriteLine(this.LCDSIZEResultTextBox.Text);
          streamWriter.WriteLine(this.HddResultTextBox.Text);
          streamWriter.WriteLine(this.CPUBrandResultTextBox.Text);
          streamWriter.WriteLine(this.CPUResultTextBox.Text);
          streamWriter.WriteLine(this.GPYTypeResultTextBox.Text);
          streamWriter.WriteLine(this.CPUTypeResultTextBox.Text);
          streamWriter.WriteLine(this.CPUSpeedResultTextBox.Text);
          streamWriter.WriteLine(this.WebCamResultTextBox.Text);
        }
      }
    }
  
    private void ProductExitMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void ProductSelectAnotherProductMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
