namespace Lab2
{
    partial class FormSelect
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.LabelGitElect = new System.Windows.Forms.Label();
            this.LabelGit = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelFray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.LabelDopColor = new System.Windows.Forms.Label();
            this.LabelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxGit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.panelGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.LabelGitElect);
            this.groupBox.Controls.Add(this.LabelGit);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(18, 13);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(190, 126);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Тип";
            // 
            // LabelGitElect
            // 
            this.LabelGitElect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelGitElect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGitElect.Location = new System.Drawing.Point(26, 65);
            this.LabelGitElect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGitElect.Name = "LabelGitElect";
            this.LabelGitElect.Size = new System.Drawing.Size(134, 34);
            this.LabelGitElect.TabIndex = 1;
            this.LabelGitElect.Text = "Электрогитара";
            this.LabelGitElect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelGitElect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGitElect_MouseDown);
            // 
            // LabelGit
            // 
            this.LabelGit.AllowDrop = true;
            this.LabelGit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelGit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGit.Location = new System.Drawing.Point(26, 24);
            this.LabelGit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGit.Name = "LabelGit";
            this.LabelGit.Size = new System.Drawing.Size(134, 33);
            this.LabelGit.TabIndex = 0;
            this.LabelGit.Text = "Гитара";
            this.LabelGit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelGit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGit_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelGold);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Location = new System.Drawing.Point(430, 13);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(120, 244);
            this.groupBoxColors.TabIndex = 2;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(66, 186);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(35, 35);
            this.panelGold.TabIndex = 6;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Controls.Add(this.panelFray);
            this.panelGray.Location = new System.Drawing.Point(16, 186);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(35, 35);
            this.panelGray.TabIndex = 5;
            // 
            // panelFray
            // 
            this.panelFray.BackColor = System.Drawing.Color.Gray;
            this.panelFray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFray.Location = new System.Drawing.Point(-1, -1);
            this.panelFray.Name = "panelFray";
            this.panelFray.Size = new System.Drawing.Size(35, 35);
            this.panelFray.TabIndex = 6;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(66, 134);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(16, 31);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(16, 134);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(66, 82);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(35, 35);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(16, 82);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(35, 35);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(66, 31);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(35, 35);
            this.panelWhite.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(44, 158);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(134, 34);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(44, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // LabelDopColor
            // 
            this.LabelDopColor.AllowDrop = true;
            this.LabelDopColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDopColor.Location = new System.Drawing.Point(19, 284);
            this.LabelDopColor.Name = "LabelDopColor";
            this.LabelDopColor.Size = new System.Drawing.Size(134, 34);
            this.LabelDopColor.TabIndex = 4;
            this.LabelDopColor.Text = " Доп.цвет";
            this.LabelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.LabelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // LabelBaseColor
            // 
            this.LabelBaseColor.AllowDrop = true;
            this.LabelBaseColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelBaseColor.Location = new System.Drawing.Point(19, 234);
            this.LabelBaseColor.Name = "LabelBaseColor";
            this.LabelBaseColor.Size = new System.Drawing.Size(134, 34);
            this.LabelBaseColor.TabIndex = 3;
            this.LabelBaseColor.Text = "Основной цвет";
            this.LabelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.LabelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // pictureBoxGit
            // 
            this.pictureBoxGit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGit.Location = new System.Drawing.Point(19, 9);
            this.pictureBoxGit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGit.Name = "pictureBoxGit";
            this.pictureBoxGit.Size = new System.Drawing.Size(134, 211);
            this.pictureBoxGit.TabIndex = 0;
            this.pictureBoxGit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxGit);
            this.panel1.Controls.Add(this.LabelDopColor);
            this.panel1.Controls.Add(this.LabelBaseColor);
            this.panel1.Location = new System.Drawing.Point(229, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 340);
            this.panel1.TabIndex = 7;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSelect";
            this.Text = "FormSelect";
            this.groupBox.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.panelGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label LabelGitElect;
        private System.Windows.Forms.Label LabelGit;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelFray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label LabelDopColor;
        private System.Windows.Forms.Label LabelBaseColor;
        private System.Windows.Forms.PictureBox pictureBoxGit;
        private System.Windows.Forms.Panel panel1;
    }
}