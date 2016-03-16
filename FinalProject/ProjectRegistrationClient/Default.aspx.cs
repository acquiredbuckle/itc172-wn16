using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SelectServiceReference.SelectServiceClient sc = new SelectServiceReference.SelectServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateShowDropDownList();
            PopulateVenueDropDownList();
            PopulateaArtistDropDownList();
        }

    }
    protected void PopulateShowDropDownList()
    {
        string[] shows = sc.GetShows();
        ShowDropDownList.DataSource = shows;
        ShowDropDownList.DataBind();
    }
    protected void PopulateVenueDropDownList()
    {
        string[] venues = sc.GetVenues();
        VenueDropDownList.DataSource = venues;
        VenueDropDownList.DataBind();
    }
    protected void PopulateaArtistDropDownList()
    {
        string[] artists = sc.GetArtists();
        ArtistDropDownList.DataSource = artists;
        ArtistDropDownList.DataBind();
    }

    protected void PopulateDataListVenue()
    {
        string venueName = VenueDropDownList.SelectedItem.ToString();
        SelectServiceReference.ShowInfo[] shows = sc.GetShowsByVenue(venueName);
        ShowByVenueDataList.DataSource = shows;
        ShowByVenueDataList.DataBind();
    }
    protected void ShowByVenueButton_Click(object sender, EventArgs e)
    {
        PopulateDataListVenue();
    }

    protected void PopulateDataListArtist()
    {
        string artistName = ArtistDropDownList.SelectedItem.ToString();
        SelectServiceReference.ShowInfo[] artists = sc.GetShowsByArtist(artistName);
        ShowByArtistDataList.DataSource = artists;
        ShowByArtistDataList.DataBind();
    }
    protected void ShowByArtistButton_Click(object sender, EventArgs e)
    {
        PopulateDataListArtist();
    }
}