using Microsoft.Maui.Layouts;

namespace PaddingSample;

public class LabelExt : Label
{
    public LabelExt()
    {
        
    }
}
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        childLayout.Padding = new Thickness(60);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        childLayout.Padding = new Thickness(40);
    }
}

