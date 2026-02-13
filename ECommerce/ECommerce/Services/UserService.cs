
using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;
using System.Linq.Expressions;

namespace ECommerce.Services
{
    public class UserService (GenericRepository<User> _userRepository)
    {
        public async Task<UserVM>Login(LoginVM loginVM)
        {
            var conditions = new List<Expression<Func<User, bool>>>()
            {
                x=>x.Email == loginVM.Email,
                x=>x.Password == loginVM.Password,
            };

            var found = await _userRepository.GetByFilter(conditions: conditions.ToArray());
            var userVM = new UserVM();

            if(found !=null)
            {
                userVM.UserId = found.UserId;
                userVM.FullName = found.FullName;
                userVM.Email = found.Email;
                userVM.Type = found.Type;
            }
            return userVM;
        }

        public async Task Register(UserVM userVM)
        {
            if (userVM.Password != userVM.RepeatPassword)
                throw new InvalidOperationException("The Password Are Not The Same");
            var conditions = new List<Expression<Func<User, bool>>>()
            {
                x=>x.Email == userVM.Email
            };

            var foundEmail = await _userRepository.GetByFilter(conditions: conditions.ToArray());

            if (foundEmail != null)
                throw new InvalidOperationException("The Email Address Is Already Registered");

            var entity = new User()
            {
                FullName = userVM.FullName,
                Email = userVM.Email,
                Type = userVM.Type,
                Password = userVM.Password,
            };

            await _userRepository.AddAsync(entity);
        }
    }
}
