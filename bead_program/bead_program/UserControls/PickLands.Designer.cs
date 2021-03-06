﻿namespace bead_program.UserControls
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
            this.btn_pick = new System.Windows.Forms.Button();
            this.dgw_lands = new System.Windows.Forms.DataGridView();
            this.btn_startyear = new System.Windows.Forms.Button();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ár = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogosult = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Válassz megyét";
            // 
            // btn_pick
            // 
            this.btn_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pick.Location = new System.Drawing.Point(60, 458);
            this.btn_pick.Name = "btn_pick";
            this.btn_pick.Size = new System.Drawing.Size(175, 51);
            this.btn_pick.TabIndex = 13;
            this.btn_pick.Text = "Megye választása";
            this.btn_pick.UseVisualStyleBackColor = true;
            this.btn_pick.Click += new System.EventHandler(this.btn_pick_Click);
            // 
            // dgw_lands
            // 
            this.dgw_lands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_lands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.County,
            this.Ár,
            this.Jogosult,
            this.Column1,
            this.ForestCoverage,
            this.Rain});
            this.dgw_lands.Location = new System.Drawing.Point(60, 55);
            this.dgw_lands.Name = "dgw_lands";
            this.dgw_lands.Size = new System.Drawing.Size(668, 397);
            this.dgw_lands.TabIndex = 12;
            // 
            // btn_startyear
            // 
            this.btn_startyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_startyear.Location = new System.Drawing.Point(553, 458);
            this.btn_startyear.Name = "btn_startyear";
            this.btn_startyear.Size = new System.Drawing.Size(175, 51);
            this.btn_startyear.TabIndex = 16;
            this.btn_startyear.Text = "Tovább";
            this.btn_startyear.UseVisualStyleBackColor = true;
            this.btn_startyear.Click += new System.EventHandler(this.btn_startyear_Click);
            // 
            // County
            // 
            this.County.DataPropertyName = "name";
            this.County.HeaderText = "Megye";
            this.County.Name = "County";
            // 
            // Ár
            // 
            this.Ár.DataPropertyName = "value";
            this.Ár.HeaderText = "Ár";
            this.Ár.Name = "Ár";
            // 
            // Jogosult
            // 
            this.Jogosult.DataPropertyName = "owner";
            this.Jogosult.HeaderText = "Jogosult";
            this.Jogosult.Name = "Jogosult";
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
            this.Controls.Add(this.btn_startyear);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pick);
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
        private System.Windows.Forms.Button btn_pick;
        private System.Windows.Forms.DataGridView dgw_lands;
        private System.Windows.Forms.Button btn_startyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ár;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogosult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForestCoverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rain;
    }
}
