namespace SYRIS_Mini
{
    partial class MainFrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.minitrv0001 = new System.Windows.Forms.TreeView();
            this.miniiml0001 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.minitrv0001);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1012);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // minitrv0001
            // 
            this.minitrv0001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minitrv0001.ImageIndex = 0;
            this.minitrv0001.ImageList = this.miniiml0001;
            this.minitrv0001.Location = new System.Drawing.Point(0, 0);
            this.minitrv0001.Name = "minitrv0001";
            this.minitrv0001.SelectedImageIndex = 0;
            this.minitrv0001.Size = new System.Drawing.Size(250, 1012);
            this.minitrv0001.TabIndex = 0;
            this.minitrv0001.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.minitrv0001_NodeMouseClick);
            // 
            // miniiml0001
            // 
            this.miniiml0001.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("miniiml0001.ImageStream")));
            this.miniiml0001.TransparentColor = System.Drawing.Color.Transparent;
            this.miniiml0001.Images.SetKeyName(0, "folder.png");
            this.miniiml0001.Images.SetKeyName(1, "list.png");
            this.miniiml0001.Images.SetKeyName(2, "objects.png");
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1012);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView minitrv0001;
        private System.Windows.Forms.ImageList miniiml0001;
    }
}

