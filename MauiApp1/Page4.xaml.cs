namespace MauiApp1;
using MauiApp1.Models;
public partial class Page4 : ContentPage
{
    int par_ID;
    int chi_ID;
    public Page4()
	{
		InitializeComponent();

        
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        assilistXaml.ItemsSource = App.DBTrans.GetAssignments();

    }

    private void SHOW_Clicked(object sender, EventArgs e)
    {
        assilistXaml.ItemsSource = App.DBTrans.GetAssignments();
    }
}