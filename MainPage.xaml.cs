namespace BurgerShop;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        var IngredientType = new List<string>();
        IngredientType.Add("Говядина");
        IngredientType.Add("Свинина");
        IngredientType.Add("Курица");
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{

	}

    private void IngridientPicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

