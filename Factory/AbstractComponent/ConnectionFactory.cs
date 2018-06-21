using Factory.Interface;

namespace Factory.AbstractComponent
{
    public abstract class ConnectionFactory
    {
        public ConnectionFactory()
        {
        }

        public abstract IConnection CreateConnection(string type);
    }
}