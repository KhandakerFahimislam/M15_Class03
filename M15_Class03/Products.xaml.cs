
using M15_Class03.ViewModels;
using System.Net.Http.Json;

namespace M15_Class03;

public partial class Products : ContentPage
{
	ProductCollection productCollection;
	public Products()
	{
		InitializeComponent();
		this.productCollection = new ProductCollection();
		this.Init();
	}

	public async void Init()
	{
		await LoadData();
	}

	private async Task LoadData()
	{
		var http = new HttpClient();
		string url = "http//http://localhost:5179";
		if(DeviceInfo.Platform==DevicePlatform.Android)
		{
			url = "http://10.0.2.2:5179";
		}
		var data = await http.GetFromJsonAsync<List<ProductViewModel>>($"{url}/api/products");

		foreach ( var item in data )
		{
			item.RemotePictureUrl = $"{url}/Pictures/{item.Picture}";
				productCollection.Add(item);

		}

	}
}