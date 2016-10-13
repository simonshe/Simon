
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Simon.Droid
{
	[Activity(Label = "MyWebActivity")]
	public class MyWebActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here

			//1.controller vs. view

			SetContentView(Resource.Layout.cashflow_mywebview);

			//2.UIControl Binding 

			var btn = FindViewById<Button>(Resource.Id.cashflow_mywebview_btnGo);
			var txt = FindViewById<EditText>(Resource.Id.cashflow_mywebview_txtURL);
			var web = FindViewById<WebView>(Resource.Id.cashflow_mywebview_webview);








		}
	}
}
