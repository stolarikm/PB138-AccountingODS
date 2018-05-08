
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox;

	private global::Gtk.Table table3;

	private global::Gtk.Calendar calendarInvoiceDate;

	private global::Gtk.Calendar calendarMaturityDate;

	private global::Gtk.ComboBoxEntry comboboxentryType;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry entryDebtorName;

	private global::Gtk.Entry entryDebtorAdress;

	private global::Gtk.Entry entryDebtorZip;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Entry entryCreditorName;

	private global::Gtk.Entry entryCreditorAdress;

	private global::Gtk.Entry entryCreditorZip;

	private global::Gtk.ScrolledWindow scrolledwindow1;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label labelDebtTitle;

	private global::Gtk.NodeView nodeviewDebt;

	private global::Gtk.ScrolledWindow scrolledwindow;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Label labelCreditTitle;

	private global::Gtk.NodeView nodeviewCredit;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox = new global::Gtk.HBox();
		this.hbox.Name = "hbox";
		this.hbox.Homogeneous = true;
		this.hbox.Spacing = 2;
		// Container child hbox.Gtk.Box+BoxChild
		this.table3 = new global::Gtk.Table(((uint)(7)), ((uint)(1)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.calendarInvoiceDate = new global::Gtk.Calendar();
		this.calendarInvoiceDate.CanFocus = true;
		this.calendarInvoiceDate.Name = "calendarInvoiceDate";
		this.calendarInvoiceDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.table3.Add(this.calendarInvoiceDate);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.calendarInvoiceDate]));
		w1.TopAttach = ((uint)(3));
		w1.BottomAttach = ((uint)(4));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.calendarMaturityDate = new global::Gtk.Calendar();
		this.calendarMaturityDate.CanFocus = true;
		this.calendarMaturityDate.Name = "calendarMaturityDate";
		this.calendarMaturityDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.table3.Add(this.calendarMaturityDate);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.calendarMaturityDate]));
		w2.TopAttach = ((uint)(4));
		w2.BottomAttach = ((uint)(5));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.comboboxentryType = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentryType.Name = "comboboxentryType";
		this.table3.Add(this.comboboxentryType);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxentryType]));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryDebtorName = new global::Gtk.Entry();
		this.entryDebtorName.CanFocus = true;
		this.entryDebtorName.Name = "entryDebtorName";
		this.entryDebtorName.Text = global::Mono.Unix.Catalog.GetString("Debtor name");
		this.entryDebtorName.IsEditable = true;
		this.entryDebtorName.InvisibleChar = '•';
		this.hbox2.Add(this.entryDebtorName);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryDebtorName]));
		w4.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryDebtorAdress = new global::Gtk.Entry();
		this.entryDebtorAdress.CanFocus = true;
		this.entryDebtorAdress.Name = "entryDebtorAdress";
		this.entryDebtorAdress.Text = global::Mono.Unix.Catalog.GetString("Debtor adress");
		this.entryDebtorAdress.IsEditable = true;
		this.entryDebtorAdress.InvisibleChar = '•';
		this.hbox2.Add(this.entryDebtorAdress);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryDebtorAdress]));
		w5.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryDebtorZip = new global::Gtk.Entry();
		this.entryDebtorZip.CanFocus = true;
		this.entryDebtorZip.Name = "entryDebtorZip";
		this.entryDebtorZip.Text = global::Mono.Unix.Catalog.GetString("Debtor ZIP code");
		this.entryDebtorZip.IsEditable = true;
		this.entryDebtorZip.InvisibleChar = '•';
		this.hbox2.Add(this.entryDebtorZip);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryDebtorZip]));
		w6.Position = 2;
		this.table3.Add(this.hbox2);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3[this.hbox2]));
		w7.TopAttach = ((uint)(1));
		w7.BottomAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryCreditorName = new global::Gtk.Entry();
		this.entryCreditorName.CanFocus = true;
		this.entryCreditorName.Name = "entryCreditorName";
		this.entryCreditorName.Text = global::Mono.Unix.Catalog.GetString("Creditor name");
		this.entryCreditorName.IsEditable = true;
		this.entryCreditorName.InvisibleChar = '•';
		this.hbox3.Add(this.entryCreditorName);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryCreditorName]));
		w8.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryCreditorAdress = new global::Gtk.Entry();
		this.entryCreditorAdress.CanFocus = true;
		this.entryCreditorAdress.Name = "entryCreditorAdress";
		this.entryCreditorAdress.Text = global::Mono.Unix.Catalog.GetString("Creditor adress");
		this.entryCreditorAdress.IsEditable = true;
		this.entryCreditorAdress.InvisibleChar = '•';
		this.hbox3.Add(this.entryCreditorAdress);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryCreditorAdress]));
		w9.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryCreditorZip = new global::Gtk.Entry();
		this.entryCreditorZip.CanFocus = true;
		this.entryCreditorZip.Name = "entryCreditorZip";
		this.entryCreditorZip.Text = global::Mono.Unix.Catalog.GetString("Creditor ZIP code");
		this.entryCreditorZip.IsEditable = true;
		this.entryCreditorZip.InvisibleChar = '•';
		this.hbox3.Add(this.entryCreditorZip);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryCreditorZip]));
		w10.Position = 2;
		this.table3.Add(this.hbox3);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3[this.hbox3]));
		w11.TopAttach = ((uint)(2));
		w11.BottomAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox.Add(this.table3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox[this.table3]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		global::Gtk.Viewport w13 = new global::Gtk.Viewport();
		w13.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport1.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelDebtTitle = new global::Gtk.Label();
		this.labelDebtTitle.Name = "labelDebtTitle";
		this.labelDebtTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Debt");
		this.vbox2.Add(this.labelDebtTitle);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelDebtTitle]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.nodeviewDebt = new global::Gtk.NodeView();
		this.nodeviewDebt.CanFocus = true;
		this.nodeviewDebt.Name = "nodeviewDebt";
		this.vbox2.Add(this.nodeviewDebt);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.nodeviewDebt]));
		w15.Position = 1;
		w13.Add(this.vbox2);
		this.scrolledwindow1.Add(w13);
		this.hbox.Add(this.scrolledwindow1);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox[this.scrolledwindow1]));
		w18.Position = 1;
		// Container child hbox.Gtk.Box+BoxChild
		this.scrolledwindow = new global::Gtk.ScrolledWindow();
		this.scrolledwindow.CanFocus = true;
		this.scrolledwindow.Name = "scrolledwindow";
		this.scrolledwindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w19 = new global::Gtk.Viewport();
		w19.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelCreditTitle = new global::Gtk.Label();
		this.labelCreditTitle.Name = "labelCreditTitle";
		this.labelCreditTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Credit");
		this.vbox1.Add(this.labelCreditTitle);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelCreditTitle]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.nodeviewCredit = new global::Gtk.NodeView();
		this.nodeviewCredit.CanFocus = true;
		this.nodeviewCredit.Name = "nodeviewCredit";
		this.vbox1.Add(this.nodeviewCredit);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.nodeviewCredit]));
		w21.Position = 1;
		w19.Add(this.vbox1);
		this.scrolledwindow.Add(w19);
		this.hbox.Add(this.scrolledwindow);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox[this.scrolledwindow]));
		w24.Position = 2;
		this.Add(this.hbox);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1510;
		this.DefaultHeight = 781;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
