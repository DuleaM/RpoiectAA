﻿using ProiectAA;
using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    SimData sim_data;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        serverOutput.WidthRequest = 800;
        serverOutput.HeightRequest = 300;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void get_sim_elements()
    {
    }

    protected void startButton_OnClick(object sender, EventArgs e)
    {

        //Start Conncetion with the details from UI
        sim_data = new SimData();

        string hostname = hostname_textbox.Text;
        int port = Convert.ToInt32(port_textbox.Text);

        try {
            Consumer.start_connection(hostname, port);
        }
        catch
        {
            return;
        }

        //Get Details from text boxes
        //Benchmark
        sim_data.Benchmark = benchmark_combobox.ActiveText;


        //Get Cache Details
        sim_data.CacheType = cache_type_combobox.ActiveText;
        sim_data.CacheSets = sets_textbox.Text;
        sim_data.CacheBlockSize = blocksize_textbox.Text;
        sim_data.CacheAsoc = asoc_textbox.Text;


        //Get Sim Details
        sim_data.NrInstructions = nr_instructions_textbox.Text;
        sim_data.IssueInOrder = issue_inorder_option.ActiveText;
        sim_data.IssueWidth = issue_width_textbox.Text;
        sim_data.IFQsize = if_queuesize_textbox.Text;
        sim_data.Mplat = branch_latency_textbox.Text;
        sim_data.RUU = ruu_size_textbox.Text;

        Consumer.send_command_to_server(sim_data.getCommand());
        serverOutput.Buffer.Text = Consumer.get_output_from_server();

    }

    protected void CacheType_onChange(object sender, EventArgs e)
    {
        string cache_type = cache_type_combobox.ActiveText;

        if (cache_type.Equals("dl1")) {
            sets_textbox.Text = "128";
            blocksize_textbox.Text = "32";
            asoc_textbox.Text = "4";
        }
        else if (cache_type.Equals("ul2")){
            sets_textbox.Text = "1024";
            blocksize_textbox.Text = "64";
            asoc_textbox.Text = "4";
        } 
        else if (cache_type.Equals("il1")){
            sets_textbox.Text = "512";
            blocksize_textbox.Text = "32";
            asoc_textbox.Text = "1";
        }

    }

    protected void helpClick(object sender, EventArgs e)
    {
        string program = "evince";
        string filepath = "/home/licenta/AA/RpoiectAA/ProiectAA/ProiectAA/Help.pdf";
        System.Diagnostics.Process.Start(program, filepath);
    }
}
