
![1 1](https://github.com/enmertkaya/RealTimeData/assets/151652097/d92f61f2-bcfc-4ac0-9eaa-de104bee40eb)

AspNet Core 6.0 ile geliştirdiğim admin ve vitrin panelleri bulunan, içerisinde SignalR kütüphanesini hakkını vererek kullandığım oldukça kapsamlı bir real-time uygulama yapısıyla hazırlanmıştır. Bu projede sıfırdan bir restoran için sipariş yönetimi uygulaması geliştirildi. Bu uygulamada backend kısmında Api kullandım. Backende kullandığım bu Api yapısını UI tarafında consume ettim. Consume işlemlerinde oldukça güçlü bir arayüz kullandım. Hem admin, hem UI hem de sipariş kısımları oldukça tatminkar oldu. Rezervasyon işlemleri için kullanıcılarımıza mail gönderdim. SignalR ile anlık bildirim, anlık mesajlaşma, anlık sepet gibi işlemleri gerçekleştirdik. Projemi mimariye ve solid prensiplerine olabildiğince sadık kalarak clean code prenseplerinde kodladım.  

Genel olarak kullandığım teknolojiler şu şekildedir.

AspNet Core 6.0, Asp.Net Core Api, SignalR, Swagger, Dto ,N Tier Architecture, MSSQL, İlişkili Tablolar, Html Css Bootstrap, JavaScrip, Ajax, Entity Framework - Linq, Alert, Basket, Rezervasyon İşlemleri, Real-Time Uygulamalar, Real-Time Mesajlaşma, Real-Time İstatistik, Real-Time Bildirim, Mail Gönderme İşlemleri

### 1-Kullanıcı Rolü 
* :ear: ​**Kullanıcı İşlemleri : Kullanıcı QR code ile tarattığı fotoğraf sonucu menüye erişebilir. Gelen menüden seçimini yapabilir. Yaptığı seçim sonucunda kasa bilgisi eklenir ve ödeme yapabilir.

Kullanıcı 2 id numaralı Steak Burger seçimi yapmıştır.
![2](https://github.com/enmertkaya/RealTimeData/assets/151652097/d040b0c2-1980-4bc7-845a-f3001b828186)

Kasada ödeme tutarı anlık olarak signalR ile yansımıştır.

![2 2](https://github.com/enmertkaya/RealTimeData/assets/151652097/9fa684cf-0f86-446f-805a-9a7b562f9351)

Kullanıcılar uygulama üzerinden indirimli ürünleri görüp sipariş verebilir.

![3](https://github.com/enmertkaya/RealTimeData/assets/151652097/aa30dcbf-528d-4713-b605-496f62b1795f)

Kullanıcıların anlık olarak oluşturduğu rezervasyon işlemleri, signalR tarafından admin panelini kontrol eden kişi tarafından anında görüntülenebilir.

![4](https://github.com/enmertkaya/RealTimeData/assets/151652097/ea2629fc-0f65-4c2e-9df4-4e2430581494)

Kullanıcılar anlık olarak canlı konuşma ekranını kullanabilir ve isteklerini iletebilirler.

![5](https://github.com/enmertkaya/RealTimeData/assets/151652097/b1e46dda-d8f8-44d3-b88d-951b005e73e4)

Kullanıcı yorumları sayfada gözükebilir.

![6](https://github.com/enmertkaya/RealTimeData/assets/151652097/41df6e07-70e2-4d31-9045-96885dcec309)


### 2-Admin / Yönetici Rolü 

:house:​**Admin İşlemleri  :** Yönetici ** İşletme için rezervasyon bilgileri , menüyü ve kategorileri düzenleyebilir , indirimleri düzenler, masa durumlarını ve anlık konuşmayı yönetir , mail gönderebilir , qr kod oluşturabilir.

Açılan admin sayfasından giriş yapılır ;
![7](https://github.com/enmertkaya/RealTimeData/assets/151652097/1d87986f-9a79-46c0-adec-fe17af0dbd1d)

Gelen admin panelinde sol tarafta bulunan alanlardan istenilen sayfa kontrol edilebilir,
![8](https://github.com/enmertkaya/RealTimeData/assets/151652097/5205235d-a378-4c47-8666-3d3c4e6c228b)

Yeni rezervasyon oluşturan kullanıcılar için, admin panelini kullanan yöneticiler onay verdiği zaman bildirim olarak panele yansır.
![9](https://github.com/enmertkaya/RealTimeData/assets/151652097/7d5a0776-3aac-468d-bd38-f04338487c1c)

Menüye dair bilgiler anlık istatistik sayfasında tutulur.Değişen bilgiler signalR ile anlık olarak admin paneline yansır.Burada 6 kategori için görsel paylaşılmıştır.
![10](https://github.com/enmertkaya/RealTimeData/assets/151652097/d0386f1a-a15e-4d94-8953-5b8042155faa)

Anlık olarak yeni bir kategori girmek istersek istatistik sayfasında kategori sayısının yenilemeye ihtiyac duymadan anında 7 oldugunu gorebiliriz.
![11](https://github.com/enmertkaya/RealTimeData/assets/151652097/321dd440-b7e6-4c87-9650-7bb8613d9bc0)

İşletmede bulunan masalar için dolu ya da boş olarak giriş yapılabilir.Dolu masalar yeşil, boş masalar kırmızı olarak gözükmektedir.
![12](https://github.com/enmertkaya/RealTimeData/assets/151652097/c2181224-1ddf-473f-9188-80b035d3ad18)

İşletmeye dair anlık istatistik ve bilgiler burada tutulabilir. İstatistik barları verilerimize göre artıp azalacaktır.
![13](https://github.com/enmertkaya/RealTimeData/assets/151652097/b6f3e6cd-ee1e-4cf5-97a1-ee5c73c71c65)

Yönetici kişiler admin paneli üstünden bilgilerini güncelleyebilir.
![14](https://github.com/enmertkaya/RealTimeData/assets/151652097/d6cd5f91-bcc3-4599-b49a-43d1fc78d506)

Admin sayfasından istenilen bir mail gönderilebilir.
![15](https://github.com/enmertkaya/RealTimeData/assets/151652097/1e97ebd2-833d-4cb9-ac1e-55572988e8eb)

İsteniien masa için QR kod oluşturulabilir. Yapıştırılan QR code ile masaya ait bilgiler ve siparişler kolaylıkla alınabilir.
![16](https://github.com/enmertkaya/RealTimeData/assets/151652097/ec16e692-82f7-4a52-aed6-8efcdd910154)

Projeme ait ilişkisel veri tabanı şu şekildedir,
![18](https://github.com/enmertkaya/RealTimeData/assets/151652097/ea96ca58-a3e1-441f-bae4-566258afd438)


***Projeye dair api ve consume işlemleri , mimari ve projenin ilerleme aşaması commitlerde mevcuttur.***

![17](https://github.com/enmertkaya/RealTimeData/assets/151652097/aed9a19f-1c3a-4ff6-a787-693c28b6c91b)
