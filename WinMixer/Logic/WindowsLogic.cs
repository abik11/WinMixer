using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using WinMixer.Model;
using System.Runtime.InteropServices;

namespace WinMixer.Logic
{
   public class WindowsLogic
   {
      [DllImport("user32.dll")]
      public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

      public static List<Window>GetNonExplorerWindows()
      {
         return Process.GetProcesses()
            .Where(x => !String.IsNullOrWhiteSpace(x.MainWindowTitle))
            .Select(x => new Window() {
               HWND = x.MainWindowHandle,
               MainWindowTitle = x.MainWindowTitle,
               ProcessName = x.ProcessName
            })
            .ToList();
      }
   }
}