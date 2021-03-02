using AspnetNote.MVC6.DataContext;
using AspnetNote.MVC6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetNote.MVC6.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet] // 입력 없으면 default 값은 [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 회원 가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)// 메서드이름만 같고 인자 다르게해서 오버로딩한다.
        {
            // 벨리데이션 체크?
            if (ModelState.IsValid) // 사용자한테 필수로 입력받아야할 내용을 모두 입력 받았느냐
            {
                using (var db = new AspnetNoteDbContext())
                {
                    // 사용자 한테 입력받은 데이터가 model 이기 때문에 model은 사용한다.
                    // ★ 모두 필수적으로 입력을 받았는지 안받았는지 판단하는 기준은 Model에 있는 [Required] 기준이다
                    // 즉, Required된 값이 모두 입력받지 못하면 IsValid는 false이다.★
                    db.Users.Add(model);// 메모리 까지 올리기 -> 디버깅해보면 OnConfiguring 간다
                    db.SaveChanges();   // 실제 sql로 저장(DB에 commit)
                }
                // Register View에서 다른 뷰로 전달
                return RedirectToAction("Index", "Home"); // HomeController에 있는 Index 액션으로 전달을 하겠다.
            
            }
            // 벨리데이션 체크 실패하면
            return View(model); // Register 뷰로 다시 돌아간다.
        }

        // db 자원을 쓰고 난 다음에 반환을 시켜줘야 메모리 누수나 그런게 없다
    }
}
