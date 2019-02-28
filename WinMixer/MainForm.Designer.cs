namespace WinMixer
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.listGroupBox = new System.Windows.Forms.GroupBox();
         this.formsList = new System.Windows.Forms.CheckedListBox();
         this.optionsGroupBox = new System.Windows.Forms.GroupBox();
         this.secondsTextBox = new System.Windows.Forms.TextBox();
         this.secondsLabel = new System.Windows.Forms.Label();
         this.startButton = new System.Windows.Forms.Button();
         this.showWindowTimer = new System.Windows.Forms.Timer(this.components);
         this.stopButton = new System.Windows.Forms.Button();
         this.refreshWindowsList = new System.Windows.Forms.Timer(this.components);
         this.listGroupBox.SuspendLayout();
         this.optionsGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // listGroupBox
         // 
         this.listGroupBox.Controls.Add(this.formsList);
         this.listGroupBox.Location = new System.Drawing.Point(13, 13);
         this.listGroupBox.Name = "listGroupBox";
         this.listGroupBox.Size = new System.Drawing.Size(170, 171);
         this.listGroupBox.TabIndex = 0;
         this.listGroupBox.TabStop = false;
         this.listGroupBox.Text = "Select windows";
         // 
         // formsList
         // 
         this.formsList.BackColor = System.Drawing.SystemColors.Control;
         this.formsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.formsList.CheckOnClick = true;
         this.formsList.ForeColor = System.Drawing.SystemColors.WindowText;
         this.formsList.FormattingEnabled = true;
         this.formsList.Location = new System.Drawing.Point(7, 20);
         this.formsList.Name = "formsList";
         this.formsList.Size = new System.Drawing.Size(157, 135);
         this.formsList.TabIndex = 0;
         this.formsList.SelectedIndexChanged += new System.EventHandler(this.formsList_SelectedIndexChanged);
         // 
         // optionsGroupBox
         // 
         this.optionsGroupBox.Controls.Add(this.secondsTextBox);
         this.optionsGroupBox.Controls.Add(this.secondsLabel);
         this.optionsGroupBox.Location = new System.Drawing.Point(189, 13);
         this.optionsGroupBox.Name = "optionsGroupBox";
         this.optionsGroupBox.Size = new System.Drawing.Size(168, 138);
         this.optionsGroupBox.TabIndex = 1;
         this.optionsGroupBox.TabStop = false;
         this.optionsGroupBox.Text = "Options";
         // 
         // secondsTextBox
         // 
         this.secondsTextBox.Location = new System.Drawing.Point(62, 17);
         this.secondsTextBox.Name = "secondsTextBox";
         this.secondsTextBox.Size = new System.Drawing.Size(45, 20);
         this.secondsTextBox.TabIndex = 1;
         this.secondsTextBox.Text = "10";
         this.secondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.secondsTextBox.WordWrap = false;
         this.secondsTextBox.TextChanged += new System.EventHandler(this.secondsTextBox_TextChanged);
         // 
         // secondsLabel
         // 
         this.secondsLabel.AutoSize = true;
         this.secondsLabel.Location = new System.Drawing.Point(7, 20);
         this.secondsLabel.Name = "secondsLabel";
         this.secondsLabel.Size = new System.Drawing.Size(52, 13);
         this.secondsLabel.TabIndex = 0;
         this.secondsLabel.Text = "Seconds:";
         // 
         // startButton
         // 
         this.startButton.Enabled = false;
         this.startButton.Location = new System.Drawing.Point(189, 157);
         this.startButton.Name = "startButton";
         this.startButton.Size = new System.Drawing.Size(75, 23);
         this.startButton.TabIndex = 2;
         this.startButton.Text = "Start";
         this.startButton.UseVisualStyleBackColor = true;
         this.startButton.Click += new System.EventHandler(this.startButton_Click);
         // 
         // showWindowTimer
         // 
         this.showWindowTimer.Interval = 10000;
         this.showWindowTimer.Tick += new System.EventHandler(this.showWindowTimer_Tick);
         // 
         // stopButton
         // 
         this.stopButton.Enabled = false;
         this.stopButton.Location = new System.Drawing.Point(282, 157);
         this.stopButton.Name = "stopButton";
         this.stopButton.Size = new System.Drawing.Size(75, 23);
         this.stopButton.TabIndex = 3;
         this.stopButton.Text = "Stop";
         this.stopButton.UseVisualStyleBackColor = true;
         this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
         // 
         // refreshWindowsList
         // 
         this.refreshWindowsList.Interval = 1000;
         this.refreshWindowsList.Tick += new System.EventHandler(this.refreshWindowsList_Tick);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(369, 192);
         this.Controls.Add(this.stopButton);
         this.Controls.Add(this.startButton);
         this.Controls.Add(this.optionsGroupBox);
         this.Controls.Add(this.listGroupBox);
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(385, 231);
         this.MinimumSize = new System.Drawing.Size(385, 231);
         this.Name = "MainForm";
         this.ShowIcon = false;
         this.Text = "WinMixer";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
         this.listGroupBox.ResumeLayout(false);
         this.optionsGroupBox.ResumeLayout(false);
         this.optionsGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox listGroupBox;
      private System.Windows.Forms.CheckedListBox formsList;
      private System.Windows.Forms.GroupBox optionsGroupBox;
      private System.Windows.Forms.Button startButton;
      private System.Windows.Forms.Label secondsLabel;
      private System.Windows.Forms.TextBox secondsTextBox;
      private System.Windows.Forms.Timer showWindowTimer;
      private System.Windows.Forms.Button stopButton;
      private System.Windows.Forms.Timer refreshWindowsList;
   }
}

