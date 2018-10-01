using System;

namespace WinMixer.Model
{
   public class Window
   {
      public IntPtr HWND { get; set; }
      public string MainWindowTitle { get; set; }
      public string ProcessName { get; set; }
   }
}