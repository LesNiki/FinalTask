Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]


1. Для решения поставленной задачи нарисована блок-схема алгоритма, которая представлена в файле diagram.jpg.

2. Написана программа, решающая поставленную задачу.

2.1. Для этого созданы два массива: в array1 заданы первоначальные значения, в array2 будет выведен массив из сформированных значений.

2.2. Далее создан цикл, в котором перебираются значения начального массива. 
Переменная i меняется и увеличивается при нахождении значений, удовлетворяющих поиску (так мы "пробегаемся" по всей длине первого массива).

2.3. Внутри цикла создано условие, удовлетворяющее заданному (длина строки нового массива должна быть не больше 3 симоволов). 
Подходящие под это условие строки записываются в новый массив array2.

2.4. Создан метод вывода массива на экран, благодаря которому выведены оба массива.

3. В работе использован контроль версий, создано несколько коммитов.
4. Создан репозиторий на GitHub, куда загружены необходимые файлы.
