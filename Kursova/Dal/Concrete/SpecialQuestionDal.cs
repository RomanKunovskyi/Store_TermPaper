using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class SpecialQuestionDal : ADalCrud<SpecialQuestionEntity>
    {
        public SpecialQuestionDal() : base() { }
        protected override SpecialQuestionEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            SpecialQuestionEntity entity = new SpecialQuestionEntity(
            Convert.ToInt64(parameters[Convert.ToInt32(ESpecialQuestionEntity.ID)]),
            parameters[Convert.ToInt32(ESpecialQuestionEntity.QUESTION)],
            parameters[Convert.ToInt32(ESpecialQuestionEntity.ANSWER)]);
            return entity;
        }

        protected override IDictionary<Enum, (string field, string pvalue, dynamic value)> GetKeyFieldsValues(SpecialQuestionEntity entity)
        {
            IDictionary<Enum, (string field, string pvalue, dynamic value)> Dictionary = new Dictionary<Enum, (string field, string pvalue, dynamic value)>();
            if (entity.ID.HasValue)
            {
                Dictionary.Add(ESpecialQuestionEntity.ID, ("user_id", "@id", entity.ID));
            }
            if (entity.Question != null)
            {
                Dictionary.Add(ESpecialQuestionEntity.QUESTION, ("quetion", "@quetion", entity.Question));
            }
            if (entity.Answer != null)
            {
                Dictionary.Add(ESpecialQuestionEntity.ANSWER, ("answer", "@answer", entity.Answer));
            }
            return Dictionary;
        }

        protected override string GetTableField(string field) => field switch
        {
            "id" => "user_id",
            "quetion" => "quetion",
            "answer" => "answer",
            _ => throw new FieldNotFoundExeption(field)
        };

        protected override string GetTableName()
        {
            return "tblSpecialQuestion";
        }
    }
}
