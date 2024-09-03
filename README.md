# Pratik-BasicMVC
Bu proje, ASP.NET Core MVC kullanarak basit bir müşteri ve sipariş bilgilerini görüntüleme uygulamasıdır. Proje, MVC yapısını öğrenmek ve geliştirmek isteyenler için temel bir örnek sunar.

## Özellikler

- Müşteri bilgilerini görüntüleme
- Sipariş bilgilerini görüntüleme
- MVC mimarisine uygun yapı

## Kullanılan Teknolojiler

- ASP.NET Core MVC
- C#
- Bootstrap (isteğe bağlı olarak görsel düzenlemeler için)

## Proje Yapısı

```bash
Pratik_BasicMVC/
│
├── Controllers/
│   ├── CustomerOrdersController.cs
│   └── HomeController.cs
│
├── Models/
│   ├── Customer.cs
│   ├── CustomerOrderViewModel.cs
│   ├── ErrorViewModel.cs
│   └── Order.cs
│
├── Views/
│   ├── CustomerOrders/
│   │   └── Index.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _ValidationScriptsPartial.cshtml
│       ├── Error.cshtml
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│       ├── bootstrap/
│       ├── jquery/
│       ├── jquery-validation/
│       └── jquery-validation-unobtrusive/
│
├── Properties/
│   └── launchSettings.json
│
├── appsettings.Development.json
├── appsettings.json
├── Program.cs
└── README.md

```
