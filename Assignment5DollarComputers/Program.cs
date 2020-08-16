using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5DollarComputers
{
  static class Program
  {
    public static SplashForm splashForm;
    public static StartForm startForm;
    public static SelectForm selectForm;
    public static ProductInfoForm productInfoForm;
    public static OrderForm orderForm;
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
      Application.Run(splashForm);
    }
  }
}