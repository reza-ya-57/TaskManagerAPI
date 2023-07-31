using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Web.APIModels.AuthDto
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "وارد کردن نام کاربری الزامی است")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "وارد کردن رمز عبور الزامی است")]
        public string Password { get; set; }
    }
}
