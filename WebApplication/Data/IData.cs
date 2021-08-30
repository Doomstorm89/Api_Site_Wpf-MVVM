namespace WebApplication.Data
{
    public interface IData<in T>
    {
        public void SaveDb() { }

        public void AddData(T data) { }
    }
}