
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


