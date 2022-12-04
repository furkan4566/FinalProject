using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    //static olursa new lemeye gerek kalmaz
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountofCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isim'de zaten başka bir ürün var";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string CategoryLimitExceded = "Category Limit Aşıldı,Yeni ürün eklenemez";
        public static string UserRegistered = "Kayıt Oldunuz";
        public static string UserNotFound="Kayıt Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı Zaten Var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
