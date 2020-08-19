using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 18/08/2020
 *Section- 001
*/

namespace Assignment5DollarComputers
{
  static class Program
  {
    public static SplashForm splashForm;
    public static StartForm startForm;
    public static SelectForm selectForm;
    public static ProductInfoForm productInfoForm;
    public static OrderForm orderForm;
    public static AboutBoxForm aboutBoxForm;
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      splashForm = new SplashForm();
      startForm = new StartForm();
      selectForm = new SelectForm();
      productInfoForm = new ProductInfoForm();
      orderForm = new OrderForm();
      aboutBoxForm = new AboutBoxForm();
      Application.Run(splashForm);
    }
  }
}