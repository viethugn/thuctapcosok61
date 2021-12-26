
namespace BinaryTree_TTCS
{
    partial class frmBinaryTree
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
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.grbCongCu = new System.Windows.Forms.GroupBox();
            this.btnPostOrderTraverse = new System.Windows.Forms.Button();
            this.btnPreOrderTraverse = new System.Windows.Forms.Button();
            this.btnInOrderTraverse = new System.Windows.Forms.Button();
            this.bR_TreePanel1 = new BinaryTree_TTCS.BR_TreePanel();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.grbCongCu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGenerateTree.Location = new System.Drawing.Point(56, 198);
            this.btnGenerateTree.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(229, 61);
            this.btnGenerateTree.TabIndex = 1;
            this.btnGenerateTree.Text = "Generate Random Tree";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max Size";
            // 
            // numMax
            // 
            this.numMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numMax.Location = new System.Drawing.Point(177, 136);
            this.numMax.Margin = new System.Windows.Forms.Padding(4);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(119, 30);
            this.numMax.TabIndex = 2;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMin
            // 
            this.numMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numMin.Location = new System.Drawing.Point(177, 83);
            this.numMin.Margin = new System.Windows.Forms.Padding(4);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(119, 30);
            this.numMin.TabIndex = 3;
            // 
            // numSize
            // 
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numSize.Location = new System.Drawing.Point(177, 33);
            this.numSize.Margin = new System.Windows.Forms.Padding(4);
            this.numSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(119, 30);
            this.numSize.TabIndex = 4;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // grbCongCu
            // 
            this.grbCongCu.Controls.Add(this.btnPostOrderTraverse);
            this.grbCongCu.Controls.Add(this.btnPreOrderTraverse);
            this.grbCongCu.Controls.Add(this.btnInOrderTraverse);
            this.grbCongCu.Controls.Add(this.btnGenerateTree);
            this.grbCongCu.Controls.Add(this.label1);
            this.grbCongCu.Controls.Add(this.label2);
            this.grbCongCu.Controls.Add(this.label3);
            this.grbCongCu.Controls.Add(this.numSize);
            this.grbCongCu.Controls.Add(this.numMin);
            this.grbCongCu.Controls.Add(this.numMax);
            this.grbCongCu.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCongCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbCongCu.Location = new System.Drawing.Point(956, 0);
            this.grbCongCu.Name = "grbCongCu";
            this.grbCongCu.Size = new System.Drawing.Size(321, 643);
            this.grbCongCu.TabIndex = 8;
            this.grbCongCu.TabStop = false;
            this.grbCongCu.Text = "Công cụ";
            // 
            // btnPostOrderTraverse
            // 
            this.btnPostOrderTraverse.Location = new System.Drawing.Point(56, 545);
            this.btnPostOrderTraverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostOrderTraverse.Name = "btnPostOrderTraverse";
            this.btnPostOrderTraverse.Size = new System.Drawing.Size(229, 61);
            this.btnPostOrderTraverse.TabIndex = 8;
            this.btnPostOrderTraverse.Text = "Post-Order (LRN)";
            this.btnPostOrderTraverse.UseVisualStyleBackColor = true;
            this.btnPostOrderTraverse.Click += new System.EventHandler(this.btnPostOrderTraverse_Click);
            // 
            // btnPreOrderTraverse
            // 
            this.btnPreOrderTraverse.Location = new System.Drawing.Point(56, 480);
            this.btnPreOrderTraverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreOrderTraverse.Name = "btnPreOrderTraverse";
            this.btnPreOrderTraverse.Size = new System.Drawing.Size(229, 61);
            this.btnPreOrderTraverse.TabIndex = 9;
            this.btnPreOrderTraverse.Text = "Pre-Order (NLR)";
            this.btnPreOrderTraverse.UseVisualStyleBackColor = true;
            this.btnPreOrderTraverse.Click += new System.EventHandler(this.btnPreOrderTraverse_Click);
            // 
            // btnInOrderTraverse
            // 
            this.btnInOrderTraverse.Location = new System.Drawing.Point(56, 415);
            this.btnInOrderTraverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnInOrderTraverse.Name = "btnInOrderTraverse";
            this.btnInOrderTraverse.Size = new System.Drawing.Size(229, 61);
            this.btnInOrderTraverse.TabIndex = 10;
            this.btnInOrderTraverse.Text = "In-Order (LNR)";
            this.btnInOrderTraverse.UseVisualStyleBackColor = true;
            this.btnInOrderTraverse.Click += new System.EventHandler(this.btnInOrderTraverse_Click);
            // 
            // bR_TreePanel1
            // 
            this.bR_TreePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bR_TreePanel1.AutoScroll = true;
            this.bR_TreePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bR_TreePanel1.Location = new System.Drawing.Point(26, 28);
            this.bR_TreePanel1.Name = "bR_TreePanel1";
            this.bR_TreePanel1.Size = new System.Drawing.Size(910, 578);
            this.bR_TreePanel1.TabIndex = 0;
            // 
            // frmBinaryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 643);
            this.Controls.Add(this.grbCongCu);
            this.Controls.Add(this.bR_TreePanel1);
            this.Name = "frmBinaryTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng cây nhị phân";
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.grbCongCu.ResumeLayout(false);
            this.grbCongCu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateTree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.GroupBox grbCongCu;
        private System.Windows.Forms.Button btnPostOrderTraverse;
        private System.Windows.Forms.Button btnPreOrderTraverse;
        private System.Windows.Forms.Button btnInOrderTraverse;
        private BR_TreePanel bR_TreePanel1;
    }
}

