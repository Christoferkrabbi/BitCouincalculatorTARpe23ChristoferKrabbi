namespace BitCouincalculatorTARpe23ChristoferKrabbi
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bitcoinAmountInput = new TextBox();
            button1 = new Button();
            label4 = new Label();
            tulemuslabel = new Label();
            resultlabel = new Label();
            currencyselector = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 102);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 167);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // bitcoinAmountInput
            // 
            bitcoinAmountInput.Location = new Point(74, 48);
            bitcoinAmountInput.Name = "bitcoinAmountInput";
            bitcoinAmountInput.Size = new Size(100, 23);
            bitcoinAmountInput.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(74, 185);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 208);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            label4.Click += label4_Click;
            // 
            // tulemuslabel
            // 
            tulemuslabel.AutoSize = true;
            tulemuslabel.Location = new Point(74, 300);
            tulemuslabel.Name = "tulemuslabel";
            tulemuslabel.Size = new Size(56, 15);
            tulemuslabel.TabIndex = 8;
            tulemuslabel.Text = "Tulemus:";
            tulemuslabel.Visible = false;
            tulemuslabel.Click += label5_Click;
            // 
            // resultlabel
            // 
            resultlabel.Location = new Point(74, 340);
            resultlabel.Name = "resultlabel";
            resultlabel.Size = new Size(248, 66);
            resultlabel.TabIndex = 9;
            resultlabel.Text = "None";
            resultlabel.Visible = false;
            resultlabel.Click += label6_Click;
            // 
            // currencyselector
            // 
            currencyselector.FormattingEnabled = true;
            currencyselector.ItemHeight = 15;
            currencyselector.Items.AddRange(new object[] { "USD", "GBP", "EEK" });
            currencyselector.Location = new Point(74, 120);
            currencyselector.Name = "currencyselector";
            currencyselector.Size = new Size(91, 19);
            currencyselector.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currencyselector);
            Controls.Add(resultlabel);
            Controls.Add(tulemuslabel);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(bitcoinAmountInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox bitcoinAmountInput;
        private Button button1;
        private Label label4;
        private Label tulemuslabel;
        private Label resultlabel;
        private ListBox currencyselector;
    }
}
