namespace MemoryLeakDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    
    private void Image1Btn_OnClicked(object? sender, EventArgs e)
    {
        Image.Source = "icon_info.svg";
    }
    
    private void Image2Btn_OnClicked(object? sender, EventArgs e)
    {
        Image.Source = "dotnet_bot.svg";
    }
}