using Android.App;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace DividerItemDecorationProblem
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

			var layoutManager = new LinearLayoutManager(this);

			var divider = ContextCompat.GetDrawable(this, Resource.Layout.cell_divider);
			var itemDecoration = new DividerItemDecoration(this, DividerItemDecoration.Vertical);
			itemDecoration.SetDrawable(divider);

			var _recyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);
			_recyclerView.SetLayoutManager(layoutManager);
			_recyclerView.AddItemDecoration(itemDecoration);

		}
	}
}

