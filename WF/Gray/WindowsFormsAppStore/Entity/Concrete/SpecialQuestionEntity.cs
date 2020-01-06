using Entity.Abstract.Interfaces;

namespace Entity.Concrete
{
    public enum ESpecialQuestionEntity
    {
        ID = 0,
        QUESTION,
        ANSWER
    }
    public sealed class SpecialQuestionEntity:IEntity
    {
        public long? ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public SpecialQuestionEntity(long id,string question, string answer)
        {
            ID = id; Question = question; Answer = answer;
        }
    }
}
