using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
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
    private void ApplicationMessage(string message, string title)
    {
      MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void OrderForm_Load(object sender, EventArgs e)
    {

    }

    private void OrderAboutMenuItem_Click(object sender, EventArgs e)
    {
      Program.aboutBoxForm.Show();
      this.Hide();
    }

    private void OrderPrintMenuItem_Click(object sender, EventArgs e)
    {

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