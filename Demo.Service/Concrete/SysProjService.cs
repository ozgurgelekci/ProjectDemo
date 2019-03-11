using System.Collections.Generic;
using System.Linq;
using Demo.Core.Entities.Concrete.SysProj;
using Demo.Data.GenericRepository.Abstract;
using Demo.Data.UnitOfWork.Abstract;
using Demo.Dto.QueryDto;
using Demo.Service.Abstract;

namespace Demo.Service.Concrete
{
    public class SysprojService : ISysprojService
    {
        private readonly IGenericRepository<Parameter> _parameterRepository;
        private readonly IGenericRepository<Resource> _resourceRepository;
        private readonly IGenericRepository<Language> _languageRepository;
        private readonly IGenericRepository<LookupList> _lookupListRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SysprojService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _parameterRepository = _unitOfWork.GetRepository<Parameter>();
            _resourceRepository = _unitOfWork.GetRepository<Resource>();
            _languageRepository = _unitOfWork.GetRepository<Language>();
            _lookupListRepository = _unitOfWork.GetRepository<LookupList>();
        }

        public List<QResourceLanguageDto> GetAllResourceLanguages()
        {
            var result = (from r in _resourceRepository.GetAll()
                          join l in _languageRepository.GetAll() on r.LanguageId equals l.Id
                          select new QResourceLanguageDto
                          {
                              Id = r.Id,
                              Label = r.Label,
                              LanguageTitle = l.Culture,
                              LanguageId = l.Id,
                              Title = r.Title
                          }
                ).ToList();

            return result;
        }

        public List<Parameter> GetAllParameters()
        {
            var result = _parameterRepository.GetAll();
            return result.OrderBy(p => p.Name).ToList();
        }

        public List<LookupList> GetAlLookupLists()
        {
            return _lookupListRepository.GetAll().ToList();
        }
    }
}
