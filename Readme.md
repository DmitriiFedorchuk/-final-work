**Задача:**

Написать программу, которая из имеющегося массива строк,формирует массив из строк, длина которых
меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

**Описание решения**
Создается два массива, из первого будем выбирать те элементы, которые соответствуют условию задачи а во второй будем помещать эти элементы. Далее создаю метод который сортирует наш массив и выбирает элементы соответствующие условию, то есть <=3, при обнаружении соответствия, элемент первого массива, записывается в переменную count . После того как записали элемент,  count увеличиваем на 1 и переходим снова к циклу for в котором ind увеличивается на 1 единицу. Все условия выполняются до конца массива.