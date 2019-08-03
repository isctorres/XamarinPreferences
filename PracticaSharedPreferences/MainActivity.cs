using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using Android.Preferences;

namespace PracticaSharedPreferences
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Android.Content.ISharedPreferences preferences = GetSharedPreferences("PreferenciasUsuario", Android.Content.FileCreationMode.Private);
            //Android.Content.ISharedPreferences preferences = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
           
            string preferenciaUsuario = preferences.GetString("Usuario", "isctorres");
            string preferenciaCorreo = preferences.GetString("Correo", "isctorres@gmail.com");

            EditText usuario = FindViewById<EditText>(Resource.Id.etUsuario);
            usuario.Text = preferenciaUsuario;
            EditText correo = FindViewById<EditText>(Resource.Id.etCorreo);
            correo.Text = preferenciaCorreo;

            var preferencias = Android.Support.V7.Preferences.PreferenceManager.GetDefaultSharedPreferences(this);
            string backGroundColor = preferencias.GetString("BackGroundColor", "#fff111");
            string keyNombreUsuario = preferencias.GetString("KeyNombreUsuario", "desconocido");

            LinearLayout layoutPrincipal = FindViewById<LinearLayout>(Resource.Id.layoutPrincipal);
            layoutPrincipal.SetBackgroundColor(Android.Graphics.Color.ParseColor(backGroundColor));
        }

        protected override void OnStop()
        {
            base.OnStop();
            Android.Content.ISharedPreferences preferences = GetSharedPreferences("PreferenciasUsuario", Android.Content.FileCreationMode.Private);
            Android.Content.ISharedPreferencesEditor editor = preferences.Edit();
            EditText usuario = FindViewById<EditText>(Resource.Id.etUsuario);
            string preferenciaUsuario = usuario.Text;
            EditText correo = FindViewById<EditText>(Resource.Id.etCorreo);
            string preferenciaCorreo = correo.Text;
            editor.PutString("Usuario", preferenciaUsuario);
            editor.PutString("Correo", preferenciaCorreo);
            editor.Commit();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}