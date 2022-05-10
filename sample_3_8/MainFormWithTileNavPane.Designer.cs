namespace sample_3_8 {
  partial class MainFormWithTileNavPane {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormWithTileNavPane));
      DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
      this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
      this.gridPage = new DevExpress.XtraBars.Navigation.NavigationPage();
      this.richEditPage = new DevExpress.XtraBars.Navigation.NavigationPage();
      this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
      this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
      this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
      this.tileNavCategory3 = new DevExpress.XtraBars.Navigation.TileNavCategory();
      this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
      this.tileNavSubItem4 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
      this.tileNavSubItem5 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
      this.tileNavCategory4 = new DevExpress.XtraBars.Navigation.TileNavCategory();
      this.gridItem = new DevExpress.XtraBars.Navigation.TileNavItem();
      this.richEditItem = new DevExpress.XtraBars.Navigation.TileNavItem();
      this.tileNavItem3 = new DevExpress.XtraBars.Navigation.TileNavItem();
      this.tileNavSubItem1 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
      this.tileNavSubItem2 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
      this.tileNavSubItem3 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
      ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
      this.navigationFrame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
      this.SuspendLayout();
      // 
      // navigationFrame1
      // 
      this.navigationFrame1.Controls.Add(this.gridPage);
      this.navigationFrame1.Controls.Add(this.richEditPage);
      this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.navigationFrame1.Location = new System.Drawing.Point(0, 40);
      this.navigationFrame1.Name = "navigationFrame1";
      this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.gridPage,
            this.richEditPage});
      this.navigationFrame1.SelectedPage = this.gridPage;
      this.navigationFrame1.Size = new System.Drawing.Size(722, 463);
      this.navigationFrame1.TabIndex = 0;
      this.navigationFrame1.Text = "navigationFrame1";
      this.navigationFrame1.QueryControl += new DevExpress.XtraBars.Navigation.QueryControlEventHandler(this.navigationFrame1_QueryControl);
      // 
      // gridPage
      // 
      this.gridPage.Caption = "gridPage";
      this.gridPage.Name = "gridPage";
      this.gridPage.Size = new System.Drawing.Size(722, 463);
      // 
      // richEditPage
      // 
      this.richEditPage.Caption = "richEditPage";
      this.richEditPage.Name = "richEditPage";
      this.richEditPage.Size = new System.Drawing.Size(722, 463);
      // 
      // tileNavPane1
      // 
      this.tileNavPane1.AllowGlyphSkinning = true;
      this.tileNavPane1.Buttons.Add(this.navButton2);
      this.tileNavPane1.Buttons.Add(this.navButton3);
      this.tileNavPane1.Buttons.Add(this.tileNavCategory3);
      this.tileNavPane1.Categories.AddRange(new DevExpress.XtraBars.Navigation.TileNavCategory[] {
            this.tileNavCategory4});
      this.tileNavPane1.ContinuousNavigation = true;
      // 
      // tileNavCategory1
      // 
      this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
      // 
      // 
      // 
      this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
      this.tileNavPane1.Name = "tileNavPane1";
      this.tileNavPane1.Size = new System.Drawing.Size(722, 40);
      this.tileNavPane1.TabIndex = 2;
      this.tileNavPane1.Text = "tileNavPane1";
      // 
      // navButton2
      // 
      this.navButton2.Caption = "Main Menu";
      this.navButton2.IsMain = true;
      this.navButton2.Name = "navButton2";
      // 
      // navButton3
      // 
      this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
      this.navButton3.Caption = "Button";
      this.navButton3.Name = "navButton3";
      // 
      // tileNavCategory3
      // 
      this.tileNavCategory3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
      this.tileNavCategory3.Caption = "Category";
      this.tileNavCategory3.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tileNavItem2});
      this.tileNavCategory3.Name = "tileNavCategory3";
      // 
      // 
      // 
      this.tileNavCategory3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement4.Text = "Category";
      this.tileNavCategory3.Tile.Elements.Add(tileItemElement4);
      // 
      // tileNavItem2
      // 
      this.tileNavItem2.Caption = "Category Item";
      this.tileNavItem2.Name = "tileNavItem2";
      this.tileNavItem2.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.tileNavSubItem4,
            this.tileNavSubItem5});
      // 
      // 
      // 
      this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement3.Text = "Category Item";
      this.tileNavItem2.Tile.Elements.Add(tileItemElement3);
      this.tileNavItem2.Tile.Name = "tileBarItem2";
      // 
      // tileNavSubItem4
      // 
      this.tileNavSubItem4.Caption = "Sub-Item";
      this.tileNavSubItem4.Name = "tileNavSubItem4";
      // 
      // 
      // 
      this.tileNavSubItem4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement1.Text = "Sub-Item";
      this.tileNavSubItem4.Tile.Elements.Add(tileItemElement1);
      this.tileNavSubItem4.Tile.Name = "tileBarItem9";
      // 
      // tileNavSubItem5
      // 
      this.tileNavSubItem5.Caption = "Sub-Item";
      this.tileNavSubItem5.Name = "tileNavSubItem5";
      // 
      // 
      // 
      this.tileNavSubItem5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement2.Text = "Sub-Item";
      this.tileNavSubItem5.Tile.Elements.Add(tileItemElement2);
      this.tileNavSubItem5.Tile.Name = "tileBarItem10";
      // 
      // tileNavCategory4
      // 
      this.tileNavCategory4.Caption = "Control Views";
      this.tileNavCategory4.GroupName = "";
      this.tileNavCategory4.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.gridItem,
            this.richEditItem,
            this.tileNavItem3});
      this.tileNavCategory4.Name = "tileNavCategory4";
      // 
      // 
      // 
      this.tileNavCategory4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
      tileItemElement11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
      tileItemElement11.Text = "Control Views";
      this.tileNavCategory4.Tile.Elements.Add(tileItemElement11);
      this.tileNavCategory4.Tile.Name = "tileBarItem4";
      // 
      // gridItem
      // 
      this.gridItem.Caption = "Grid";
      this.gridItem.Name = "gridItem";
      // 
      // 
      // 
      this.gridItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
      tileItemElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
      tileItemElement5.Text = "Grid";
      this.gridItem.Tile.Elements.Add(tileItemElement5);
      this.gridItem.Tile.Name = "tileBarItem5";
      this.gridItem.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.gridItem_TileClick);
      // 
      // richEditItem
      // 
      this.richEditItem.Caption = "Rich Edit";
      this.richEditItem.Name = "richEditItem";
      // 
      // 
      // 
      this.richEditItem.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
      tileItemElement6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
      tileItemElement6.Text = "Rich Edit";
      this.richEditItem.Tile.Elements.Add(tileItemElement6);
      this.richEditItem.Tile.Name = "tileBarItem1";
      this.richEditItem.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.richEditItem_TileClick);
      // 
      // tileNavItem3
      // 
      this.tileNavItem3.Caption = "Sample with Sub-Items";
      this.tileNavItem3.Name = "tileNavItem3";
      this.tileNavItem3.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.tileNavSubItem1,
            this.tileNavSubItem2,
            this.tileNavSubItem3});
      // 
      // 
      // 
      this.tileNavItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
      tileItemElement10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
      tileItemElement10.Text = "Sample with Sub-Items";
      this.tileNavItem3.Tile.Elements.Add(tileItemElement10);
      this.tileNavItem3.Tile.Name = "tileBarItem3";
      // 
      // tileNavSubItem1
      // 
      this.tileNavSubItem1.Caption = "Sub Item 1";
      this.tileNavSubItem1.Name = "tileNavSubItem1";
      // 
      // 
      // 
      this.tileNavSubItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement7.Text = "Sub Item 1";
      this.tileNavSubItem1.Tile.Elements.Add(tileItemElement7);
      this.tileNavSubItem1.Tile.Name = "tileBarItem6";
      // 
      // tileNavSubItem2
      // 
      this.tileNavSubItem2.Caption = "Sub Item 2";
      this.tileNavSubItem2.Name = "tileNavSubItem2";
      // 
      // 
      // 
      this.tileNavSubItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement8.Text = "Sub Item 2";
      this.tileNavSubItem2.Tile.Elements.Add(tileItemElement8);
      this.tileNavSubItem2.Tile.Name = "tileBarItem7";
      // 
      // tileNavSubItem3
      // 
      this.tileNavSubItem3.Caption = "Sub Item 3";
      this.tileNavSubItem3.Name = "tileNavSubItem3";
      // 
      // 
      // 
      this.tileNavSubItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
      tileItemElement9.Text = "Sub Item 3";
      this.tileNavSubItem3.Tile.Elements.Add(tileItemElement9);
      this.tileNavSubItem3.Tile.Name = "tileBarItem8";
      // 
      // MainFormWithTileNavPane
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(722, 503);
      this.Controls.Add(this.navigationFrame1);
      this.Controls.Add(this.tileNavPane1);
      this.Name = "MainFormWithTileNavPane";
      this.Text = "MainFormWithTileNavPane";
      ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
      this.navigationFrame1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
    private DevExpress.XtraBars.Navigation.NavigationPage gridPage;
    private DevExpress.XtraBars.Navigation.NavigationPage richEditPage;
    private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
    private DevExpress.XtraBars.Navigation.NavButton navButton2;
    private DevExpress.XtraBars.Navigation.NavButton navButton3;
    private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory3;
    private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory4;
    private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem3;
    private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem1;
    private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem2;
    private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem3;
    private DevExpress.XtraBars.Navigation.TileNavItem gridItem;
    private DevExpress.XtraBars.Navigation.TileNavItem richEditItem;
    private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
    private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem4;
    private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem5;
  }
}