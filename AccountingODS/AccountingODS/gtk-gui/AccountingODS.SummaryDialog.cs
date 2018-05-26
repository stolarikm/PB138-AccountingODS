
// This file has been generated by the GUI designer. Do not modify.
namespace AccountingODS
{
	public partial class SummaryDialog
	{
		private global::Gtk.Table table1;

		private global::Gtk.Label label1;

		private global::Gtk.Table table3;

		private global::Gtk.Label label2;

		private global::Gtk.Label labelIncomes;

		private global::Gtk.Table table4;

		private global::Gtk.Label label4;

		private global::Gtk.Label labelExpenditures;

		private global::Gtk.Table table5;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelDifference;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AccountingODS.SummaryDialog
			this.Name = "AccountingODS.SummaryDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child AccountingODS.SummaryDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.HeightRequest = 0;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(1)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Overview of incomes and expenditures of current accounting period");
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Incomes:");
			this.table3.Add(this.label2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.label2]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelIncomes = new global::Gtk.Label();
			this.labelIncomes.Name = "labelIncomes";
			this.labelIncomes.LabelProp = global::Mono.Unix.Catalog.GetString("label3");
			this.labelIncomes.Justify = ((global::Gtk.Justification)(1));
			this.table3.Add(this.labelIncomes);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.labelIncomes]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add(this.table3);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.table3]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table4 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Expenditures:");
			this.table4.Add(this.label4);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table4[this.label4]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.labelExpenditures = new global::Gtk.Label();
			this.labelExpenditures.Name = "labelExpenditures";
			this.labelExpenditures.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
			this.labelExpenditures.Justify = ((global::Gtk.Justification)(2));
			this.table4.Add(this.labelExpenditures);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4[this.labelExpenditures]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add(this.table4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.table4]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table5 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(6));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("DIfference:");
			this.table5.Add(this.label6);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table5[this.label6]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.labelDifference = new global::Gtk.Label();
			this.labelDifference.Name = "labelDifference";
			this.labelDifference.LabelProp = global::Mono.Unix.Catalog.GetString("label7");
			this.labelDifference.Justify = ((global::Gtk.Justification)(2));
			this.table5.Add(this.labelDifference);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table5[this.labelDifference]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add(this.table5);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.table5]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add(this.table1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(w1[this.table1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Internal child AccountingODS.SummaryDialog.ActionArea
			global::Gtk.HButtonBox w13 = this.ActionArea;
			w13.Name = "dialog1_ActionArea";
			w13.Spacing = 10;
			w13.BorderWidth = ((uint)(5));
			w13.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w13[this.buttonOk]));
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 471;
			this.DefaultHeight = 137;
			this.Show();
			this.buttonOk.Clicked += new global::System.EventHandler(this.OnButtonOkClicked);
		}
	}
}
