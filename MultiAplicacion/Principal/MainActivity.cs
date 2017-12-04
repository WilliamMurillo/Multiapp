using Android.App;
using Android.Widget;
using Android.OS;

namespace Principal
{
    [Activity(Label = "Apps", MainLauncher = true)]
    public class MainActivity : Activity
    {
         ImageButton btnCalendar, btnTraslate, btnConversormoneda, btnConversorUnidades, btnPaint, btnContactos, btnCalculadora;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            
        }
    }
}

