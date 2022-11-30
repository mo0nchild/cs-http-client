using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHttpClient.Controllers
{
    using TokenType = IValidationController.ValidationControllerToken;
    public interface IValidationController
    {
        public ValidationControllerToken TakeToken(System.String name);
        public System.Boolean CheckAllTokens();
        public sealed class ValidationControllerToken : System.Object
        {
            public System.Boolean TokenValue { get; set; } = default;
            public System.Guid TokenID { get; set; } = Guid.NewGuid();
        }
    }

    public class ValidationController : System.Object, Controllers.IValidationController 
    {
        private Dictionary<string, TokenType> TokensList { get; set; } = default!;
        public ValidationController() : base() => this.TokensList = new();
        public bool CheckAllTokens()
        {
            foreach (KeyValuePair<string, TokenType> token in this.TokensList)
            {
                if (token.Value.TokenValue == default(bool)) return default(bool);
            }
            return true;
        }
        public TokenType TakeToken(string name)
        {
            if (!TokensList.ContainsKey(name)) this.TokensList.Add(name, new TokenType());
            return this.TokensList[name];
        }
    }
}
