using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.ViewsModel
{
	public class LoginViewModel

	{
		[DisplayName("Kullanici adi"),
		Required(ErrorMessage = " {0} alan bos gecilemez"),
		StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı.")]
		public string Username { get; set; }

		[DisplayName("Sifre"),
		Required(ErrorMessage = " {0} alan bos gecilemez"),
		DataType(DataType.Password),
		StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı.")]
		public string Password { get; set; }
	}
}