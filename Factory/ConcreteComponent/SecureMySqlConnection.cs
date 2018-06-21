using Factory.Interface;

namespace Factory.ConcreteComponent
{
    internal class SecureMySqlConnection : IConnection
    {
        public string Description()
        {
            return "MySql secure";
        }
    }
}