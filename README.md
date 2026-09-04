# MalDar

> پروژه‌ای فقط و فقط برای تمرین و یادگیری مبانی **Blazor**

![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

## درباره‌ی پروژه

`MalDar` یک ریپازیتوری متن‌باز و کاملاً آموزشیه که فقط و فقط برای تمرین و یادگیری **مبانی Blazor** ساخته شده — بدون هیچ وابستگی به MAUI، بدون هیچ اپلیکیشن اندرویدی، و بدون هیچ منطق کسب‌وکاری واقعی. اینجا صرفاً محلی برای تمرین سرفصل‌های زیره.

## سرفصل‌های دوره‌ی مقدماتی

| # | موضوع | توضیح |
|---|-------|-------|
| ۱ | اکوسیستم Blazor در .NET 10 | مدل‌های میزبانی: Blazor Server، Blazor WebAssembly، الگوی یکپارچه‌ی Blazor Web App (Static SSR / Interactive Server / Interactive WebAssembly / Auto)، و Blazor Hybrid |
| ۲ | آناتومی یک پروژه‌ی Blazor | `Program.cs`، `App.razor`، `Routes.razor`، `MainLayout.razor`، `_Imports.razor`، `wwwroot` |
| ۳ | کامپوننت‌ها — قلب Blazor | Razor syntax، Parameters، EventCallback، ترکیب کامپوننت‌ها (Composition)، Cascading Values/Parameters |
| ۴ | Data Binding و رویدادها | `@bind`، `@bind:event`، `@bind:after`، `@onclick` و سایر event handler ها |
| ۵ | چرخه‌ی حیات کامپوننت (Lifecycle) | `OnInitialized[Async]`، `OnParametersSet[Async]`، `OnAfterRender[Async]`، `IDisposable`/`IAsyncDisposable` |
| ۶ | Routing و Navigation | `@page`، route parameters، `NavLink`، `NavigationManager` |
| ۷ | فرم‌ها و اعتبارسنجی | `EditForm`، `DataAnnotationsValidator`، `InputText`/`InputNumber`/...، اعتبارسنجی سفارشی |
| ۸ | Dependency Injection در Blazor | تفاوت رفتار DI بین Server/WASM/Hybrid |
| ۹ | ارتباط با API | تنظیم `HttpClient`، فراخوانی API، مدیریت خطا و loading state |
| ۱۰ | JS Interop (پایه) | `IJSRuntime`، فراخوانی جاوااسکریپت از C# و برعکس |
| ۱۱ | Razor Class Library (RCL) | پل ارتباطی برای اشتراک‌گذاری UI بین یک پروژه‌ی وب و یک پروژه‌ی Hybrid |
| ۱۲ | آشنایی مفهومی با Blazor Hybrid / BlazorWebView | مقدمه‌ای بر مکانیزمی که در MAUI استفاده می‌شه (پیاده‌سازی کامل، سرفصل دوره‌ی بعدیه) |

## نقشه‌ی راه (دوره‌های بعدی)

**متوسط:** الگوهای مدیریت state (state container، Fluxor)، Authentication/Authorization، ترکیب render mode ها و پرفورمنس، تست کامپوننت با bUnit، SignalR/real-time، PWA

**پیشرفته:** JS Interop پیشرفته (JS modules، `JSObjectReference`)، معماری مشترک بین یک اپ وب و یک اپ MAUI Hybrid، CI/CD برای اپ‌های Hybrid، پرفورمنس پیشرفته (virtualization، استراتژی‌های prerendering)، دسترسی‌پذیری (accessibility)

## پیش‌نیازها

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ (یا VS Code با افزونه‌ی C# Dev Kit)

## اجرای پروژه

```bash
git clone https://github.com/mousaamiri/MalDar.git
cd MalDar
dotnet run
```

## لایسنس

این پروژه تحت لایسنس [MIT](./LICENSE) منتشر شده.

## نویسنده

**Mousa Amiri Motlagh**
[github.com/mousaamiri](https://github.com/mousaamiri)