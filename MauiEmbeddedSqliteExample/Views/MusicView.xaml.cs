using MauiEmbeddedSqliteExample.ViewModel;

namespace MauiEmbeddedSqliteExample.Views;

public partial class MusicView : ContentPage
{
	public MusicView(MusicViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}

	protected override void OnAppearing()
	{
        base.OnAppearing();

        ((MusicViewModel)BindingContext).OnAppearing();
    }
}