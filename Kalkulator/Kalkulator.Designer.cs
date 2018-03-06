namespace Kalkulator
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonNr1 = new System.Windows.Forms.Button();
            this.buttonNr6 = new System.Windows.Forms.Button();
            this.buttonNr2 = new System.Windows.Forms.Button();
            this.buttonDecSep = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonNr5 = new System.Windows.Forms.Button();
            this.buttonNr4 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonNr9 = new System.Windows.Forms.Button();
            this.buttonNr8 = new System.Windows.Forms.Button();
            this.buttonNr7 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonNr0 = new System.Windows.Forms.Button();
            this.buttonNr3 = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.labelPreviousOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.Color.White;
            this.textBoxDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDisplay.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.textBoxDisplay.Location = new System.Drawing.Point(19, 28);
            this.textBoxDisplay.MaxLength = 13;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDisplay.Size = new System.Drawing.Size(249, 50);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "0";
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonNr1
            // 
            this.buttonNr1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr1.Location = new System.Drawing.Point(19, 288);
            this.buttonNr1.Name = "buttonNr1";
            this.buttonNr1.Size = new System.Drawing.Size(50, 50);
            this.buttonNr1.TabIndex = 1;
            this.buttonNr1.Text = "1";
            this.buttonNr1.UseVisualStyleBackColor = true;
            this.buttonNr1.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonNr6
            // 
            this.buttonNr6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr6.Location = new System.Drawing.Point(151, 222);
            this.buttonNr6.Name = "buttonNr6";
            this.buttonNr6.Size = new System.Drawing.Size(50, 50);
            this.buttonNr6.TabIndex = 2;
            this.buttonNr6.Text = "6";
            this.buttonNr6.UseVisualStyleBackColor = true;
            this.buttonNr6.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonNr2
            // 
            this.buttonNr2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr2.Location = new System.Drawing.Point(85, 288);
            this.buttonNr2.Name = "buttonNr2";
            this.buttonNr2.Size = new System.Drawing.Size(50, 50);
            this.buttonNr2.TabIndex = 3;
            this.buttonNr2.Text = "2";
            this.buttonNr2.UseVisualStyleBackColor = true;
            this.buttonNr2.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonDecSep
            // 
            this.buttonDecSep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecSep.Location = new System.Drawing.Point(19, 356);
            this.buttonDecSep.Name = "buttonDecSep";
            this.buttonDecSep.Size = new System.Drawing.Size(50, 50);
            this.buttonDecSep.TabIndex = 4;
            this.buttonDecSep.Text = ".";
            this.buttonDecSep.UseVisualStyleBackColor = true;
            this.buttonDecSep.Click += new System.EventHandler(this.buttonDecSep_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEquals.Location = new System.Drawing.Point(151, 356);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(117, 50);
            this.buttonEquals.TabIndex = 8;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCE.Location = new System.Drawing.Point(19, 85);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 50);
            this.buttonCE.TabIndex = 7;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonNr5
            // 
            this.buttonNr5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr5.Location = new System.Drawing.Point(85, 222);
            this.buttonNr5.Name = "buttonNr5";
            this.buttonNr5.Size = new System.Drawing.Size(50, 50);
            this.buttonNr5.TabIndex = 6;
            this.buttonNr5.Text = "5";
            this.buttonNr5.UseVisualStyleBackColor = true;
            this.buttonNr5.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonNr4
            // 
            this.buttonNr4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr4.Location = new System.Drawing.Point(19, 222);
            this.buttonNr4.Name = "buttonNr4";
            this.buttonNr4.Size = new System.Drawing.Size(50, 50);
            this.buttonNr4.TabIndex = 5;
            this.buttonNr4.Text = "4";
            this.buttonNr4.UseVisualStyleBackColor = true;
            this.buttonNr4.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlus.Location = new System.Drawing.Point(218, 85);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(50, 50);
            this.buttonPlus.TabIndex = 12;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // buttonNr9
            // 
            this.buttonNr9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr9.Location = new System.Drawing.Point(151, 153);
            this.buttonNr9.Name = "buttonNr9";
            this.buttonNr9.Size = new System.Drawing.Size(50, 50);
            this.buttonNr9.TabIndex = 11;
            this.buttonNr9.Text = "9";
            this.buttonNr9.UseVisualStyleBackColor = true;
            this.buttonNr9.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonNr8
            // 
            this.buttonNr8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr8.Location = new System.Drawing.Point(85, 153);
            this.buttonNr8.Name = "buttonNr8";
            this.buttonNr8.Size = new System.Drawing.Size(50, 50);
            this.buttonNr8.TabIndex = 10;
            this.buttonNr8.Text = "8";
            this.buttonNr8.UseVisualStyleBackColor = true;
            this.buttonNr8.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonNr7
            // 
            this.buttonNr7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr7.Location = new System.Drawing.Point(19, 153);
            this.buttonNr7.Name = "buttonNr7";
            this.buttonNr7.Size = new System.Drawing.Size(50, 50);
            this.buttonNr7.TabIndex = 9;
            this.buttonNr7.Text = "7";
            this.buttonNr7.UseVisualStyleBackColor = true;
            this.buttonNr7.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinus.Location = new System.Drawing.Point(218, 153);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(50, 50);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "−";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC.Location = new System.Drawing.Point(85, 85);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 14;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonNr0
            // 
            this.buttonNr0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr0.Location = new System.Drawing.Point(85, 356);
            this.buttonNr0.Name = "buttonNr0";
            this.buttonNr0.Size = new System.Drawing.Size(50, 50);
            this.buttonNr0.TabIndex = 15;
            this.buttonNr0.Text = "0";
            this.buttonNr0.UseVisualStyleBackColor = true;
            this.buttonNr0.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonNr3
            // 
            this.buttonNr3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNr3.Location = new System.Drawing.Point(151, 288);
            this.buttonNr3.Name = "buttonNr3";
            this.buttonNr3.Size = new System.Drawing.Size(50, 50);
            this.buttonNr3.TabIndex = 16;
            this.buttonNr3.Text = "3";
            this.buttonNr3.UseVisualStyleBackColor = true;
            this.buttonNr3.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackspace.Location = new System.Drawing.Point(151, 85);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(50, 50);
            this.buttonBackspace.TabIndex = 17;
            this.buttonBackspace.Text = "⌫";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMultiply.Location = new System.Drawing.Point(218, 222);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiply.TabIndex = 18;
            this.buttonMultiply.Text = "✕";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDivide.Location = new System.Drawing.Point(218, 288);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 50);
            this.buttonDivide.TabIndex = 19;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // labelPreviousOperation
            // 
            this.labelPreviousOperation.AutoSize = true;
            this.labelPreviousOperation.BackColor = System.Drawing.Color.Transparent;
            this.labelPreviousOperation.Location = new System.Drawing.Point(16, 12);
            this.labelPreviousOperation.Name = "labelPreviousOperation";
            this.labelPreviousOperation.Size = new System.Drawing.Size(0, 13);
            this.labelPreviousOperation.TabIndex = 20;
            this.labelPreviousOperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 418);
            this.Controls.Add(this.labelPreviousOperation);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonNr3);
            this.Controls.Add(this.buttonNr0);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonNr9);
            this.Controls.Add(this.buttonNr8);
            this.Controls.Add(this.buttonNr7);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonNr5);
            this.Controls.Add(this.buttonNr4);
            this.Controls.Add(this.buttonDecSep);
            this.Controls.Add(this.buttonNr2);
            this.Controls.Add(this.buttonNr6);
            this.Controls.Add(this.buttonNr1);
            this.Controls.Add(this.textBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kalkulator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonNr1;
        private System.Windows.Forms.Button buttonNr6;
        private System.Windows.Forms.Button buttonNr2;
        private System.Windows.Forms.Button buttonDecSep;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonNr5;
        private System.Windows.Forms.Button buttonNr4;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonNr9;
        private System.Windows.Forms.Button buttonNr8;
        private System.Windows.Forms.Button buttonNr7;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonNr0;
        private System.Windows.Forms.Button buttonNr3;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Label labelPreviousOperation;
    }
}

