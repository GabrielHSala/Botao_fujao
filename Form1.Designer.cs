namespace Botao_fujao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRejeitar = new Button();
            btnAceitar = new Button();
            SuspendLayout();
            // 
            // btnRejeitar
            // 
            btnRejeitar.BackColor = Color.FromArgb(192, 0, 0);
            btnRejeitar.Cursor = Cursors.Hand;
            btnRejeitar.FlatStyle = FlatStyle.Popup;
            btnRejeitar.ForeColor = Color.White;
            btnRejeitar.Location = new Point(177, 158);
            btnRejeitar.Name = "btnRejeitar";
            btnRejeitar.Size = new Size(177, 119);
            btnRejeitar.TabIndex = 1;
            btnRejeitar.Text = "NÃO";
            btnRejeitar.UseVisualStyleBackColor = false;
            btnRejeitar.MouseEnter += btnRejeitar_MouseEnter;
            // 
            // btnAceitar
            // 
            btnAceitar.BackColor = Color.Lime;
            btnAceitar.Cursor = Cursors.Hand;
            btnAceitar.FlatStyle = FlatStyle.Popup;
            btnAceitar.ForeColor = Color.White;
            btnAceitar.Location = new Point(464, 158);
            btnAceitar.Name = "btnAceitar";
            btnAceitar.Size = new Size(93, 54);
            btnAceitar.TabIndex = 2;
            btnAceitar.Text = "SIM";
            btnAceitar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Controls.Add(btnAceitar);
            Controls.Add(btnRejeitar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRejeitar;
        private Button btnAceitar;
    }
}