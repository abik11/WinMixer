﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinMixer.Logic;
using WinMixer.Model;

namespace WinMixer.ViewModel
{
   public class MainViewModel : IViewModel
   {
      public bool CorrectSeconds { get; set; }
      public bool FormsChosen { get; set; }
      public bool IsStartReady { get { return CorrectSeconds && FormsChosen; } }
      public List<Window> Windows { get; set; }
      public List<Window> MixedWindows { get; set; }

      private int index = 0;

      public MainViewModel()
      {
         CorrectSeconds = true;
         FormsChosen = false;
         Windows = WindowsLogic.GetNonExplorerWindows();
         MixedWindows = new List<Window>();
      }

      public void InitializeList(CheckedListBox list)
      {
         list.Items.AddRange(WindowsLogic.GetWindowsProcessNames(Windows));
      }

      public void RefreshList(CheckedListBox list)
      {
         Windows = WindowsLogic.GetNonExplorerWindows();

         foreach (Window window in Windows)
         {
            if (!list.Items.Contains(window.ProcessName))
               list.Items.Add(window.ProcessName);
         }

         int itemsCount = list.Items.Count - 1;
         for (int i = itemsCount; i > 0; i--)
         {
            if (!Windows.Any(x => x.ProcessName == (string)list.Items[i]))
               list.Items.Remove(list.Items[i]);
         }         
         
         list.Refresh();
      }

      public void InitializeTextBox(TextBox textBox)
      {
         int? seconds = Properties.Settings.Default?.Seconds;
         textBox.Text = seconds.Value.ToString();
      }

      public void EnableButtonIfReady(Button button, bool condition)
      {
         button.Enabled = condition;
      }

      public void SetTextBoxState(TextBox textBox, bool state, Color color)
      {
         textBox.BackColor = color;
         CorrectSeconds = state;
      }

      public void AddMixedWindow(string processName)
      {
         Window tmp = Windows.FirstOrDefault(x => x.ProcessName == processName);
         MixedWindows.Add(tmp);
      }

      public void SwitchWindows()
      {
         MinimizeAllWindows();
         WindowsLogic.ShowWindow(MixedWindows[index].HWND, (int)ShowMode.Maximize);

         if (index == MixedWindows.Count-1)
            index = 0;
         else
            index++;
      }

      private void MinimizeAllWindows()
      {
         foreach (Window window in Windows)
         {
            WindowsLogic.ShowWindow(window.HWND, (int)ShowMode.Minimize);
         }
      }
   }
}