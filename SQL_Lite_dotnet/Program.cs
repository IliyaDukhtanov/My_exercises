// Первый проект на C# с базой данных

//Шаг 1. Импортируем пространство имён для работы с БД
using Microsoft.Data.Sqlite; 
using static System.Random;

string path = "users.db";
if (File.Exists(path)) File.Delete(path);

// Шаг 2. Создаём подключение к существующей базе данных или создаём новый файл БД и открываем его
var connection = new SqliteConnection($"Data Source={path}"); 
connection.Open();

// Шаг 3. Создаём экземпляр типа SqliteCommand, который необходим для выполнения SQL запросов. Указываем какое подключение нужно использовать
SqliteCommand command = new SqliteCommand();  
command.Connection = connection;

// Шаг 4. Формируем запрос на создание таблицы и выполняем его
command.CommandText = @" 
CREATE TABLE clients (
    id INTEGER, 
    full_name TEXT,
    date_birth TEXT,
    status INTEGER
)
";
command.ExecuteNonQuery();

// Шаг 5. Имитируем процесс добавления данных
for (int i = 1; i < 10; i++) 
{
    var dt = new DateOnly(
        Shared.Next(1990, 2020),
        Shared.Next(1, 12),
        Shared.Next(1, 28)
        ).ToString("yyyy-MM-dd");

    var sql = string.Format(
    @"
        INSERT INTO clients
            (id, full_name, date_birth, status)
        VALUES
            ({0}, 'ФИО_{1}','{2}',{3});
    ",
    i, i, dt, Shared.Next(100, 999)
    );
    command.CommandText = sql;
    command.ExecuteNonQuery();
}

// Шаг 6. Формируем запрос на выборку данных, выполняем его и сохраняем результат выполнения
command.CommandText = @"
SELECT 
    * 
FROM clients
";

SqliteDataReader reader = command.ExecuteReader();

// Можно проверить есть ли данные
// Console.WriteLine($"reader.HasRows: {reader.HasRows}");

// Шаг 7. Получаем данные для дальнейшей работы. 
while (reader.Read())
{
    string rec = string.Format("{0} {1} {2} {3}",
        reader["id"], 
        reader["full_name"],
        reader["date_birth"],
        reader["status"]
        );
    Console.WriteLine(rec);
}

reader.Close();
command.Cancel();
connection.Close();