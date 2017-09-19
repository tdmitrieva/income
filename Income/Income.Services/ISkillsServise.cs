using Income.DataTransferObjects;
using System.Collections.Generic;

namespace Income.Services
{
    public interface ISkillsServise
    {
        ICollection<SkillModel> GetAll();
    }
}
