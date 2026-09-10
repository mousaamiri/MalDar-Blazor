# MalDar.Mobile

![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

<div dir="rtl">

> ⚠️ این ریپازیتوری/پروژه هم مانند [MalDar-Blazor](https://github.com/mousaamiri/MalDar-Blazor) صرفاً برای **یادگیری و تمرین مبانی .NET MAUI Blazor Hybrid** ساخته می‌شود. سطح آن مقدماتی است؛ نویسنده پیش از این هیچ تجربه‌ای با MAUI یا XAML نداشته و این پروژه اولین قدم‌های او در این مسیر است.
>
> نام و مسیر این پروژه فرضی در نظر گرفته شده (`MalDar.Mobile`)؛ اگر در عمل نام یا محل دیگری انتخاب شود، کافی‌ست عنوان و ارجاعات نام در همین فایل اصلاح شود.

## درباره

`MalDar.Mobile` ادامه‌ی مستقیم دوره‌ی مقدماتی [MalDar-Blazor](https://github.com/mousaamiri/MalDar-Blazor) است. هدف، ساخت یک اپ موبایل با **.NET MAUI Blazor Hybrid** است که به‌جای بازنویسی UI، همان کتابخانه‌ی `MalDar.UI` (شامل صفحات و سرویس‌های مدیریت کالا) را مستقیماً به‌عنوان Razor Class Library reference می‌دهد.

## سناریو و پیاده‌سازی

| # | فاز | هدف | وضعیت |
|---|-----|-----|-------|
| ۱ | ساخت پروژه‌ی MAUI Blazor Hybrid + reference به `MalDar.UI` | دیدن اولین اجرای اپ روی دسکتاپ | در حال آغاز |
| ۲ | آناتومی پروژه (`Platforms`، `MauiProgram.cs`، `App.xaml.cs`، `MainPage.xaml`) | فهم اسکلت پروژه بدون غرق‌شدن در XAML | برنامه‌ریزی‌شده |
| ۳ | Wiring مجدد DI و `HttpClient` برای موبایل | وصل‌شدن `MalDar.UI` به API واقعی از اپ موبایل | برنامه‌ریزی‌شده |
| ۴ | چالش‌های خاص پلتفرم (آدرس API روی امولاتور Android، گواهی dev https) | رفع گیرهای رایج مبتدی‌ها | برنامه‌ریزی‌شده |
| ۵ | App Lifecycle موبایل | رفتار درست اپ هنگام Sleep/Resume | برنامه‌ریزی‌شده |
| ۶ | معرفی MAUI Essentials (مثل Connectivity یا SecureStorage) | اولین قابلیت واقعاً native داخل MalDar | برنامه‌ریزی‌شده |
| ۷ | اجرا و دیباگ روی Android امولاتور | خروج از حالت فقط-ویندوز | برنامه‌ریزی‌شده |
| ۸ (اختیاری) | آشنایی مقدماتی با Shell و XAML | فقط در صورت نیاز به native navigation | آینده/اختیاری |

## مفاهیم کلیدی

- میزبانی UI مبتنی بر Blazor داخل یک کنترل native به نام `BlazorWebView`، بدون نیاز به بازنویسی با XAML
- اشتراک‌گذاری واقعیِ UI بین یک اپ وب و یک اپ موبایل از طریق یک Razor Class Library مشترک (`MalDar.UI`)
- الگوی آشنای DI/`Program.cs` که در `MauiProgram.cs` هم تکرار می‌شود
- دسترسی به قابلیت‌های native (فایل، مکان، اتصال شبکه و ...) از داخل کامپوننت‌های Blazor از طریق MAUI Essentials
- تفاوت‌های عملی اجرای همان UI روی وب در برابر یک اپ موبایل (شبکه، چرخه‌ی حیات، گواهی‌های dev)

## نتایج

در حال حاضر تنها نقشه‌ی راه و مرحله‌ی اول تعریف شده‌اند؛ اجرای عملی (ساخت پروژه و reference دادن به `MalDar.UI`) هنوز آغاز نشده است. این بخش پس از هر مرحله به‌روزرسانی می‌شود.

## یادداشت‌ها

- **پیش‌نیاز:** نصب/آپدیت Workload «.NET Multi-platform App UI development» از Visual Studio Installer.
- این پروژه به `MalDar.UI` از ریپازیتوری [MalDar-Blazor](https://github.com/mousaamiri/MalDar-Blazor) با یک ProjectReference مستقیم وابسته است و بدون آن قابل build نیست — یا باید هر دو در یک solution مشترک باشند، یا این ریپازیتوری به‌صورت submodule/کنار همان مخزن نگهداری شود.
- مانند MalDar-Blazor، این پروژه هم صرفاً آموزشی است؛ تصمیمات معماری آن (از جمله انتخاب یا نادیده‌گرفتن Shell) بر اساس نیاز یادگیری گرفته می‌شود، نه یک محصول نهایی.

## لایسنس

مشابه پروژه‌ی وب، تحت لایسنس MIT در نظر گرفته شده (در صورت نیاز قابل تغییر).

## نویسنده

**Mousa Amiri Motlagh**
[github.com/mousaamiri](https://github.com/mousaamiri)

</div>
