using System;
using System.Windows.Forms;
using WinMixer.ViewModel;

namespace WinMixer
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm(new MainViewModel()));
      }
   }
}