using ProiectAA;
using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    SimData sim_data;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void get_sim_elements()
    {
        sim_data = new SimData();
        
    }

    protected void startButton_OnClick(object sender, EventArgs e)
    {
        //MessageDialog dialog = new MessageDialog(this, DialogFlags.DestroyWithParent, MessageType.Question, ButtonsType.YesNo, "Aolo ai belit pula");

        //dialog.Run();
    }

    protected void CacheType_onChange(object sender, EventArgs e)
    {
        string cache_type = cache_type_combobox.ActiveText;

        if (cache_type.Equals("dl1")) {
            sets_textbox.Text = "128";
            blocksize_textbox.Text = "32";
            asoc_textbox.Text = "4";
        }
        else if (cache_type.Equals("dl2")){
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
}
