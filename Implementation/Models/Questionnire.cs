
namespace Implementation.Models
{
    using DesignPatterns.Interfaces;
    using System.Collections.Generic;

    public class Questionnire : IQuestionnire
    {
        public Questionnire()
        {
            Questions = new HashSet<IQuestion<object>>();
        }
        public int Id { get; set; }
        public string User { get; set; }
        public virtual ICollection<IQuestion<object>> Questions { get; set; }
    }
}