namespace lab16
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
            this.exitButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.population = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.virus = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.population)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virus)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(87, 78);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(10, 78);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(69, 23);
            this.optionsButton.TabIndex = 5;
            this.optionsButton.Text = "Настроить";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // population
            // 
            this.population.Location = new System.Drawing.Point(10, 25);
            this.population.Maximum = new decimal(new int[] {
            499,
            0,
            0,
            0});
            this.population.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(69, 20);
            this.population.TabIndex = 6;
            this.population.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Население";
            // 
            // virus
            // 
            this.virus.Location = new System.Drawing.Point(87, 25);
            this.virus.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.virus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.virus.Name = "virus";
            this.virus.Size = new System.Drawing.Size(69, 20);
            this.virus.TabIndex = 8;
            this.virus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вирус";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(10, 52);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(146, 20);
            this.statusBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 109);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.virus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.population);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.exitButton);
            this.Name = "MainForm";
            this.Text = "Индивидуальное задание";
            ((System.ComponentModel.ISupportInitialize)(this.population)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.NumericUpDown population;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown virus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusBox;
    }
}

