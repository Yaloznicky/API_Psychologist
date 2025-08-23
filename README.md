# API_Psychologist

## Описание

Это диплоный проект, состоящий из двух приложений:
1. API_Psychologist - серверня часть. Приложение для платформы психолога. Проект предоставляет RESTful API для управления данными пользователей и сеансов, используя современный стек технологий .NET 8 и MySQL.
2. DesktopPsychologist_WF - клиентская часть. Приложение Windows Forms, разработанное для предоставления информации об услугах психолога через удобный десктопный интерфейс. Приложение использует современные технологии .NET и включает интеграцию с внешними API.

## Технические характеристики

API_Psychologist
* Платформа: .NET 8.0
* ORM: Entity Framework Core 8.0.3
* Интерактивная документация Swagger/OpenAPI: Swashbuckle.AspNetCore 6.5.0
* База данных: MySQL

DesktopPsychologist_WF
* Платформа: .NET Framework 4.8
* Архитектура: Dependency Injection с использованием Microsoft.Extensions.DependencyInjection
* ORM: Entity Framework 6
* Интерфейс: Windows Forms

## Настройка и запуск

### Предварительные требования

Перед запуском проекта убедитесь, что на вашем компьютере установлено:
1. .NET 8.0 SDK
2. MySQL Server (версия 8.0 или выше)
3. IDE или редактор кода (рекомендуется Visual Studio 2022)
4. .NET Framework 4.8

### Сборка и настройка приложений

API_Psychologist
1. Клонируйте репозиторий: `git clone [https://github.com/Yaloznicky/API_Psychologist.git]`
2. Откройте решение в Visual Studio
3. Восстановите NuGet пакеты
4. Настройте базу данных (если необходимо):
    
    4.1. Обновите строку подключения в файле appsettings.json:
    ```
        "ConnectionStrings": {
            "Default": "Server=localhost;User=root;Password=your_password;Port=port_number_;Database=dbpsychologist"
        },
    ```
        Замените your_password на пароль вашего пользователя MySQL.
        Замените port_number на номер порта вашего пользователя MySQL.
    4.2. Применените миграции `dotnet ef database update`

DesktopPsychologist_WF
1. Клонируйте репозиторий `git clone [https://github.com/Yaloznicky/DesktopPsychologist_WF.git]`
2. Откройте решение в Visual Studio
3. Восстановите NuGet пакеты
4. Соберите решение (Ctrl+Shift+B)

### Запуск и использование

1. Запустите приложение API_Psychologist: `dotnet run` или (F5)
2. Запустите приложение DesktopPsychologist_WF (F5)

> **DesktopPsychologist_WF**\
> Для доступа к административному интерфейсу нужно воспользоваться учетной записью администратора: логин - Admin, пароль - 123.\
> В данном проекте не используется валидация паролей по количеству символов, использованию букв в верхнем и нижнем регистре, цифр и спец. символов.\
> Для рабочего проекта необходимо использовать усложненную валидацию паролей.

## Документация API

После запуска приложения API_Psychologist документация API доступна через Swagger UI: http://localhost:5180/swagger

## Разработка

Доплнительная разработка и внесение изменений не требуется.

## Участники

* Ялозницкий Станислав Валерьевич
