using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace Module25.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Unit2-4
            //using (var db = new AppContext())
            //{
            #region Unit_2
            //// Использование EF
            //var user1 = new User { Name = "Arthur", Role = "Admin" };
            //var user2 = new User { Name = "Klim", Role = "User" };

            //db.Users.Add(user1);
            //db.Users.Add(user2);
            //db.SaveChanges();
            #endregion
            #region Unit_3
            #region Create (Add)
            //var user1 = new User { Name = "Alice", Role = "User" };
            //var user2 = new User { Name = "Bob", Role = "User" };
            //var user3 = new User { Name = "Bruce", Role = "User" };

            //// Добавление одиночного пользователя
            //db.Users.Add(user1);

            //// Добавление нескольких пользователей
            //db.Users.AddRange(user2, user3);

            //db.SaveChanges();
            #endregion
            #region Read (Выбор объектов из базы)
            //// Выбор всех пользователей
            //var allUsersd = db.Users.ToList();

            //// Выбор пользователей с ролью "Admin"
            //var admins = db.Users.Where(user => user.Role == "Admin").ToList();
            #endregion
            #region Update
            //// Выбор первого пользователя в таблице
            //var firstUser = db.Users.FirstOrDefault();

            //firstUser.Email = "simpleemail@gmail.com";
            //db.SaveChanges();
            #endregion
            #region Delete
            //var user3 = new User { Id = 5, Name = "Bruce", Role = "User" };

            ////db.Users.Remove(user3);
            //db.Entry(user3).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //db.SaveChanges();
            #endregion
            #endregion
            #region Unit_4
            #region Один к одному
            //var user1 = new User { Name = "Arthur", Role = "Admin" };
            //var user2 = new User { Name = "Bob", Role = "Admin" };
            //var user3 = new User { Name = "Clark", Role = "User" };
            //var user4 = new User { Name = "Dan", Role = "User" };

            //// Добавляем user2 и сохраняем, чтобы получить Id
            //db.Users.Add(user2);
            //db.SaveChanges();

            //db.Users.AddRange(user1, user3, user4);

            //var user1Creds = new UserCredential { Login = "ArthurL", Password = "qwerty123" };
            //var user2Creds = new UserCredential { Login = "BobJ", Password = "asdfgh585" };
            //var user3Creds = new UserCredential { Login = "ClarkK", Password = "111zlt777" };
            //var user4Creds = new UserCredential { Login = "DanE", Password = "zxc333vbn" };

            //// Связать объекты сущностей User и UserCredential можно несколькими способами: 
            //// Через свойство User в объекте класса UserCredential(user1Creds.User = user1);
            //// Через свойство UserCredential в объекте класса User(user3.UserCredential = user3Creds);
            //// Через передачу Id пользователя в свойство UserId.Данный способ будет работать, только если
            //// у вас есть Id пользователя, и он уже был записан в БД(user2Creds.UserId = user2.Id).

            //user1Creds.User = user1;
            //user2Creds.UserId = user2.Id;
            //user3.UserCredential = user3Creds;
            //user4.UserCredential = user4Creds;

            //// Не добавляем user1Creds в БД
            //db.UserCredentials.AddRange(user2Creds, user3Creds, user4Creds);

            //db.SaveChanges();
            #endregion
            #region Один ко многим
            //var company1 = new Company { Name = "SF" };
            //var company2 = new Company { Name = "VK" };

            //var company3 = new Company { Name = "FB" };
            //db.Companies.Add(company3);
            //db.SaveChanges();

            //var user1 = new User { Name = "Arthur", Role = "Admin" };
            //var user2 = new User { Name = "Bob", Role = "Admin" };
            //var user3 = new User { Name = "Clark", Role = "User" };

            //user1.Company = company1;
            //company2.Users.Add(user2);
            //user3.CompanyId = company3.Id;

            //db.Companies.AddRange(company1, company2);
            //db.Users.AddRange(user1, user2, user3);

            //db.SaveChanges();
            #endregion
            #region Многие ко многим
            //var topic1 = new Topic { Name = "Раздел 1" };
            //var topic2 = new Topic { Name = "Раздел 2" };
            //var topic3 = new Topic { Name = "Раздел 3" };

            //var user1 = new User { Name = "Пользователь 1", Email = "gmail1@gmail.com" };
            //var user2 = new User { Name = "Пользователь 2", Email = "gmail2@gmail.com" };
            //var user3 = new User { Name = "Пользователь 3", Email = "gmail3@gmail.com" };
            //var user4 = new User { Name = "Пользователь 4", Email = "gmail4@gmail.com" };

            //topic1.Users.AddRange(new[] { user3, user4 });
            //topic1.Users.AddRange(new[] { user1, user2 });
            //user1.Topics.AddRange(new[] { topic1, topic3 });

            //db.Topics.AddRange(topic1, topic2, topic3);
            //db.Users.AddRange(user1, user2, user3, user4);

            //db.SaveChanges();
            #endregion
            #endregion
            //}
            #endregion
            #region Unit_5
            // Создаем контекст для добавления данных
            using (var db = new AppContext())
            {
                // Пересоздаем базу
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                // Заполняем данными
                var company1 = new Company { Name = "SF" };
                var company2 = new Company { Name = "VK" };
                var company3 = new Company { Name = "FB" };
                db.Companies.AddRange(company1, company2, company3);

                var user1 = new User { Name = "Arthur", Role = "Admin", Company = company1 };
                var user2 = new User { Name = "Bob", Role = "Admin", Company = company2 };
                var user3 = new User { Name = "Clark", Role = "User", Company = company2 };
                var user4 = new User { Name = "Dan", Role = "User", Company = company3 };

                db.Users.AddRange(user1, user2, user3, user4);

                db.SaveChanges();
            }

            // Создаем контекст для выбора данных
            using (var db = new AppContext())
            {
                var usersQuery =
                    from user in db.Users // При таких запросах мы получаем данные только из таблицы пользователей,
                                          // а значит, свойство Company для полученных пользователей будет равно null.
                                          // Для того чтобы включить данные и по компании в запрос, следует уточнить
                                          // таблицу с помощью Include:
                                          // from user in db.Users.Include(u => u.Company)
                    where user.CompanyId == 2
                    select user;
                // var usersQuery = db.Users.Where(u => u.CompanyId == 2); (Аналог записи выше с помощью методов-расширения LINQ)

                // При таких запросах мы получаем данные только из таблицы пользователей,
                // а значит, свойство Company для полученных пользователей будет равно null.
                // Для того чтобы включить данные и по компании в запрос, следует уточнить
                // таблицу с помощью Include:
                // var usersQuery = db.Users.Include(u => u.Company).Where(u => u.CompanyId == 2);

                // Также важно понимать, что поскольку мы выбираем данные по связанным компаниям, мы можем преобразовать запрос:
                // var usersQuery = db.Users.Include(u => u.Company).Where(u => u.Company.Id == 2);
                // или
                // var usersQuery = db.Users.Include(u => u.Company).Where(u => u.Company.Name == "VK");

                //var users = usersQuery.ToList();

                //foreach (var user in users)
                //{
                //    // Вывод Id пользователей
                //    Console.WriteLine(user.Id);
                //}

                var users = db.Users.Where(v => v.CompanyId == 2);

                var userCompany = db.Users.Select(v => v.Company);

                var firstUser = db.Users.First();

                var joinedCompanies = db.Users.Join(db.Companies, c => c.CompanyId, p => p.Id, (p, c) => new { CompanyName = c.Name });

                var sumCompanies = db.Users.Sum(v => v.CompanyId);
            }

            // Создаем контекст для добавления данных
            using (var db = new AppContext())
            {
                var query1 = db.Users
                    .ToList()                       // Выполняет запрос
                    .Where(u => u.Role == "Admin"); // Фильтрует

                var query2 = db.Users
                    .Where(u => u.Role == "Admin")  // Фильтрует
                    .ToList();                      // Выполняет запрос
            }
            #endregion
        }
    }
}