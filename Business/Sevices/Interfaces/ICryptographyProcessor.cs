using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Sevices.Interfaces
{
    public interface ICryptographyProcessor
    {
        byte[] CreateSalt();
        byte[] GenerateHash(string userPassword, byte[] salt);
        Task<bool> AreEqualAsync(string userEmail, string userPassword);
    }
}
