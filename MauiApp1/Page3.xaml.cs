
using MauiApp1.Models;


namespace MauiApp1;

public partial class Page3 : ContentPage
{
    int par_ID;
    int chi_ID;
    public Page3()
	{
		InitializeComponent();
        ClistXaml.ItemsSource = App.DBTrans.GetChilds();
        parentlistXaml.ItemsSource = App.DBTrans.GetParents();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        
        ClistXaml.ItemsSource = App.DBTrans.GetChilds();
        parentlistXaml.ItemsSource = App.DBTrans.GetParents();
        
    }

    private void parentlistXaml_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var p = e.Item as Parent;
        par_ID = p.P_ID;
    }

    private void ClistXaml_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var c = e.Item as Child;
        chi_ID = c.C_ID;
    }

    private void ADD_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddAssignment(new Models.Assignment
        {
            C_ID = chi_ID,
            P_ID = par_ID

        });
    }
}