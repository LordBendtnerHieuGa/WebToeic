﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using WebToeic.WebAppMVC.Data.Entities;

namespace WebToeic.WebAppMVC.ViewModels
{
    public class InforVM : User
    {
        [Required(ErrorMessage = "Hãy nhập tên của bạn")]
        public string UserName { get; set; } = default!;

        [EmailAddress]
        [Required(ErrorMessage = "Hãy nhập email của bạn")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Hãy nhập mật khẩu của bạn")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Required(ErrorMessage = "Hãy nhập mật khẩu của bạn")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; } = default!;

        [Display(Name = "Hãy xác nhận mật khẩu")]
        [Required(ErrorMessage = "Hãy nhập mật khẩu của bạn lần nữa")]
        [Compare("Password", ErrorMessage = "Hai mật khẩu không trùng nhau ")]
        public string ConfirmPassword { get; set; } = default!;

    }
}
