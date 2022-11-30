using CSHttpClient.NetworkTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSHttpClient.Controllers
{
    public interface IProfileController
    {
        public StudentInfo GetProfileData(string login, string password);
        public CollectionStatements GetProfileStatements(string profile_id, string course);
    }

    public class ProfileController : System.Object, IProfileController
    {
        private IHttpTransfer TransferController { get; set; } = default!;
        public ProfileController(IHttpTransfer httpTransfer) : base() => this.TransferController = httpTransfer;

        public StudentInfo GetProfileData(string login, string password)
        {
            return this.TransferController.SendRequest<StudentInfo>(new Dictionary<string, object>()
            { { "Логин", login }, { "Пароль", password } }, "authorization");
        }

        public CollectionStatements GetProfileStatements(string profile_id, string course)
        {
            return this.TransferController.SendRequest<CollectionStatements>(new Dictionary<string, object>()
            { { "Код", profile_id }, { "Курс", course } }, "statements");
        }
    }
}
