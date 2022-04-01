
namespace DiceGame
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.diceControl1 = new DiceGame.DiceControl();
            ((System.ComponentModel.ISupportInitialize)(this.diceControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить кубик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diceControl1
            // 
            this.diceControl1.Location = new System.Drawing.Point(90, 112);
            this.diceControl1.Name = "diceControl1";
            this.diceControl1.NumberColor = System.Drawing.Color.Black;
            this.diceControl1.NumberFont = new System.Drawing.Font("Arial", 20F);
            this.diceControl1.Size = new System.Drawing.Size(100, 100);
            this.diceControl1.TabIndex = 2;
            this.diceControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
         //   this.Controls.Add(this.diceControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Игральная кость";
            ((System.ComponentModel.ISupportInitialize)(this.diceControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DiceControl diceControl1;
    }
}

