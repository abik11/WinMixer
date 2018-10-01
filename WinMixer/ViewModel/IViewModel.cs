using System.Drawing;
using System.Windows.Forms;

namespace WinMixer.ViewModel
{
   public interface IViewModel
   {
      void InitializeList(CheckedListBox list);
      void InitializeTextBox(TextBox textBox);
      void EnableButtonIfReady(Button button, bool condition);
      void SetTextBoxState(TextBox textBox, bool state, Color color);
   }
}