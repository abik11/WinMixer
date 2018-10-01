using System;
using System.Drawing;
using System.Windows.Forms;
using WinMixer.ViewModel;

namespace WinMixer
{
   public partial class MainForm : Form
   {
      private MainViewModel vm;

      public MainForm(IViewModel viewModel)
      {
         InitializeComponent();
         vm = (MainViewModel)viewModel;
         vm.InitializeList(formsList);
         vm.InitializeTextBox(secondsTextBox);
      }

      private void secondsTextBox_TextChanged(object sender, EventArgs e)
      {
         bool state = true;
         Color color = SystemColors.Window;

         if (String.IsNullOrWhiteSpace(secondsTextBox.Text))
         {
            state = false;
            color = SystemColors.Window;
         }
         else
         {
            try
            {
               Convert.ToInt16(secondsTextBox.Text);
            }
            catch (FormatException)
            {
               state = false;
               color = Color.OrangeRed;
            }
            catch (OverflowException)
            {
               state = false;
               color = Color.OrangeRed;
            }
         }

         vm.SetTextBoxState(secondsTextBox, state, color);
         vm.EnableButtonIfReady(startButton, vm.IsStartReady);
      }

      private void formsList_SelectedIndexChanged(object sender, EventArgs e)
      {
         vm.MixedWindows.Clear();
         foreach (int x in formsList.CheckedIndices)
         {
            vm.AddMixedWindow(formsList.Items[x].ToString());
         }

         if (vm.MixedWindows.Count > 1)
         {
            vm.FormsChosen = true;   
         }
         else
         {
            vm.FormsChosen = false;
         }
         vm.EnableButtonIfReady(startButton, vm.IsStartReady);
      }

      private void startButton_Click(object sender, EventArgs e)
      {
         showWindowTimer.Interval = Convert.ToInt32(secondsTextBox.Text) * 1000;
         showWindowTimer.Start();
         vm.EnableButtonIfReady(stopButton, true);
         vm.EnableButtonIfReady(startButton, false);
         listGroupBox.Enabled = false;
         optionsGroupBox.Enabled = false;
      }

      private void stopButton_Click(object sender, EventArgs e)
      {
         showWindowTimer.Stop();
         vm.EnableButtonIfReady(stopButton, false);
         vm.EnableButtonIfReady(startButton, true);
         listGroupBox.Enabled = true;
         optionsGroupBox.Enabled = true;
      }

      private void showWindowTimer_Tick(object sender, EventArgs e)
      {
         vm.SwitchWindows();
      }
   }
}