using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Web.Dtos.BaseDto
{
    public class PersonRequest
    {
        [Required(ErrorMessage = "وارد کردن نام اجرای است")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "وارد کردن نام خانوادگی اجرای است")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "وارد کردن کدملی اجرای است")]
        public string NationalCode { get; set; }
        [Required(ErrorMessage = "وارد کردن شماره موبایل اجرای است")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
