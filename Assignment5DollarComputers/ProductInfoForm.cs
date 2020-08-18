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
      try
      {

        OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        var openFileDialogResult = OpenFileDialog.ShowDialog();
        if (openFileDialogResult != DialogResult.Cancel)
        {
          using (StreamReader streamReader = new StreamReader(OpenFileDialog.FileName))
          {
           this.ProductIDResultTextBox.Text= streamReader.ReadLine();
           this.ConditionResultTextBox.Text = streamReader.ReadLine();
            this.CostResultTextBox.Text = streamReader.ReadLine();
            this.PlatformResultTextBox.Text = streamReader.ReadLine();
            this.OSResultTextBox.Text = streamReader.ReadLine();
            this.ManufResultTextBox.Text = streamReader.ReadLine();
            this.ModelResultTextBox.Text = streamReader.ReadLine();
            this.MemoryResultTextBox.Text = streamReader.ReadLine();
            this.LCDSIZEResultTextBox.Text = streamReader.ReadLine();
            this.HddResultTextBox.Text = streamReader.ReadLine();
            this.CPUBrandResultTextBox.Text = streamReader.ReadLine();
            this.CPUResultTextBox.Text = streamReader.ReadLine();
            this.GPYTypeResultTextBox.Text = streamReader.ReadLine();
            this.CPUTypeResultTextBox.Text = streamReader.ReadLine();
            this.CPUSpeedResultTextBox.Text = streamReader.ReadLine();
            this.WebCamResultTextBox.Text = streamReader.ReadLine();

            streamReader.Close();
            streamReader.Dispose();
            this.ApplicationMessage("File Saved Successfully", "Dollar Computers");
          }
        }
        else
        {
          this.ApplicationMessage("File cannot open", "Dollar Computers");
        }
      }
      catch (Exception ex)
      {
        this.ApplicationMessage($"Error: Not able to open file due to {ex.Message}", "Dollar Computers");
        return;
      }
    }

    private void ProductSaveMenuItem_Click(object sender, EventArgs e)
    {
      try
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
            streamWriter.WriteLine(this.OSResultTextBox.Text);
            streamWriter.WriteLine(this.ManufResultTextBox.Text);
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

            streamWriter.Close();
            streamWriter.Dispose();
            this.ApplicationMessage("File Successfully Read", "Dollar Computers");
          }
        }
        else
        {
          this.ApplicationMessage("Not able to  Read File", "Dollar Computers");
        }
      }
      catch (Exception ex)
      {
        this.ApplicationMessage($"Error: Not able to Read file due to {ex.Message}", "Dollar Computers");
        return;

      }
    }
    private void ApplicationMessage(string message, string title)
    {
      MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void ProductExitMenuItem_Click(object sender, EventArgs e)
    {
      Program.productInfoForm.Show();
    }

    private void ProductSelectAnotherProductMenuItem_Click(object sender, EventArgs e)
    {
      Program.selectForm.Show();
      this.Hide();
    }

    private void ProductInfoForm_Load(object sender, EventArgs e)
    {
      this.ProductIDResultTextBox.Text= RowFields.ProductID;
      this.ConditionResultTextBox.Text=RowFields.Condition ;
      this.CostResultTextBox.Text= RowFields.Cost ;
      this.PlatformResultTextBox.Text= RowFields.Platform ;
      this.ManufResultTextBox.Text = RowFields.Manufacturer;
      this.OSResultTextBox.Text = RowFields.OS;
      this.ModelResultTextBox.Text=RowFields.Model ;
      this.MemoryResultTextBox.Text=RowFields.Memory ;
      this.LCDSIZEResultTextBox.Text= RowFields.LCDSize;
      this.HddResultTextBox.Text=RowFields.HDD ;
      this.CPUBrandResultTextBox.Text=RowFields.CPUBrand;
      this.CPUResultTextBox.Text=RowFields.CPUNumber ;
      this.GPYTypeResultTextBox.Text=RowFields.GPUType;
      this.CPUTypeResultTextBox.Text=RowFields.CPUType;
      this.CPUSpeedResultTextBox.Text=RowFields.CPUSpeed ;
      this.WebCamResultTextBox.Text=RowFields.WebCam;
    }
  }
}