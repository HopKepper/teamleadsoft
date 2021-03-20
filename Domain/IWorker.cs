namespace VMakarov.SalaryDev.Domain
{
    public interface IWorker
    {
        double Salary { get; set; }
        string Name { get; }
        string Surname { get; }
        int ID { get; }
        double LTime { get; set; }
        void LogTime();
    }
}