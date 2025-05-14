using Library.Domain.Model;

namespace Library.Domain.Data;

public static class DataSeeder
{
    public static readonly List<Book> Books =
    [
        new() { InventoryNumber = 1, CatalogCode = "A123", Authors = "А.Б. Смит", Title = "Программирование на C#", PublicationType = "Учебник", PublicationPlace = "Киев", PublicationYear = 2021 },
        new() { InventoryNumber = 2, CatalogCode = "Y002", Authors = "Д.К. Джонсон", Title = "Искусственный интеллект", PublicationType = "Научная работа", PublicationPlace = "Одесса", PublicationYear = 2020 },
        new() { InventoryNumber = 3, CatalogCode = "Z003", Authors = "М.Н. Уильямс", Title = "Веб-разработка", PublicationType = "Практическое руководство", PublicationPlace = "Львов", PublicationYear = 2022 },
        new() { InventoryNumber = 4, CatalogCode = "W004", Authors = "О.П. Браун", Title = "Квантовая физика", PublicationType = "Исследование", PublicationPlace = "Харьков", PublicationYear = 2019 },
        new() { InventoryNumber = 5, CatalogCode = "V005", Authors = "Р.С. Грин", Title = "Машинное обучение", PublicationType = "Учебное пособие", PublicationPlace = "Днепр", PublicationYear = 2023 },
        new() { InventoryNumber = 6, CatalogCode = "U006", Authors = "Т.Л. Блэк", Title = "Кибербезопасность", PublicationType = "Руководство", PublicationPlace = "Запорожье", PublicationYear = 2021 },
        new() { InventoryNumber = 7, CatalogCode = "T007", Authors = "Э.Ф. Уайт", Title = "Анализ данных", PublicationType = "Учебник", PublicationPlace = "Винница", PublicationYear = 2022 }
    ];

    public static readonly List<Department> Departments =
    [
        new() { Id = 1, Name = "Технический отдел" },
        new() { Id = 2, Name = "Научный отдел" },
        new() { Id = 3, Name = "Литературный отдел" },
        new() { Id = 4, Name = "Журнальный отдел" },
        new() { Id = 5, Name = "Коллекционный отдел" },
        new() { Id = 6, Name = "Цифровой отдел" },
        new() { Id = 7, Name = "Иностранный отдел" }
    ];

    public static readonly List<BookInDepartment> BooksInDepartments =
    [
        new() { Id = 1, InventoryNumber = 1, DepartmentId = 1, Quantity = 10 },
        new() { Id = 2, InventoryNumber = 2, DepartmentId = 2, Quantity = 5 },
        new() { Id = 3, InventoryNumber = 3, DepartmentId = 1, Quantity = 8 },
        new() { Id = 4, InventoryNumber = 4, DepartmentId = 3, Quantity = 3 },
        new() { Id = 5, InventoryNumber = 5, DepartmentId = 4, Quantity = 7 },
        new() { Id = 6, InventoryNumber = 6, DepartmentId = 5, Quantity = 2 },
        new() { Id = 7, InventoryNumber = 7, DepartmentId = 6, Quantity = 12 }
    ];

    public static readonly List<Reader> Readers =
    [
        new() { Id = 1, FullName = "Ковалев С.С.", Address = "ул. Шевченко, 15", Phone = "555-123-456", RegistrationDate = new DateTime(2023, 1, 10) },
        new() { Id = 2, FullName = "Мельник О.О.", Address = "ул. Франко, 25", Phone = "555-987-654", RegistrationDate = new DateTime(2023, 2, 15) },
        new() { Id = 3, FullName = "Шевченко П.П.", Address = "ул. Леси Украинки, 35", Phone = "555-111-222", RegistrationDate = new DateTime(2023, 3, 20) },
        new() { Id = 4, FullName = "Бондаренко И.И.", Address = "ул. Хрещатик, 45", Phone = "555-444-333", RegistrationDate = new DateTime(2023, 4, 25) },
        new() { Id = 5, FullName = "Ткаченко В.В.", Address = "ул. Грушевского, 55", Phone = "555-777-888", RegistrationDate = new DateTime(2023, 5, 30) },
        new() { Id = 6, FullName = "Кравченко Н.Н.", Address = "ул. Саксаганского, 65", Phone = "555-000-999", RegistrationDate = new DateTime(2023, 6, 5) },
        new() { Id = 7, FullName = "Олийнык М.М.", Address = "ул. Богдана Хмельницкого, 75", Phone = "555-666-555", RegistrationDate = new DateTime(2023, 7, 10) }
    ];

    public static readonly List<BookIssue> BookIssues =
    [
        new() { Id = 1, InventoryNumber = 1, ReaderId = 1, IssueDate = new DateTime(2023, 11, 1), DaysIssued = 21, ReturnDate = new DateTime(2023, 11, 22), Book = Books[0] },
        new() { Id = 2, InventoryNumber = 2, ReaderId = 2, IssueDate = new DateTime(2023, 11, 2), DaysIssued = 14, ReturnDate = new DateTime(2023, 11, 16), Book = Books[1] },
        new() { Id = 3, InventoryNumber = 3, ReaderId = 3, IssueDate = new DateTime(2023, 11, 3), DaysIssued = 7, ReturnDate = new DateTime(2023, 11, 10), Book = Books[2] },
        new() { Id = 4, InventoryNumber = 4, ReaderId = 4, IssueDate = new DateTime(2023, 11, 4), DaysIssued = 30, ReturnDate = new DateTime(2023, 12, 4), Book = Books[3] },
        new() { Id = 5, InventoryNumber = 5, ReaderId = 5, IssueDate = new DateTime(2023, 11, 5), DaysIssued = 10, ReturnDate = new DateTime(2023, 11, 15), Book = Books[4] },
        new() { Id = 6, InventoryNumber = 6, ReaderId = 6, IssueDate = new DateTime(2023, 11, 6), DaysIssued = 5, ReturnDate = new DateTime(2023, 11, 11), Book = Books[5] },
        new() { Id = 7, InventoryNumber = 7, ReaderId = 7, IssueDate = new DateTime(2023, 11, 7), DaysIssued = 28, ReturnDate = new DateTime(2023, 12, 5), Book = Books[6] }
    ];
}
