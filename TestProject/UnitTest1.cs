using DeMVC.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            List<Filter> filters = new List<Filter>();
            filters.Add(new Filter
            {
                Title = "Проектирование системы для \"ООО Автопром-сервис\"",
                Status = "запланирована",
                FioWorker = "Галиуллина Альбина Нафисовна",
                FioManager = "Куклева Дарья Владимировна"
            });
            filters.Add(new Filter
            {
                Title = "Установка оборудования для \"ООО Автопром-сервис\"",
                Status = "запланирована",
                FioWorker = "Галиуллина Альбина Нафисовна",
                FioManager = "Куклева Дарья Владимировна"
            });
            WorkerFilter workerFilter=new WorkerFilter();
            Worker worker = new Worker()
            {
                login= "galiulina",
                FirstName= "Галиуллина",
                MiddleName= "Альбина",
                LastName= "Нафисовна",
                password="123"
            };
            workerFilter.Worker=worker;
            List<Filter> filters2 = workerFilter.getWork(worker.login);
            CollectionAssert.AreEqual(filters, filters2);

        }
    }
}