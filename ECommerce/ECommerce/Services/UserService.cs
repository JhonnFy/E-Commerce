using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;
using System.Linq.Expressions;

namespace ECommerce.Services
{
    public class UserService(GenericRepository<User> _userRepository)
    {
        public async Task<UserVM> Login(LoginVM loginVM)
        {
            var conditions = new List<Expression<Func<User, bool>>>()
            {
                x => x.Email == loginVM.Email,
                x => x.Password == loginVM.Password,
            };

            var found = await _userRepository.GetByFilter(conditions: conditions.ToArray());
            var userVM = new UserVM();

            if (found != null)
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
            // 1️⃣ Validar que no falten campos
            if (string.IsNullOrWhiteSpace(userVM.FullName) ||
                string.IsNullOrWhiteSpace(userVM.Email) ||
                string.IsNullOrWhiteSpace(userVM.Password) ||
                string.IsNullOrWhiteSpace(userVM.RepeatPassword))
            {
                throw new InvalidOperationException("Todos Los Campos Son Obligatorios");
            }

            // 2️⃣ Validar que las contraseñas coincidan
            if (userVM.Password != userVM.RepeatPassword)
                throw new InvalidOperationException("Las Contraseñas No Coinciden");

            // 3️⃣ Validar si el correo ya está registrado
            var conditions = new List<Expression<Func<User, bool>>>()
            {
                x => x.Email == userVM.Email
            };

            var foundEmail = await _userRepository.GetByFilter(conditions: conditions.ToArray());
            if (foundEmail != null)
                throw new InvalidOperationException("El Correo Ya Está Registrado");

            // 4️⃣ Crear usuario
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