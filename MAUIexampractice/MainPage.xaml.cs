


namespace MAUIexampractice;

public partial class MainPage : ContentPage
{
    double I1_Price = -1;
    double I2_Price = -1;
    double I3_Price;
    string I1_Name;
    string I2_Name;
    string I3_Name;
    string I1_IMG;
    string I2_IMG;
    string I3_IMG;


    public List<Products> PurchList = new List<Products>();
    public MainPage()
    {
        InitializeComponent();

        var LaptopList = new List<Products>
        {
            new Products ("Asus Rog Laptop",17999,"com1.png"),
            new Products ("Lenovo IdeaPad Laptop",16999,"com2.png"),
            new Products ("Monster Laptop",14999,"com3.png"),
        };
        var MouseList = new List<Products>
        {

            new Products ("Asus Rog Mouse",350,"mouse1.png"),
            new Products ("Lenovo Mouse",150,"mouse2.png"),
            new Products ("Monster Mouse",250,"mouse3.png"),
        };

        Laptop_List_View.ItemsSource = LaptopList;
        Mouse_List_View.ItemsSource = MouseList;
    }

    private void Laptop_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var Laptop = (Products)e.Item;
        I1_IMG = Laptop.IMG;
        I1_Name = Laptop.Name;
        I1_Price = Laptop.Price;
    }

    private void Mouse_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var Mouse = (Products)e.Item;
        I2_IMG = Mouse.IMG;
        I2_Name = Mouse.Name;
        I2_Price = Mouse.Price;
    }

    private async void ChartButton_Clicked(object sender, EventArgs e)
    {
        if (I1_Price == -1 || I2_Price == -1)
        {
            await DisplayAlert("Error", "Please Select Products", "OK");
        }
        else
        {
            PurchList.Clear();
            PurchList.Add(new Products(I1_Name, I1_Price, I1_IMG));
            PurchList.Add(new Products(I2_Name, I2_Price, I2_IMG));

            PurchList.Add(new Products("Total", I1_Price + I2_Price, ""));

            Purchase_List_View.ItemsSource = null;
            Purchase_List_View.ItemsSource = PurchList;
        }
    }
}

