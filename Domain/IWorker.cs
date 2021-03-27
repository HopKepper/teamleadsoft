namespace VMakarov.SalaryDev.Domain
{
    public interface IWorker // TODO: Можно переделать в абстрактный класс, чтобы в дальнейшем использовать Строитель/Фабричный Метод
    {
        double Salary { get; set; }
        string Name { get; }
        string Surname { get; }
        int ID { get; }
        double LTime { get; set; }
        void LogTime();
    }
}