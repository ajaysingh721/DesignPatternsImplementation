
namespace DesignPatterns.Interfaces
{

    using Enums;
    using System.Collections.Generic;

    public interface IQuestion<T>
    {
        int Id { get; set; }
        T Value { get; set; }
        string Key { get; set; }
        string Label { get; set; }
        bool Required { get; set; }
        string RegEx { get; set; }
        int Order { get; set; }
        QuestionType ControlType { get; set; }
        ICollection<IQuestionnire> Questionnires { get; set; }
    }
}