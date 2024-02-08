
namespace HotelManagementSystem.UI
{
    partial class AddReviewUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FoodCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.environmentCB = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(231, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Your Review Honestly!";
            // 
            // ServiceCB
            // 
            this.ServiceCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceCB.FormattingEnabled = true;
            this.ServiceCB.Items.AddRange(new object[] {
            "Poor",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.ServiceCB.Location = new System.Drawing.Point(421, 233);
            this.ServiceCB.Name = "ServiceCB";
            this.ServiceCB.Size = new System.Drawing.Size(138, 29);
            this.ServiceCB.TabIndex = 2;
            this.ServiceCB.Text = "Select Ratting";
            this.ServiceCB.SelectedIndexChanged += new System.EventHandler(this.ServiceCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Service Review: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Food Review: ";
            // 
            // FoodCB
            // 
            this.FoodCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodCB.FormattingEnabled = true;
            this.FoodCB.Items.AddRange(new object[] {
            "Poor",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.FoodCB.Location = new System.Drawing.Point(421, 291);
            this.FoodCB.Name = "FoodCB";
            this.FoodCB.Size = new System.Drawing.Size(138, 29);
            this.FoodCB.TabIndex = 5;
            this.FoodCB.Text = "Select Ratting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Environment Review: ";
            // 
            // environmentCB
            // 
            this.environmentCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.environmentCB.FormattingEnabled = true;
            this.environmentCB.Items.AddRange(new object[] {
            "Poor",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.environmentCB.Location = new System.Drawing.Point(421, 345);
            this.environmentCB.Name = "environmentCB";
            this.environmentCB.Size = new System.Drawing.Size(138, 29);
            this.environmentCB.TabIndex = 7;
            this.environmentCB.Text = "Select Ratting";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SubmitBtn.Location = new System.Drawing.Point(253, 425);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(254, 40);
            this.SubmitBtn.TabIndex = 8;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddReviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.environmentCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FoodCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServiceCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddReviewUC";
            this.Size = new System.Drawing.Size(804, 546);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServiceCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FoodCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox environmentCB;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button backBtn;
    }
}
