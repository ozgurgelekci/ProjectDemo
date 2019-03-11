using System.Linq;
using Demo.Core.AppConst;
using Demo.Core.Entities.Concrete.Common;
using Demo.Data.GenericRawSql.Abstract;
using Demo.Data.UnitOfWork.Abstract;
using Demo.Service.Abstract;

namespace Demo.Service.Concrete
{
    public class CommonService : ICommonService
    {
        private readonly IGenericRawSql _rawSql;
        private readonly IUnitOfWork _unitOfWork;

        public CommonService(IUnitOfWork unitOfWork)
        {
            _rawSql = _unitOfWork.GetRawSql();
            _unitOfWork = unitOfWork;
        }

        public Person FindPerson(int personId)
        {
            var result = _rawSql.Execute(StaticParams.DemoDbConnectionstring, typeof(Person),
                $"select * from common.Person a where a.Id = {personId}").Cast<Person>().SingleOrDefault();

            return result;
        }
    }
}
