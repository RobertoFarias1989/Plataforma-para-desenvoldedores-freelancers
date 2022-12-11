using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateProject
{
    public class CreateProjectCommand : IRequest<int>
    {
        //Perceba que essas informações são as que , obrigatoriamente, serão enviadas
        //ou seja, aquelas que estão no construtor da sua entidade
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdClient { get; set; }
        public int IdFreelancer { get; set; }
        public decimal TotalCost { get; set; }
    }
}
