

namespace MauiApp1;

public partial class Page1 : ContentPage
{
    string gender;
	public Page1()
	{
		InitializeComponent();
        listXaml.ItemsSource = App.DBTrans.GetChilds();

    }

    private void add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddChild(new Models.Child
        {
            C_Name = cname.Text,
            C_L_Name = clastName.Text,
            C_Gender = gender
            
        });
        listXaml.ItemsSource = App.DBTrans.GetChilds();

        if (male.IsChecked)
            gender = "male";
        if (female.IsChecked)
            gender = "female";
        
    }

    private void show_Clicked(object sender, EventArgs e)
    {

    }
}