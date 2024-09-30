using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Sevices.Concrete
{
    public class CryptographyProcessor : ICryptographyProcessor
    {
        private readonly ICryptographyProcessorRepo _cryptography;

        public CryptographyProcessor(ICryptographyProcessorRepo cryptography)
        {
            _cryptography = cryptography;
        }
        public byte[] CreateSalt()
        => _cryptography.CreateSalt();

        public byte[] GenerateHash(string userPassword, byte[] salt)
        =>  _cryptography.GenerateHash(userPassword, salt);
        public Task<bool> AreEqualAsync(string userEmail, string userPassword)
        => _cryptography.AreEqualAsync(userEmail, userPassword);
    }
}
