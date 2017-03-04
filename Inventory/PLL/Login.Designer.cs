namespace Inventory.PLL
{
    partial class Login
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
            this.profileDataGrid = new System.Windows.Forms.DataGridView();
            this.loadProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // profileDataGrid
            // 
            this.profileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileDataGrid.Location = new System.Drawing.Point(98, 97);
            this.profileDataGrid.Name = "profileDataGrid";
            this.profileDataGrid.RowTemplate.Height = 23;
            this.profileDataGrid.Size = new System.Drawing.Size(335, 174);
            this.profileDataGrid.TabIndex = 0;
            // 
            // loadProfile
            // 
            this.loadProfile.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loadProfile.Location = new System.Drawing.Point(333, 26);
            this.loadProfile.Name = "loadProfile";
            this.loadProfile.Size = new System.Drawing.Size(100, 44);
            this.loadProfile.TabIndex = 1;
            this.loadProfile.Text = "Load Profile";
            this.loadProfile.UseVisualStyleBackColor = true;
            this.loadProfile.Click += new System.EventHandler(this.loadProfile_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 313);
            this.Controls.Add(this.loadProfile);
            this.Controls.Add(this.profileDataGrid);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView profileDataGrid;
        private System.Windows.Forms.Button loadProfile;
    }
}