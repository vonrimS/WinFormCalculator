
namespace SimpleCalculator
{
    partial class MenuForm
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
            this.AboutCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор";
            // 
            // AboutCheckBox
            // 
            this.AboutCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AboutCheckBox.AutoSize = true;
            this.AboutCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.AboutCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.AboutCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AboutCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AboutCheckBox.Location = new System.Drawing.Point(40, 393);
            this.AboutCheckBox.Name = "AboutCheckBox";
            this.AboutCheckBox.Size = new System.Drawing.Size(139, 30);
            this.AboutCheckBox.TabIndex = 20;
            this.AboutCheckBox.Text = "О программе";
            this.AboutCheckBox.UseVisualStyleBackColor = true;
            this.AboutCheckBox.Click += new System.EventHandler(this.AboutCheckBox_Click);
            this.AboutCheckBox.MouseLeave += new System.EventHandler(this.AboutCheckBox_MouseLeave);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(40, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 30);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Обычный";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox3.Location = new System.Drawing.Point(40, 178);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 30);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "Расширенный";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(252, 440);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.AboutCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Opacity = 0.99D;
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AboutCheckBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}