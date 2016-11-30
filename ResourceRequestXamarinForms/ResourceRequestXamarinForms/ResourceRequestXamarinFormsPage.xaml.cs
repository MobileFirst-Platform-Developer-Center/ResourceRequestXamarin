/**
* Copyright 2016 IBM Corp.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System.Diagnostics;
using Xamarin.Forms;

namespace ResourceRequestXamarinForms
{
	public partial class ResourceRequestXamarinFormsPage : ContentPage
	{
		public static ResourceRequestXamarinFormsPage _this;

		public ResourceRequestXamarinFormsPage()
		{
			Debug.WriteLine("Before initialize");
			InitializeComponent();
			_this = this;
			BindingContext = new ViewModel();
		}

		public static User GetTextValues()
		{
			User _user = new User(_this.FirstName.Text, _this.MiddleName.Text, _this.LastName.Text,
			                      _this.Age.Text, _this.Height.Text, _this.BirthDate.Text);
			return _user;
		}

		public static void DisplayOutput(string output)
		{
			_this.Output.Text = output;
		}
	}
}
