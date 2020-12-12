namespace bead_program.UserControls
{
    partial class PlayerBid
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
            this.lbl_countyname = new System.Windows.Forms.Label();
            this.lbl_startvalue = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.btn_bid = new System.Windows.Forms.Button();
            this.lbl_biggestbid = new System.Windows.Forms.Label();
            this.lbl_biggestbiddername = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_countyname
            // 
            this.lbl_countyname.AutoSize = true;
            this.lbl_countyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_countyname.Location = new System.Drawing.Point(25, 61);
            this.lbl_countyname.Name = "lbl_countyname";
            this.lbl_countyname.Size = new System.Drawing.Size(237, 31);
            this.lbl_countyname.TabIndex = 0;
            this.lbl_countyname.Text = "temp_countyname";
            this.lbl_countyname.Click += new System.EventHandler(this.lbl_countyname_Click);
            // 
            // lbl_startvalue
            // 
            this.lbl_startvalue.AutoSize = true;
            this.lbl_startvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_startvalue.Location = new System.Drawing.Point(29, 107);
            this.lbl_startvalue.Name = "lbl_startvalue";
            this.lbl_startvalue.Size = new System.Drawing.Size(165, 25);
            this.lbl_startvalue.TabIndex = 1;
            this.lbl_startvalue.Text = "temp_startvalue";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_value.Location = new System.Drawing.Point(157, 344);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(154, 31);
            this.lbl_value.TabIndex = 2;
            this.lbl_value.Text = "temp_value";
            // 
            // btn_bid
            // 
            this.btn_bid.Location = new System.Drawing.Point(114, 433);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(239, 67);
            this.btn_bid.TabIndex = 3;
            this.btn_bid.Text = "Emelés (500 000 Ft)";
            this.btn_bid.UseVisualStyleBackColor = true;
            // 
            // lbl_biggestbid
            // 
            this.lbl_biggestbid.AutoSize = true;
            this.lbl_biggestbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_biggestbid.Location = new System.Drawing.Point(176, 236);
            this.lbl_biggestbid.Name = "lbl_biggestbid";
            this.lbl_biggestbid.Size = new System.Drawing.Size(129, 16);
            this.lbl_biggestbid.TabIndex = 4;
            this.lbl_biggestbid.Text = "Legnagyobb licitáló:";
            // 
            // lbl_biggestbiddername
            // 
            this.lbl_biggestbiddername.AutoSize = true;
            this.lbl_biggestbiddername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_biggestbiddername.Location = new System.Drawing.Point(148, 268);
            this.lbl_biggestbiddername.Name = "lbl_biggestbiddername";
            this.lbl_biggestbiddername.Size = new System.Drawing.Size(184, 25);
            this.lbl_biggestbiddername.TabIndex = 5;
            this.lbl_biggestbiddername.Text = "temp_biddername";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title.Location = new System.Drawing.Point(179, 14);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(113, 31);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Licitálás";
            // 
            // PlayerBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_biggestbiddername);
            this.Controls.Add(this.lbl_biggestbid);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_startvalue);
            this.Controls.Add(this.lbl_countyname);
            this.Name = "PlayerBid";
            this.Size = new System.Drawing.Size(458, 591);
            this.Load += new System.EventHandler(this.PlayerBid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_countyname;
        private System.Windows.Forms.Label lbl_startvalue;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.Label lbl_biggestbid;
        private System.Windows.Forms.Label lbl_biggestbiddername;
        private System.Windows.Forms.Label lbl_title;
    }
}
