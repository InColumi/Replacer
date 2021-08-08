
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Delete = new System.Windows.Forms.TabPage();
            this.Replace = new System.Windows.Forms.TabPage();
            this.textBoxShowPath = new System.Windows.Forms.TextBox();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.textBoxInputDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Delete.SuspendLayout();
            this.Replace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Delete);
            this.tabControl1.Controls.Add(this.Replace);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 458);
            this.tabControl1.TabIndex = 0;
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
            this.Delete.Size = new System.Drawing.Size(712, 427);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Удаление";
            this.Delete.ToolTipText = "Удаление введенных слов, словосочетаний, ссылок во всех тхт, что есть в папке.";
            // 
            // Replace
            // 
            this.Replace.BackColor = System.Drawing.Color.AliceBlue;
            this.Replace.Controls.Add(this.label3);
            this.Replace.Controls.Add(this.textBox2);
            this.Replace.Location = new System.Drawing.Point(4, 27);
            this.Replace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Replace.Name = "Replace";
            this.Replace.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Replace.Size = new System.Drawing.Size(705, 387);
            this.Replace.TabIndex = 1;
            this.Replace.Text = "Замена";
            this.Replace.ToolTipText = "Замена, ввести одно слово\\словосочетание и на что заменить, так же во всех файлах" +
    " тхт, что есть в папке.";
            // 
            // textBoxShowPath
            // 
            this.textBoxShowPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShowPath.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxShowPath.Location = new System.Drawing.Point(123, 12);
            this.textBoxShowPath.Name = "textBoxShowPath";
            this.textBoxShowPath.Size = new System.Drawing.Size(528, 25);
            this.textBoxShowPath.TabIndex = 1;
            this.textBoxShowPath.Text = "C:\\Users\\Admin\\Desktop\\1";
            this.textBoxShowPath.TextChanged += new System.EventHandler(this.textBoxShowPath_TextChanged);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowser.BackColor = System.Drawing.Color.White;
            this.buttonBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowser.Location = new System.Drawing.Point(657, 12);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(75, 25);
            this.buttonBrowser.TabIndex = 2;
            this.buttonBrowser.Text = "...";
            this.buttonBrowser.UseVisualStyleBackColor = false;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // textBoxInputDelete
            // 
            this.textBoxInputDelete.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInputDelete.Location = new System.Drawing.Point(4, 27);
            this.textBoxInputDelete.Multiline = true;
            this.textBoxInputDelete.Name = "textBoxInputDelete";
            this.textBoxInputDelete.Size = new System.Drawing.Size(314, 353);
            this.textBoxInputDelete.TabIndex = 0;
            this.textBoxInputDelete.Text = "Привет, учёба, привет мир";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите слова/словосочетания/ссылки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите слова/словосочетания/ссылки:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(4, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(314, 353);
            this.textBox2.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(629, 389);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(744, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.textBoxShowPath);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacer";
            this.tabControl1.ResumeLayout(false);
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            this.Replace.ResumeLayout(false);
            this.Replace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.TabPage Replace;
        private System.Windows.Forms.TextBox textBoxShowPath;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.TextBox textBoxInputDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDelete;
    }
}

