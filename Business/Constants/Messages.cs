using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalit = "Product's name is invalit";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Products are listed";
        public static string ProductCountOfCategoryError = "Bir kateqoriyada maxsimum 10 mehsul ola biler";
        public static string ProductNameAlreadyExists = "Bu adda mehsul var";
        public static string CategoryLimitExceded = "Category limiti kecdiyi ucun yeni mehsul elave olunmur";
        public static string AuthorizationDenied = "Selahiyyetiniz yoxdur";
        public static string UserRegistered = "Qebul olundu";
        public static string UserNotFound = "Istifadeci tapilmadi";
        public static string PasswordError = "Parol xetasi";
        public static string SuccessfulLogin = "Ugurlu girish";
        public static string UserAlreadyExists = "Istifadeci movcud";
        public static string AccessTokenCreated;
    }
}
