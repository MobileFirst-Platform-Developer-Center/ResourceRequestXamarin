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
namespace ResourceRequestXamarinForms
{
	public class User
	{
		public string FirstName { get; private set; }
		public string MiddleName { get; private set; }
		public string LastName { get; private set; }
		public string Age { get; private set; }
		public string Height { get; private set; }
		public string BirthDate { get; private set; }

		public User(string FirstName,string MiddleName,string LastName,string Age,string Height,string BirthDate)
		{
			this.FirstName = FirstName;
			this.MiddleName = MiddleName;
			this.LastName = LastName;
			this.Age = Age;
			this.Height = Height;
			this.BirthDate = BirthDate;
		}
	}
}
