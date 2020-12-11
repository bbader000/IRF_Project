namespace bead_program
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForestCoverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.County,
            this.Column1,
            this.ForestCoverage,
            this.Rain});
            this.dataGridView1.Location = new System.Drawing.Point(179, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // County
            // 
            this.County.DataPropertyName = "name";
            this.County.HeaderText = "Megye";
            this.County.Name = "County";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "area";
            this.Column1.HeaderText = "Terület (km2)";
            this.Column1.Name = "Column1";
            // 
            // ForestCoverage
            // 
            this.ForestCoverage.DataPropertyName = "forest";
            this.ForestCoverage.HeaderText = "Erdős terület";
            this.ForestCoverage.Name = "ForestCoverage";
            // 
            // Rain
            // 
            this.Rain.DataPropertyName = "rain";
            this.Rain.HeaderText = "Éves csapadék";
            this.Rain.Name = "Rain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 527);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForestCoverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rain;
    }
}

