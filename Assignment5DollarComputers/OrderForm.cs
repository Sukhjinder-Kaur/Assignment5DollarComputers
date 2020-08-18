using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5DollarComputers
{
  public partial class OrderForm : Form
  {
    public OrderForm()
    {
      InitializeComponent();
    }

    private void OrderBackButton_Click(object sender, EventArgs e)
    {
      ProductInfoForm productInfoForm = new ProductInfoForm();
      productInfoForm.Show();
      this.Hide();
    }

    private void OrderCancelButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult = MessageBox.Show("Do you want to exit the program?", "Dollar Computers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (_dialogResult == DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void OrderFinishButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult = MessageBox.Show("Thank you for using Dollar Computers Application" + "\n" +
                 "Order will be processed in 7-10 business days", "Dollar Computers",MessageBoxButtons.OK, MessageBoxIcon.Information);
      if (_dialogResult == DialogResult.OK)
      {
        this.Close();
      }

    }
    private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void OrderForm_Load(object sender, EventArgs e)
    {
      OrderConditionResultLabel.Text = RowFields.Condition;
      OrderPriceResultLabel.Text = RowFields.Cost;
      OrderPlatformResultLabel.Text = RowFields.Platform;
      OrderManufacturerResultLabel.Text = RowFields.Manufacturer;
      OrderOSResultLabel.Text = RowFields.OS;
      OrderModelResultLabel.Text = RowFields.Model;
      OrderMemoryResultLabel.Text = RowFields.Memory;
      OrderLCDSizeResultLabel.Text = RowFields.LCDSize;
      OrderHDDResultLabel.Text = RowFields.HDD;
      OrderCPUBrandResultLabel.Text = RowFields.CPUBrand;
      OrderCPUNumberResultLabel.Text = RowFields.CPUNumber;
      OrderGPUTypeResultLabel.Text = RowFields.GPUType;
      OrderCPUTypeResultLabel.Text = RowFields.CPUType;
      OrderCPUSpeedResultLabel.Text = RowFields.CPUSpeed;
      OrderWebCamResultLabel.Text = RowFields.WebCam;

      if (this.OrderPriceResultLabel.Text != string.Empty)
      {
        OrderPriceResultLabel.Text = Convert.ToString($"${ RowFields.Cost}");
        OrderSalesTaxResultLabel.Text ="$"+ Convert.ToString(Convert.ToDouble(RowFields.Cost) * 0.13);
        OrderTotalResultLabel.Text = "$" + Convert.ToString(Convert.ToDouble(RowFields.Cost) * 1.13);
      }
    }

      private void OrderAboutMenuItem_Click(object sender, EventArgs e)
    {
      Program.aboutBoxForm.Show();
      this.Hide();
    }

    private void OrderPrintMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult = MessageBox.Show("Do you want to print a receipt?", "Dollar Computers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (_dialogResult == DialogResult.Yes)
      {
        CaptureScreen();
        PrintOrderFormDocument.Print();
      }
    }

    Bitmap memoryImage;

    private void CaptureScreen()
    {
      Graphics myGraphics = this.CreateGraphics();
      Size s = this.Size;
      memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
      Graphics memoryGraphics = Graphics.FromImage(memoryImage);
      memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
    }
    private void OrderExitMenuItem_Click(object sender, EventArgs e)
    {
      Program.orderForm.Show();
    }

    private void OrderBackMenuItem_Click(object sender, EventArgs e)
    {
      ProductInfoForm productInfoForm = new ProductInfoForm();
      productInfoForm.Show();
      this.Hide();
    }
  }
}