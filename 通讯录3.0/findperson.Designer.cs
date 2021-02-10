namespace 通讯录3._0
{
    partial class findperson
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textInPut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(81, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "请输入姓名或电话号码：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textInPut
            // 
            this.textInPut.Location = new System.Drawing.Point(190, 217);
            this.textInPut.Multiline = true;
            this.textInPut.Name = "textInPut";
            this.textInPut.Size = new System.Drawing.Size(409, 32);
            this.textInPut.TabIndex = 5;
            this.textInPut.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "查找哪位联系人？";
            // 
            // findperson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textInPut);
            this.Controls.Add(this.label1);
            this.Name = "findperson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找联系人";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textInPut;
        private System.Windows.Forms.Label label1;
    }
}