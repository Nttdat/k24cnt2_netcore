using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NttdLesson09Annotation.Models.DataViewModels
{
    public class NttdMemberRegister
    {
        public int NttdMemberId { get; set; }
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(20, ErrorMessage = "Tên đăng nhập có độ dài 20 ký tự")]
        public string? NttdMemberUserName { get; set; }
        [DisplayName("Họ và Tên")]
        [Required(ErrorMessage = "Họ và Tên không được để trống")]
        public string? NttdMemberPassWord { get; set; }
        [DisplayName("PassWord")]
        [Required(ErrorMessage = "PassWord không được để trống")]
        [StringLength(20, ErrorMessage = "PassWord có độ dài 20 ký tự")]
        public string? NttdMemberEmail { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? NttdMemberPhoneNumber { get; set; }
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Bắt đầu bằng 0 và có 10 hoặc 12 chữ số")]
        public DateTime? NttdMemberBirthday { get; set; } 


    }
}
