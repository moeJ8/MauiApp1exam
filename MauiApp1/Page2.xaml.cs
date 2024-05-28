namespace MauiApp1;

public partial class Page2 : ContentPage
{
    string gender;
	public Page2()
	{
		InitializeComponent();
        parentlistXaml.ItemsSource = App.DBTrans.GetParents();

    }

    private void add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddParent(new Models.Parent
        {
            P_Name = name.Text,
            P_L_Name = lastName.Text,
            P_Tel = tel.Text,
            P_Mother_Father = gender

        });
        parentlistXaml.ItemsSource = App.DBTrans.GetParents();

        if (mother.IsChecked)
            gender = "mother";
        if (father.IsChecked)
            gender = "father";
    }

    private void show_Clicked(object sender, EventArgs e)
    {

    }
}