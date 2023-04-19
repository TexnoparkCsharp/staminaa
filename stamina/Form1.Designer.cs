namespace stamina
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.baslawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qisqaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.waqit = new System.Windows.Forms.Timer(this.components);
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.eki = new System.Windows.Forms.Label();
            this.bir = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1027, 96);
            this.button1.TabIndex = 0;
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // baslawToolStripMenuItem
            // 
            this.baslawToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.baslawToolStripMenuItem.Name = "baslawToolStripMenuItem";
            this.baslawToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.baslawToolStripMenuItem.Text = "Baslaw";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanlarToolStripMenuItem,
            this.uzinToolStripMenuItem,
            this.qisqaToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modeToolStripMenuItem.Text = "Jaziw turi";
            // 
            // sanlarToolStripMenuItem
            // 
            this.sanlarToolStripMenuItem.Name = "sanlarToolStripMenuItem";
            this.sanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sanlarToolStripMenuItem.Text = "Sanlar";
            this.sanlarToolStripMenuItem.Click += new System.EventHandler(this.sanlarToolStripMenuItem_Click);
            // 
            // uzinToolStripMenuItem
            // 
            this.uzinToolStripMenuItem.Name = "uzinToolStripMenuItem";
            this.uzinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uzinToolStripMenuItem.Text = "Uzin";
            this.uzinToolStripMenuItem.Click += new System.EventHandler(this.uzinToolStripMenuItem_Click);
            // 
            // qisqaToolStripMenuItem
            // 
            this.qisqaToolStripMenuItem.Name = "qisqaToolStripMenuItem";
            this.qisqaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qisqaToolStripMenuItem.Text = "Qisqa";
            this.qisqaToolStripMenuItem.Click += new System.EventHandler(this.qisqaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baslawToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // waqit
            // 
            this.waqit.Interval = 1000;
            this.waqit.Tick += new System.EventHandler(this.waqit_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(471, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00";
            // 
            // eki
            // 
            this.eki.BackColor = System.Drawing.SystemColors.Highlight;
            this.eki.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eki.Location = new System.Drawing.Point(23, 254);
            this.eki.Name = "eki";
            this.eki.Size = new System.Drawing.Size(500, 70);
            this.eki.TabIndex = 5;
            this.eki.Text = "Space start";
            this.eki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bir
            // 
            this.bir.BackColor = System.Drawing.SystemColors.Highlight;
            this.bir.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bir.Location = new System.Drawing.Point(529, 254);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(500, 70);
            this.bir.TabIndex = 6;
            this.bir.Text = "Esc stop";
            this.bir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1067, 510);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.eki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.ToolStripMenuItem baslawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanlarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uzinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qisqaToolStripMenuItem;
        private System.Windows.Forms.Timer waqit;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private System.Windows.Forms.Label eki;
        private System.Windows.Forms.Label bir;
    }
}

