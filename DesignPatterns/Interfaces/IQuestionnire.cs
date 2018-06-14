
namespace DesignPatterns.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IQuestionnire
    {
        int Id { get; set; }
        string User { get; set; }
        ICollection<IQuestion<object>> Questions { get; set; }
    }
}
