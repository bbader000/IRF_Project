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
            this.lbl_actualyear = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_dogs = new System.Windows.Forms.Label();
            this.lbl_numberofdogs = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_currentbalance = new System.Windows.Forms.Label();
            this.btn_buydog = new System.Windows.Forms.Button();
            this.btn_selldog = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_startyear = new System.Windows.Forms.Button();
            this.btn_startharvest = new System.Windows.Forms.Button();
            this.btn_yearresults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_actualyear
            // 
            this.lbl_actualyear.AutoSize = true;
            this.lbl_actualyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_actualyear.Location = new System.Drawing.Point(888, 30);
            this.lbl_actualyear.Name = "lbl_actualyear";
            this.lbl_actualyear.Size = new System.Drawing.Size(89, 20);
            this.lbl_actualyear.TabIndex = 3;
            this.lbl_actualyear.Text = "Aktuális év:";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_year.Location = new System.Drawing.Point(897, 68);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(74, 31);
            this.lbl_year.TabIndex = 4;
            this.lbl_year.Text = "2015";
            // 
            // lbl_dogs
            // 
            this.lbl_dogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_dogs.Location = new System.Drawing.Point(891, 182);
            this.lbl_dogs.Name = "lbl_dogs";
            this.lbl_dogs.Size = new System.Drawing.Size(86, 43);
            this.lbl_dogs.TabIndex = 6;
            this.lbl_dogs.Text = "0";
            this.lbl_dogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_numberofdogs
            // 
            this.lbl_numberofdogs.AutoSize = true;
            this.lbl_numberofdogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_numberofdogs.Location = new System.Drawing.Point(879, 146);
            this.lbl_numberofdogs.Name = "lbl_numberofdogs";
            this.lbl_numberofdogs.Size = new System.Drawing.Size(112, 20);
            this.lbl_numberofdogs.TabIndex = 5;
            this.lbl_numberofdogs.Text = "Kutyák száma:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_balance.Location = new System.Drawing.Point(853, 457);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(174, 28);
            this.lbl_balance.TabIndex = 7;
            this.lbl_balance.Text = "0";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_balance.Click += new System.EventHandler(this.lbl_balance_Click);
            // 
            // lbl_currentbalance
            // 
            this.lbl_currentbalance.AutoSize = true;
            this.lbl_currentbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_currentbalance.Location = new System.Drawing.Point(899, 418);
            this.lbl_currentbalance.Name = "lbl_currentbalance";
            this.lbl_currentbalance.Size = new System.Drawing.Size(75, 20);
            this.lbl_currentbalance.TabIndex = 8;
            this.lbl_currentbalance.Text = "Egyenleg";
            // 
            // btn_buydog
            // 
            this.btn_buydog.Location = new System.Drawing.Point(888, 262);
            this.btn_buydog.Name = "btn_buydog";
            this.btn_buydog.Size = new System.Drawing.Size(96, 41);
            this.btn_buydog.TabIndex = 9;
            this.btn_buydog.Text = "Kutya vétel";
            this.btn_buydog.UseVisualStyleBackColor = true;
            this.btn_buydog.Click += new System.EventHandler(this.btn_buydog_Click);
            // 
            // btn_selldog
            // 
            this.btn_selldog.Location = new System.Drawing.Point(888, 321);
            this.btn_selldog.Name = "btn_selldog";
            this.btn_selldog.Size = new System.Drawing.Size(96, 41);
            this.btn_selldog.TabIndex = 10;
            this.btn_selldog.Text = "Kutya eladás";
            this.btn_selldog.UseVisualStyleBackColor = true;
            this.btn_selldog.Click += new System.EventHandler(this.btn_selldog_Click);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(12, 30);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(830, 530);
            this.panel_main.TabIndex = 12;
            // 
            // btn_startyear
            // 
            this.btn_startyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_startyear.Location = new System.Drawing.Point(871, 558);
            this.btn_startyear.Name = "btn_startyear";
            this.btn_startyear.Size = new System.Drawing.Size(138, 40);
            this.btn_startyear.TabIndex = 13;
            this.btn_startyear.Text = "Év kezdése";
            this.btn_startyear.UseVisualStyleBackColor = true;
            this.btn_startyear.Click += new System.EventHandler(this.btn_startyear_Click);
            // 
            // btn_startharvest
            // 
            this.btn_startharvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_startharvest.Location = new System.Drawing.Point(871, 500);
            this.btn_startharvest.Name = "btn_startharvest";
            this.btn_startharvest.Size = new System.Drawing.Size(138, 40);
            this.btn_startharvest.TabIndex = 14;
            this.btn_startharvest.Text = "Szüret kezdése";
            this.btn_startharvest.UseVisualStyleBackColor = true;
            this.btn_startharvest.Click += new System.EventHandler(this.btn_startharvest_Click);
            // 
            // btn_yearresults
            // 
            this.btn_yearresults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_yearresults.Location = new System.Drawing.Point(12, 577);
            this.btn_yearresults.Name = "btn_yearresults";
            this.btn_yearresults.Size = new System.Drawing.Size(210, 40);
            this.btn_yearresults.TabIndex = 15;
            this.btn_yearresults.Text = "Éves érékelő exportálás";
            this.btn_yearresults.UseVisualStyleBackColor = true;
            this.btn_yearresults.Click += new System.EventHandler(this.btn_yearresults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 629);
            this.Controls.Add(this.btn_yearresults);
            this.Controls.Add(this.btn_startharvest);
            this.Controls.Add(this.btn_startyear);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.btn_selldog);
            this.Controls.Add(this.btn_buydog);
            this.Controls.Add(this.lbl_currentbalance);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_dogs);
            this.Controls.Add(this.lbl_numberofdogs);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_actualyear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_actualyear;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_dogs;
        private System.Windows.Forms.Label lbl_numberofdogs;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_currentbalance;
        private System.Windows.Forms.Button btn_buydog;
        private System.Windows.Forms.Button btn_selldog;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_startyear;
        private System.Windows.Forms.Button btn_startharvest;
        private System.Windows.Forms.Button btn_yearresults;
    }
}

