
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
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxInputOld = new System.Windows.Forms.TextBox();
            this.textBoxShowPath = new System.Windows.Forms.TextBox();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputNew = new System.Windows.Forms.TextBox();
            this.labelDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReplace
            // 
            this.buttonReplace.AutoSize = true;
            this.buttonReplace.BackColor = System.Drawing.Color.White;
            this.buttonReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(204)))));
            this.buttonReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReplace.Location = new System.Drawing.Point(387, 37);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 27);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxInputOld
            // 
            this.textBoxInputOld.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInputOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputOld.Location = new System.Drawing.Point(48, 40);
            this.textBoxInputOld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInputOld.Name = "textBoxInputOld";
            this.textBoxInputOld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputOld.Size = new System.Drawing.Size(331, 23);
            this.textBoxInputOld.TabIndex = 2;
            this.textBoxInputOld.TextChanged += new System.EventHandler(this.textBoxInputOld_TextChanged);
            // 
            // textBoxShowPath
            // 
            this.textBoxShowPath.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxShowPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxShowPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxShowPath.Location = new System.Drawing.Point(10, 10);
            this.textBoxShowPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShowPath.Name = "textBoxShowPath";
            this.textBoxShowPath.Size = new System.Drawing.Size(369, 23);
            this.textBoxShowPath.TabIndex = 1;
            this.textBoxShowPath.TextChanged += new System.EventHandler(this.textBoxShowPath_TextChanged);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.AutoSize = true;
            this.buttonBrowser.BackColor = System.Drawing.Color.White;
            this.buttonBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowser.Font = new System.Drawing.Font("Forte", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowser.Location = new System.Drawing.Point(387, 8);
            this.buttonBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(75, 26);
            this.buttonBrowser.TabIndex = 0;
            this.buttonBrowser.Text = "Обзор";
            this.buttonBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBrowser.UseVisualStyleBackColor = false;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Что:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Чем:";
            // 
            // textBoxInputNew
            // 
            this.textBoxInputNew.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInputNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputNew.Location = new System.Drawing.Point(48, 71);
            this.textBoxInputNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInputNew.Name = "textBoxInputNew";
            this.textBoxInputNew.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputNew.Size = new System.Drawing.Size(331, 23);
            this.textBoxInputNew.TabIndex = 3;
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Location = new System.Drawing.Point(400, 75);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(49, 15);
            this.labelDone.TabIndex = 7;
            this.labelDone.Text = "Готово";
            this.labelDone.Visible = false;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(471, 100);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.textBoxInputNew);
            this.Controls.Add(this.textBoxInputOld);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.textBoxShowPath);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxShowPath;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.TextBox textBoxInputOld;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputNew;
        private System.Windows.Forms.Label labelDone;
    }
}

