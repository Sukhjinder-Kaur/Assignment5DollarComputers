using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 18/08/2020
 *Section- 001
 *Program description= Start form contains the option to move futher to the following forms to proceed with the order
 *or open the previously saved order else exit */

namespace Assignment5DollarComputers
{
  public partial class StartForm : Form
  {
    public StartForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// This method opens the SelectForm
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StartButton_Click(object sender, EventArgs e)
    {
      Program.selectForm.Show();
      this.Hide();
    }
    /// <summary>
    /// This method opens the PRoduct Info Form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OpenButton_Click(object sender, EventArgs e)
    {
      Program.productInfoForm.Show();
      this.Hide();
    }
    /// <summary>
    /// This method takes the user out from the application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}