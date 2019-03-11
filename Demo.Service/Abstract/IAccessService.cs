using Demo.Dto.QueryDto;

namespace Demo.Service.Abstract
{
    public interface IAccessService
    {
        /// <summary>
        /// E mail ve passworda göre giriş kontrolü yapar.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Signin(string email, string password);

        /// <summary>
        /// Gönderilen e maile göre mail kontrolü yapar.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool AnyEmail(string email);

        /// <summary>
        /// Emaile göre User bilgilerini getirir.
        /// </summary>
        QUserInfoDto GetUserInfo(string email);


        /// <summary>
        /// Userın block olup olmadığı bilgisini verir.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool GetUserIsBlock(int userId);
    }
}
