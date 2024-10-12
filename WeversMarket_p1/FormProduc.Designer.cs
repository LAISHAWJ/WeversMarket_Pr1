namespace WeversMarket_p1
{
    partial class FormProduc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduc));
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            BtAdd = new Button();
            BtUpdate = new Button();
            BtDelete = new Button();
            BtRefresh = new Button();
            BtBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(BtBack);
            panel1.Controls.Add(BtRefresh);
            panel1.Controls.Add(BtDelete);
            panel1.Controls.Add(BtUpdate);
            panel1.Controls.Add(BtAdd);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 623);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Location = new Point(387, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 52);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(869, 555);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 68);
            label1.Name = "label1";
            label1.Size = new Size(285, 60);
            label1.TabIndex = 3;
            label1.Text = "PRODUCTOS";
            // 
            // BtAdd
            // 
            BtAdd.BackColor = Color.Green;
            BtAdd.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtAdd.ForeColor = SystemColors.ControlLightLight;
            BtAdd.Location = new Point(61, 176);
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(176, 48);
            BtAdd.TabIndex = 3;
            BtAdd.Text = "AGREGAR";
            BtAdd.UseVisualStyleBackColor = false;
            // 
            // BtUpdate
            // 
            BtUpdate.BackColor = Color.FromArgb(255, 128, 0);
            BtUpdate.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtUpdate.ForeColor = SystemColors.ControlLightLight;
            BtUpdate.Location = new Point(61, 240);
            BtUpdate.Name = "BtUpdate";
            BtUpdate.Size = new Size(176, 48);
            BtUpdate.TabIndex = 4;
            BtUpdate.Text = "EDITAR";
            BtUpdate.UseVisualStyleBackColor = false;
            // 
            // BtDelete
            // 
            BtDelete.BackColor = Color.Red;
            BtDelete.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtDelete.ForeColor = SystemColors.ControlLight;
            BtDelete.Location = new Point(61, 305);
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(176, 48);
            BtDelete.TabIndex = 5;
            BtDelete.Text = "ELIMINAR";
            BtDelete.UseVisualStyleBackColor = false;
            // 
            // BtRefresh
            // 
            BtRefresh.BackColor = Color.FromArgb(128, 128, 255);
            BtRefresh.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);
            BtRefresh.ForeColor = SystemColors.ControlLight;
            BtRefresh.Location = new Point(61, 367);
            BtRefresh.Name = "BtRefresh";
            BtRefresh.Size = new Size(176, 48);
            BtRefresh.TabIndex = 6;
            BtRefresh.Text = "REFRESH";
            BtRefresh.UseVisualStyleBackColor = false;
            // 
            // BtBack
            // 
            BtBack.BackgroundImage = (Image)resources.GetObject("BtBack.BackgroundImage");
            BtBack.BackgroundImageLayout = ImageLayout.Center;
            BtBack.FlatStyle = FlatStyle.Flat;
            BtBack.ForeColor = Color.Wheat;
            BtBack.Location = new Point(5, 541);
            BtBack.Name = "BtBack";
            BtBack.Size = new Size(90, 76);
            BtBack.TabIndex = 3;
            BtBack.UseVisualStyleBackColor = true;
            BtBack.Click += BtBack_Click;
            // 
            // FormProduc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1306, 659);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormProduc";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtRefresh;
        private Button BtDelete;
        private Button BtUpdate;
        private Button BtAdd;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button BtBack;
    }
}