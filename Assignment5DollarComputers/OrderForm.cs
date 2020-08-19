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
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 18/08/2020
 *Section- 001
 */


namespace Assignment5DollarComputers
{
  public partial class OrderForm : Form
  {
    public OrderForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// this method takes the user to the previous form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OrderBackButton_Click(object sender, EventArgs e)
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
    private void OrderCancelButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult = MessageBox.Show("Do you want to exit the program?", "Dollar Computers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (_dialogResult == DialogResult.Yes)
      {
        this.Close();
      }
    }
    /// <summary>
    ///   /// <summary>
    /// this methods opens a dialog box that shows the user the order confirmation and finishes the process
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OrderFinishButton_Click(object sender, EventArgs e)
    {
      DialogResult _dialogResult = MessageBox.Show("Thank you for using Dollar Computers Application" + "\n" +
                 "Order will be processed in 7-10 business days", "Dollar Computers",MessageBoxButtons.OK, MessageBoxIcon.Information);
      if (_dialogResult == DialogResult.OK)
      {
        this.Close();
      }

    }
    /// <summary>
    /// This method closes the application completely
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    /// <summary>
    /// This method loads the data from the Product Info Form calculates the tax and
    /// changes the image of the product as per the manufacturer selection
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
        double cost= Convert.ToDouble( RowFields.Cost);
        OrderPriceResultLabel.Text = $"{cost:C2}";
        double tax = Convert.ToDouble(RowFields.Cost) * 0.13;
        OrderSalesTaxResultLabel.Text = $"{tax:C2}";
        double totalcost= Convert.ToDouble(Convert.ToDouble(RowFields.Cost) * 1.13);
        OrderTotalResultLabel.Text = $"{totalcost:C2}";
      }

      if (this.OrderManufacturerResultLabel.Text != string.Empty)
      {
        string Manufacturer = this.OrderManufacturerResultLabel.Text;
        Image imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\default.jpg"); ;
        switch (Manufacturer.ToUpper())
        {
          case "ACER":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Acer.jpg");
            break;
          case "ASUS":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Asus.jpg");
            break;
          case "CYBERTRONPC":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Cybertronpc.jpg");
            break;
          case "GATEWAY":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Gateway.jpg");
            break;
          case "HP":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Hp.jpg");
            break;
          case "IBUYPOWER":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Ibuypower.jpg");
            break;
          case "IMAC":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Imac.jpg");
            break;
          case "MACPRO":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Imac.jpg");
            break;
          case "LENOVO":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Lenovo.jpg");
            break;
          case "TOSHIBA":
            imageToShow = System.Drawing.Image.FromFile("..\\..\\Images\\Toshiba.jpg");
            break;
        }
        this.OrderPicture.BackgroundImage = imageToShow;
        this.OrderPicture.BackgroundImageLayout = ImageLayout.Zoom;
      }
    }
    /// <summary>
    /// This method opens the About Form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OrderAboutMenuItem_Click(object sender, EventArgs e)
    {
      Program.aboutBoxForm.Show();
      this.Hide();
    }
    /// <summary>
    /// This method manages printing of receipts or orders
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
    /// <summary>
    /// this method takes the user to the previous form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OrderBackMenuItem_Click(object sender, EventArgs e)
    {
      ProductInfoForm productInfoForm = new ProductInfoForm();
      productInfoForm.Show();
      this.Hide();
    }
  }
}