using System.Collections.Generic;
using Income.Repositories;
using Income.Models;
using System.Linq;
using Income.DataTransferObjects;
using Income.DataTransferObjects.MappingEngine;

namespace Income.Services.Implementations
{
    public class SkillsService : ISkillsServise
    {
        private readonly IUnitOfWork unitOfWork;

        public SkillsService(IUnitOfWork unitOfWorkInstance)
        {
            unitOfWork = unitOfWorkInstance;
        }

        public ICollection<SkillModel> GetAll()
        {
            Repository<Skill> skillsRepository = unitOfWork.GetRepository<Skill>();
            List<Skill> skills = skillsRepository.Query().ToList();
            return ModelMapper.Map<ICollection<SkillModel>>(skills);
        }
    }
}
