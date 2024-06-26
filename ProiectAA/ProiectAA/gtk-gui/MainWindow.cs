
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry hostname_textbox;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Entry port_textbox;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.ComboBox cache_type_combobox;

	private global::Gtk.Label label5;

	private global::Gtk.Entry sets_textbox;

	private global::Gtk.Entry blocksize_textbox;

	private global::Gtk.Label label6;

	private global::Gtk.Entry asoc_textbox;

	private global::Gtk.Label label7;

	private global::Gtk.Entry nr_instructions_textbox;

	private global::Gtk.Entry issue_width_textbox;

	private global::Gtk.Entry if_queuesize_textbox;

	private global::Gtk.Entry branch_latency_textbox;

	private global::Gtk.Label label13;

	private global::Gtk.Label label12;

	private global::Gtk.Label label11;

	private global::Gtk.Label label10;

	private global::Gtk.Label label9;

	private global::Gtk.Label label8;

	private global::Gtk.ComboBox issue_inorder_option;

	private global::Gtk.Label label14;

	private global::Gtk.Entry ruu_size_textbox;

	private global::Gtk.Label label16;

	private global::Gtk.ComboBox benchmark_combobox;

	private global::Gtk.Button startButton;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView serverOutput;

	private global::Gtk.Button helpButton;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hostname_textbox = new global::Gtk.Entry();
		this.hostname_textbox.CanFocus = true;
		this.hostname_textbox.Name = "hostname_textbox";
		this.hostname_textbox.Text = global::Mono.Unix.Catalog.GetString("127.0.0.1");
		this.hostname_textbox.IsEditable = true;
		this.hostname_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.hostname_textbox);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hostname_textbox]));
		w1.X = 72;
		w1.Y = 11;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Hostname");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w2.X = 7;
		w2.Y = 17;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Port");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w3.X = 255;
		w3.Y = 17;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.port_textbox = new global::Gtk.Entry();
		this.port_textbox.CanFocus = true;
		this.port_textbox.Name = "port_textbox";
		this.port_textbox.Text = global::Mono.Unix.Catalog.GetString("8000");
		this.port_textbox.IsEditable = true;
		this.port_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.port_textbox);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.port_textbox]));
		w4.X = 285;
		w4.Y = 10;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Cache Properties");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w5.X = 6;
		w5.Y = 90;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Cache type");
		this.fixed1.Add(this.label4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
		w6.X = 9;
		w6.Y = 128;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.cache_type_combobox = global::Gtk.ComboBox.NewText();
		this.cache_type_combobox.AppendText(global::Mono.Unix.Catalog.GetString("dl1"));
		this.cache_type_combobox.AppendText(global::Mono.Unix.Catalog.GetString("ul2"));
		this.cache_type_combobox.AppendText(global::Mono.Unix.Catalog.GetString("il1"));
		this.cache_type_combobox.Name = "cache_type_combobox";
		this.cache_type_combobox.Active = 0;
		this.fixed1.Add(this.cache_type_combobox);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cache_type_combobox]));
		w7.X = 90;
		w7.Y = 119;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Sets");
		this.fixed1.Add(this.label5);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label5]));
		w8.X = 13;
		w8.Y = 179;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.sets_textbox = new global::Gtk.Entry();
		this.sets_textbox.CanFocus = true;
		this.sets_textbox.Name = "sets_textbox";
		this.sets_textbox.Text = global::Mono.Unix.Catalog.GetString("128");
		this.sets_textbox.IsEditable = true;
		this.sets_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.sets_textbox);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.sets_textbox]));
		w9.X = 97;
		w9.Y = 169;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.blocksize_textbox = new global::Gtk.Entry();
		this.blocksize_textbox.CanFocus = true;
		this.blocksize_textbox.Name = "blocksize_textbox";
		this.blocksize_textbox.Text = global::Mono.Unix.Catalog.GetString("32");
		this.blocksize_textbox.IsEditable = true;
		this.blocksize_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.blocksize_textbox);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.blocksize_textbox]));
		w10.X = 97;
		w10.Y = 213;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Block Size");
		this.fixed1.Add(this.label6);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label6]));
		w11.X = 13;
		w11.Y = 218;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.asoc_textbox = new global::Gtk.Entry();
		this.asoc_textbox.CanFocus = true;
		this.asoc_textbox.Name = "asoc_textbox";
		this.asoc_textbox.Text = global::Mono.Unix.Catalog.GetString("4");
		this.asoc_textbox.IsEditable = true;
		this.asoc_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.asoc_textbox);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.asoc_textbox]));
		w12.X = 97;
		w12.Y = 259;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Asociativity");
		this.fixed1.Add(this.label7);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label7]));
		w13.X = 15;
		w13.Y = 264;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.nr_instructions_textbox = new global::Gtk.Entry();
		this.nr_instructions_textbox.CanFocus = true;
		this.nr_instructions_textbox.Name = "nr_instructions_textbox";
		this.nr_instructions_textbox.Text = global::Mono.Unix.Catalog.GetString("5000000");
		this.nr_instructions_textbox.IsEditable = true;
		this.nr_instructions_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.nr_instructions_textbox);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.nr_instructions_textbox]));
		w14.X = 616;
		w14.Y = 127;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.issue_width_textbox = new global::Gtk.Entry();
		this.issue_width_textbox.CanFocus = true;
		this.issue_width_textbox.Name = "issue_width_textbox";
		this.issue_width_textbox.Text = global::Mono.Unix.Catalog.GetString("4");
		this.issue_width_textbox.IsEditable = true;
		this.issue_width_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.issue_width_textbox);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.issue_width_textbox]));
		w15.X = 616;
		w15.Y = 200;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.if_queuesize_textbox = new global::Gtk.Entry();
		this.if_queuesize_textbox.CanFocus = true;
		this.if_queuesize_textbox.Name = "if_queuesize_textbox";
		this.if_queuesize_textbox.Text = global::Mono.Unix.Catalog.GetString("4");
		this.if_queuesize_textbox.IsEditable = true;
		this.if_queuesize_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.if_queuesize_textbox);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.if_queuesize_textbox]));
		w16.X = 616;
		w16.Y = 239;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.branch_latency_textbox = new global::Gtk.Entry();
		this.branch_latency_textbox.CanFocus = true;
		this.branch_latency_textbox.Name = "branch_latency_textbox";
		this.branch_latency_textbox.Text = global::Mono.Unix.Catalog.GetString("3");
		this.branch_latency_textbox.IsEditable = true;
		this.branch_latency_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.branch_latency_textbox);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.branch_latency_textbox]));
		w17.X = 616;
		w17.Y = 278;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label13 = new global::Gtk.Label();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Branch Miss-Pred Latency");
		this.fixed1.Add(this.label13);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label13]));
		w18.X = 462;
		w18.Y = 282;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label12 = new global::Gtk.Label();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("IF Queue Size");
		this.fixed1.Add(this.label12);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label12]));
		w19.X = 464;
		w19.Y = 243;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label11 = new global::Gtk.Label();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Issue Width");
		this.fixed1.Add(this.label11);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label11]));
		w20.X = 463;
		w20.Y = 205;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label10 = new global::Gtk.Label();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Issue InOrder");
		this.fixed1.Add(this.label10);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label10]));
		w21.X = 463;
		w21.Y = 169;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Nr. Of Instructions");
		this.fixed1.Add(this.label9);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label9]));
		w22.X = 461;
		w22.Y = 133;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Simulator Details");
		this.fixed1.Add(this.label8);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label8]));
		w23.X = 459;
		w23.Y = 91;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.issue_inorder_option = global::Gtk.ComboBox.NewText();
		this.issue_inorder_option.AppendText(global::Mono.Unix.Catalog.GetString("true"));
		this.issue_inorder_option.AppendText(global::Mono.Unix.Catalog.GetString("false"));
		this.issue_inorder_option.Name = "issue_inorder_option";
		this.issue_inorder_option.Active = 0;
		this.fixed1.Add(this.issue_inorder_option);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.issue_inorder_option]));
		w24.X = 616;
		w24.Y = 162;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label14 = new global::Gtk.Label();
		this.label14.Name = "label14";
		this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("RUU Size");
		this.fixed1.Add(this.label14);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label14]));
		w25.X = 459;
		w25.Y = 323;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ruu_size_textbox = new global::Gtk.Entry();
		this.ruu_size_textbox.CanFocus = true;
		this.ruu_size_textbox.Name = "ruu_size_textbox";
		this.ruu_size_textbox.Text = global::Mono.Unix.Catalog.GetString("16");
		this.ruu_size_textbox.IsEditable = true;
		this.ruu_size_textbox.InvisibleChar = '•';
		this.fixed1.Add(this.ruu_size_textbox);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.ruu_size_textbox]));
		w26.X = 616;
		w26.Y = 320;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label16 = new global::Gtk.Label();
		this.label16.Name = "label16";
		this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("Benchmark");
		this.fixed1.Add(this.label16);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label16]));
		w27.X = 501;
		w27.Y = 16;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.benchmark_combobox = global::Gtk.ComboBox.NewText();
		this.benchmark_combobox.AppendText(global::Mono.Unix.Catalog.GetString("li.ss"));
		this.benchmark_combobox.AppendText(global::Mono.Unix.Catalog.GetString("su2cor.ss"));
		this.benchmark_combobox.AppendText(global::Mono.Unix.Catalog.GetString("swim.ss"));
		this.benchmark_combobox.AppendText(global::Mono.Unix.Catalog.GetString("tomcatv.ss"));
		this.benchmark_combobox.AppendText(global::Mono.Unix.Catalog.GetString("wave5.ss"));
		this.benchmark_combobox.Name = "benchmark_combobox";
		this.benchmark_combobox.Active = 0;
		this.fixed1.Add(this.benchmark_combobox);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.benchmark_combobox]));
		w28.X = 584;
		w28.Y = 9;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.startButton = new global::Gtk.Button();
		this.startButton.CanFocus = true;
		this.startButton.Name = "startButton";
		this.startButton.UseUnderline = true;
		this.startButton.Label = global::Mono.Unix.Catalog.GetString("Start");
		this.fixed1.Add(this.startButton);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.startButton]));
		w29.X = 760;
		w29.Y = 11;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.serverOutput = new global::Gtk.TextView();
		this.serverOutput.CanFocus = true;
		this.serverOutput.Name = "serverOutput";
		this.GtkScrolledWindow.Add(this.serverOutput);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w31.X = 10;
		w31.Y = 416;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.helpButton = new global::Gtk.Button();
		this.helpButton.CanFocus = true;
		this.helpButton.Name = "helpButton";
		this.helpButton.UseUnderline = true;
		this.helpButton.Label = global::Mono.Unix.Catalog.GetString("Help");
		this.fixed1.Add(this.helpButton);
		global::Gtk.Fixed.FixedChild w32 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.helpButton]));
		w32.X = 741;
		w32.Y = 54;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 823;
		this.DefaultHeight = 604;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.cache_type_combobox.Changed += new global::System.EventHandler(this.CacheType_onChange);
		this.startButton.Clicked += new global::System.EventHandler(this.startButton_OnClick);
		this.helpButton.Clicked += new global::System.EventHandler(this.helpClick);
	}
}
