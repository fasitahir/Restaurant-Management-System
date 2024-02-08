
namespace HotelManagementSystem
{
    partial class MenuUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.menuDLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.menuGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menuGridView.AutoGenerateColumns = false;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.menuGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuGridView.DataSource = this.menuDLBindingSource;
            this.menuGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuGridView.Location = new System.Drawing.Point(0, 95);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuGridView.Size = new System.Drawing.Size(594, 440);
            this.menuGridView.TabIndex = 0;
            this.menuGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuGridView_CellContentClick);
            // 
            // menuDLBindingSource
            // 
            this.menuDLBindingSource.DataSource = typeof(HotelManagementSystem.DL.MenuDL);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 27);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuGridView);
            this.Name = "MenuUC";
            this.Size = new System.Drawing.Size(594, 535);
            this.Load += new System.EventHandler(this.MenuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.BindingSource menuDLBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button backBtn;
    }
}
