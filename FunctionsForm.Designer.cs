namespace BinaryLogicFunctions
{
    partial class FunctionsForm
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
            this.firstOperandComboBox = new System.Windows.Forms.ComboBox();
            this.secondOperandComboBox = new System.Windows.Forms.ComboBox();
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstOperandComboBox
            // 
            this.firstOperandComboBox.FormattingEnabled = true;
            this.firstOperandComboBox.Location = new System.Drawing.Point(155, 104);
            this.firstOperandComboBox.Name = "firstOperandComboBox";
            this.firstOperandComboBox.Size = new System.Drawing.Size(133, 24);
            this.firstOperandComboBox.TabIndex = 7;
            // 
            // secondOperandComboBox
            // 
            this.secondOperandComboBox.FormattingEnabled = true;
            this.secondOperandComboBox.Location = new System.Drawing.Point(155, 197);
            this.secondOperandComboBox.Name = "secondOperandComboBox";
            this.secondOperandComboBox.Size = new System.Drawing.Size(133, 24);
            this.secondOperandComboBox.TabIndex = 8;
            // 
            // functionComboBox
            // 
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Location = new System.Drawing.Point(41, 307);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(121, 24);
            this.functionComboBox.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(164, 449);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 10;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(123, 365);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(199, 50);
            this.addbutton.TabIndex = 11;
            this.addbutton.Text = "Виконати";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(422, 133);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(357, 180);
            this.listBoxResults.TabIndex = 12;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.Location = new System.Drawing.Point(445, 365);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(127, 57);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Видалити результат";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayButton.Location = new System.Drawing.Point(622, 348);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(157, 90);
            this.displayButton.TabIndex = 14;
            this.displayButton.Text = "Відобразити використані операції";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Калькулятор бінарних функцій";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Оберіть першу логічну змінну:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Оберіть другу логічну змінну:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Оберіть логічну операцію:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(418, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Використані операції:";
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(this.secondOperandComboBox);
            this.Controls.Add(this.firstOperandComboBox);
            this.Name = "FunctionsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox firstOperandComboBox;
        private System.Windows.Forms.ComboBox secondOperandComboBox;
        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

