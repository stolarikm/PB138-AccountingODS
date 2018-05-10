
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox;

	private global::Gtk.Table table3;

	private global::Gtk.Button buttonAddInvoice;

	private global::Gtk.Calendar calendarInvoiceDate;

	private global::Gtk.Calendar calendarMaturityDate;

	private global::Gtk.Label label8;

	private global::Gtk.Label label9;

	private global::Gtk.Table table2;

	private global::Gtk.Entry entryCreditorAdress;

	private global::Gtk.Entry entryCreditorName;

	private global::Gtk.Entry entryCreditorZip;

	private global::Gtk.Entry entryDebtorAdress;

	private global::Gtk.Entry entryDebtorName;

	private global::Gtk.Entry entryDebtorZip;

	private global::Gtk.Label label2;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.Label label5;

	private global::Gtk.Label label6;

	private global::Gtk.Label label7;

	private global::Gtk.Table table4;

	private global::Gtk.ComboBox comboboxType;

	private global::Gtk.Label label10;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label labelDebtTitle;

	private global::Gtk.ScrolledWindow scrolledwindow1;

	private global::Gtk.NodeView nodeviewDebt;

	private global::Gtk.Table table5;

	private global::Gtk.Table table7;

	private global::Gtk.Entry entryInvoiceItemCost;

	private global::Gtk.Label label12;

	private global::Gtk.Table table8;

	private global::Gtk.Entry entryInvoiceItemName;

	private global::Gtk.Label label11;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Label labelCreditTitle;

	private global::Gtk.ScrolledWindow scrolledwindow2;

	private global::Gtk.NodeView nodeviewCredit;

	private global::Gtk.Table table6;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

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
		this.buttonAddInvoice = new global::Gtk.Button();
		this.buttonAddInvoice.CanFocus = true;
		this.buttonAddInvoice.Name = "buttonAddInvoice";
		this.buttonAddInvoice.UseUnderline = true;
		this.buttonAddInvoice.Label = global::Mono.Unix.Catalog.GetString("Add invoice");
		this.table3.Add(this.buttonAddInvoice);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.buttonAddInvoice]));
		w1.TopAttach = ((uint)(6));
		w1.BottomAttach = ((uint)(7));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.calendarInvoiceDate = new global::Gtk.Calendar();
		this.calendarInvoiceDate.CanFocus = true;
		this.calendarInvoiceDate.Name = "calendarInvoiceDate";
		this.calendarInvoiceDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.table3.Add(this.calendarInvoiceDate);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.calendarInvoiceDate]));
		w2.TopAttach = ((uint)(3));
		w2.BottomAttach = ((uint)(4));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.calendarMaturityDate = new global::Gtk.Calendar();
		this.calendarMaturityDate.CanFocus = true;
		this.calendarMaturityDate.Name = "calendarMaturityDate";
		this.calendarMaturityDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.table3.Add(this.calendarMaturityDate);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.calendarMaturityDate]));
		w3.TopAttach = ((uint)(5));
		w3.BottomAttach = ((uint)(6));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Invoice date");
		this.table3.Add(this.label8);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.label8]));
		w4.TopAttach = ((uint)(2));
		w4.BottomAttach = ((uint)(3));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Maturity date");
		this.table3.Add(this.label9);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.label9]));
		w5.TopAttach = ((uint)(4));
		w5.BottomAttach = ((uint)(5));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.table2 = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.entryCreditorAdress = new global::Gtk.Entry();
		this.entryCreditorAdress.CanFocus = true;
		this.entryCreditorAdress.Name = "entryCreditorAdress";
		this.entryCreditorAdress.IsEditable = true;
		this.entryCreditorAdress.InvisibleChar = '•';
		this.table2.Add(this.entryCreditorAdress);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.entryCreditorAdress]));
		w6.TopAttach = ((uint)(3));
		w6.BottomAttach = ((uint)(4));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.entryCreditorName = new global::Gtk.Entry();
		this.entryCreditorName.CanFocus = true;
		this.entryCreditorName.Name = "entryCreditorName";
		this.entryCreditorName.IsEditable = true;
		this.entryCreditorName.InvisibleChar = '•';
		this.table2.Add(this.entryCreditorName);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.entryCreditorName]));
		w7.TopAttach = ((uint)(3));
		w7.BottomAttach = ((uint)(4));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.entryCreditorZip = new global::Gtk.Entry();
		this.entryCreditorZip.CanFocus = true;
		this.entryCreditorZip.Name = "entryCreditorZip";
		this.entryCreditorZip.IsEditable = true;
		this.entryCreditorZip.InvisibleChar = '•';
		this.table2.Add(this.entryCreditorZip);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.entryCreditorZip]));
		w8.TopAttach = ((uint)(3));
		w8.BottomAttach = ((uint)(4));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.entryDebtorAdress = new global::Gtk.Entry();
		this.entryDebtorAdress.CanFocus = true;
		this.entryDebtorAdress.Name = "entryDebtorAdress";
		this.entryDebtorAdress.IsEditable = true;
		this.entryDebtorAdress.InvisibleChar = '•';
		this.table2.Add(this.entryDebtorAdress);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.entryDebtorAdress]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.LeftAttach = ((uint)(1));
		w9.RightAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.entryDebtorName = new global::Gtk.Entry();
		this.entryDebtorName.CanFocus = true;
		this.entryDebtorName.Name = "entryDebtorName";
		this.entryDebtorName.IsEditable = true;
		this.entryDebtorName.InvisibleChar = '•';
		this.table2.Add(this.entryDebtorName);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.entryDebtorName]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.entryDebtorZip = new global::Gtk.Entry();
		this.entryDebtorZip.CanFocus = true;
		this.entryDebtorZip.Name = "entryDebtorZip";
		this.entryDebtorZip.IsEditable = true;
		this.entryDebtorZip.InvisibleChar = '•';
		this.table2.Add(this.entryDebtorZip);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.entryDebtorZip]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(2));
		w11.RightAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Debtor name");
		this.table2.Add(this.label2);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.label2]));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Debtor adress");
		this.table2.Add(this.label3);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
		w13.LeftAttach = ((uint)(1));
		w13.RightAttach = ((uint)(2));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Debtor ZIP code");
		this.table2.Add(this.label4);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
		w14.LeftAttach = ((uint)(2));
		w14.RightAttach = ((uint)(3));
		w14.XOptions = ((global::Gtk.AttachOptions)(4));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Creditor ZIP code");
		this.table2.Add(this.label5);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
		w15.TopAttach = ((uint)(2));
		w15.BottomAttach = ((uint)(3));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		w15.XOptions = ((global::Gtk.AttachOptions)(4));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Creditor name");
		this.table2.Add(this.label6);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.label6]));
		w16.TopAttach = ((uint)(2));
		w16.BottomAttach = ((uint)(3));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Creditor adress");
		this.table2.Add(this.label7);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
		w17.TopAttach = ((uint)(2));
		w17.BottomAttach = ((uint)(3));
		w17.LeftAttach = ((uint)(1));
		w17.RightAttach = ((uint)(2));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table3.Add(this.table2);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3[this.table2]));
		w18.TopAttach = ((uint)(1));
		w18.BottomAttach = ((uint)(2));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.table4 = new global::Gtk.Table(((uint)(2)), ((uint)(1)), true);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(6));
		// Container child table4.Gtk.Table+TableChild
		this.comboboxType = global::Gtk.ComboBox.NewText();
		this.comboboxType.Name = "comboboxType";
		this.table4.Add(this.comboboxType);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table4[this.comboboxType]));
		w19.TopAttach = ((uint)(1));
		w19.BottomAttach = ((uint)(2));
		w19.XOptions = ((global::Gtk.AttachOptions)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.label10 = new global::Gtk.Label();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Invoice type");
		this.table4.Add(this.label10);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table4[this.label10]));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table3.Add(this.table4);
		global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3[this.table4]));
		w21.XOptions = ((global::Gtk.AttachOptions)(4));
		w21.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hbox.Add(this.table3);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox[this.table3]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelDebtTitle = new global::Gtk.Label();
		this.labelDebtTitle.Name = "labelDebtTitle";
		this.labelDebtTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Debt");
		this.vbox2.Add(this.labelDebtTitle);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelDebtTitle]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		this.nodeviewDebt = new global::Gtk.NodeView();
		this.nodeviewDebt.CanFocus = true;
		this.nodeviewDebt.Name = "nodeviewDebt";
		this.scrolledwindow1.Add(this.nodeviewDebt);
		this.vbox2.Add(this.scrolledwindow1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
		w25.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.table5 = new global::Gtk.Table(((uint)(2)), ((uint)(1)), false);
		this.table5.RowSpacing = ((uint)(6));
		this.table5.ColumnSpacing = ((uint)(6));
		// Container child table5.Gtk.Table+TableChild
		this.table7 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
		this.table7.Name = "table7";
		this.table7.RowSpacing = ((uint)(6));
		this.table7.ColumnSpacing = ((uint)(6));
		// Container child table7.Gtk.Table+TableChild
		this.entryInvoiceItemCost = new global::Gtk.Entry();
		this.entryInvoiceItemCost.CanFocus = true;
		this.entryInvoiceItemCost.Name = "entryInvoiceItemCost";
		this.entryInvoiceItemCost.IsEditable = true;
		this.entryInvoiceItemCost.InvisibleChar = '•';
		this.table7.Add(this.entryInvoiceItemCost);
		global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table7[this.entryInvoiceItemCost]));
		w26.LeftAttach = ((uint)(1));
		w26.RightAttach = ((uint)(2));
		w26.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table7.Gtk.Table+TableChild
		this.label12 = new global::Gtk.Label();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Item cost");
		this.table7.Add(this.label12);
		global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table7[this.label12]));
		w27.XOptions = ((global::Gtk.AttachOptions)(4));
		w27.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table5.Add(this.table7);
		global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table5[this.table7]));
		w28.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table5.Gtk.Table+TableChild
		this.table8 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
		this.table8.Name = "table8";
		this.table8.RowSpacing = ((uint)(6));
		this.table8.ColumnSpacing = ((uint)(6));
		// Container child table8.Gtk.Table+TableChild
		this.entryInvoiceItemName = new global::Gtk.Entry();
		this.entryInvoiceItemName.CanFocus = true;
		this.entryInvoiceItemName.Name = "entryInvoiceItemName";
		this.entryInvoiceItemName.IsEditable = true;
		this.entryInvoiceItemName.InvisibleChar = '•';
		this.table8.Add(this.entryInvoiceItemName);
		global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table8[this.entryInvoiceItemName]));
		w29.LeftAttach = ((uint)(1));
		w29.RightAttach = ((uint)(2));
		w29.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table8.Gtk.Table+TableChild
		this.label11 = new global::Gtk.Label();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Item text");
		this.table8.Add(this.label11);
		global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table8[this.label11]));
		w30.XOptions = ((global::Gtk.AttachOptions)(4));
		w30.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table5.Add(this.table8);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table5[this.table8]));
		w31.TopAttach = ((uint)(1));
		w31.BottomAttach = ((uint)(2));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox2.Add(this.table5);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table5]));
		w32.Position = 2;
		w32.Expand = false;
		w32.Fill = false;
		this.hbox.Add(this.vbox2);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox[this.vbox2]));
		w33.Position = 1;
		w33.Expand = false;
		// Container child hbox.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelCreditTitle = new global::Gtk.Label();
		this.labelCreditTitle.Name = "labelCreditTitle";
		this.labelCreditTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Credit");
		this.vbox1.Add(this.labelCreditTitle);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelCreditTitle]));
		w34.Position = 0;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow2.CanFocus = true;
		this.scrolledwindow2.Name = "scrolledwindow2";
		this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow2.Gtk.Container+ContainerChild
		this.nodeviewCredit = new global::Gtk.NodeView();
		this.nodeviewCredit.CanFocus = true;
		this.nodeviewCredit.Name = "nodeviewCredit";
		this.scrolledwindow2.Add(this.nodeviewCredit);
		this.vbox1.Add(this.scrolledwindow2);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow2]));
		w36.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table6 = new global::Gtk.Table(((uint)(2)), ((uint)(1)), false);
		this.table6.Name = "table6";
		this.table6.RowSpacing = ((uint)(6));
		this.table6.ColumnSpacing = ((uint)(6));
		// Container child table6.Gtk.Table+TableChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Add invoice item");
		this.table6.Add(this.button2);
		global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table6[this.button2]));
		w37.XOptions = ((global::Gtk.AttachOptions)(4));
		w37.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table6.Gtk.Table+TableChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Delete invoice");
		this.table6.Add(this.button3);
		global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table6[this.button3]));
		w38.TopAttach = ((uint)(1));
		w38.BottomAttach = ((uint)(2));
		w38.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add(this.table6);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table6]));
		w39.Position = 2;
		w39.Expand = false;
		w39.Fill = false;
		this.hbox.Add(this.vbox1);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox[this.vbox1]));
		w40.Position = 2;
		w40.Expand = false;
		this.Add(this.hbox);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1510;
		this.DefaultHeight = 781;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.buttonAddInvoice.Clicked += new global::System.EventHandler(this.OnButtonAddInvoiceClicked);
	}
}
