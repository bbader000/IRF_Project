namespace bead_program.Forms
{
    partial class BidForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_biggestbiddername = new System.Windows.Forms.Label();
            this.lbl_biggestbid = new System.Windows.Forms.Label();
            this.btn_bid = new System.Windows.Forms.Button();
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_startvalue = new System.Windows.Forms.Label();
            this.lbl_countyname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title.Location = new System.Drawing.Point(195, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(113, 31);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "Licitálás";
            // 
            // lbl_biggestbiddername
            // 
            this.lbl_biggestbiddername.AutoSize = true;
            this.lbl_biggestbiddername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_biggestbiddername.Location = new System.Drawing.Point(151, 292);
            this.lbl_biggestbiddername.Name = "lbl_biggestbiddername";
            this.lbl_biggestbiddername.Size = new System.Drawing.Size(184, 25);
            this.lbl_biggestbiddername.TabIndex = 12;
            this.lbl_biggestbiddername.Text = "temp_biddername";
            // 
            // lbl_biggestbid
            // 
            this.lbl_biggestbid.AutoSize = true;
            this.lbl_biggestbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_biggestbid.Location = new System.Drawing.Point(179, 260);
            this.lbl_biggestbid.Name = "lbl_biggestbid";
            this.lbl_biggestbid.Size = new System.Drawing.Size(129, 16);
            this.lbl_biggestbid.TabIndex = 11;
            this.lbl_biggestbid.Text = "Legnagyobb licitáló:";
            // 
            // btn_bid
            // 
            this.btn_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_bid.Location = new System.Drawing.Point(120, 436);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(239, 67);
            this.btn_bid.TabIndex = 10;
            this.btn_bid.Text = "Emelés (500 000 Ft)";
            this.btn_bid.UseVisualStyleBackColor = true;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_value.Location = new System.Drawing.Point(160, 368);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(154, 31);
            this.lbl_value.TabIndex = 9;
            this.lbl_value.Text = "temp_value";
            // 
            // lbl_startvalue
            // 
            this.lbl_startvalue.AutoSize = true;
            this.lbl_startvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_startvalue.Location = new System.Drawing.Point(32, 131);
            this.lbl_startvalue.Name = "lbl_startvalue";
            this.lbl_startvalue.Size = new System.Drawing.Size(165, 25);
            this.lbl_startvalue.TabIndex = 8;
            this.lbl_startvalue.Text = "temp_startvalue";
            // 
            // lbl_countyname
            // 
            this.lbl_countyname.AutoSize = true;
            this.lbl_countyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_countyname.Location = new System.Drawing.Point(28, 85);
            this.lbl_countyname.Name = "lbl_countyname";
            this.lbl_countyname.Size = new System.Drawing.Size(237, 31);
            this.lbl_countyname.TabIndex = 7;
            this.lbl_countyname.Text = "temp_countyname";
            // 
            // BidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 591);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_biggestbiddername);
            this.Controls.Add(this.lbl_biggestbid);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_startvalue);
            this.Controls.Add(this.lbl_countyname);
            this.Name = "BidForm";
            this.Load += new System.EventHandler(this.BidForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_biggestbiddername;
        private System.Windows.Forms.Label lbl_biggestbid;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_startvalue;
        private System.Windows.Forms.Label lbl_countyname;
    }
}