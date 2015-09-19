Project Slimming Center

Перед запуском:
1. Установить EntityFramework в приложение.

При первом запуске:
1. Cоздается база данный SlimmingCenter с помощью EntityFramework, методом CodeFirst. 
2. Заполняются данные 3-х клиентов. 
3. Метод Index выводит их Id и Name в список в представлении.

Перед последующими запусками:
1. В файле Global.asax в методе Application_Start закомментировать строку 
Database.SetInitialezer(new CenterInitialize()); чтобы база не удалялась и создавалась повторно.
2. В конфигурационном файле проверить строку подключения для текущей СУБД. (в приложении прописана строка для SQLEXPRESS)
