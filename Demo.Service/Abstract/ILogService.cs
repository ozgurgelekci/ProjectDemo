using Demo.Core.Entities.Concrete.Log;

namespace Demo.Service.Abstract
{
    public interface ILogService
    {
        /// <summary>
        /// Alınan hataları ExceptionLoga kaydeder.
        /// </summary>
        /// <param name="exceptionLog"></param>
        void AddExceptionLog(ExceptionLog exceptionLog);

        /// <summary>
        /// Erişilen Url'leri RequestLog'a kaydeder.
        /// </summary>
        /// <param name="requestLog"></param>
        void AddRequestLog(RequestLog requestLog);

        /// <summary>
        /// Erişilen Url ile ilgili parametre ve detay bilgilerini kaydeder.
        /// </summary>
        /// <param name="requestDetailLog"></param>
        void AddRequestDetailLog(RequestDetailLog requestDetailLog);
    }
}
