﻿// ReSharper disable RedundantUsingDirective
using System;
// ReSharper restore RedundantUsingDirective

namespace Ewars.Models
{
	public class User
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public string EMailAddress { get; set; }
		public string ImageSourcePath { get; set; }
	}
}
