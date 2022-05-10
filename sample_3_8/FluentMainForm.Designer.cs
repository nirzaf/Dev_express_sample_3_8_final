namespace sample_3_8 {
  partial class FluentMainForm {
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
      this.components = new System.ComponentModel.Container();
      this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
      this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
      this.gridPage = new DevExpress.XtraBars.Navigation.NavigationPage();
      this.richEditPage = new DevExpress.XtraBars.Navigation.NavigationPage();
      this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
      this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
      this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
      this.fluentDesignFormContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
      this.navigationFrame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // fluentDesignFormContainer1
      // 
      this.fluentDesignFormContainer1.Controls.Add(this.navigationFrame1);
      this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 31);
      this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
      this.fluentDesignFormContainer1.Size = new System.Drawing.Size(472, 462);
      this.fluentDesignFormContainer1.TabIndex = 0;
      // 
      // navigationFrame1
      // 
      this.navigationFrame1.Controls.Add(this.gridPage);
      this.navigationFrame1.Controls.Add(this.richEditPage);
      this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
      this.navigationFrame1.Name = "navigationFrame1";
      this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.gridPage,
            this.richEditPage});
      this.navigationFrame1.SelectedPage = this.gridPage;
      this.navigationFrame1.Size = new System.Drawing.Size(472, 462);
      this.navigationFrame1.TabIndex = 0;
      this.navigationFrame1.Text = "navigationFrame1";
      this.navigationFrame1.QueryControl += new DevExpress.XtraBars.Navigation.QueryControlEventHandler(this.navigationFrame1_QueryControl);
      // 
      // gridPage
      // 
      this.gridPage.Name = "gridPage";
      this.gridPage.Size = new System.Drawing.Size(472, 462);
      // 
      // richEditPage
      // 
      this.richEditPage.Name = "richEditPage";
      this.richEditPage.Size = new System.Drawing.Size(472, 462);
      // 
      // accordionControl1
      // 
      this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
      this.accordionControl1.Location = new System.Drawing.Point(0, 31);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
      this.accordionControl1.Size = new System.Drawing.Size(260, 462);
      this.accordionControl1.TabIndex = 1;
      this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
      // 
      // accordionControlElement1
      // 
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement1.Text = "Grid";
      this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
      // 
      // accordionControlElement2
      // 
      this.accordionControlElement2.Name = "accordionControlElement2";
      this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement2.Text = "Rich Edit";
      this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
      // 
      // fluentDesignFormControl1
      // 
      this.fluentDesignFormControl1.FluentDesignForm = this;
      this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
      this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
      this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
      this.fluentDesignFormControl1.Size = new System.Drawing.Size(732, 31);
      this.fluentDesignFormControl1.TabIndex = 2;
      this.fluentDesignFormControl1.TabStop = false;
      // 
      // fluentFormDefaultManager1
      // 
      this.fluentFormDefaultManager1.DockingEnabled = false;
      this.fluentFormDefaultManager1.Form = this;
      // 
      // FluentMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(732, 493);
      this.ControlContainer = this.fluentDesignFormContainer1;
      this.Controls.Add(this.fluentDesignFormContainer1);
      this.Controls.Add(this.accordionControl1);
      this.Controls.Add(this.fluentDesignFormControl1);
      this.FluentDesignFormControl = this.fluentDesignFormControl1;
      this.Name = "FluentMainForm";
      this.NavigationControl = this.accordionControl1;
      this.Text = "FluentMainForm";
      this.fluentDesignFormContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
      this.navigationFrame1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
    private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
    private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
    private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
    private DevExpress.XtraBars.Navigation.NavigationPage gridPage;
    private DevExpress.XtraBars.Navigation.NavigationPage richEditPage;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
  }
}