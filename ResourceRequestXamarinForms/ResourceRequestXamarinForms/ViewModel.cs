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

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Worklight;
using System.Collections.Generic;
using System.Net;

namespace ResourceRequestXamarinForms
{
	public class ViewModel : INotifyPropertyChanged
	{
		public ICommand SubmitCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public ViewModel()
		{
			SubmitCommand = new Command(SubmitValues);
		}

		private async void SubmitValues()
		{
			User _UserFromPage = ResourceRequestXamarinFormsPage.GetTextValues();

			IWorklightClient _newClient = App.GetWorklightClient;

			StringBuilder uriBuilder = new StringBuilder().Append("/adapters/JavaAdapter/users")
			                                              .Append("/").Append(_UserFromPage.FirstName)
														  .Append("/").Append(_UserFromPage.MiddleName)
														  .Append("/").Append(_UserFromPage.LastName);

			WorklightResourceRequest rr = _newClient.ResourceRequest(new Uri(uriBuilder.ToString(),UriKind.Relative), "POST", "");

			rr.SetQueryParameter("age", _UserFromPage.Age);

			System.Net.WebHeaderCollection headerCollection = new WebHeaderCollection();

			headerCollection["birthdate"] = _UserFromPage.BirthDate;

			rr.AddHeader(headerCollection);

			Dictionary<string, string> formParams = new Dictionary<string, string>();
			formParams.Add("height", _UserFromPage.Height);

			WorklightResponse resp = await rr.Send(formParams);

			Debug.WriteLine(resp.ResponseJSON);

			ResourceRequestXamarinFormsPage.DisplayOutput(resp.ResponseText);

		}

	}
}
