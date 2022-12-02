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
                Title = "�������������� ������� ��� \"��� ��������-������\"",
                Status = "�������������",
                FioWorker = "���������� ������� ���������",
                FioManager = "������� ����� ������������"
            });
            filters.Add(new Filter
            {
                Title = "��������� ������������ ��� \"��� ��������-������\"",
                Status = "�������������",
                FioWorker = "���������� ������� ���������",
                FioManager = "������� ����� ������������"
            });
            WorkerFilter workerFilter=new WorkerFilter();
            Worker worker = new Worker()
            {
                login= "galiulina",
                FirstName= "����������",
                MiddleName= "�������",
                LastName= "���������",
                password="123"
            };
            workerFilter.Worker=worker;
            List<Filter> filters2 = workerFilter.getWork(worker.login);
            CollectionAssert.AreEqual(filters, filters2);

        }
    }
}