# Basic_block-ControlTask
Control Task

##___Задача:___## 

Написать программу, которая из имеющегося массива строк  формирует новый массив из строк, длина которых меньше,  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
***

####___Алгоритм решения задачи:___####

Пропишем два строковых массива, первый инициализирован, длинна второго массива равна длине первого массива, но он пока только объявлен.

___Создадим метод string типа с параметрами из двух строковых массивов, для инициализации второго массива по условию задания.__


Инициализируем переменную count нулём, она будет счётчиком индексов элементов для второго массива.


Через цикл for пройдём по первому массиву, количество итераций будет меньше длины первого массива, что соответствуе количеству элементов массива по индексу и если есть элементы в массиве, по условию задачи, меньше либо равные 3 символам, положим их во второй массив, при этом count отразит индекс этих элементов.

__Создадим метод типа void для вывода второго массива на печать.__ 
параметром для него будет массив, который надо напечатать в консоле.

Через цикл foreach пропишем элементы в консоль.
