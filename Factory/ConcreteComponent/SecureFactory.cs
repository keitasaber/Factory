using Factory.AbstractComponent;
using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Factory.ConcreteComponent
{
    class SecureFactory : ConnectionFactory
    {
        public override IConnection CreateConnection(string type)
        {
            switch (type)
            {
                case "Oracle":
                    return new SecureOracleConnection();
                case "Sqlserver":
                    return new SecureSqlServerConnection();
                default:
                    return new SecureMySqlConnection();
            }
        }
    }
}
