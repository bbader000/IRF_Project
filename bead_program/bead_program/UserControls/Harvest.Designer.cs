namespace bead_program.UserControls
{
    partial class Harvest
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
            this.lbl_cashcounter = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mushcounter = new System.Windows.Forms.Label();
            this.lbl_marketprice = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_processstatus = new System.Windows.Forms.Label();
            this.lbl_process = new System.Windows.Forms.Label();
            this.btn_results = new System.Windows.Forms.Button();
            this.lbl_actualmonth = new System.Windows.Forms.Label();
            this.lbl_m = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cashcounter
            // 
            this.lbl_cashcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cashcounter.Location = new System.Drawing.Point(228, 320);
            this.lbl_cashcounter.Name = "lbl_cashcounter";
            this.lbl_cashcounter.Size = new System.Drawing.Size(362, 50);
            this.lbl_cashcounter.TabIndex = 0;
            this.lbl_cashcounter.Text = "0";
            this.lbl_cashcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cash
            // 
            this.lbl_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cash.Location = new System.Drawing.Point(250, 269);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(328, 51);
            this.lbl_cash.TabIndex = 1;
            this.lbl_cash.Text = "Bevétel (HUF)";
            this.lbl_cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(230, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Begyűjtött gomba (kg)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mushcounter
            // 
            this.lbl_mushcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mushcounter.Location = new System.Drawing.Point(273, 193);
            this.lbl_mushcounter.Name = "lbl_mushcounter";
            this.lbl_mushcounter.Size = new System.Drawing.Size(277, 49);
            this.lbl_mushcounter.TabIndex = 2;
            this.lbl_mushcounter.Text = "0";
            this.lbl_mushcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_marketprice
            // 
            this.lbl_marketprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_marketprice.Location = new System.Drawing.Point(23, 11);
            this.lbl_marketprice.Name = "lbl_marketprice";
            this.lbl_marketprice.Size = new System.Drawing.Size(141, 48);
            this.lbl_marketprice.TabIndex = 4;
            this.lbl_marketprice.Text = "Piaci ár:";
            this.lbl_marketprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_price.Location = new System.Drawing.Point(44, 54);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(98, 31);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "0";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_processstatus
            // 
            this.lbl_processstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_processstatus.Location = new System.Drawing.Point(43, 140);
            this.lbl_processstatus.Name = "lbl_processstatus";
            this.lbl_processstatus.Size = new System.Drawing.Size(98, 31);
            this.lbl_processstatus.TabIndex = 7;
            this.lbl_processstatus.Text = "0";
            this.lbl_processstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_process
            // 
            this.lbl_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_process.Location = new System.Drawing.Point(1, 92);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(185, 40);
            this.lbl_process.TabIndex = 6;
            this.lbl_process.Text = "Feldolgozottság:";
            this.lbl_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_process.Click += new System.EventHandler(this.lbl_process_Click);
            // 
            // btn_results
            // 
            this.btn_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_results.Location = new System.Drawing.Point(300, 434);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(238, 63);
            this.btn_results.TabIndex = 8;
            this.btn_results.Text = "Kiértékelés";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // lbl_actualmonth
            // 
            this.lbl_actualmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_actualmonth.Location = new System.Drawing.Point(576, 54);
            this.lbl_actualmonth.Name = "lbl_actualmonth";
            this.lbl_actualmonth.Size = new System.Drawing.Size(192, 31);
            this.lbl_actualmonth.TabIndex = 10;
            this.lbl_actualmonth.Text = "Július";
            this.lbl_actualmonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_actualmonth.Click += new System.EventHandler(this.lbl_actualmonth_Click);
            // 
            // lbl_m
            // 
            this.lbl_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_m.Location = new System.Drawing.Point(555, 11);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(235, 48);
            this.lbl_m.TabIndex = 9;
            this.lbl_m.Text = "Hónap:";
            this.lbl_m.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_m.Click += new System.EventHandler(this.lbl_m_Click);
            // 
            // Harvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_actualmonth);
            this.Controls.Add(this.lbl_m);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.lbl_processstatus);
            this.Controls.Add(this.lbl_process);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_marketprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mushcounter);
            this.Controls.Add(this.lbl_cash);
            this.Controls.Add(this.lbl_cashcounter);
            this.Name = "Harvest";
            this.Size = new System.Drawing.Size(830, 530);
            this.Load += new System.EventHandler(this.Harvest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_cashcounter;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mushcounter;
        private System.Windows.Forms.Label lbl_marketprice;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_processstatus;
        private System.Windows.Forms.Label lbl_process;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Label lbl_actualmonth;
        private System.Windows.Forms.Label lbl_m;
    }
}
