namespace Servis_Protocol
{
    partial class ServisProtocolForm
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
            this.DefaultInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ProtocolDateLabel = new System.Windows.Forms.Label();
            this.ProtocolNumberLabel = new System.Windows.Forms.Label();
            this.EditDefualtInfoButton = new System.Windows.Forms.Button();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.CustomerICLabel = new System.Windows.Forms.Label();
            this.CustomerPSCLabel = new System.Windows.Forms.Label();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeviceGroupBox = new System.Windows.Forms.GroupBox();
            this.EditDeviceButton = new System.Windows.Forms.Button();
            this.DeviceNumberLabel = new System.Windows.Forms.Label();
            this.DeviceModelLabel = new System.Windows.Forms.Label();
            this.DeviceManufacturerLabel = new System.Windows.Forms.Label();
            this.MeasurmentGroupBox = new System.Windows.Forms.GroupBox();
            this.MeasurmentDeleteButton = new System.Windows.Forms.Button();
            this.MeasurmentEditButton = new System.Windows.Forms.Button();
            this.MeasurmentAddButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SaveProtocolButton = new System.Windows.Forms.Button();
            this.LoadProtocolButton = new System.Windows.Forms.Button();
            this.ViewProtocolButton = new System.Windows.Forms.Button();
            this.ExportProtocolButton = new System.Windows.Forms.Button();
            this.ProtocolNumberValue = new System.Windows.Forms.Label();
            this.ProtocolDateValue = new System.Windows.Forms.Label();
            this.CustomerNameValue = new System.Windows.Forms.Label();
            this.CustomerAddressValue = new System.Windows.Forms.Label();
            this.CustomerPSCValue = new System.Windows.Forms.Label();
            this.CustomerICValue = new System.Windows.Forms.Label();
            this.DeviceManufacturerValue = new System.Windows.Forms.Label();
            this.DeviceModelValue = new System.Windows.Forms.Label();
            this.DeviceNumberValue = new System.Windows.Forms.Label();
            this.colParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultInfoGroupBox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.DeviceGroupBox.SuspendLayout();
            this.MeasurmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultInfoGroupBox
            // 
            this.DefaultInfoGroupBox.Controls.Add(this.ProtocolDateValue);
            this.DefaultInfoGroupBox.Controls.Add(this.ProtocolNumberValue);
            this.DefaultInfoGroupBox.Controls.Add(this.ProtocolDateLabel);
            this.DefaultInfoGroupBox.Controls.Add(this.ProtocolNumberLabel);
            this.DefaultInfoGroupBox.Controls.Add(this.EditDefualtInfoButton);
            this.DefaultInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DefaultInfoGroupBox.Name = "DefaultInfoGroupBox";
            this.DefaultInfoGroupBox.Size = new System.Drawing.Size(589, 81);
            this.DefaultInfoGroupBox.TabIndex = 0;
            this.DefaultInfoGroupBox.TabStop = false;
            this.DefaultInfoGroupBox.Text = "Základní Infromace";
            // 
            // ProtocolDateLabel
            // 
            this.ProtocolDateLabel.AutoSize = true;
            this.ProtocolDateLabel.Location = new System.Drawing.Point(27, 50);
            this.ProtocolDateLabel.Name = "ProtocolDateLabel";
            this.ProtocolDateLabel.Size = new System.Drawing.Size(79, 13);
            this.ProtocolDateLabel.TabIndex = 2;
            this.ProtocolDateLabel.Text = "Datum Měření:";
            // 
            // ProtocolNumberLabel
            // 
            this.ProtocolNumberLabel.AutoSize = true;
            this.ProtocolNumberLabel.Location = new System.Drawing.Point(27, 25);
            this.ProtocolNumberLabel.Name = "ProtocolNumberLabel";
            this.ProtocolNumberLabel.Size = new System.Drawing.Size(82, 13);
            this.ProtocolNumberLabel.TabIndex = 1;
            this.ProtocolNumberLabel.Text = "Číslo Protokolu:";
            // 
            // EditDefualtInfoButton
            // 
            this.EditDefualtInfoButton.Location = new System.Drawing.Point(506, 19);
            this.EditDefualtInfoButton.Name = "EditDefualtInfoButton";
            this.EditDefualtInfoButton.Size = new System.Drawing.Size(77, 51);
            this.EditDefualtInfoButton.TabIndex = 0;
            this.EditDefualtInfoButton.Text = "Upravit";
            this.EditDefualtInfoButton.UseVisualStyleBackColor = true;
            this.EditDefualtInfoButton.Click += new System.EventHandler(this.EditDefualtInfoButton_Click);
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.CustomerICValue);
            this.CustomerGroupBox.Controls.Add(this.CustomerPSCValue);
            this.CustomerGroupBox.Controls.Add(this.CustomerAddressValue);
            this.CustomerGroupBox.Controls.Add(this.CustomerNameValue);
            this.CustomerGroupBox.Controls.Add(this.EditCustomerButton);
            this.CustomerGroupBox.Controls.Add(this.CustomerICLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerPSCLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerAddressLabel);
            this.CustomerGroupBox.Controls.Add(this.CustomerNameLabel);
            this.CustomerGroupBox.Location = new System.Drawing.Point(12, 99);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(283, 149);
            this.CustomerGroupBox.TabIndex = 3;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Zákazník";
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Location = new System.Drawing.Point(202, 120);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.EditCustomerButton.TabIndex = 5;
            this.EditCustomerButton.Text = "Upravit";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // CustomerICLabel
            // 
            this.CustomerICLabel.AutoSize = true;
            this.CustomerICLabel.Location = new System.Drawing.Point(27, 100);
            this.CustomerICLabel.Name = "CustomerICLabel";
            this.CustomerICLabel.Size = new System.Drawing.Size(20, 13);
            this.CustomerICLabel.TabIndex = 4;
            this.CustomerICLabel.Text = "IČ:";
            // 
            // CustomerPSCLabel
            // 
            this.CustomerPSCLabel.AutoSize = true;
            this.CustomerPSCLabel.Location = new System.Drawing.Point(27, 76);
            this.CustomerPSCLabel.Name = "CustomerPSCLabel";
            this.CustomerPSCLabel.Size = new System.Drawing.Size(31, 13);
            this.CustomerPSCLabel.TabIndex = 3;
            this.CustomerPSCLabel.Text = "PSČ:";
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Location = new System.Drawing.Point(27, 50);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(43, 13);
            this.CustomerAddressLabel.TabIndex = 2;
            this.CustomerAddressLabel.Text = "Adresa:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(27, 25);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(41, 13);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Název:";
            // 
            // DeviceGroupBox
            // 
            this.DeviceGroupBox.Controls.Add(this.DeviceNumberValue);
            this.DeviceGroupBox.Controls.Add(this.DeviceModelValue);
            this.DeviceGroupBox.Controls.Add(this.DeviceManufacturerValue);
            this.DeviceGroupBox.Controls.Add(this.EditDeviceButton);
            this.DeviceGroupBox.Controls.Add(this.DeviceNumberLabel);
            this.DeviceGroupBox.Controls.Add(this.DeviceModelLabel);
            this.DeviceGroupBox.Controls.Add(this.DeviceManufacturerLabel);
            this.DeviceGroupBox.Location = new System.Drawing.Point(323, 99);
            this.DeviceGroupBox.Name = "DeviceGroupBox";
            this.DeviceGroupBox.Size = new System.Drawing.Size(278, 149);
            this.DeviceGroupBox.TabIndex = 6;
            this.DeviceGroupBox.TabStop = false;
            this.DeviceGroupBox.Text = "Zařízení";
            // 
            // EditDeviceButton
            // 
            this.EditDeviceButton.Location = new System.Drawing.Point(197, 120);
            this.EditDeviceButton.Name = "EditDeviceButton";
            this.EditDeviceButton.Size = new System.Drawing.Size(75, 23);
            this.EditDeviceButton.TabIndex = 5;
            this.EditDeviceButton.Text = "Upravit";
            this.EditDeviceButton.UseVisualStyleBackColor = true;
            this.EditDeviceButton.Click += new System.EventHandler(this.EditDeviceButton_Click);
            // 
            // DeviceNumberLabel
            // 
            this.DeviceNumberLabel.AutoSize = true;
            this.DeviceNumberLabel.Location = new System.Drawing.Point(27, 76);
            this.DeviceNumberLabel.Name = "DeviceNumberLabel";
            this.DeviceNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.DeviceNumberLabel.TabIndex = 3;
            this.DeviceNumberLabel.Text = "Sériové Číslo:";
            // 
            // DeviceModelLabel
            // 
            this.DeviceModelLabel.AutoSize = true;
            this.DeviceModelLabel.Location = new System.Drawing.Point(27, 50);
            this.DeviceModelLabel.Name = "DeviceModelLabel";
            this.DeviceModelLabel.Size = new System.Drawing.Size(39, 13);
            this.DeviceModelLabel.TabIndex = 2;
            this.DeviceModelLabel.Text = "Model:";
            // 
            // DeviceManufacturerLabel
            // 
            this.DeviceManufacturerLabel.AutoSize = true;
            this.DeviceManufacturerLabel.Location = new System.Drawing.Point(27, 25);
            this.DeviceManufacturerLabel.Name = "DeviceManufacturerLabel";
            this.DeviceManufacturerLabel.Size = new System.Drawing.Size(49, 13);
            this.DeviceManufacturerLabel.TabIndex = 1;
            this.DeviceManufacturerLabel.Text = "Výrobce:";
            // 
            // MeasurmentGroupBox
            // 
            this.MeasurmentGroupBox.Controls.Add(this.MeasurmentDeleteButton);
            this.MeasurmentGroupBox.Controls.Add(this.MeasurmentEditButton);
            this.MeasurmentGroupBox.Controls.Add(this.MeasurmentAddButton);
            this.MeasurmentGroupBox.Controls.Add(this.DataGrid);
            this.MeasurmentGroupBox.Location = new System.Drawing.Point(12, 272);
            this.MeasurmentGroupBox.Name = "MeasurmentGroupBox";
            this.MeasurmentGroupBox.Size = new System.Drawing.Size(589, 243);
            this.MeasurmentGroupBox.TabIndex = 7;
            this.MeasurmentGroupBox.TabStop = false;
            this.MeasurmentGroupBox.Text = "Měření";
            // 
            // MeasurmentDeleteButton
            // 
            this.MeasurmentDeleteButton.Location = new System.Drawing.Point(502, 208);
            this.MeasurmentDeleteButton.Name = "MeasurmentDeleteButton";
            this.MeasurmentDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.MeasurmentDeleteButton.TabIndex = 3;
            this.MeasurmentDeleteButton.Text = "Smazat";
            this.MeasurmentDeleteButton.UseVisualStyleBackColor = true;
            this.MeasurmentDeleteButton.Click += new System.EventHandler(this.MeasurmentDeleteButton_Click);
            // 
            // MeasurmentEditButton
            // 
            this.MeasurmentEditButton.Location = new System.Drawing.Point(421, 207);
            this.MeasurmentEditButton.Name = "MeasurmentEditButton";
            this.MeasurmentEditButton.Size = new System.Drawing.Size(75, 23);
            this.MeasurmentEditButton.TabIndex = 2;
            this.MeasurmentEditButton.Text = "Upravit";
            this.MeasurmentEditButton.UseVisualStyleBackColor = true;
            this.MeasurmentEditButton.Click += new System.EventHandler(this.MeasurmentEditButton_Click);
            // 
            // MeasurmentAddButton
            // 
            this.MeasurmentAddButton.Location = new System.Drawing.Point(340, 208);
            this.MeasurmentAddButton.Name = "MeasurmentAddButton";
            this.MeasurmentAddButton.Size = new System.Drawing.Size(75, 23);
            this.MeasurmentAddButton.TabIndex = 1;
            this.MeasurmentAddButton.Text = "Přidat";
            this.MeasurmentAddButton.UseVisualStyleBackColor = true;
            this.MeasurmentAddButton.Click += new System.EventHandler(this.MeasurmentAddButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParameter,
            this.colValue,
            this.colUnit,
            this.colSuits});
            this.DataGrid.Location = new System.Drawing.Point(13, 36);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(564, 165);
            this.DataGrid.TabIndex = 0;
            // 
            // SaveProtocolButton
            // 
            this.SaveProtocolButton.Location = new System.Drawing.Point(12, 523);
            this.SaveProtocolButton.Name = "SaveProtocolButton";
            this.SaveProtocolButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProtocolButton.TabIndex = 8;
            this.SaveProtocolButton.Text = "Uložit";
            this.SaveProtocolButton.UseVisualStyleBackColor = true;
            this.SaveProtocolButton.Click += new System.EventHandler(this.SaveProtocolButton_Click);
            // 
            // LoadProtocolButton
            // 
            this.LoadProtocolButton.Location = new System.Drawing.Point(93, 523);
            this.LoadProtocolButton.Name = "LoadProtocolButton";
            this.LoadProtocolButton.Size = new System.Drawing.Size(75, 23);
            this.LoadProtocolButton.TabIndex = 9;
            this.LoadProtocolButton.Text = "Načíst";
            this.LoadProtocolButton.UseVisualStyleBackColor = true;
            this.LoadProtocolButton.Click += new System.EventHandler(this.LoadProtocolButton_Click);
            // 
            // ViewProtocolButton
            // 
            this.ViewProtocolButton.Location = new System.Drawing.Point(526, 523);
            this.ViewProtocolButton.Name = "ViewProtocolButton";
            this.ViewProtocolButton.Size = new System.Drawing.Size(75, 23);
            this.ViewProtocolButton.TabIndex = 10;
            this.ViewProtocolButton.Text = "Náhled";
            this.ViewProtocolButton.UseVisualStyleBackColor = true;
            this.ViewProtocolButton.Click += new System.EventHandler(this.ViewProtocolButton_Click);
            // 
            // ExportProtocolButton
            // 
            this.ExportProtocolButton.Location = new System.Drawing.Point(445, 523);
            this.ExportProtocolButton.Name = "ExportProtocolButton";
            this.ExportProtocolButton.Size = new System.Drawing.Size(75, 23);
            this.ExportProtocolButton.TabIndex = 11;
            this.ExportProtocolButton.Text = "Export";
            this.ExportProtocolButton.UseVisualStyleBackColor = true;
            // 
            // ProtocolNumberValue
            // 
            this.ProtocolNumberValue.AutoSize = true;
            this.ProtocolNumberValue.Location = new System.Drawing.Point(116, 25);
            this.ProtocolNumberValue.Name = "ProtocolNumberValue";
            this.ProtocolNumberValue.Size = new System.Drawing.Size(13, 13);
            this.ProtocolNumberValue.TabIndex = 3;
            this.ProtocolNumberValue.Text = "?";
            // 
            // ProtocolDateValue
            // 
            this.ProtocolDateValue.AutoSize = true;
            this.ProtocolDateValue.Location = new System.Drawing.Point(112, 50);
            this.ProtocolDateValue.Name = "ProtocolDateValue";
            this.ProtocolDateValue.Size = new System.Drawing.Size(13, 13);
            this.ProtocolDateValue.TabIndex = 4;
            this.ProtocolDateValue.Text = "?";
            // 
            // CustomerNameValue
            // 
            this.CustomerNameValue.AutoSize = true;
            this.CustomerNameValue.Location = new System.Drawing.Point(74, 25);
            this.CustomerNameValue.Name = "CustomerNameValue";
            this.CustomerNameValue.Size = new System.Drawing.Size(13, 13);
            this.CustomerNameValue.TabIndex = 6;
            this.CustomerNameValue.Text = "?";
            // 
            // CustomerAddressValue
            // 
            this.CustomerAddressValue.AutoSize = true;
            this.CustomerAddressValue.Location = new System.Drawing.Point(74, 50);
            this.CustomerAddressValue.Name = "CustomerAddressValue";
            this.CustomerAddressValue.Size = new System.Drawing.Size(13, 13);
            this.CustomerAddressValue.TabIndex = 7;
            this.CustomerAddressValue.Text = "?";
            // 
            // CustomerPSCValue
            // 
            this.CustomerPSCValue.AutoSize = true;
            this.CustomerPSCValue.Location = new System.Drawing.Point(64, 76);
            this.CustomerPSCValue.Name = "CustomerPSCValue";
            this.CustomerPSCValue.Size = new System.Drawing.Size(13, 13);
            this.CustomerPSCValue.TabIndex = 8;
            this.CustomerPSCValue.Text = "?";
            // 
            // CustomerICValue
            // 
            this.CustomerICValue.AutoSize = true;
            this.CustomerICValue.Location = new System.Drawing.Point(53, 100);
            this.CustomerICValue.Name = "CustomerICValue";
            this.CustomerICValue.Size = new System.Drawing.Size(13, 13);
            this.CustomerICValue.TabIndex = 9;
            this.CustomerICValue.Text = "?";
            // 
            // DeviceManufacturerValue
            // 
            this.DeviceManufacturerValue.AutoSize = true;
            this.DeviceManufacturerValue.Location = new System.Drawing.Point(82, 25);
            this.DeviceManufacturerValue.Name = "DeviceManufacturerValue";
            this.DeviceManufacturerValue.Size = new System.Drawing.Size(13, 13);
            this.DeviceManufacturerValue.TabIndex = 9;
            this.DeviceManufacturerValue.Text = "?";
            // 
            // DeviceModelValue
            // 
            this.DeviceModelValue.AutoSize = true;
            this.DeviceModelValue.Location = new System.Drawing.Point(72, 50);
            this.DeviceModelValue.Name = "DeviceModelValue";
            this.DeviceModelValue.Size = new System.Drawing.Size(13, 13);
            this.DeviceModelValue.TabIndex = 10;
            this.DeviceModelValue.Text = "?";
            // 
            // DeviceNumberValue
            // 
            this.DeviceNumberValue.AutoSize = true;
            this.DeviceNumberValue.Location = new System.Drawing.Point(106, 76);
            this.DeviceNumberValue.Name = "DeviceNumberValue";
            this.DeviceNumberValue.Size = new System.Drawing.Size(13, 13);
            this.DeviceNumberValue.TabIndex = 11;
            this.DeviceNumberValue.Text = "?";
            // 
            // colParameter
            // 
            this.colParameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colParameter.DataPropertyName = "Parameter";
            this.colParameter.HeaderText = "Parametr";
            this.colParameter.Name = "colParameter";
            this.colParameter.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.DataPropertyName = "Value";
            this.colValue.HeaderText = "Naměřená hodnota";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "Jednotka";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colSuits
            // 
            this.colSuits.DataPropertyName = "Suits";
            this.colSuits.HeaderText = "Vyhovuje";
            this.colSuits.Name = "colSuits";
            this.colSuits.ReadOnly = true;
            // 
            // ServisProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 558);
            this.Controls.Add(this.ExportProtocolButton);
            this.Controls.Add(this.ViewProtocolButton);
            this.Controls.Add(this.LoadProtocolButton);
            this.Controls.Add(this.SaveProtocolButton);
            this.Controls.Add(this.MeasurmentGroupBox);
            this.Controls.Add(this.DeviceGroupBox);
            this.Controls.Add(this.CustomerGroupBox);
            this.Controls.Add(this.DefaultInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServisProtocolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servisní Protokol";
            this.DefaultInfoGroupBox.ResumeLayout(false);
            this.DefaultInfoGroupBox.PerformLayout();
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.DeviceGroupBox.ResumeLayout(false);
            this.DeviceGroupBox.PerformLayout();
            this.MeasurmentGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DefaultInfoGroupBox;
        private System.Windows.Forms.Label ProtocolNumberLabel;
        private System.Windows.Forms.Button EditDefualtInfoButton;
        private System.Windows.Forms.Label ProtocolDateLabel;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.Label CustomerICLabel;
        private System.Windows.Forms.Label CustomerPSCLabel;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.GroupBox DeviceGroupBox;
        private System.Windows.Forms.Button EditDeviceButton;
        private System.Windows.Forms.Label DeviceNumberLabel;
        private System.Windows.Forms.Label DeviceModelLabel;
        private System.Windows.Forms.Label DeviceManufacturerLabel;
        private System.Windows.Forms.GroupBox MeasurmentGroupBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button MeasurmentDeleteButton;
        private System.Windows.Forms.Button MeasurmentEditButton;
        private System.Windows.Forms.Button MeasurmentAddButton;
        private System.Windows.Forms.Button SaveProtocolButton;
        private System.Windows.Forms.Button LoadProtocolButton;
        private System.Windows.Forms.Button ViewProtocolButton;
        private System.Windows.Forms.Button ExportProtocolButton;
        private System.Windows.Forms.Label ProtocolDateValue;
        private System.Windows.Forms.Label ProtocolNumberValue;
        private System.Windows.Forms.Label CustomerICValue;
        private System.Windows.Forms.Label CustomerPSCValue;
        private System.Windows.Forms.Label CustomerAddressValue;
        private System.Windows.Forms.Label CustomerNameValue;
        private System.Windows.Forms.Label DeviceNumberValue;
        private System.Windows.Forms.Label DeviceModelValue;
        private System.Windows.Forms.Label DeviceManufacturerValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuits;
    }
}

