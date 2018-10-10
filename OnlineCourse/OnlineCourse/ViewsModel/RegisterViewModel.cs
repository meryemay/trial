using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.ViewsModel
{
	public class RegisterViewModel
	{
		[DisplayName("Kullanici adi"),
		Required(ErrorMessage = " {0} alan bos gecilemez"),
		StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı.")]
		public string Username { get; set; }

		[DisplayName("E-posta"),
		Required(ErrorMessage = " {0} alan bos gecilemez"),
		StringLength(70, ErrorMessage = "{0} max. {1} karakter olmalı."),
		EmailAddress(ErrorMessage = "{0} alanı için bir eposta adresi giriniz.")]
		public string Email { get; set; }

		[DisplayName("Sifre"),
		Required(ErrorMessage = " {0} alan bos gecilemez"),
		DataType(DataType.Password),
		StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı.")]
		public string Password { get; set; }

		[DisplayName("Sifre Tekrar"),
		Required(ErrorMessage = " {0} alan bos gecilemez"),
		DataType(DataType.Password),
		StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı."),
		Compare("Password", ErrorMessage = "{0} ile {1} uyuşmuyor.")]
		public string Repassword { get; set; }
	}
}