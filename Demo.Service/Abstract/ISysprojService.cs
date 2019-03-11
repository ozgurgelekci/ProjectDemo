using System.Collections.Generic;
using Demo.Core.Entities.Concrete.SysProj;
using Demo.Dto.QueryDto;

namespace Demo.Service.Abstract
{
    public interface ISysprojService
    {
        /// <summary>
        /// Tüm dil paketlerini getirir.
        /// </summary>
        /// <returns></returns>
        List<QResourceLanguageDto> GetAllResourceLanguages();

        /// <summary>
        /// Tüm parametreleri getirir.
        /// </summary>
        /// <returns></returns>
        List<Parameter> GetAllParameters();

        /// <summary>
        /// Tüm LookupListleri getirir.
        /// </summary>
        /// <returns></returns>
        List<LookupList> GetAlLookupLists();
    }
}
