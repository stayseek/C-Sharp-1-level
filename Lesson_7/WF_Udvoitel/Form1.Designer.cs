namespace WF_Udvoitel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulty = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumText = new System.Windows.Forms.Label();
            this.lblCurNumText = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurNumber = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStepsText = new System.Windows.Forms.Label();
            this.lblCurSteps = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(217, 27);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulty
            // 
            this.btnMulty.Location = new System.Drawing.Point(217, 57);
            this.btnMulty.Name = "btnMulty";
            this.btnMulty.Size = new System.Drawing.Size(75, 23);
            this.btnMulty.TabIndex = 2;
            this.btnMulty.Text = "x2";
            this.btnMulty.UseVisualStyleBackColor = true;
            this.btnMulty.Click += new System.EventHandler(this.btnMulty_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(217, 87);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(217, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumText
            // 
            this.lblNumText.AutoSize = true;
            this.lblNumText.Location = new System.Drawing.Point(12, 37);
            this.lblNumText.Name = "lblNumText";
            this.lblNumText.Size = new System.Drawing.Size(108, 13);
            this.lblNumText.TabIndex = 5;
            this.lblNumText.Text = "Необходимое число";
            // 
            // lblCurNumText
            // 
            this.lblCurNumText.AutoSize = true;
            this.lblCurNumText.Location = new System.Drawing.Point(12, 67);
            this.lblCurNumText.Name = "lblCurNumText";
            this.lblCurNumText.Size = new System.Drawing.Size(66, 13);
            this.lblCurNumText.TabIndex = 6;
            this.lblCurNumText.Text = "Ваше число";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(139, 37);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "label3";
            // 
            // lblCurNumber
            // 
            this.lblCurNumber.AutoSize = true;
            this.lblCurNumber.Location = new System.Drawing.Point(139, 67);
            this.lblCurNumber.Name = "lblCurNumber";
            this.lblCurNumber.Size = new System.Drawing.Size(35, 13);
            this.lblCurNumber.TabIndex = 8;
            this.lblCurNumber.Text = "label4";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblStepsText
            // 
            this.lblStepsText.AutoSize = true;
            this.lblStepsText.Location = new System.Drawing.Point(12, 97);
            this.lblStepsText.Name = "lblStepsText";
            this.lblStepsText.Size = new System.Drawing.Size(82, 13);
            this.lblStepsText.TabIndex = 9;
            this.lblStepsText.Text = "Сделано ходов";
            // 
            // lblCurSteps
            // 
            this.lblCurSteps.AutoSize = true;
            this.lblCurSteps.Location = new System.Drawing.Point(139, 97);
            this.lblCurSteps.Name = "lblCurSteps";
            this.lblCurSteps.Size = new System.Drawing.Size(35, 13);
            this.lblCurSteps.TabIndex = 10;
            this.lblCurSteps.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.lblCurSteps);
            this.Controls.Add(this.lblStepsText);
            this.Controls.Add(this.lblCurNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCurNumText);
            this.Controls.Add(this.lblNumText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnMulty);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Удвоитель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulty;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumText;
        private System.Windows.Forms.Label lblCurNumText;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurNumber;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblStepsText;
        private System.Windows.Forms.Label lblCurSteps;
    }
}

