string myLog = "ArmfeterLex", myPas = "Arm";
string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещён!";
Console.WriteLine("Введите логин:   ");
string log = Console.ReadLine();
if (log.Length < 5) mes = "Логин очень короткий!\n" + mesNo;
else if (log != myLog) mes = "Неверный логин!\n" + mesNo;
if (log.Length > 12) mes = "Логин очень длинный!\n" + mesNo;
else if (log != myLog) mes = "Неверный логин!\n" + mesNo;
else
{ Console.Write("Введите пароль:   ");
    string pas = Console.ReadLine();
    mes = (pas == myPas) ? mesYes : "Неверный пароль!\n" + mesNo;
}
Console.WriteLine(mes);
Console.ReadKey();
