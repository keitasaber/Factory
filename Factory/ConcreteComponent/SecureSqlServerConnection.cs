using Factory.Interface;

namespace Factory.ConcreteComponent
{
    internal class SecureSqlServerConnection : IConnection
    {
        public string Description()
        {
            return "Sqlserver Secure";
        }
    }
}