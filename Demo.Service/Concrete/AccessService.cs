using System.Linq;
using Demo.Core.Entities.Concrete.Access;
using Demo.Core.Entities.Concrete.Common;
using Demo.Data.GenericRepository.Abstract;
using Demo.Data.UnitOfWork.Abstract;
using Demo.Dto.QueryDto;
using Demo.Service.Abstract;

namespace Demo.Service.Concrete
{
    public class AccessService : IAccessService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Unit> _unitRepository;
        private readonly IGenericRepository<Person> _personRepository;
        private readonly IGenericRepository<UserRole> _userRoleRepository;

        public AccessService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepository = _unitOfWork.GetRepository<User>();
            _unitRepository = _unitOfWork.GetRepository<Unit>();
            _personRepository = _unitOfWork.GetRepository<Person>();
            _userRoleRepository = _unitOfWork.GetRepository<UserRole>();

        }

        public bool Signin(string email, string password)
        {
            return _userRepository.GetAll().Any(p => p.Email == email && p.Password == password);
        }

        public bool AnyEmail(string email)
        {
            return _userRepository.GetAll().Any(p => p.Email == email);
        }

        public QUserInfoDto GetUserInfo(string email)
        {
            var result = (from a in _userRepository.GetAll()
                          join b in _personRepository.GetAll() on a.Id equals b.UserId into bs
                          from b in bs.DefaultIfEmpty()
                          join c in _unitRepository.GetAll() on b.UnitId equals c.Id
                          join d in _userRoleRepository.GetAll() on a.Id equals d.UserId
                          where a.Email == email
                          select new QUserInfoDto
                          {
                              Email = a.Email,
                              FullName = a.Name + " " + a.Surname,
                              RoleId = d.RoleId,
                              UnitId = b.UnitId,
                              UserId = a.Id
                          }
                ).SingleOrDefault();

            return result;
        }

        public bool GetUserIsBlock(int userId)
        {
            return _userRepository.GetAll().Any(u => u.Id == userId);
        }
    }
}
