using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewReview : System.Web.UI.Page
{
     LoginServiceReference.IShowTrackLoginService lsr = LoginServiceReference.IShowTrackLoginService();
     SelectServiceReference.ISelectService ssc = SelectServiceReference.ISelectServic();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["VenueKey"] != null)
        {
            if (!IsPostBack)
            {
                PopulateArtistNameList();
                Panel1.Visible = false;
            }
        }
        else
        {
            Response.Redirect("VenueLogin.aspx");
        }
    }
        protected void PopulateArtistNameList() 
        {
            string[] names = ssc.GetArtists();
            ArtistNameDropDownList.DataSource = names;
            ArtistNameDropDownList.DataBind();
            ArtistNameDropDownList.Items.Add("New Artist");
        }

    protected void ArtistNameDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
        if(ArtistNameDropDownList.SelectedItem.Text.Equals("New Artist"))
        {
            Panel1.Visible = true;
        }

        }

    protected void AddShow()
    {
        LoginServiceReference.NewShow ns = new LoginServiceReference.NewShow();
        ns.ShowName = ShowTitleTextBox.Text;
        ns.ShowDate = ShowDateCalendar.DataBind;
        ns.SHowTime = ShowTimeTextBox.Text;
        ns.ShowTicketInfo = TicketInfoTextBox.Text;
        ns.ShowDateEntered = DateTime.Now;

        lsr.AddShow(ns);
    }

    protected void SaveShowButton_Click(object sender, EventArgs e)
    {
        AddShow();
    }

 }
