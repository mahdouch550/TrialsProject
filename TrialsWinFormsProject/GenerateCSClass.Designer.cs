namespace TrialsWinFormsProject
{
    partial class GenerateCSClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameSpaceTextBox = new System.Windows.Forms.TextBox();
            this.ClassPathTextBox = new System.Windows.Forms.TextBox();
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PropertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.PrpertyType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyNamespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButotn = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namespace :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Path :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Properties :";
            // 
            // NameSpaceTextBox
            // 
            this.NameSpaceTextBox.Location = new System.Drawing.Point(109, 18);
            this.NameSpaceTextBox.Name = "NameSpaceTextBox";
            this.NameSpaceTextBox.Size = new System.Drawing.Size(623, 22);
            this.NameSpaceTextBox.TabIndex = 3;
            // 
            // ClassPathTextBox
            // 
            this.ClassPathTextBox.Location = new System.Drawing.Point(109, 63);
            this.ClassPathTextBox.Name = "ClassPathTextBox";
            this.ClassPathTextBox.Size = new System.Drawing.Size(623, 22);
            this.ClassPathTextBox.TabIndex = 3;
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Location = new System.Drawing.Point(761, 41);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreviewTextBox.Size = new System.Drawing.Size(458, 511);
            this.PreviewTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preview :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PropertiesDataGridView);
            this.panel1.Location = new System.Drawing.Point(15, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 408);
            this.panel1.TabIndex = 6;
            // 
            // PropertiesDataGridView
            // 
            this.PropertiesDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.PropertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrpertyType,
            this.PropertyName,
            this.PropertyNamespace});
            this.PropertiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PropertiesDataGridView.Name = "PropertiesDataGridView";
            this.PropertiesDataGridView.RowHeadersVisible = false;
            this.PropertiesDataGridView.RowHeadersWidth = 51;
            this.PropertiesDataGridView.RowTemplate.Height = 24;
            this.PropertiesDataGridView.Size = new System.Drawing.Size(717, 408);
            this.PropertiesDataGridView.TabIndex = 5;
            this.PropertiesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertiesDataGridView_CellEndEdit);
            this.PropertiesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PropertiesDataGridView_RowsAdded);
            // 
            // PrpertyType
            // 
            this.PrpertyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrpertyType.HeaderText = "Type";
            this.PrpertyType.MinimumWidth = 6;
            this.PrpertyType.Name = "PrpertyType";
            this.PrpertyType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrpertyType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PropertyName
            // 
            this.PropertyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyName.HeaderText = "Name";
            this.PropertyName.MinimumWidth = 6;
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PropertyNamespace
            // 
            this.PropertyNamespace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyNamespace.HeaderText = "Namespace";
            this.PropertyNamespace.MinimumWidth = 6;
            this.PropertyNamespace.Name = "PropertyNamespace";
            // 
            // CloseButotn
            // 
            this.CloseButotn.Location = new System.Drawing.Point(761, 558);
            this.CloseButotn.Name = "CloseButotn";
            this.CloseButotn.Size = new System.Drawing.Size(458, 34);
            this.CloseButotn.TabIndex = 7;
            this.CloseButotn.Text = "Close";
            this.CloseButotn.UseVisualStyleBackColor = true;
            this.CloseButotn.Click += new System.EventHandler(this.CloseButotn_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(15, 558);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(717, 34);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "Generate && Save";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // GenerateCSClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 604);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CloseButotn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PreviewTextBox);
            this.Controls.Add(this.ClassPathTextBox);
            this.Controls.Add(this.NameSpaceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateCSClass";
            this.Text = "Generate a CS Class";
            this.Load += new System.EventHandler(this.GenerateCSClass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameSpaceTextBox;
        private System.Windows.Forms.TextBox ClassPathTextBox;
        private System.Windows.Forms.TextBox PreviewTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PropertiesDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn PrpertyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyNamespace;
        private System.Windows.Forms.Button CloseButotn;
        private System.Windows.Forms.Button GenerateButton;
    }
}

