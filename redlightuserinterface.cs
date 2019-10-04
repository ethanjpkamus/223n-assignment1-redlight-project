using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

//.fillellipse()

public class redlightuserinterface: Form
{
     private Label title = new Label();
     private Button pause_resume_button = new Button();
     private Button exit_button = new Button();
     private Size maximumfibonacciinterfacesize = new Size(1000,700);
     private Size minimumfibonacciinterfacesize = new Size(1000,700);
     private bool redlight_on = false;
     private static System.Timers.Timer patek = new System.Timers.Timer();
     private SolidBrush redbrush = new SolidBrush(Color.Red);
     private SolidBrush greybrush = new SolidBrush(Color.Transparent);
     private SolidBrush rectbrush = new SolidBrush(Color.White);

     public void switch_pr_button(Object sender, EventArgs events){
          patek.Enabled = !patek.Enabled;
          pause_resume_button.Text = getprbutton();
     }

     protected override void OnPaint(PaintEventArgs e){
          Graphics graph = e.Graphics;
          graph.FillRectangle(rectbrush,0,500,1000,200);
          if(redlight_on){
               graph.FillEllipse(redbrush,300,75,400,400);
          }
          else{
               graph.FillEllipse(greybrush,300,75,400,400);
          }
          base.OnPaint(e);
     }

     protected void update_redlight(System.Object sender, ElapsedEventArgs events){
          redlight_on = !redlight_on;
          Invalidate();
     }

     protected void stoprun(Object sender, EventArgs events){
          Close();
     }

     public string getprbutton(){
          if(patek.Enabled){
               return "Pause";
          }
          return "Resume";
     }
     public redlightuserinterface(){
          //Set the size of the user interface box.
          MaximumSize = maximumfibonacciinterfacesize;
          MinimumSize = minimumfibonacciinterfacesize;

          patek.Interval = 100;
          patek.Enabled = false;

          //Initialize text strings
          Text = "Creepy Red Light";

          title.Text = "Red Light Project created by Ethan Kamus";
          pause_resume_button.Text = "Resume";
          exit_button.Text = "Exit";

          //Set sizes
          Size = new Size(1000,700);

          title.Size = new Size(400,20);
          pause_resume_button.Size = new Size(175,75);
          exit_button.Size = new Size(175,75);

          //Set locations
          title.Location = new Point(0,0);
          pause_resume_button.Location = new Point(50,550);
          exit_button.Location = new Point(770,550);

          //Add controls to the form
          Controls.Add(title);
          Controls.Add(pause_resume_button);
          Controls.Add(exit_button);

          patek.Elapsed += new ElapsedEventHandler(update_redlight);
          patek.AutoReset = true;
          patek.Enabled = false;

          //Register the event handler.  In this case each button has an event handler, but no other
          //controls have event handlers.
          pause_resume_button.Click += new EventHandler(switch_pr_button);
          exit_button.Click += new EventHandler(stoprun);  //The '+' is required.

     }//End of constructor Fibuserinterface
}
