using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ASPNETHomework.Models.DTO;
using System.Threading;
using System.Collections.Generic;
using ASPNETHomework.DAL;
using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Services.Services
{
    /// <summary>
    /// User Service.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Initialize <see cref="UserService"/>
        /// </summary>
        /// <param name="logger">Logger.</param>
        /// <param name="context">DB Context.</param>
        public UserService(ILogger<UserService> logger, UnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        /// <inheritdoc Проверка на пустоту пробелы и в конце наличие в базе данных/>
        public bool IsValidUserCredentials(string userName, string password)
        {
            _logger.LogInformation($"Validating user [{userName}]");
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return _unitOfWork.Users.Context.Users.Any(x => x.Login == userName && x.Password == password);// is it work?
        }

        /// <inheritdoc />
        public bool IsAnExistingUser(string userName)
        {
            return _unitOfWork.Users.Context.Users.Any(x => x.Login == userName);
        }

        /// <inheritdoc />
        public string GetUserRole(string userName)
        {
            if (!IsAnExistingUser(userName))
            {
                return string.Empty;
            }

            var role = _unitOfWork.Users.Context.UserRoles
                .Include(x => x.User)
                .Include(x => x.Role)
                .SingleOrDefault(x => x.User.Login == userName).Role?.Name;

            if (string.IsNullOrEmpty(role))
                throw new ArgumentNullException("Can't find role.");

            return role;
        }

		public Task<UserDto> CreateAsync(UserDto dto)
		{
            if(_unitOfWork.Users.Context.Users.Any(x => x.Login == dto.Login))
			{
                throw new ArgumentException("User is already exists");
            }
            return  _unitOfWork.Users.CreateAsync(dto);

        }

		public Task<UserDto> GetAsync(int id, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<UserDto>> GetAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<UserDto> UpdateAsync(UserDto dto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(params int[] ids)
		{
			throw new NotImplementedException();
		}
	}
}
