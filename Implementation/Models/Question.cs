
namespace Implementation.Models
{
    using DesignPatterns.Enums;
    using DesignPatterns.Interfaces;

    public class Question : IQuestion<string>
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
        public string RegEx { get; set; }
        public int Order { get; set; }
        public QuestionType ControlType { get; set; }
    }
}