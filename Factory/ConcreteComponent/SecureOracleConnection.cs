using Factory.Interface;

namespace Factory.ConcreteComponent
{
    internal class SecureOracleConnection : IConnection
    {
        public string Description()
        {
            return "Oracle Secure";
        }
    }
}