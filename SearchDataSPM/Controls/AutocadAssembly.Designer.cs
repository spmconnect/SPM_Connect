﻿namespace SearchDataSPM
{
    partial class AutocadAssembly
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutocadAssembly));
            this.LabelTooltips = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Expandchk = new System.Windows.Forms.CheckBox();
            this.Assy_txtbox = new System.Windows.Forms.TextBox();
            this.Descriptiontxtbox = new System.Windows.Forms.TextBox();
            this.oemitemtxtbox = new System.Windows.Forms.TextBox();
            this.oemtxtbox = new System.Windows.Forms.TextBox();
            this.ItemTxtBox = new System.Windows.Forms.TextBox();
            this.qtytxtbox = new System.Windows.Forms.TextBox();
            this.SPM = new System.Windows.Forms.Label();
            this.Editbttn = new System.Windows.Forms.Button();
            this.savebttn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Assy_label = new System.Windows.Forms.Label();
            this.oemlbl = new System.Windows.Forms.Label();
            this.oemitemlbl = new System.Windows.Forms.Label();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.Itemlbl = new System.Windows.Forms.Label();
            this.qtylbl = new System.Windows.Forms.Label();
            this.Addremovecontextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Addremovecontextmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTooltips
            // 
            this.LabelTooltips.AutoPopDelay = 4000;
            this.LabelTooltips.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabelTooltips.InitialDelay = 500;
            this.LabelTooltips.ReshowDelay = 100;
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleName = "";
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 650);
            this.txtSearch.MaximumSize = new System.Drawing.Size(32767, 25);
            this.txtSearch.MinimumSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 25);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.Text = "Search";
            this.LabelTooltips.SetToolTip(this.txtSearch, "Enter Search Keyword");
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // Expandchk
            // 
            this.Expandchk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Expandchk.AutoSize = true;
            this.Expandchk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Expandchk.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expandchk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Expandchk.Location = new System.Drawing.Point(412, 15);
            this.Expandchk.MinimumSize = new System.Drawing.Size(30, 0);
            this.Expandchk.Name = "Expandchk";
            this.Expandchk.Size = new System.Drawing.Size(60, 26);
            this.Expandchk.TabIndex = 31;
            this.Expandchk.Text = "+/-";
            this.LabelTooltips.SetToolTip(this.Expandchk, "Expand/Collapse Tree");
            this.Expandchk.UseVisualStyleBackColor = true;
            this.Expandchk.Click += new System.EventHandler(this.Expandchk_Click);
            // 
            // Assy_txtbox
            // 
            this.Assy_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assy_txtbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Assy_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assy_txtbox.Location = new System.Drawing.Point(130, 16);
            this.Assy_txtbox.MaximumSize = new System.Drawing.Size(120, 25);
            this.Assy_txtbox.MinimumSize = new System.Drawing.Size(110, 25);
            this.Assy_txtbox.Name = "Assy_txtbox";
            this.Assy_txtbox.Size = new System.Drawing.Size(120, 26);
            this.Assy_txtbox.TabIndex = 27;
            this.LabelTooltips.SetToolTip(this.Assy_txtbox, "Enter Assy Item Number");
            this.Assy_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Assy_txtbox_KeyDown);
            this.Assy_txtbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Assy_txtbox_MouseDoubleClick);
            // 
            // Descriptiontxtbox
            // 
            this.Descriptiontxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Descriptiontxtbox.Location = new System.Drawing.Point(589, 214);
            this.Descriptiontxtbox.MaximumSize = new System.Drawing.Size(180, 50);
            this.Descriptiontxtbox.MinimumSize = new System.Drawing.Size(180, 50);
            this.Descriptiontxtbox.Multiline = true;
            this.Descriptiontxtbox.Name = "Descriptiontxtbox";
            this.Descriptiontxtbox.ReadOnly = true;
            this.Descriptiontxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Descriptiontxtbox.Size = new System.Drawing.Size(180, 50);
            this.Descriptiontxtbox.TabIndex = 35;
            this.LabelTooltips.SetToolTip(this.Descriptiontxtbox, "Item Description");
            // 
            // oemitemtxtbox
            // 
            this.oemitemtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oemitemtxtbox.Location = new System.Drawing.Point(589, 350);
            this.oemitemtxtbox.MaximumSize = new System.Drawing.Size(180, 50);
            this.oemitemtxtbox.MinimumSize = new System.Drawing.Size(180, 50);
            this.oemitemtxtbox.Multiline = true;
            this.oemitemtxtbox.Name = "oemitemtxtbox";
            this.oemitemtxtbox.ReadOnly = true;
            this.oemitemtxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oemitemtxtbox.Size = new System.Drawing.Size(180, 50);
            this.oemitemtxtbox.TabIndex = 39;
            this.LabelTooltips.SetToolTip(this.oemitemtxtbox, "Item Manufacturer OEM");
            // 
            // oemtxtbox
            // 
            this.oemtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oemtxtbox.Location = new System.Drawing.Point(589, 281);
            this.oemtxtbox.MaximumSize = new System.Drawing.Size(180, 50);
            this.oemtxtbox.MinimumSize = new System.Drawing.Size(180, 50);
            this.oemtxtbox.Multiline = true;
            this.oemtxtbox.Name = "oemtxtbox";
            this.oemtxtbox.ReadOnly = true;
            this.oemtxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oemtxtbox.Size = new System.Drawing.Size(180, 50);
            this.oemtxtbox.TabIndex = 37;
            this.LabelTooltips.SetToolTip(this.oemtxtbox, "Item Manufacturer");
            // 
            // ItemTxtBox
            // 
            this.ItemTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemTxtBox.Location = new System.Drawing.Point(589, 177);
            this.ItemTxtBox.MaximumSize = new System.Drawing.Size(180, 20);
            this.ItemTxtBox.MinimumSize = new System.Drawing.Size(180, 20);
            this.ItemTxtBox.Name = "ItemTxtBox";
            this.ItemTxtBox.ReadOnly = true;
            this.ItemTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemTxtBox.Size = new System.Drawing.Size(180, 20);
            this.ItemTxtBox.TabIndex = 33;
            this.LabelTooltips.SetToolTip(this.ItemTxtBox, "Item Number");
            // 
            // qtytxtbox
            // 
            this.qtytxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtytxtbox.Location = new System.Drawing.Point(589, 415);
            this.qtytxtbox.MaximumSize = new System.Drawing.Size(180, 20);
            this.qtytxtbox.MinimumSize = new System.Drawing.Size(180, 20);
            this.qtytxtbox.Name = "qtytxtbox";
            this.qtytxtbox.ReadOnly = true;
            this.qtytxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.qtytxtbox.Size = new System.Drawing.Size(180, 20);
            this.qtytxtbox.TabIndex = 43;
            this.LabelTooltips.SetToolTip(this.qtytxtbox, "Item Quantities Per Assembly");
            this.qtytxtbox.TextChanged += new System.EventHandler(this.qtytxtbox_TextChanged);
            this.qtytxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qtytxtbox_KeyDown);
            this.qtytxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtytxtbox_KeyPress);
            // 
            // SPM
            // 
            this.SPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SPM.BackColor = System.Drawing.Color.Transparent;
            this.SPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SPM.Image = ((System.Drawing.Image)(resources.GetObject("SPM.Image")));
            this.SPM.Location = new System.Drawing.Point(484, 22);
            this.SPM.MaximumSize = new System.Drawing.Size(288, 100);
            this.SPM.MinimumSize = new System.Drawing.Size(100, 100);
            this.SPM.Name = "SPM";
            this.SPM.Size = new System.Drawing.Size(288, 100);
            this.SPM.TabIndex = 32;
            this.SPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTooltips.SetToolTip(this.SPM, "SPM Automation Inc.");
            this.SPM.DoubleClick += new System.EventHandler(this.SPM_DoubleClick);
            // 
            // Editbttn
            // 
            this.Editbttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Editbttn.Location = new System.Drawing.Point(12, 681);
            this.Editbttn.Name = "Editbttn";
            this.Editbttn.Size = new System.Drawing.Size(75, 23);
            this.Editbttn.TabIndex = 45;
            this.Editbttn.Text = "Edit";
            this.LabelTooltips.SetToolTip(this.Editbttn, "Edit or Modify current assembly");
            this.Editbttn.UseVisualStyleBackColor = true;
            this.Editbttn.Click += new System.EventHandler(this.Editbttn_Click);
            // 
            // savebttn
            // 
            this.savebttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savebttn.Location = new System.Drawing.Point(102, 681);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(93, 23);
            this.savebttn.TabIndex = 46;
            this.savebttn.Text = "Save to Catalog";
            this.LabelTooltips.SetToolTip(this.savebttn, "Update modified assembly to Autocad Catalog");
            this.savebttn.UseVisualStyleBackColor = true;
            this.savebttn.Click += new System.EventHandler(this.savebttn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(12, 59);
            this.treeView1.MinimumSize = new System.Drawing.Size(100, 100);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(460, 585);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // Assy_label
            // 
            this.Assy_label.AutoSize = true;
            this.Assy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assy_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Assy_label.Location = new System.Drawing.Point(6, 22);
            this.Assy_label.Name = "Assy_label";
            this.Assy_label.Size = new System.Drawing.Size(112, 15);
            this.Assy_label.TabIndex = 28;
            this.Assy_label.Text = "Assembly Code :";
            // 
            // oemlbl
            // 
            this.oemlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oemlbl.AutoSize = true;
            this.oemlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oemlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oemlbl.Location = new System.Drawing.Point(480, 281);
            this.oemlbl.Name = "oemlbl";
            this.oemlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oemlbl.Size = new System.Drawing.Size(46, 15);
            this.oemlbl.TabIndex = 38;
            this.oemlbl.Text = "OEM :";
            // 
            // oemitemlbl
            // 
            this.oemitemlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oemitemlbl.AutoSize = true;
            this.oemitemlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oemitemlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oemitemlbl.Location = new System.Drawing.Point(480, 353);
            this.oemitemlbl.Name = "oemitemlbl";
            this.oemitemlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oemitemlbl.Size = new System.Drawing.Size(102, 30);
            this.oemitemlbl.TabIndex = 40;
            this.oemitemlbl.Text = "OEM \r\nItem Number : ";
            this.oemitemlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionlbl.Location = new System.Drawing.Point(480, 217);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionlbl.Size = new System.Drawing.Size(80, 15);
            this.descriptionlbl.TabIndex = 36;
            this.descriptionlbl.Text = "Description";
            // 
            // Itemlbl
            // 
            this.Itemlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Itemlbl.AutoSize = true;
            this.Itemlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Itemlbl.Location = new System.Drawing.Point(484, 180);
            this.Itemlbl.Name = "Itemlbl";
            this.Itemlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Itemlbl.Size = new System.Drawing.Size(43, 15);
            this.Itemlbl.TabIndex = 34;
            this.Itemlbl.Text = "Item :";
            // 
            // qtylbl
            // 
            this.qtylbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtylbl.AutoSize = true;
            this.qtylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtylbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtylbl.Location = new System.Drawing.Point(480, 418);
            this.qtylbl.Name = "qtylbl";
            this.qtylbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.qtylbl.Size = new System.Drawing.Size(78, 15);
            this.qtylbl.TabIndex = 44;
            this.qtylbl.Text = "Qty/Assy\'s :";
            // 
            // Addremovecontextmenu
            // 
            this.Addremovecontextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.removeItemToolStripMenuItem});
            this.Addremovecontextmenu.Name = "contextMenuStrip1";
            this.Addremovecontextmenu.Size = new System.Drawing.Size(145, 48);
            this.Addremovecontextmenu.Opening += new System.ComponentModel.CancelEventHandler(this.Addremovecontextmenu_Opening);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addItemToolStripMenuItem.Image")));
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeItemToolStripMenuItem.Image")));
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // AutocadAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.savebttn);
            this.Controls.Add(this.Editbttn);
            this.Controls.Add(this.Descriptiontxtbox);
            this.Controls.Add(this.oemlbl);
            this.Controls.Add(this.oemitemtxtbox);
            this.Controls.Add(this.oemtxtbox);
            this.Controls.Add(this.SPM);
            this.Controls.Add(this.oemitemlbl);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.Itemlbl);
            this.Controls.Add(this.ItemTxtBox);
            this.Controls.Add(this.qtylbl);
            this.Controls.Add(this.qtytxtbox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Expandchk);
            this.Controls.Add(this.Assy_label);
            this.Controls.Add(this.Assy_txtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AutocadAssembly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCad Assembly Catalog - SPM Connect";
            this.Load += new System.EventHandler(this.ParentView_Load);
            this.Addremovecontextmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip LabelTooltips;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox Expandchk;
        private System.Windows.Forms.Label Assy_label;
        private System.Windows.Forms.TextBox Assy_txtbox;
        private System.Windows.Forms.TextBox Descriptiontxtbox;
        private System.Windows.Forms.Label oemlbl;
        private System.Windows.Forms.TextBox oemitemtxtbox;
        private System.Windows.Forms.TextBox oemtxtbox;
        private System.Windows.Forms.Label SPM;
        private System.Windows.Forms.Label oemitemlbl;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.Label Itemlbl;
        private System.Windows.Forms.TextBox ItemTxtBox;
        private System.Windows.Forms.Label qtylbl;
        private System.Windows.Forms.TextBox qtytxtbox;
        private System.Windows.Forms.Button Editbttn;
        private System.Windows.Forms.Button savebttn;
        private System.Windows.Forms.ContextMenuStrip Addremovecontextmenu;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
    }
}