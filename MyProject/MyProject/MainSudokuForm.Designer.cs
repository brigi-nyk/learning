namespace MyProject
{
    partial class MainSudokuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSudokuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSudoku = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomMidle = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeftBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightMidle = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMidle = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeftMidle = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTopRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTopMidle = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelSudoku.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.retroToolStripMenuItem,
            this.automaticToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // retroToolStripMenuItem
            // 
            this.retroToolStripMenuItem.Name = "retroToolStripMenuItem";
            this.retroToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.retroToolStripMenuItem.Text = "Retro";
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            this.automaticToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.automaticToolStripMenuItem.Text = "Automatic";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // legendToolStripMenuItem
            // 
            this.legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.legendToolStripMenuItem.Text = "Legend";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanelSudoku);
            this.panel1.Location = new System.Drawing.Point(1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 472);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanelSudoku
            // 
            this.tableLayoutPanelSudoku.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelSudoku.ColumnCount = 3;
            this.tableLayoutPanelSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanelSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelRightBottom, 2, 2);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelBottomMidle, 1, 2);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelLeftBottom, 0, 2);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelRightMidle, 2, 1);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelMidle, 1, 1);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelLeftMidle, 0, 1);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelTopRight, 2, 0);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelTopMidle, 1, 0);
            this.tableLayoutPanelSudoku.Controls.Add(this.tableLayoutPanelLeftTop, 0, 0);
            this.tableLayoutPanelSudoku.Location = new System.Drawing.Point(22, 16);
            this.tableLayoutPanelSudoku.Name = "tableLayoutPanelSudoku";
            this.tableLayoutPanelSudoku.RowCount = 3;
            this.tableLayoutPanelSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanelSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanelSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanelSudoku.Size = new System.Drawing.Size(399, 399);
            this.tableLayoutPanelSudoku.TabIndex = 0;
            // 
            // tableLayoutPanelRightBottom
            // 
            this.tableLayoutPanelRightBottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelRightBottom.ColumnCount = 3;
            this.tableLayoutPanelRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelRightBottom.Location = new System.Drawing.Point(270, 270);
            this.tableLayoutPanelRightBottom.Name = "tableLayoutPanelRightBottom";
            this.tableLayoutPanelRightBottom.RowCount = 3;
            this.tableLayoutPanelRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightBottom.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelRightBottom.TabIndex = 8;
            // 
            // tableLayoutPanelBottomMidle
            // 
            this.tableLayoutPanelBottomMidle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelBottomMidle.ColumnCount = 3;
            this.tableLayoutPanelBottomMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelBottomMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelBottomMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelBottomMidle.Location = new System.Drawing.Point(137, 270);
            this.tableLayoutPanelBottomMidle.Name = "tableLayoutPanelBottomMidle";
            this.tableLayoutPanelBottomMidle.RowCount = 3;
            this.tableLayoutPanelBottomMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelBottomMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelBottomMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelBottomMidle.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelBottomMidle.TabIndex = 7;
            // 
            // tableLayoutPanelLeftBottom
            // 
            this.tableLayoutPanelLeftBottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLeftBottom.ColumnCount = 3;
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelLeftBottom.Location = new System.Drawing.Point(6, 270);
            this.tableLayoutPanelLeftBottom.Name = "tableLayoutPanelLeftBottom";
            this.tableLayoutPanelLeftBottom.RowCount = 3;
            this.tableLayoutPanelLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftBottom.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelLeftBottom.TabIndex = 6;
            // 
            // tableLayoutPanelRightMidle
            // 
            this.tableLayoutPanelRightMidle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelRightMidle.ColumnCount = 3;
            this.tableLayoutPanelRightMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelRightMidle.Location = new System.Drawing.Point(270, 138);
            this.tableLayoutPanelRightMidle.Name = "tableLayoutPanelRightMidle";
            this.tableLayoutPanelRightMidle.RowCount = 3;
            this.tableLayoutPanelRightMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRightMidle.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelRightMidle.TabIndex = 5;
            // 
            // tableLayoutPanelMidle
            // 
            this.tableLayoutPanelMidle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMidle.ColumnCount = 3;
            this.tableLayoutPanelMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelMidle.Location = new System.Drawing.Point(137, 138);
            this.tableLayoutPanelMidle.Name = "tableLayoutPanelMidle";
            this.tableLayoutPanelMidle.RowCount = 3;
            this.tableLayoutPanelMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMidle.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelMidle.TabIndex = 4;
            // 
            // tableLayoutPanelLeftMidle
            // 
            this.tableLayoutPanelLeftMidle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLeftMidle.ColumnCount = 3;
            this.tableLayoutPanelLeftMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelLeftMidle.Location = new System.Drawing.Point(6, 138);
            this.tableLayoutPanelLeftMidle.Name = "tableLayoutPanelLeftMidle";
            this.tableLayoutPanelLeftMidle.RowCount = 3;
            this.tableLayoutPanelLeftMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftMidle.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelLeftMidle.TabIndex = 3;
            // 
            // tableLayoutPanelTopRight
            // 
            this.tableLayoutPanelTopRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelTopRight.ColumnCount = 3;
            this.tableLayoutPanelTopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelTopRight.Location = new System.Drawing.Point(270, 6);
            this.tableLayoutPanelTopRight.Name = "tableLayoutPanelTopRight";
            this.tableLayoutPanelTopRight.RowCount = 3;
            this.tableLayoutPanelTopRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopRight.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelTopRight.TabIndex = 2;
            // 
            // tableLayoutPanelTopMidle
            // 
            this.tableLayoutPanelTopMidle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelTopMidle.ColumnCount = 3;
            this.tableLayoutPanelTopMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelTopMidle.Location = new System.Drawing.Point(137, 6);
            this.tableLayoutPanelTopMidle.Name = "tableLayoutPanelTopMidle";
            this.tableLayoutPanelTopMidle.RowCount = 3;
            this.tableLayoutPanelTopMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelTopMidle.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelTopMidle.TabIndex = 1;
            // 
            // tableLayoutPanelLeftTop
            // 
            this.tableLayoutPanelLeftTop.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLeftTop.ColumnCount = 3;
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanelLeftTop.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanelLeftTop.Name = "tableLayoutPanelLeftTop";
            this.tableLayoutPanelLeftTop.RowCount = 3;
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftTop.Size = new System.Drawing.Size(121, 121);
            this.tableLayoutPanelLeftTop.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainSudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 519);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainSudokuForm";
            this.Text = "SUDOKU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelSudoku.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSudoku;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomMidle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightMidle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMidle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftMidle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopMidle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftTop;
    }
}

