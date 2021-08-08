﻿
namespace Replacer
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Delete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputDelete = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.TabPage();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInputReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxChanges = new System.Windows.Forms.ListBox();
            this.textBoxShowPath = new System.Windows.Forms.TextBox();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Delete.SuspendLayout();
            this.Replace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.Delete);
            this.tabControl.Controls.Add(this.Replace);
            this.tabControl.Location = new System.Drawing.Point(19, 45);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(426, 403);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.textBoxInputReplace_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.AliceBlue;
            this.Delete.Controls.Add(this.buttonDelete);
            this.Delete.Controls.Add(this.label2);
            this.Delete.Controls.Add(this.textBoxInputDelete);
            this.Delete.Location = new System.Drawing.Point(4, 27);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Size = new System.Drawing.Size(418, 372);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Удаление";
            this.Delete.ToolTipText = "Удаление введенных слов, словосочетаний, ссылок во всех тхт, что есть в папке.";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(337, 334);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите слова/словосочетания/ссылки(через запятую):";
            // 
            // textBoxInputDelete
            // 
            this.textBoxInputDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputDelete.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInputDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputDelete.Location = new System.Drawing.Point(4, 27);
            this.textBoxInputDelete.Multiline = true;
            this.textBoxInputDelete.Name = "textBoxInputDelete";
            this.textBoxInputDelete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputDelete.Size = new System.Drawing.Size(409, 301);
            this.textBoxInputDelete.TabIndex = 0;
            // 
            // Replace
            // 
            this.Replace.BackColor = System.Drawing.Color.AliceBlue;
            this.Replace.Controls.Add(this.buttonReplace);
            this.Replace.Controls.Add(this.label3);
            this.Replace.Controls.Add(this.textBoxInputReplace);
            this.Replace.Location = new System.Drawing.Point(4, 27);
            this.Replace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Replace.Name = "Replace";
            this.Replace.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Replace.Size = new System.Drawing.Size(418, 372);
            this.Replace.TabIndex = 1;
            this.Replace.Text = "Замена";
            this.Replace.ToolTipText = "Замена, ввести одно слово\\словосочетание и на что заменить, так же во всех файлах" +
    " тхт, что есть в папке.";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.AutoSize = true;
            this.buttonReplace.BackColor = System.Drawing.Color.White;
            this.buttonReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.buttonReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Location = new System.Drawing.Point(329, 334);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(84, 30);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите слова/словосочетания/ссылки(через запятую):";
            // 
            // textBoxInputReplace
            // 
            this.textBoxInputReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputReplace.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInputReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputReplace.Location = new System.Drawing.Point(4, 27);
            this.textBoxInputReplace.Multiline = true;
            this.textBoxInputReplace.Name = "textBoxInputReplace";
            this.textBoxInputReplace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputReplace.Size = new System.Drawing.Size(409, 301);
            this.textBoxInputReplace.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Изменения в файлах:";
            // 
            // listBoxChanges
            // 
            this.listBoxChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxChanges.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxChanges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxChanges.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChanges.FormattingEnabled = true;
            this.listBoxChanges.HorizontalScrollbar = true;
            this.listBoxChanges.ItemHeight = 15;
            this.listBoxChanges.Location = new System.Drawing.Point(448, 99);
            this.listBoxChanges.Name = "listBoxChanges";
            this.listBoxChanges.ScrollAlwaysVisible = true;
            this.listBoxChanges.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxChanges.Size = new System.Drawing.Size(286, 345);
            this.listBoxChanges.Sorted = true;
            this.listBoxChanges.TabIndex = 3;
            // 
            // textBoxShowPath
            // 
            this.textBoxShowPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShowPath.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxShowPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxShowPath.Location = new System.Drawing.Point(123, 12);
            this.textBoxShowPath.Name = "textBoxShowPath";
            this.textBoxShowPath.ReadOnly = true;
            this.textBoxShowPath.Size = new System.Drawing.Size(517, 25);
            this.textBoxShowPath.TabIndex = 1;
            this.textBoxShowPath.TextChanged += new System.EventHandler(this.textBoxShowPath_TextChanged);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowser.BackColor = System.Drawing.Color.White;
            this.buttonBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowser.Location = new System.Drawing.Point(646, 12);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(75, 25);
            this.buttonBrowser.TabIndex = 2;
            this.buttonBrowser.Text = "...";
            this.buttonBrowser.UseVisualStyleBackColor = false;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь к папке:";
            // 
            // labelExample
            // 
            this.labelExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExample.Location = new System.Drawing.Point(15, 453);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(430, 22);
            this.labelExample.TabIndex = 5;
            this.labelExample.Text = "Пример: слово1,слово2,слово3,слово4,слово5";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxChanges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.textBoxShowPath);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacer";
            this.tabControl.ResumeLayout(false);
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            this.Replace.ResumeLayout(false);
            this.Replace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.TabPage Replace;
        private System.Windows.Forms.TextBox textBoxShowPath;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.TextBox textBoxInputDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputReplace;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label labelExample;
    }
}

