using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.API.Models
{
    public record AddJobVacancyDTO(
        string Title,
        string Description,
        string Company,
        bool IsRemote,
        string SalaryRange
    )
    {
        
    }
}