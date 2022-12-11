using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string description)
        {
            Description = description;//Aqui o usuário deve passar esse parâmetro
            CreatedAt = DateTime.Now;
        }

        public string Description { get; private set; }//O private set é para respeitar o encapsulamento
        public DateTime CreatedAt { get; private set; }//Ele não permite a alteração dessa propriedade fora do escopo da classe
    }
}
