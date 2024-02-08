
namespace HotelManagementSystem.UI
{
    partial class ManagerPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.workerBtn = new System.Windows.Forms.Button();
            this.expensesBtn = new System.Windows.Forms.Button();
            this.reviewBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.expensesPanel = new System.Windows.Forms.Panel();
            this.totalExpensesBtn = new System.Windows.Forms.Button();
            this.productExpensesBtn = new System.Windows.Forms.Button();
            this.workersExpensesBtn = new System.Windows.Forms.Button();
            this.totalExpensesUC1 = new HotelManagementSystem.UI.TotalExpensesUC();
            this.manageWorkersUC1 = new HotelManagementSystem.UI.ManageWorkersUC();
            this.manageProductUC1 = new HotelManagementSystem.UI.ManageProductUC();
            this.viewReviewUC1 = new HotelManagementSystem.UI.ViewReviewUC();
            this.productExpenses_UC1 = new HotelManagementSystem.UI.ProductExpenses_UC();
            this.workerExpensesUC1 = new HotelManagementSystem.UI.WorkerExpensesUC();
            this.expensesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(304, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 130);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(432, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 130);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager";
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.LightGray;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Black;
            this.productBtn.Location = new System.Drawing.Point(12, 135);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(121, 34);
            this.productBtn.TabIndex = 3;
            this.productBtn.Text = "Product";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu";
            // 
            // workerBtn
            // 
            this.workerBtn.BackColor = System.Drawing.Color.LightGray;
            this.workerBtn.FlatAppearance.BorderSize = 0;
            this.workerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workerBtn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerBtn.ForeColor = System.Drawing.Color.Black;
            this.workerBtn.Location = new System.Drawing.Point(12, 192);
            this.workerBtn.Name = "workerBtn";
            this.workerBtn.Size = new System.Drawing.Size(121, 34);
            this.workerBtn.TabIndex = 5;
            this.workerBtn.Text = "Workers";
            this.workerBtn.UseVisualStyleBackColor = false;
            this.workerBtn.Click += new System.EventHandler(this.workerBtn_Click);
            // 
            // expensesBtn
            // 
            this.expensesBtn.BackColor = System.Drawing.Color.LightGray;
            this.expensesBtn.FlatAppearance.BorderSize = 0;
            this.expensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesBtn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesBtn.ForeColor = System.Drawing.Color.Black;
            this.expensesBtn.Location = new System.Drawing.Point(12, 249);
            this.expensesBtn.Name = "expensesBtn";
            this.expensesBtn.Size = new System.Drawing.Size(121, 34);
            this.expensesBtn.TabIndex = 6;
            this.expensesBtn.Text = "Expenses";
            this.expensesBtn.UseVisualStyleBackColor = false;
            this.expensesBtn.Click += new System.EventHandler(this.expensesBtn_Click);
            // 
            // reviewBtn
            // 
            this.reviewBtn.BackColor = System.Drawing.Color.LightGray;
            this.reviewBtn.FlatAppearance.BorderSize = 0;
            this.reviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewBtn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBtn.ForeColor = System.Drawing.Color.Black;
            this.reviewBtn.Location = new System.Drawing.Point(12, 306);
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.Size = new System.Drawing.Size(121, 34);
            this.reviewBtn.TabIndex = 8;
            this.reviewBtn.Text = "Reviews";
            this.reviewBtn.UseVisualStyleBackColor = false;
            this.reviewBtn.Click += new System.EventHandler(this.reviewBtn_Click_1);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.LightGray;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.Location = new System.Drawing.Point(12, 363);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(121, 34);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // expensesPanel
            // 
            this.expensesPanel.BackColor = System.Drawing.Color.DimGray;
            this.expensesPanel.Controls.Add(this.totalExpensesBtn);
            this.expensesPanel.Controls.Add(this.productExpensesBtn);
            this.expensesPanel.Controls.Add(this.workersExpensesBtn);
            this.expensesPanel.Location = new System.Drawing.Point(130, 216);
            this.expensesPanel.Name = "expensesPanel";
            this.expensesPanel.Size = new System.Drawing.Size(121, 112);
            this.expensesPanel.TabIndex = 13;
            // 
            // totalExpensesBtn
            // 
            this.totalExpensesBtn.BackColor = System.Drawing.Color.LightGray;
            this.totalExpensesBtn.FlatAppearance.BorderSize = 0;
            this.totalExpensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalExpensesBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpensesBtn.ForeColor = System.Drawing.Color.Black;
            this.totalExpensesBtn.Location = new System.Drawing.Point(0, 77);
            this.totalExpensesBtn.Name = "totalExpensesBtn";
            this.totalExpensesBtn.Size = new System.Drawing.Size(121, 32);
            this.totalExpensesBtn.TabIndex = 18;
            this.totalExpensesBtn.Text = "Total";
            this.totalExpensesBtn.UseVisualStyleBackColor = false;
            this.totalExpensesBtn.Click += new System.EventHandler(this.totalExpensesBtn_Click);
            // 
            // productExpensesBtn
            // 
            this.productExpensesBtn.BackColor = System.Drawing.Color.LightGray;
            this.productExpensesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productExpensesBtn.FlatAppearance.BorderSize = 0;
            this.productExpensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productExpensesBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productExpensesBtn.ForeColor = System.Drawing.Color.Black;
            this.productExpensesBtn.Location = new System.Drawing.Point(0, 0);
            this.productExpensesBtn.Name = "productExpensesBtn";
            this.productExpensesBtn.Size = new System.Drawing.Size(121, 32);
            this.productExpensesBtn.TabIndex = 15;
            this.productExpensesBtn.Text = "Product";
            this.productExpensesBtn.UseVisualStyleBackColor = false;
            this.productExpensesBtn.Click += new System.EventHandler(this.productExpensesBtn_Click);
            // 
            // workersExpensesBtn
            // 
            this.workersExpensesBtn.BackColor = System.Drawing.Color.LightGray;
            this.workersExpensesBtn.FlatAppearance.BorderSize = 0;
            this.workersExpensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersExpensesBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workersExpensesBtn.ForeColor = System.Drawing.Color.Black;
            this.workersExpensesBtn.Location = new System.Drawing.Point(0, 38);
            this.workersExpensesBtn.Name = "workersExpensesBtn";
            this.workersExpensesBtn.Size = new System.Drawing.Size(121, 32);
            this.workersExpensesBtn.TabIndex = 16;
            this.workersExpensesBtn.Text = "Workers";
            this.workersExpensesBtn.UseVisualStyleBackColor = false;
            this.workersExpensesBtn.Click += new System.EventHandler(this.workersExpensesBtn_Click);
            // 
            // totalExpensesUC1
            // 
            this.totalExpensesUC1.Location = new System.Drawing.Point(-1, 2);
            this.totalExpensesUC1.Name = "totalExpensesUC1";
            this.totalExpensesUC1.Size = new System.Drawing.Size(801, 499);
            this.totalExpensesUC1.TabIndex = 16;
            // 
            // manageWorkersUC1
            // 
            this.manageWorkersUC1.Location = new System.Drawing.Point(-1, 1);
            this.manageWorkersUC1.Name = "manageWorkersUC1";
            this.manageWorkersUC1.Size = new System.Drawing.Size(801, 499);
            this.manageWorkersUC1.TabIndex = 11;
            // 
            // manageProductUC1
            // 
            this.manageProductUC1.Location = new System.Drawing.Point(-1, 1);
            this.manageProductUC1.Name = "manageProductUC1";
            this.manageProductUC1.Size = new System.Drawing.Size(801, 499);
            this.manageProductUC1.TabIndex = 10;
            // 
            // viewReviewUC1
            // 
            this.viewReviewUC1.Location = new System.Drawing.Point(-1, 2);
            this.viewReviewUC1.Name = "viewReviewUC1";
            this.viewReviewUC1.Size = new System.Drawing.Size(801, 499);
            this.viewReviewUC1.TabIndex = 12;
            // 
            // productExpenses_UC1
            // 
            this.productExpenses_UC1.Location = new System.Drawing.Point(-1, 1);
            this.productExpenses_UC1.Name = "productExpenses_UC1";
            this.productExpenses_UC1.Size = new System.Drawing.Size(801, 499);
            this.productExpenses_UC1.TabIndex = 14;
            // 
            // workerExpensesUC1
            // 
            this.workerExpensesUC1.Location = new System.Drawing.Point(-1, 1);
            this.workerExpensesUC1.Name = "workerExpensesUC1";
            this.workerExpensesUC1.Size = new System.Drawing.Size(801, 499);
            this.workerExpensesUC1.TabIndex = 15;
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.ManagerBackground4_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.expensesPanel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.reviewBtn);
            this.Controls.Add(this.expensesBtn);
            this.Controls.Add(this.workerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.manageWorkersUC1);
            this.Controls.Add(this.manageProductUC1);
            this.Controls.Add(this.viewReviewUC1);
            this.Controls.Add(this.productExpenses_UC1);
            this.Controls.Add(this.workerExpensesUC1);
            this.Controls.Add(this.totalExpensesUC1);
            this.DoubleBuffered = true;
            this.Name = "ManagerPage";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerPage_Load);
            this.expensesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button workerBtn;
        private System.Windows.Forms.Button expensesBtn;
        private System.Windows.Forms.Button reviewBtn;
        private System.Windows.Forms.Button logoutBtn;
        private ManageProductUC manageProductUC1;
        private ManageWorkersUC manageWorkersUC1;
        private ViewReviewUC viewReviewUC1;
        private System.Windows.Forms.Panel expensesPanel;
        private System.Windows.Forms.Button totalExpensesBtn;
        private System.Windows.Forms.Button workersExpensesBtn;
        private System.Windows.Forms.Button productExpensesBtn;
        private ProductExpenses_UC productExpenses_UC1;
        private WorkerExpensesUC workerExpensesUC1;
        private TotalExpensesUC totalExpensesUC1;
    }
}