using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public interface IConnectionStringConsumer
    {
        void SetConnectionString(string connectionString);
        void SetOpenType(string openType, int? selectedId, bool isAdmin);
    }
}
