using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Consts
{
    public static class Messages
    {
        public static string JobAdded = "İş başarıyla eklendi";
        public static string JobDeleted = "İş başarıyla silindi";
        public static string JobUpdated = "İş başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
