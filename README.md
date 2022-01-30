# Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

* Вводим массив startArray с набором элементов. 
* Вводим пустой массив finalArray, в него будут складываться элементы, подходящие под условия.
* Вводим счетчик элементов "i" для массива startArray и "j" для массива finalArray.

Далее выполняем проверку:

1. Пока i < длины массива startArray:

    **1.1  если количество символов в iтом элементе массива startArray меньше или равно трем:**
    
    1.1.1 увеличиваем количество элементов в массиве finalArray (Array.Resize), увеличиваем j (j+1);

    1.1.2 записываем iтый элемент startArray в jтый элемент finalArray, выводим на экран;

    1.1.3 увеличиваем i (i+1) и возвращаемся к пункту 1;

    **1.2 если количество символов в iтом элементе массива startArray больше трех:**

    1.2.1 увеличиваем i (i+1) и возвращаемся к пункту 1;

При достижении условия в пункте 1 программа прекращает работу.
