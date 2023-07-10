// Получаем ссылки на радио-кнопки и поля для ввода
const noRecoveryRadioButton = document.getElementById('RecoveryChoice1');
const codeWordRadioButton = document.getElementById('RecoveryChoice2');
const emailRadioButton = document.getElementById('RecoveryChoice3');
const codeWordInput = document.getElementById('codeWordInput');
const emailInput = document.getElementById('emailInput');

// Добавляем обработчик события при изменении выбора радио-кнопки
noRecoveryRadioButton.addEventListener('change', function () {
    codeWordInput.value = ''; // Очищаем поле кодового слова
    emailInput.value = ''; // Очищаем поле email
    codeWordInput.style.display = 'none'; // Скрываем поле для ввода кодового слова
    emailInput.style.display = 'none'; // Скрываем поле для ввода email
});

codeWordRadioButton.addEventListener('change', function () {
    emailInput.value = ''; // Очищаем поле email
    codeWordInput.style.display = 'block'; // Показываем поле для ввода кодового слова
    emailInput.style.display = 'none'; // Скрываем поле для ввода email
});

emailRadioButton.addEventListener('change', function () {
    codeWordInput.value = ''; // Очищаем поле кодового слова
    codeWordInput.style.display = 'none'; // Скрываем поле для ввода кодового слова
    emailInput.style.display = 'block'; // Показываем поле для ввода email
});
