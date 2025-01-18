# Login Formu
![image](https://github.com/user-attachments/assets/bf8aa99b-c116-4df2-bcca-ac466fd3208d)

# konturolleri
## 1. İsmin veri tabanında olup olmadığını kontrol ediyor ve yoksa yok diyerek geri meşaj döndürüyor.
## 2. İsim varsa şifreyi kontrol ediyor ve yanlış ise şifre yanlış olduğunu meşaj ile dönderiyor.
## İki konturolde doğru geçerse Dashboard sayfasına yönlendiriyor

# Dashboard Formu
![image](https://github.com/user-attachments/assets/2b7744b6-fd49-4df8-acbf-527f5550ae27)

# Form Load kodları
## 1. Timerde kullanacağım bills,processes,banks tabloların liste örneği alıyorum yavaşlatmaması için.
## 2. Chart aracını kullanarak BankBalance grafiğini yazdırdık.
## 3. Chart aracını kullanarak BillAmount grafiğini yazdırdık.

# Timer Tick kodları
## 1. Tüm faturaların BillTitle ile BillAmount bilgilerini sırasına göre 2 saniye arayla geçiyor.
## 2. Tüm gelen havalelerin Desciription ile Amount değerlerini sırasına göre 2 saniye arayla geçiyor.
## 3. Burda değişiklik yapmak istedim ve internetten Dolar ve Euro kurlarını alıp, BankBalance ile çarptım ve 2 saniye arayla Dolar, Euro, TL değerlerini gösterdim.

# Bank Formu
![image](https://github.com/user-attachments/assets/8d3f7557-d2c8-4965-812d-b73d10e9dfb5)

# Load Kodu
## 1. list metonudu çalıştırıp dataGridView aracını dolduruyor.
## 2. BankTitle değerlerini cmbBankProcesses aracına ekledim.

## Yeni bir list metodu oluşturdum ve dataGridView aracına BankProcesses listesini yazdırdım
## Listeleme Butonu list metodunu çalıştırarak dataGridView değerlerini güncelliyor.
## Ekleme butonunda yazdığımız verileri yeni bir BankProcesses nesnesine atayıp ekleme işlemini yaptı.
## Silme butonunda silinecek satırın id sini Find metodu ile tüm satırı yakalayıp sildik.
## Güncelleme işleminide satırın id si ile satırı yakalayıp verilen değerler ile değiştirip kaydediyor.

# Bankaların Formu
![image](https://github.com/user-attachments/assets/0696e9d1-b425-49f7-b464-e6f23b70d53a)

# Load kodu
## Tüm Bankaların fiyatlarını BankBalance stunundan sırayla Ziraat Bankası,Vakıfbank,İş Bankası isimli satırlardan çekildi.
## Ve son 5 banka hareketini GroupBox aracının içerisine label yardımı ile yazdım.

# Billing Formu
![image](https://github.com/user-attachments/assets/efbd7a5d-e6ae-4057-a6a6-fd552dc916ea)

# Load Kodu
## Bills tablosunun örnek listesini alıp dataGridView aracına yazdırıyor.
## Listele butonunda ise gene aynı işlem uygulanıyor.
## Ekle butonunda eklenecek verileri geçici olarak bir değişkene atayıp yeni Bills nesnesine ekleyip veri tabanına ekleme isteği gönderdik.
## Silme butonunda silinecek satırın id değerini alıp veri tabanında sorgu yapıp o id olan satırı alıp sildik.
## Güncelleme butonunda'da bu seferde güncellenecek değerleri çekip güncellenmesi istenen satırın id sini sorgulayarak bulup çektiğimiz verilerle güncelledik.

# Kategori Formu
![image](https://github.com/user-attachments/assets/26853413-a13f-4475-9e21-b0974f89b146)

## Load bölümünde list metodunu çalıştırıp tüm kategorileri listesini dataGridView aracına eklenmesini sağlıyor.
## List metodunda dataGridView aracına veri tabanından Categorys tablosunu ToList metodu ile çekti ve yazdırdı.
## Ekleme metodunda ise yine verileri yeni bir Categoriys nesnesine atayıp ekleme isteği gönderiliyor.
## Silme metodunda silinecek id'yi alıp satırı tesbit edip siliyoruz.
## Güncelleme metodunda id ile satırı tesbit edip o satır değerlerini güncellenecek değerlerle değiştirip kaydediliyor.

# Harcamalar Formu
![image](https://github.com/user-attachments/assets/55c34517-f815-472a-9237-0209dd317a5e)

# Load Kodu
## List metodunu çağırıp tüm harcamaların listesini dataGridView aracına yazdırdım.
## Kategorileri CMB aracına id'si ile Namesini yazdırdık.

## list metodunda listeleme işlemini detayına indik ve yeni bir tablo oluşturduk ve dataGridView aracına ekledik.
## Listele butonunnda List metodunu çağırdık.
## Ekleme işlemi için yeni bir Spendings nesnesi oluşturduk ve nesnenin içerisine eklenecek değerleri atayıp ekleme işlemini yaptık.
## Silme işlemi için silinecek satır id'si üzerinden silinecek stırı tesbit edip sildik.
## Güncelleme işlemi içnde silinecek satır id'si ile satırı aldık ve güncellenecek verileri atayıp kaydettik.

# Ayarlar Formu
![image](https://github.com/user-attachments/assets/66495d82-2908-4be2-94b8-de93b78b487e)

Öncelikle sağ taraftaki üç butonu panel2'e koyduk ve sol taraftaki tüm araçlar panel1'e ekli.

# Formun Tüm kodları
## Load kodu benim oluşturduğum özellikler sınıfındaki proparti'ler ile Fore Color, Back Color, Size, Yazı Tipi, Yazı Tipi Boyutu ve Form Tipi değerlerini Text'ine yazdırdım.
## Back Color, Fore Color, Yazı Tipi, Form Tipi gibi metin değer gireceğimiz CMB arçlarına kolaylık olsun diye tüm değerleri ekledik.
## İptal butonlarında önceki formu açıp ayarlar formunu kapadıyor.
## Görüntüle buttonunda ordaki değişikliği kontrol edebilelim diye o ayarları ayarlar formu üstünde uyguluyor ve daha detaylı görebilelim diye sol taraftaki tüm araçların görünümünü kapatıyor.
## Geri butonum ise sadece formun geri halini yüklüyor ve sol taraftaki değerleri görünür hale getiriyor.
## Kaydet butonu önce tüm değerleri kontrol edip yanlış değer varsa hata var meşajı dönüyor yoksa özellikler metodumun içerisine o değerleri atıyor ve önceki formu açıp ayarlar formunu kapadıyor.


# Eklemek istediklerim


Ayarlar ve Login formları dışında, tüm formlarda Edit sınıfının edit metodunu çağırarak, this parametresi ile Özellikler sınıfındaki özellikleri ilgili forma entegre ediyorum.

Formlar arası geçişlerde nesne oluşturmayı ve kod karmaşıklığını azaltmak için özel bir sınıf oluşturdum. Bu sınıfta tüm formlar için bir sorgu yazdım ve her formu açmak istediğimde yalnızca bu sınıfı çağırıp ilgili formu belirterek işlemi gerçekleştiriyorum.

