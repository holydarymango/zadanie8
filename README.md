#практическая 8
Эта работа, выполнена Банзеруком Д.В, студентом группы П22-3.1, которая демонстрирует систему добавления сотрудников а так же добавление новых должностей и сотрудников. Работа включает в себя окна внесения данных сотрудников и создания новых должностей и отделов.

## Функционал
  
- Обработка ошибок: Отображает ошибки при вводе данных в окне регистрации.
- Окно внесения данных сотрудника: Возволяет вносить данные.
- Окно создания должности: Позволяет создавать должность.
- Окно создания отдела: Позволяет создавать отдел.


## Скриншоты

1. Главное окно:
   
   ![](https://github.com/Durax66/ItogOOP-Tusk8--/blob/master/screenshots/screen%201.png)


2. Окно внесения данных:
   
   ![](https://github.com/Durax66/ItogOOP-Tusk8--/blob/master/screenshots/screen%204.png)
   
3.Окно создания должности:

   ![](https://github.com/Durax66/ItogOOP-Tusk8--/blob/master/screenshots/screen%203.png)

4.Окно создания отдела: 

   ![](https://github.com/Durax66/ItogOOP-Tusk8--/blob/master/screenshots/screen%202.png)
   
## Установка

1. Клонируйте репозиторий:
   
   git clone https://github.com/holydarymango/zadanie8
    
   2. Откройте проект в Visual Studio:
   - Запустите Visual Studio.
   - Выберите "Открыть проект" и перейдите к папке, куда вы клонировали репозиторий.
   - Выберите файл решения (.sln) и откройте его.

3. Убедитесь, что у вас установлен SQL Server и Entity Framework:
   - Убедитесь, что у вас установлен SQL Server (можно использовать SQL Server Express).
   - Убедитесь, что у вас установлены необходимые пакеты NuGet для Entity Framework.

4. Настройте строку подключения в файле appsettings.json:
   - Откройте файл appsettings.json в корне проекта.
   - Найдите раздел ConnectionStrings и измените строку подключения на вашу, например:
     
     "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=your_database;User   Id=your_username;Password=your_password;"
     }
     

5. Обновите базу данных:
   - Откройте консоль диспетчера пакетов (Tools > NuGet Package Manager > Package Manager Console).
   - Выполните команду для применения миграций:
     
     Update-Database
     

6. Запустите проект:
   - Нажмите F5 или выберите "Запустить" в меню, чтобы запустить приложение.
