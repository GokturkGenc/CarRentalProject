﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //General Messages  
        public static string MaintenanceTime = "Şu anda site bakımdadır. Daha sonra deneyiniz.";
        
        //for Cars
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç bilgileri güncellendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarsListed = "Araçlar listelendi.";

        

        //for Rents
        public static string RentsListed = "Kiralanan araçlar listelendi.";
        public static string RentAdded = "Kiralanan araç eklendi";
        public static string RentUpdated = "Kiralanma bilgileri güncellendi.";
        public static string RentDelete = "Kiralanmış araç teslim edildi.";
        public static string RentRequestInvalid = "Kiralama isteği geçersiz, araç teslim edilmemiş olabilir.";

        //for Customers
        public static string CustomersListed = "Müşteriler Listelendi.";
        public static string CustomerAdded = "Yeni Müsteri Eklendi";
        public static string CustomerDeleted = "Müsteri Silindi";
        public static string CustomerUpdated = "Müsteri Bilgileri Güncellendi.";

        //for Users
        public static string UsersListed = "Kullanıcılar Listelendi.";
        public static string UserAdded = "Yeni kullanıcı Eklendi";
        public static string UserDeleted = "kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Bilgileri Güncellendi.";

        //for Colors
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Bilgileri Güncellendi";
        public static string ColorsListed = "Renkler Listelendi";

        //for Brands
        public static string BrandAdded = "Marka eklendi";
        public static string BrandsListed = "Markalar Listelendi";

    }
}
