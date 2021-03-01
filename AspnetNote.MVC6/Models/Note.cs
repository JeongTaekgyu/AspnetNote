using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetNote.MVC6.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]
        public int NoteNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required]  // Not NULL 설정
        public string NoteTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required]  // Not NULL 설정
        public int NoteContents { get; set; }

        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required]  // Not NULL 설정
        public int UserNo { get; set; }

        [ForeignKey("UserNo")]  // UserNo 를 외래키로 설정
        public virtual User User { get; set; }
        // entity framework 자체에서 이 테이블 외에 다른 테이블정보를? 가져오려면 virtual 을 사용하기를 권장한다.
    }
}
