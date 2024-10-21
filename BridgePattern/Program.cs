using BridgePattern;

class Program
{
    static void Main()
    {
        INotification email = new EmailNotification();
        INotification sms = new SmsNotification();

        Notify emailNotification1 = new TextNotify(email);
        emailNotification1.SendNotify("Драйв — не вкусно, лучше бери берн", "karpenkoev@mer.ci.nsu.ru");

        Notify emailNotification2 = new HTMLNotify(email);
        emailNotification2.SendNotify("В уборную надо - купи торнадо!", "knigamy@mer.ci.nsu.ru");

        Notify smsNotification1 = new TextNotify(sms);
        smsNotification1.SendNotify("Берн с гуавой - имба", "+7 (996) 606 96 09 ");

        Notify smsNotification2 = new HTMLNotify(sms);
        smsNotification2.SendNotify("Флеш с карамболой - имба", "+7 (999) 909 90 09");
    }
}