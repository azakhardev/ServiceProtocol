namespace Servis_Protocol
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PSCLabel = new System.Windows.Forms.Label();
            this.ICLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PSCTextBox = new System.Windows.Forms.TextBox();
            this.ICTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(18, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Název:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(18, 44);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(43, 13);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Adresa:";
            // 
            // PSCLabel
            // 
            this.PSCLabel.AutoSize = true;
            this.PSCLabel.Location = new System.Drawing.Point(18, 71);
            this.PSCLabel.Name = "PSCLabel";
            this.PSCLabel.Size = new System.Drawing.Size(31, 13);
            this.PSCLabel.TabIndex = 2;
            this.PSCLabel.Text = "PSČ:";
            // 
            // ICLabel
            // 
            this.ICLabel.AutoSize = true;
            this.ICLabel.Location = new System.Drawing.Point(18, 100);
            this.ICLabel.Name = "ICLabel";
            this.ICLabel.Size = new System.Drawing.Size(20, 13);
            this.ICLabel.TabIndex = 3;
            this.ICLabel.Text = "IČ:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(208, 138);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(289, 138);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(298, 20);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Empty_Validating);
            this.NameTextBox.Validated += new System.EventHandler(this.Control_Validated);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(66, 41);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(298, 20);
            this.AddressTextBox.TabIndex = 7;
            this.AddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Empty_Validating);
            this.AddressTextBox.Validated += new System.EventHandler(this.Control_Validated);
            // 
            // PSCTextBox
            // 
            this.PSCTextBox.Location = new System.Drawing.Point(66, 67);
            this.PSCTextBox.Name = "PSCTextBox";
            this.PSCTextBox.Size = new System.Drawing.Size(298, 20);
            this.PSCTextBox.TabIndex = 8;
            this.PSCTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PSCTextBox_Validating);
            this.PSCTextBox.Validated += new System.EventHandler(this.Control_Validated);
            // 
            // ICTextBox
            // 
            this.ICTextBox.Location = new System.Drawing.Point(66, 93);
            this.ICTextBox.Name = "ICTextBox";
            this.ICTextBox.Size = new System.Drawing.Size(298, 20);
            this.ICTextBox.TabIndex = 9;
            this.ICTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ICTextBox_Validating);
            this.ICTextBox.Validated += new System.EventHandler(this.Control_Validated);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 173);
            this.Controls.Add(this.ICTextBox);
            this.Controls.Add(this.PSCTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ICLabel);
            this.Controls.Add(this.PSCLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zákazník";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PSCLabel;
        private System.Windows.Forms.Label ICLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PSCTextBox;
        private System.Windows.Forms.TextBox ICTextBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}