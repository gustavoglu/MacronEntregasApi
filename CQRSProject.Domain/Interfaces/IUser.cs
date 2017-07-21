using System.Collections.Generic;
using System.Security.Claims;

namespace CQRSProject.Domain.Interfaces
{
    public interface IUser
    {
        string Name { get; }

        string GetUserId();

        bool IsAuthenticated();

        IEnumerable<Claim> GetClaimsIdentity();

    }
}
