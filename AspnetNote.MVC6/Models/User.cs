using System.ComponentModel.DataAnnotations;

namespace AspnetNote.MVC6.Models
{
    public class User
    {
        // controll . 눌러 주면 알아서 뜬다.
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key]   // PK 설정
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage ="사용자 이름을 입력하세요")]  // Not NULL 설정 (NULL 설정해줄때는 [Required] 안써주면 된다.)
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage = "사용자 ID를 입력하세요")]  // Not NULL 설정
        public string UserId { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [Required(ErrorMessage = "사용자 비밀번호를 입력하세요")]  // Not NULL 설정
        public string UserPassword { get; set; }
    }
}
