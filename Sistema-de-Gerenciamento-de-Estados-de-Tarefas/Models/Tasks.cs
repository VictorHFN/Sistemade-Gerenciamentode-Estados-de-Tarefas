using Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Models.ENUM;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
    }
}
