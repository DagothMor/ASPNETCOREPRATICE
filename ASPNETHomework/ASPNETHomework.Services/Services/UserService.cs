using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace ASPNETHomework.Services.Services
{
    /// <summary>
    /// User Service.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly AspNetHomeworkContext _aspNetHomeworkContext;

        /// <summary>
        /// Initialize <see cref="UserService"/>
        /// </summary>
        /// <param name="logger">Logger.</param>
        /// <param name="context">DB Context.</param>
        public UserService(ILogger<UserService> logger, AspNetHomeworkContext context)
        {
            _logger = logger;
            _aspNetHomeworkContext = context;
        }

        /// <inheritdoc />
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

            return _aspNetHomeworkContext.Users.Any(x => x.Login == userName && x.Password == password);
        }

        /// <inheritdoc />
        public bool IsAnExistingUser(string userName)
        {
            return _aspNetHomeworkContext.Users.Any(x => x.Login == userName);
        }

        /// <inheritdoc />
        public string GetUserRole(string userName)
        {
            if (!IsAnExistingUser(userName))
            {
                return string.Empty;
            }

            var role = _aspNetHomeworkContext.UserRoles
                .Include(x => x.User)
                .Include(x => x.Role)
                .SingleOrDefault(x => x.User.Login == userName).Role?.Name;

            if (string.IsNullOrEmpty(role))
                throw new ArgumentNullException("Can't find role.");

            return role;
        }
    }
}
