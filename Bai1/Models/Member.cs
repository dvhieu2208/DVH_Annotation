using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bai1.Models
{
    // Models class Menber
    public class Member
    {
        [Required(ErrorMessage ="Hãy nhập id")]
        public int Id { get; set; }
        [DisplayName("Tài khoản")]
        [Required(ErrorMessage = "Tài khoản không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tài khoản có độ dài trong khoảng 3 - 20 ký tự")]
        public string UserName { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu tối thiểu 8 ký tự")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage ="Email không được để trống")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = " Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,9}$",ErrorMessage ="Phải bắt đầu bằng số 0 và dài 10 số")]
        public string Phone { get; set; }
    }
}
