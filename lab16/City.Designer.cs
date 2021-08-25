namespace lab16
{
    partial class City
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
            this.metropolis = new System.Windows.Forms.DataGridView();
            this.colony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infection = new System.Windows.Forms.Timer(this.components);
            this.domination = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metropolis)).BeginInit();
            this.SuspendLayout();
            // 
            // metropolis
            // 
            this.metropolis.AllowUserToAddRows = false;
            this.metropolis.AllowUserToDeleteRows = false;
            this.metropolis.AllowUserToResizeColumns = false;
            this.metropolis.AllowUserToResizeRows = false;
            this.metropolis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metropolis.ColumnHeadersHeight = 10;
            this.metropolis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metropolis.ColumnHeadersVisible = false;
            this.metropolis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colony});
            this.metropolis.Location = new System.Drawing.Point(12, 12);
            this.metropolis.Name = "metropolis";
            this.metropolis.ReadOnly = true;
            this.metropolis.RowHeadersVisible = false;
            this.metropolis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metropolis.RowTemplate.Height = 10;
            this.metropolis.Size = new System.Drawing.Size(508, 503);
            this.metropolis.TabIndex = 1;
            this.metropolis.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Metropolis_ColumnAdded);
            // 
            // colony
            // 
            this.colony.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colony.FillWeight = 10F;
            this.colony.Frozen = true;
            this.colony.HeaderText = "";
            this.colony.MinimumWidth = 10;
            this.colony.Name = "colony";
            this.colony.ReadOnly = true;
            this.colony.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colony.Width = 10;
            // 
            // infection
            // 
            this.infection.Tick += new System.EventHandler(this.Infection_Tick);
            // 
            // domination
            // 
            this.domination.Tick += new System.EventHandler(this.Domination_Tick);
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(532, 527);
            this.Controls.Add(this.metropolis);
            this.Name = "City";
            this.Text = "Колония клеток";
            ((System.ComponentModel.ISupportInitialize)(this.metropolis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView metropolis;
        private System.Windows.Forms.Timer infection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colony;
        private System.Windows.Forms.Timer domination;
    }
}