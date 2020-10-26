namespace DataEastEF
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title_Button = new System.Windows.Forms.Button();
            this.GameFoundDataGrid = new System.Windows.Forms.DataGridView();
            this.Release_Button = new System.Windows.Forms.Button();
            this.Genre_Button = new System.Windows.Forms.Button();
            this.Hardware_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameFoundDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Button
            // 
            this.Title_Button.Location = new System.Drawing.Point(156, 94);
            this.Title_Button.Name = "Title_Button";
            this.Title_Button.Size = new System.Drawing.Size(112, 34);
            this.Title_Button.TabIndex = 1;
            this.Title_Button.Text = "Title";
            this.Title_Button.UseVisualStyleBackColor = true;
            this.Title_Button.Click += new System.EventHandler(this.Title_Button_Click);
            // 
            // GameFoundDataGrid
            // 
            this.GameFoundDataGrid.AllowUserToAddRows = false;
            this.GameFoundDataGrid.AllowUserToDeleteRows = false;
            this.GameFoundDataGrid.AllowUserToResizeColumns = false;
            this.GameFoundDataGrid.AllowUserToResizeRows = false;
            this.GameFoundDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GameFoundDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GameFoundDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameFoundDataGrid.Location = new System.Drawing.Point(186, 164);
            this.GameFoundDataGrid.Name = "GameFoundDataGrid";
            this.GameFoundDataGrid.ReadOnly = true;
            this.GameFoundDataGrid.RowHeadersWidth = 62;
            this.GameFoundDataGrid.Size = new System.Drawing.Size(870, 720);
            this.GameFoundDataGrid.StandardTab = true;
            this.GameFoundDataGrid.TabIndex = 2;
            this.GameFoundDataGrid.Text = "dataGridView1";
            // 
            // Release_Button
            // 
            this.Release_Button.Location = new System.Drawing.Point(326, 94);
            this.Release_Button.Name = "Release_Button";
            this.Release_Button.Size = new System.Drawing.Size(112, 34);
            this.Release_Button.TabIndex = 3;
            this.Release_Button.Text = "Release Date";
            this.Release_Button.UseVisualStyleBackColor = true;
            this.Release_Button.Click += new System.EventHandler(this.Release_Button_Click);
            // 
            // Genre_Button
            // 
            this.Genre_Button.Location = new System.Drawing.Point(750, 94);
            this.Genre_Button.Name = "Genre_Button";
            this.Genre_Button.Size = new System.Drawing.Size(112, 34);
            this.Genre_Button.TabIndex = 3;
            this.Genre_Button.Text = "Genre";
            this.Genre_Button.UseVisualStyleBackColor = true;
            this.Genre_Button.Click += new System.EventHandler(this.Genre_Button_Click);
            // 
            // Hardware_Button
            // 
            this.Hardware_Button.Location = new System.Drawing.Point(510, 94);
            this.Hardware_Button.Name = "Hardware_Button";
            this.Hardware_Button.Size = new System.Drawing.Size(165, 34);
            this.Hardware_Button.TabIndex = 3;
            this.Hardware_Button.Text = "Hardware Type";
            this.Hardware_Button.UseVisualStyleBackColor = true;
            this.Hardware_Button.Click += new System.EventHandler(this.Hardware_Button_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 1001);
            this.Controls.Add(this.Hardware_Button);
            this.Controls.Add(this.Genre_Button);
            this.Controls.Add(this.Release_Button);
            this.Controls.Add(this.GameFoundDataGrid);
            this.Controls.Add(this.Title_Button);
            this.Name = "Dashboard";
            this.Text = "DataEastEF";
            ((System.ComponentModel.ISupportInitialize)(this.GameFoundDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Title_Button;
        private System.Windows.Forms.DataGridView GameFoundDataGrid;
        private System.Windows.Forms.Button Release_Button;
        private System.Windows.Forms.Button Genre_Button;
        private System.Windows.Forms.Button Hardware_Button;
    }
}

