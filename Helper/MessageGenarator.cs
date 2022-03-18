
namespace JobForStudents
{




    public static class MessageGenarator
    {
        public static readonly Dictionary<ResponseCodeEnum, string> ResponseMessages
            = new Dictionary<ResponseCodeEnum, string>
        {
    { ResponseCodeEnum.Success, "Ok" },
    { ResponseCodeEnum.GetAllDistrictsOperationFail, "İlçeler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllDistrictsOperationSuccess, "Tüm ilçeler Listelendi" },
    { ResponseCodeEnum.CreateDistrictOperationSuccess, "Yeni ilçe oluşturuldu" },
    { ResponseCodeEnum.CreateDistrictOperationFail, "Yeni ilçe oluşturulamadı" },
    { ResponseCodeEnum.DeleteDistrictOperationSuccess, "İlçe silindi" },
    { ResponseCodeEnum.DeleteDistrictOperationFail, "İlçe Silininirken hata meydana geldi" },


    { ResponseCodeEnum.CreateCityOperationSuccess, "Yeni il oluşturuldu" },
    { ResponseCodeEnum.CreateCityOperationFail, "Yeni il oluşturulamadı" },
    { ResponseCodeEnum.DeleteCityOperationFail, "İl Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteCityOperationSuccess, "İl Silindi" },
    { ResponseCodeEnum.GetAllCityOperationFail, "İl Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllCityOperationSuccess, "Tüm iller Listelendi" },
    { ResponseCodeEnum.CityEditOperationFail, "İl Düzenlenirken Hata meydana geldi" },


    { ResponseCodeEnum.CreateAddressOperationSuccess, "Yeni Adres oluşturuldu" },
    { ResponseCodeEnum.CreateAddressOperationFail, "Yeni Adres oluşturulamadı" },
    { ResponseCodeEnum.DeleteAddressOperationFail, "Adres Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteAddressOperationSuccess, "Adres Silindi" },
    { ResponseCodeEnum.GetAllAddressOperationFail, "Adresler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllAddressOperationSuccess, "Tüm Adresler Listelendi" },
    { ResponseCodeEnum.AddressEditOperationFail, "Adres Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAllDistrictByCityNameOperationFail, "Şehrin İlçeleri Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAllDistrictByCityNameRequired, "Şehir Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetAdressByCityNameOperationFail, "Şehre Göre Adres Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAdressByCityNameRequired, "Şehir Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetAllAdressByDistrictOperationFail, "İlçeye Göre Adres Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAllAdressByDistrictRequired, "İlçe Adını Kontrol Ediniz" },


    { ResponseCodeEnum.CreateSchoolOperationSuccess, "Yeni Okul oluşturuldu" },
    { ResponseCodeEnum.CreateSchoolOperationFail, "Yeni Okul oluşturulamadı" },
    { ResponseCodeEnum.DeleteSchoolOperationFail, "Okul Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteSchoolOperationSuccess, "Okul Silindi" },
    { ResponseCodeEnum.GetAllSchoolOperationFail, "Okullar Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllSchoolOperationSuccess, "Tüm Okullar Listelendi" },
    { ResponseCodeEnum.SchoolEditOperationFail, "Okul Düzenlenirken Hata meydana geldi" },


    { ResponseCodeEnum.GetSchoolsByDistrictOperationFail, "Girilen İlçede Kayıtlı Okul bulunamadı" },
    { ResponseCodeEnum.GetSchoolsByDistrictRequired, "Lütfen İlçe Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetSchoolsByCityOperationFail, "Girilen İlde Kayıtlı Okul bulunamadı" },
    { ResponseCodeEnum.GetSchoolsByCityRequired, "Lütfen Şehir Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetSchoolByNameOperationFail, "Girilen İsimde Kayıtlı Okul bulunamadı" },
    { ResponseCodeEnum.GetSchoolByNameRequired, "Okul Düzenlenirken Hata meydana geldi" },


    { ResponseCodeEnum.CreateJobAdvertisementOperationSuccess, "Yeni İş ilanı  oluşturuldu" },
    { ResponseCodeEnum.CreateJobAdvertisementOperationFail, "Yeni İş ilanı oluşturulamadı" },
    { ResponseCodeEnum.DeleteJobAdvertisementOperationFail, "İş ilanı Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteJobAdvertisementOperationSuccess, "İş ilanı Silindi" },
    { ResponseCodeEnum.GetAllJobAdvertisementOperationFail, "İş ilanıler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllJobAdvertisementOperationSuccess, "Tüm İş ilanıler Listelendi" },
    { ResponseCodeEnum.JobAdvertisementEditOperationFail, "İş ilanı Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetJobAdvertisementBySalaryOperationFail, "Maaş Aralığı Yanlış Girildi" },
    { ResponseCodeEnum.GetJobAdvertisementByCategoryOperationFail, "Categori Adı Boş Girilemez" },
    { ResponseCodeEnum.GetJobAdvertisementByTitleOperationFail, "Lütfen Title Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByCityOperationFail, "Lütfen Şehir Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByDistrictOperationFail, "Lütfen İlçe Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByNameOperationFail, "Lütfen İsim Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByWorkingTimeOperationFail, "Lütfen Zaman Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByCompanyNameOperationFail, "Girilen Şirket Adında İş İlanı Bulunamadı" },
    { ResponseCodeEnum.JobAdvertisementByCityMinSalaryTitleRequired, "Lütfen Girilen Parametreleri Kontrol Ediniz" },
    { ResponseCodeEnum.JobAdvertisementByCityMinSalaryTitleOperationFail, "Girilen Tercihlere Uygun İş İlanı bulunamadı" },
    { ResponseCodeEnum.GetJobAdvertisementBySalaryRequired, "Lütfen Maaş Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByCategoryRequired, "Lütfen Kategori Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByTitleRequired, "Lütfen Başlık Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByCityRequired, "Lütfen Şehir Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByDistrictRequired, "Lütfen İlçe Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByNameRequired, "Lütfen İsim Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByWorkingTimeRequired, "Lütfen İş Zamanı Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetJobAdvertisementByCompanyNameRequired, "Lütfen Şirket Adını Kontrol Ediniz" },



    { ResponseCodeEnum.CreateStudentOperationSuccess, "Yeni Öğrenci oluşturuldu" },
    { ResponseCodeEnum.CreateStudentOperationFail, "Yeni Öğrenci oluşturulamadı" },
    { ResponseCodeEnum.DeleteStudentOperationFail, "Öğrenci Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteStudentOperationSuccess, "Öğrenci Silindi" },
    { ResponseCodeEnum.GetAllStudentOperationFail, "Öğrenciler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllStudentOperationSuccess, "Tüm Öğrenciler Listelendi" },
    { ResponseCodeEnum.StudentEditOperationFail, "Öğrenci Kaydı Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.FindStudentByNameOperationFail, "Girilen İsimde Öğrenci Bulunamadı" },
    { ResponseCodeEnum.FindStudentByNameRequired, "Lütfen İsim Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsByCityOperationFail, "Girilen Şehirde Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsByCityRequired, "Lütfen Şehir Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsByDistrictOperationFail, "Girilen İlçede Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsByDistrictRequired, "Lütfen İlçe  Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsByEducationOperationFail, "Girilen Eğitim Seviyesinde Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsByEducationRequired, "Lütfen Eğitim Seviyesi Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsByEducationTourOperationFail, "Girilen Eğitim Türünde Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsByEducationTourRequired, "Lütfen Eğitim Türü Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsBySchoolOperationFail, "Girilen Okulda Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsBySchoolRequired, "Lütfen Okul Adı Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsByGenderRequired, "Lütfen Cinsiyet Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetStudentsByGenderOperationFail, "Girilen Cinsiyette Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsByBirthDateOperationFail, "Girilen Doğum Tarihleri Arasında Kayıtlı Öğrenci bulunamadı" },
    { ResponseCodeEnum.GetStudentsByBirthDateRequired, "Doğum Tarihleri Alanından en az biri dolu olmalıdır,Lütfen seçim yapınız" },
    
    

    { ResponseCodeEnum.CreateEmployerOperationSuccess, "Yeni İşveren oluşturuldu" },
    { ResponseCodeEnum.CreateEmployerOperationFail, "Yeni İşveren oluşturulamadı" },
    { ResponseCodeEnum.DeleteEmployerOperationFail, "İşveren Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteEmployerOperationSuccess, "İşveren Silindi" },
    { ResponseCodeEnum.GetAllEmployerOperationFail, "İşverenler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllEmployerOperationSuccess, "Tüm İşverenler Listelendi" },
    { ResponseCodeEnum.EmployerEditOperationFail, "İşveren Kaydı Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetEmployerByGenderOperationFail, "Girilen Cinsiyette Kaytılı Çalışan bulunamadı" },
    { ResponseCodeEnum.GetEmployerByGenderRequired, "Cinsiyet Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetEmployersByBirthDateRequired, "Doğum Tarihleri Alanından en az biri dolu olmalıdır,Lütfen seçim yapınız" },
    { ResponseCodeEnum.GetEmployersByBirthDateOperationFail, "Girilen Doğum Tarihleri Arasında Kayıtlı İşveren bulunamadı" },
    { ResponseCodeEnum.GetEmployerByNameRequired, "İşveren İsmini Kontrol Ediniz" },
    { ResponseCodeEnum.GetEmployerByNameOperationFail, "Girilen İsimde Kaytılı Çalışan bulunamadı" },
    { ResponseCodeEnum.GetEmployerCompanyRequired, "Şirket İsmini Kontrol Ediniz" },
    { ResponseCodeEnum.GetEmployerCompanyOperationFail, "Girilen Şirkette Kaytılı İşveren bulunamadı" },
    

    { ResponseCodeEnum.CreateCompanyOperationSuccess, "Yeni Şirket oluşturuldu" },
    { ResponseCodeEnum.CreateCompanyOperationFail, "Yeni Şirket oluşturulamadı" },
    { ResponseCodeEnum.DeleteCompanyOperationFail, "Şirket Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteCompanyOperationSuccess, "Şirket Silindi" },
    { ResponseCodeEnum.GetAllCompanyOperationFail, "Şirketler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllCompanyOperationSuccess, "Tüm Şirketler Listelendi" },
    { ResponseCodeEnum.CompanyEditOperationFail, "Şirket Kaydı Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetCompanyByCategoryOperationFail, "Kategoriye Göre Şirket Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetCompanyByDistrictRequired, "Lütfen İlçe Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetCompanyByCityRequired, "Lütfen Şehir Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetCompanyByCityOperationFail, "Şehire Göre Şirket Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetCompanyByDistrictOperationFail, "İlçeye Göre Şirket Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetCompanyByCategoryRequired, "Lütfen Kategori Alanını Kontrol Ediniz" },
    { ResponseCodeEnum.GetCompanyByNameOperationFail, "Girilen İsimde Şirket Bulunamadı" },
    { ResponseCodeEnum.GetCompanyByNameRequired, "Lütfen Şirket Alanını Kontrol Ediniz" },
    



    { ResponseCodeEnum.CreateCategoryOperationSuccess, "Yeni Kategori oluşturuldu" },
    { ResponseCodeEnum.CreateCategoryOperationFail, "Yeni Kategori oluşturulamadı" },
    { ResponseCodeEnum.DeleteCategoryOperationFail, "Kategori Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteCategoryOperationSuccess, "Kategori Silindi" },
    { ResponseCodeEnum.GetAllCategoryOperationFail, "Kategoriler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllCategoryOperationSuccess, "Tüm Kategoriler Listelendi" },
    { ResponseCodeEnum.CategoryEditOperationFail, "Kategori Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetCategoryByNameOperationFail, "Girilen İsimde Kategori Bulunamadı" },
    

    { ResponseCodeEnum.CreateRoleOperationSuccess, "Yeni Role oluşturuldu" },
    { ResponseCodeEnum.CreateRoleOperationFail, "Yeni Role oluşturulamadı" },
    { ResponseCodeEnum.DeleteRoleOperationFail, "Role Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteRoleOperationSuccess, "Role Silindi" },
    { ResponseCodeEnum.GetAllRoleOperationFail, "Roleler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllRoleOperationSuccess, "Tüm Roleler Listelendi" },
    { ResponseCodeEnum.RoleEditOperationFail, "Role Düzenlenirken Hata meydana geldi" },


    { ResponseCodeEnum.CreateAccountOperationSuccess, "Yeni Hesap oluşturuldu" },
    { ResponseCodeEnum.CreateAccountOperationFail, "Yeni Hesap oluşturulamadı" },
    { ResponseCodeEnum.DeleteAccountOperationFail, "Hesap Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteAccountOperationSuccess, "Hesap Silindi" },
    { ResponseCodeEnum.GetAllAccountOperationFail, "Hesaplar Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllAccountOperationSuccess, "Tüm Hesaplar Listelendi" },
    { ResponseCodeEnum.AccountEditOperationFail, "Hesap Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAccountByRoleNametOperationFail, "Girilen Role Ait Hesap Bulunamadı" },
    { ResponseCodeEnum.GetAccountByVisibltytOperationFail, "Girilen Görünürlüğe Ait Hesap Bulunamadı" },
    

    };


        public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
        {
            return ResponseMessages[ResponseCode];
        }

    }
}