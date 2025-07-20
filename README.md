# ToDoAPP

Bu proje, **ASP.NET Core MVC** ile geliştirilmiş basit bir yapılacaklar (ToDo) listesi uygulamasıdır. Kullanıcılar görev ekleyebilir, tamamlayabilir ve listeleyebilir. Veritabanı olarak SQL Server kullanır.

## Özellikler

- Görev ekleme
- Görevleri tamamlama
- Görevleri listeleme
- SQL Server ile veri saklama

## Kurulum ve Çalıştırma

1. **Projeyi klonlayın:**

   ```sh
   git clone https://github.com/kullaniciadi/ToDoAPP.git
   cd ToDoAPP
   ```

2. **Bağlantı dizesini güncelleyin:**

   - `ToDoAPP/appsettings.json` dosyasındaki `DefaultConnection` değerini kendi SQL Server instance’ınıza göre ayarlayın.

3. **Veritabanını oluşturun:**

   ```sh
   dotnet ef database update --project ToDoAPP/ToDoAPP.csproj
   ```

4. **Projeyi başlatın:**

   ```sh
   dotnet run --project ToDoAPP/ToDoAPP.csproj
   ```

   veya Visual Studio’da F5 ile çalıştırabilirsiniz.

5. **Tarayıcıda açın:**
   ```
   http://localhost:5286/Todo/Index
   ```

## Gereksinimler

- .NET 7 SDK
- SQL Server (veya LocalDB)
- Visual Studio 2022 (isteğe bağlı)

## Lisans

MIT
