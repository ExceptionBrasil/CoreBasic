namespace Core_Teste.Sessions
{
    public interface ISessionT
    {
        string SessionController { get; set; }
        string OpenSession();
    }
}