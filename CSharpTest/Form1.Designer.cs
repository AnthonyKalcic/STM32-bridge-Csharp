﻿namespace CSharpTest
{
    partial class Form1
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
            this.btnEnumerate = new System.Windows.Forms.Button();
            this.dgv_stLinks = new System.Windows.Forms.DataGridView();
            this.btn_OpenBridge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnumerate
            // 
            this.btnEnumerate.Location = new System.Drawing.Point(554, 12);
            this.btnEnumerate.Name = "btnEnumerate";
            this.btnEnumerate.Size = new System.Drawing.Size(75, 49);
            this.btnEnumerate.TabIndex = 0;
            this.btnEnumerate.Text = "Enumerate ST-Link devices";
            this.btnEnumerate.UseVisualStyleBackColor = true;
            this.btnEnumerate.Click += new System.EventHandler(this.btnEnumerate_Click);
            // 
            // dgv_stLinks
            // 
            this.dgv_stLinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_stLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stLinks.Location = new System.Drawing.Point(12, 12);
            this.dgv_stLinks.Name = "dgv_stLinks";
            this.dgv_stLinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stLinks.Size = new System.Drawing.Size(536, 169);
            this.dgv_stLinks.TabIndex = 1;
            // 
            // btn_OpenBridge
            // 
            this.btn_OpenBridge.Location = new System.Drawing.Point(555, 68);
            this.btn_OpenBridge.Name = "btn_OpenBridge";
            this.btn_OpenBridge.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenBridge.TabIndex = 2;
            this.btn_OpenBridge.Text = "Open Bridge";
            this.btn_OpenBridge.UseVisualStyleBackColor = true;
            this.btn_OpenBridge.Click += new System.EventHandler(this.btn_OpenBridge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OpenBridge);
            this.Controls.Add(this.dgv_stLinks);
            this.Controls.Add(this.btnEnumerate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stLinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnumerate;
        private System.Windows.Forms.DataGridView dgv_stLinks;
        private System.Windows.Forms.Button btn_OpenBridge;
    }
}

