namespace CoffeManager
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
            CoffeBar = new ProgressBar();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            WaterBar = new ProgressBar();
            MilkBar = new ProgressBar();
            label5 = new Label();
            label6 = new Label();
            addCoffe = new Button();
            addWater = new Button();
            addMilk = new Button();
            SuspendLayout();
            // 
            // CoffeBar
            // 
            CoffeBar.BackColor = SystemColors.ActiveBorder;
            CoffeBar.Location = new Point(496, 68);
            CoffeBar.Maximum = 10;
            CoffeBar.Name = "CoffeBar";
            CoffeBar.Size = new Size(234, 29);
            CoffeBar.Style = ProgressBarStyle.Continuous;
            CoffeBar.TabIndex = 0;
            CoffeBar.Value = 10;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "espresso";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "espresso", "double espresso", "cappuchino", "latte", "latte macchiato", "kawa czarna", "kawa po hiszpańsku", "flat white" });
            comboBox1.Location = new Point(28, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(28, 356);
            button1.Name = "button1";
            button1.Size = new Size(200, 62);
            button1.TabIndex = 2;
            button1.Text = "Zrealizuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 77);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Wybierz kawę: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 45);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 41);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "Poziom kawy: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 110);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Poziom wody: ";
            // 
            // WaterBar
            // 
            WaterBar.BackColor = SystemColors.ActiveBorder;
            WaterBar.Location = new Point(496, 133);
            WaterBar.Maximum = 5;
            WaterBar.Name = "WaterBar";
            WaterBar.Size = new Size(234, 29);
            WaterBar.TabIndex = 7;
            WaterBar.Value = 5;
            // 
            // MilkBar
            // 
            MilkBar.BackColor = SystemColors.ActiveBorder;
            MilkBar.Location = new Point(496, 205);
            MilkBar.Maximum = 5;
            MilkBar.Name = "MilkBar";
            MilkBar.Size = new Size(234, 29);
            MilkBar.TabIndex = 8;
            MilkBar.Value = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 182);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 9;
            label5.Text = "Poziom mleka: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 1);
            label6.Name = "label6";
            label6.Size = new Size(371, 60);
            label6.TabIndex = 10;
            label6.Text = "Coffe Manager v1";
            // 
            // addCoffe
            // 
            addCoffe.Location = new Point(735, 67);
            addCoffe.Name = "addCoffe";
            addCoffe.Size = new Size(118, 29);
            addCoffe.TabIndex = 11;
            addCoffe.Text = "Dosyp kawy";
            addCoffe.UseVisualStyleBackColor = true;
            addCoffe.Click += addCoffe_Click;
            // 
            // addWater
            // 
            addWater.Location = new Point(736, 133);
            addWater.Name = "addWater";
            addWater.Size = new Size(118, 29);
            addWater.TabIndex = 12;
            addWater.Text = "Dolej wody";
            addWater.UseVisualStyleBackColor = true;
            addWater.Click += addWater_Click;
            // 
            // addMilk
            // 
            addMilk.Location = new Point(736, 205);
            addMilk.Name = "addMilk";
            addMilk.Size = new Size(118, 29);
            addMilk.TabIndex = 13;
            addMilk.Text = "Dolej mleka";
            addMilk.UseVisualStyleBackColor = true;
            addMilk.Click += addMilk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 450);
            Controls.Add(addMilk);
            Controls.Add(addWater);
            Controls.Add(addCoffe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(MilkBar);
            Controls.Add(WaterBar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(CoffeBar);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar CoffeBar;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar WaterBar;
        private ProgressBar MilkBar;
        private Label label5;
        private Label label6;
        private Button addCoffe;
        private Button addWater;
        private Button addMilk;
    }
}
