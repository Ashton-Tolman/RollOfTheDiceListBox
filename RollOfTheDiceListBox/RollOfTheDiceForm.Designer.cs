namespace RollOfTheDiceListBox
{
    partial class RollOfTheDiceListBoxForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RollDiceButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // RollDiceButton
            // 
            RollDiceButton.Location = new Point(398, 360);
            RollDiceButton.Name = "RollDiceButton";
            RollDiceButton.Size = new Size(126, 78);
            RollDiceButton.TabIndex = 0;
            RollDiceButton.Text = "Roll Dice";
            RollDiceButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(530, 360);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(126, 78);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(662, 360);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(126, 78);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // RollOfTheDiceListBoxForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(RollDiceButton);
            Name = "RollOfTheDiceListBoxForm";
            Text = "Roll Of The Dice List Box";
            ResumeLayout(false);
        }

        #endregion

        private Button RollDiceButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}
