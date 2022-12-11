using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreenlacer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreenlacer = idFreenlacer;
            TotalCost = totalCost;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();

        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public User Client { get; private set; }
        public int IdFreenlacer { get; private set; }
        public User Freelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }//O ? indica que ele pode ser null, ou seja, que não é definida assim que o objeto é criado
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void Cancel()
        {
            if (Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.InProgress)
            Status = ProjectStatusEnum.Cancelled;
        }

        public void Start()
        {
            //Eu só startar um projeto que já foi criado
            if (Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
            }
        }

        public void Finish()
        {
            if(Status == ProjectStatusEnum.PaymentPending)
            {
                Status = ProjectStatusEnum.Finished;
                FinishedAt = DateTime.Now;
            }
        }

        public void SetPaymentPending()
        {
            Status = ProjectStatusEnum.PaymentPending;
            FinishedAt = null;
        }

        public void Update( string title, string description, decimal totalCost)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
        }
    }
}
