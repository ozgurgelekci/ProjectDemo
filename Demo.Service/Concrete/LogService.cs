using Demo.Core.Entities.Concrete.Log;
using Demo.Data.GenericRepository.Abstract;
using Demo.Data.UnitOfWork.Abstract;
using Demo.Service.Abstract;

namespace Demo.Service.Concrete
{
    public class LogService : ILogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<ExceptionLog> _exceptionLogRepository;
        private readonly IGenericRepository<RequestLog> _requestLogRepository;
        private readonly IGenericRepository<RequestDetailLog> _requestDetailLogRepository;

        public LogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _exceptionLogRepository = _unitOfWork.GetRepository<ExceptionLog>();
            _requestLogRepository = _unitOfWork.GetRepository<RequestLog>();
            _requestDetailLogRepository = _unitOfWork.GetRepository<RequestDetailLog>();
        }

        public void AddExceptionLog(ExceptionLog exceptionLog)
        {
            _exceptionLogRepository.Add(exceptionLog);
        }

        public void AddRequestLog(RequestLog requestLog)
        {
            _requestLogRepository.Add(requestLog);
        }

        public void AddRequestDetailLog(RequestDetailLog requestDetailLog)
        {
            _requestDetailLogRepository.Add(requestDetailLog);
        }
    }
}