namespace ChesscapeProject
{
    partial class Menu
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
            this.lbTestSquare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTestBoardInit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTestSquare
            // 
            this.lbTestSquare.AutoSize = true;
            this.lbTestSquare.Location = new System.Drawing.Point(301, 78);
            this.lbTestSquare.Name = "lbTestSquare";
            this.lbTestSquare.Size = new System.Drawing.Size(70, 13);
            this.lbTestSquare.TabIndex = 0;
            this.lbTestSquare.Text = "lbTestSquare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lbTestBoardInit
            // 
            this.lbTestBoardInit.AutoSize = true;
            this.lbTestBoardInit.Location = new System.Drawing.Point(301, 110);
            this.lbTestBoardInit.Name = "lbTestBoardInit";
            this.lbTestBoardInit.Size = new System.Drawing.Size(35, 13);
            this.lbTestBoardInit.TabIndex = 2;
            this.lbTestBoardInit.Text = "label3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTestBoardInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTestSquare);
            this.Name = "Menu";
            this.Text = "Chesscape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTestSquare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTestBoardInit;
    }
}

