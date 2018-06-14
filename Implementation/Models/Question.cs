
namespace Implementation.Models
{
    using DesignPatterns.Enums;
    using DesignPatterns.Interfaces;
    using System.Collections.Generic;

    public class Question : IQuestion<object>
    {
        public Question()
        {
            Questionnires = new HashSet<IQuestionnire>();
        }

        public int Id { get; set; }
        public object Value { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
        public string RegEx { get; set; }
        public int Order { get; set; }
        public QuestionType ControlType { get; set; }
        public virtual ICollection<IQuestionnire> Questionnires { get; set; }
    }
}