using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Negocio
{
    public interface IPersistente
    {
        bool Create();
        bool Read(long isbn);
        bool Update();
        bool Delete(long isbn);
    }
}
