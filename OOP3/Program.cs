using System;
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager=new PersonalCreditManager();
            ICreditManager autoCreditManager=new AutoCreditManager();
            ICreditManager housingCreditManager=new HousingCreditManager();

            ILoggerService databaseLoggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {new SmsLoggerService(),new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ToApply(new TradesCreditManager(), loggers);

             List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager, autoCreditManager};
            
            //applicationManager.DoCreditPreBrief(credits);

        }
    }
}
