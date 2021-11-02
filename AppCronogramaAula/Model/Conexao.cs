using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source = DESKTOP - 4QOUJ24\SQLEXPRESS; Initial Catalog = bdcronograma_aula; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }
    }
}
