-- Створення таблиці
CREATE TABLE books (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(100) NOT NULL,
    author VARCHAR(100) NOT NULL,
    publication_year INT,
    is_available BOOLEAN DEFAULT TRUE
);

-- Додавання нової колонки
ALTER TABLE books ADD COLUMN genre VARCHAR(50);

-- Вставка даних
INSERT INTO books (title, author, publication_year, genre) VALUES
('1984', 'George Orwell', 1949, 'Science Fiction'),
('To Kill a Mockingbird', 'Harper Lee', 1960, 'Fiction'),
('Pride and Prejudice', 'Jane Austen', 1813, 'Romance');

-- Запит на вибірку даних
SELECT * FROM books WHERE publication_year > 1900;

-- Оновлення даних
UPDATE books SET is_available = FALSE WHERE id = 1;

-- Видалення даних
DELETE FROM books WHERE id = 3;

-- Створення процедури
DELIMITER //
CREATE PROCEDURE GetAvailableBooks()
BEGIN
    SELECT * FROM books WHERE is_available = TRUE;
END //
DELIMITER ;

-- Виклик процедури
CALL GetAvailableBooks();
