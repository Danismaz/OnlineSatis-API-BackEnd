using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class CryptographyProcessorRepo : ICryptographyProcessorRepo
    {
        private readonly IUserRepo _userRepo;

        public CryptographyProcessorRepo(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public byte[] CreateSalt()
        {
            // 24 bayt uzunluğunda bir dizi oluştur
            byte[] salt = new byte[16];

            // RNGCryptoServiceProvider kullanarak diziye rastgele baytlar ekle
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public byte[] GenerateHash(string userPassword, byte[] salt)
        {
            //byte[] bytes = Encoding.UTF8.GetBytes(userPassword + salt);
            //SHA256Managed sHA256ManagedString = new SHA256Managed();
            //byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            //return hash;

            byte[] passwordBytes = Encoding.UTF8.GetBytes(userPassword);
            byte[] combinedBytes = passwordBytes.Concat(salt).ToArray();
            using (SHA512Managed sha512 = new SHA512Managed())
            {
               return sha512.ComputeHash(combinedBytes); // 64 baytlık (512 bit) hash
            }
            
            
        }
        public async Task<bool> AreEqualAsync(string userEmail, string userPassword)
        {
            var user = await  _userRepo.GetByEmailAsync(x=> x.Email.Equals(userEmail));
            var newHashedPin = GenerateHash(userPassword, user.PasswordSalt);
            return newHashedPin.SequenceEqual(user.PasswordHash);
        }
    }
}
