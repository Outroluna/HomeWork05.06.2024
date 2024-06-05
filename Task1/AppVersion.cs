using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppV.Task1
{
    public static class AppVersion
    {
        private static string CurrentVersion = "6.6.0";

        public static void IsUpdateAvailable(string latestVersion)
        {
            Console.WriteLine($"Ваша версия: {CurrentVersion}");  /// основная версия.дополнительная версия.номер сборки
            var current = new Version(CurrentVersion); ///Класс System.Version предоставляет способ представления и 
            var latest = new Version(latestVersion);   ///сравнения версий программного обеспечения
            if (latest> current)                       ///Случайно нашла эту штуку, но не совсем понимаю как оно работает. Но работает же!
                Console.WriteLine($"Доступно обновление до версии: {latestVersion}");
            else
                Console.WriteLine("Вы используете последнюю версию");
        }
    }
}
