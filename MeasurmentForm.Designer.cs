namespace Servis_Protocol
{
    partial class MeasurmentForm
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
            this.ParameterLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.SuitsLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.ParameterTextBox = new System.Windows.Forms.TextBox();
            this.SuitsCheckBox = new System.Windows.Forms.CheckBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ParameterLabel
            // 
            this.ParameterLabel.AutoSize = true;
            this.ParameterLabel.Location = new System.Drawing.Point(22, 12);
            this.ParameterLabel.Name = "ParameterLabel";
            this.ParameterLabel.Size = new System.Drawing.Size(52, 13);
            this.ParameterLabel.TabIndex = 0;
            this.ParameterLabel.Text = "Parametr:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(22, 40);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(104, 13);
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "Naměřená Hodnota:";
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(22, 68);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(54, 13);
            this.UnitLabel.TabIndex = 2;
            this.UnitLabel.Text = "Jednotka:";
            // 
            // SuitsLabel
            // 
            this.SuitsLabel.AutoSize = true;
            this.SuitsLabel.Location = new System.Drawing.Point(22, 92);
            this.SuitsLabel.Name = "SuitsLabel";
            this.SuitsLabel.Size = new System.Drawing.Size(54, 13);
            this.SuitsLabel.TabIndex = 3;
            this.SuitsLabel.Text = "Vyhovuje:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(133, 40);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(238, 20);
            this.ValueTextBox.TabIndex = 4;
            this.ValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValueTextBox_Validating);
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(133, 66);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(238, 20);
            this.UnitTextBox.TabIndex = 5;
            this.UnitTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Empty_Validating);
            // 
            // ParameterTextBox
            // 
            this.ParameterTextBox.Location = new System.Drawing.Point(133, 14);
            this.ParameterTextBox.Name = "ParameterTextBox";
            this.ParameterTextBox.Size = new System.Drawing.Size(238, 20);
            this.ParameterTextBox.TabIndex = 6;
            this.ParameterTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Empty_Validating);
            // 
            // SuitsCheckBox
            // 
            this.SuitsCheckBox.AutoSize = true;
            this.SuitsCheckBox.Location = new System.Drawing.Point(133, 92);
            this.SuitsCheckBox.Name = "SuitsCheckBox";
            this.SuitsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SuitsCheckBox.TabIndex = 7;
            this.SuitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(215, 118);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(296, 118);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // MeasurmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 153);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SuitsCheckBox);
            this.Controls.Add(this.ParameterTextBox);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.SuitsLabel);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ParameterLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeasurmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MeasurmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParameterLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Label SuitsLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.TextBox ParameterTextBox;
        private System.Windows.Forms.CheckBox SuitsCheckBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}