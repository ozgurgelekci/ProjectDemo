using Demo.Core.Entities.Concrete.Common;

namespace Demo.Service.Abstract
{
    public interface ICommonService
    {
        /// <summary>
        /// PersonId'ye göre kişi arar
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Person FindPerson(int personId);
    }
}
