using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public  abstract class BaseEntity//Ela é criada como abstract para que não seja possível instanciá-la diretamente
    {
        protected BaseEntity(){}
        public int Id { get; private set; }//todas as nossas classes terão um identificador
    }
}
