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
 *Program description= Splash screen welcomes the user to the dollar computers application. */
namespace Assignment5DollarComputers
{
  public partial class SplashForm : Form
  {
    public SplashForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// This method disables the splash screen timer and opens the StartForm
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SplashFormTimer_Tick(object sender, EventArgs e)
    {
      Program.startForm.Show();
      this.Hide();
      SplashFormTimer.Enabled = false;
    }
  }
}
