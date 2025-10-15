using exNotificacoes;

Notification[] notifications = new Notification[3];

notifications[0] = new SMS();
notifications[1] = new Email();


foreach (var i in notifications)
{
    i.Send("AOBA");
}