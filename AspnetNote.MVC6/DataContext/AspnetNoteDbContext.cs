using AspnetNote.MVC6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetNote.MVC6.DataContext
{
    // code first를 위한 DbContext 상속
    public class AspnetNoteDbContext : DbContext // (참고로 DbContext에 control . 누르고 EntityFrameworkCore 최신판 설치 눌렀다.)
    {
        // 테이블 자체를 생성하는 코드
        public DbSet<User> Users { get; set; } // 제네릭 타입 이젠 좀 

        public DbSet<Note> Notes { get; set; }

        // 마이그레이션이라는 과정을 넘거가면 db가 자동으로 생성?

        // db랑 연결될 커넥션을 만드는 방법
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // @ 기호는 ""안에 있는 string을 정확하게 전달하겠다는 표시이다. // 이게 db커넥션스트링?
            optionsBuilder.UseSqlServer(@"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            //base.OnConfiguring(optionsBuilder);
            // connection string은
        }
    }
}
