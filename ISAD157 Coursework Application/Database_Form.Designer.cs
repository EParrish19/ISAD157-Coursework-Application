namespace ISAD157_Coursework_Application
{
    partial class Database_Form
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
            this.Cbox_Data_Choice = new System.Windows.Forms.ComboBox();
            this.DataGrid_QueryResult = new System.Windows.Forms.DataGridView();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.LblFilter = new System.Windows.Forms.Label();
            this.TxtBoxFilter = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbox_Data_Choice
            // 
            this.Cbox_Data_Choice.FormattingEnabled = true;
            this.Cbox_Data_Choice.Items.AddRange(new object[] {
            "Users",
            "Friendships",
            "Work",
            "Education",
            "Messages"});
            this.Cbox_Data_Choice.Location = new System.Drawing.Point(234, 12);
            this.Cbox_Data_Choice.Name = "Cbox_Data_Choice";
            this.Cbox_Data_Choice.Size = new System.Drawing.Size(745, 21);
            this.Cbox_Data_Choice.TabIndex = 0;
            this.Cbox_Data_Choice.SelectedIndexChanged += new System.EventHandler(this.Cbox_Data_Choice_SelectedIndexChanged);
            // 
            // DataGrid_QueryResult
            // 
            this.DataGrid_QueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QueryResult.Location = new System.Drawing.Point(12, 96);
            this.DataGrid_QueryResult.Name = "DataGrid_QueryResult";
            this.DataGrid_QueryResult.Size = new System.Drawing.Size(1178, 534);
            this.DataGrid_QueryResult.TabIndex = 1;
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Location = new System.Drawing.Point(193, 15);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Data.TabIndex = 2;
            this.Lbl_Data.Text = "Data:";
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Location = new System.Drawing.Point(164, 56);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(68, 13);
            this.LblFilter.TabIndex = 3;
            this.LblFilter.Text = "Filter UserID:";
            // 
            // TxtBoxFilter
            // 
            this.TxtBoxFilter.Location = new System.Drawing.Point(238, 53);
            this.TxtBoxFilter.Name = "TxtBoxFilter";
            this.TxtBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxFilter.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(344, 51);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Database_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 696);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtBoxFilter);
            this.Controls.Add(this.LblFilter);
            this.Controls.Add(this.Lbl_Data);
            this.Controls.Add(this.DataGrid_QueryResult);
            this.Controls.Add(this.Cbox_Data_Choice);
            this.Name = "Database_Form";
            this.Text = "Database Form";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QueryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbox_Data_Choice;
        private System.Windows.Forms.DataGridView DataGrid_QueryResult;
        private System.Windows.Forms.Label Lbl_Data;
        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.TextBox TxtBoxFilter;
        private System.Windows.Forms.Button BtnSearch;
    }
}

