namespace bead_program.UserControls
{
    partial class PickLands
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_pass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgw_lands = new System.Windows.Forms.DataGridView();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForestCoverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_lands)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pass
            // 
            this.btn_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pass.Location = new System.Drawing.Point(241, 458);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(175, 51);
            this.btn_pass.TabIndex = 15;
            this.btn_pass.Text = "Év kihagyása";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgw_lands
            // 
            this.dgw_lands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_lands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.County,
            this.Column1,
            this.ForestCoverage,
            this.Rain});
            this.dgw_lands.Location = new System.Drawing.Point(60, 55);
            this.dgw_lands.Name = "dgw_lands";
            this.dgw_lands.Size = new System.Drawing.Size(710, 397);
            this.dgw_lands.TabIndex = 12;
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
            // PickLands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgw_lands);
            this.Name = "PickLands";
            this.Size = new System.Drawing.Size(830, 530);
            this.Load += new System.EventHandler(this.PickLands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_lands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgw_lands;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForestCoverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rain;
    }
}
