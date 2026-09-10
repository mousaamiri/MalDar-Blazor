# MalDar

![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

<div dir="rtl">

> ⚠️ این ریپازیتوری صرفاً برای **یادگیری و تمرین مبانی Blazor** ساخته شده است. سطح آن مقدماتی است و نباید به‌عنوان نمونه‌ای از معماری یا کد آماده‌ی تولید (production-grade) در نظر گرفته شود.

## درباره

`MalDar` یک ریپازیتوری آموزشی و متن‌باز است که به‌عنوان تمرین عملیِ دوره‌ی مقدماتی Blazor در .NET 10 ساخته شده. سناریوی تمرینی، مدیریت ساده‌ی کالاهای یک مغازه است و هدف اصلی، پیاده‌سازی گام‌به‌گام مفاهیم پایه‌ی Blazor — نه ارائه‌ی یک محصول واقعی — بوده است.

## سناریو و پیاده‌سازی

ویژگی اصلیِ پیاده‌سازی‌شده، مدیریت کالاهاست: نمایش فهرست، افزودن کالای جدید، مشاهده‌ی جزئیات هر کالا، و حذف با دیالوگ تأیید. داده‌ها در یک سرویس درون‌حافظه‌ای روی همان پروژه‌ی میزبان نگهداری می‌شوند و از طریق چند Minimal API endpoint در اختیار UI قرار می‌گیرند.

| # | موضوع | نحوه‌ی تمرین در MalDar |
|---|-------|------------------------|
| ۱ | اکوسیستم Blazor در .NET 10 | مدل Blazor Web App با Interactive Server render mode |
| ۲ | آناتومی پروژه | `Program.cs`، `App.razor`، `Routes.razor`، `MainLayout.razor` در پروژه‌ی میزبان `MalDar` |
| ۳ | کامپوننت‌ها | `Products`، `ProductDetails`، `ProductRow` در `MalDar.UI` |
| ۴ | Parameters و EventCallback | `ProductRow` مقدار `Item` را به‌عنوان Parameter می‌گیرد و رویداد حذف را با `EventCallback` گزارش می‌دهد |
| ۵ | Data Binding | `@bind` روی فرم افزودن کالا (`AddProductRequest`) |
| ۶ | Lifecycle | `OnInitializedAsync` برای بارگذاری فهرست و جزئیات کالا |
| ۷ | Routing | `@page "/products"` و `@page "/products/{Id:int}"` |
| ۸ | فرم و اعتبارسنجی | `EditForm` + `DataAnnotationsValidator` روی `AddProductRequest` |
| ۹ | Dependency Injection | ثبت `IProductService` و `ProductApiClient` در `Program.cs` |
| ۱۰ | ارتباط با API | `ProductApiClient` با `HttpClient` واقعی به endpoint های `/api/products` |
| ۱۱ | JS Interop | تأیید حذف کالا از طریق `productInterop.confirmDelete` |
| ۱۲ | Razor Class Library | جداسازی کامل UI کالاها به پروژه‌ی `MalDar.UI` — پیش‌نیاز مستقیم فاز MAUI |

## مفاهیم کلیدی

- کامپوننت‌سازی و ترکیب کامپوننت‌ها (`Products` ← `ProductRow`)
- تفکیک UI قابل‌اشتراک (`MalDar.UI`) از پروژه‌ی میزبان (`MalDar`) با Razor Class Library
- اتصال به یک API واقعی به‌جای داده‌ی ثابت
- استفاده‌ی هدفمند از JS Interop برای یک نیاز واقعی (تأیید حذف)، نه صرفاً یک مثال جدا

## نتایج

- پروژه‌ی میزبان `MalDar` (.NET 10، Interactive Server) اجرا می‌شود؛ صفحات پیش‌فرض قالب (`Home`، `Counter`، `Weather`) همچنان باقی‌مانده‌اند و بخشی از سناریوی تمرین نیستند.
- ویژگی محصولات (`/products` و `/products/{id}`) کامل کار می‌کند: نمایش، افزودن، حذف با تأیید، مشاهده‌ی جزئیات.
- `MalDar.UI` آماده‌ی reference مستقیم توسط یک پروژه‌ی MAUI Blazor Hybrid است — گام بعدی دوره (به مخزن جداگانه‌ی MAUI مراجعه شود).

## یادداشت‌ها

- **پیش‌نیازها:** [.NET 10 SDK](https://dotnet.microsoft.com/download)، Visual Studio 2022+ (یا VS Code + C# Dev Kit).
- **اجرا:**
  ```bash
  git clone https://github.com/mousaamiri/MalDar-Blazor.git
  cd MalDar-Blazor/MalDar
  dotnet run
  ```
- فایل solution (`MalDar.slnx`) داخل پوشه‌ی `MalDar` قرار دارد، نه در ریشه‌ی ریپازیتوری.
- در `MalDar.UI`، فایل‌های `Component1.razor` و `ExampleJsInterop.cs` باقی‌مانده‌ی اسکفولد پیش‌فرض RCL هستند، در هیچ‌جای اپ استفاده نمی‌شوند و حذف‌شان بی‌خطر است.
- در ریشه‌ی ریپازیتوری یک پوشه‌ی ناخواسته با نامی شامل کاراکتر بک‌تیک وجود دارد (به‌همراه یک فایل خالیِ `Products.razor` با نام مشابه داخلش) که ظاهراً به‌اشتباه در ترمینال ساخته و کامیت شده؛ پیشنهاد می‌شود از ریپازیتوری حذف شود.
- **ادامه‌ی دوره:** ساخت اپ موبایل با MAUI Blazor Hybrid که مستقیماً `MalDar.UI` را reference می‌دهد — مستندات آن در README پروژه‌ی جدید آمده است.

## لایسنس

این پروژه تحت لایسنس [MIT](./LICENSE) منتشر شده است.

## نویسنده

**Mousa Amiri Motlagh**
[github.com/mousaamiri](https://github.com/mousaamiri)

</div>