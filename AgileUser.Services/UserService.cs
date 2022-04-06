using AgileUser.Data;
using AgileUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileUser.Services
{
    public class UserService
    {
        private readonly Guid _userId;

        public UserService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    OwnerId = _userId,
                    Name = model.Name,
                    PreferredClass = model.PrefferedClass
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<UserListItem> GetUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Users
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new UserListItem
                        {
                            CharacterId = e.CharacterId,
                            Name = e.Name,
                            PreferredClass = e.PreferredClass
                        }
                        );

                return query.ToArray();
            }
        }

        public UserDetail GetUserById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Users
                    .Single(e => e.CharacterId == id && e.OwnerId == _userId);
                return
                    new UserDetail
                    {
                        CharacterId = entity.CharacterId,
                        Name = entity.Name,
                        PreferredClass = entity.PreferredClass,
                        PastGames = entity.PastGames,
                        IsBanned = entity.IsBanned
                    };
            }
        }

        public bool UpdateUser(UserEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Users
                    .Single(e => e.CharacterId == model.CharacterId && e.OwnerId == _userId);

                entity.Name = model.Name;
                entity.PreferredClass = model.PreferredClass;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
