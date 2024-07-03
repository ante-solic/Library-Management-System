﻿using N_Tier.Application.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Services
{
    public interface IWorkService
    {
        Task<CreateWorkResponseModel> CreateAsync(CreateWorkModel createWorkModel);

        Task<IEnumerable<WorkResponseModel>> GetAllAsync();

        Task<WorkResponseModel> GetById(Guid id);

        Task<UpdateWorkResponseModel> UpdateAsync(Guid id, WorkResponseModel workResponseModel);

        Task<bool> DeleteAsync(Guid id);

        IEnumerable<WorkResponseModel> Search(IEnumerable<WorkResponseModel> works, string searchString);

        IEnumerable<WorkResponseModel> Filter(IEnumerable<WorkResponseModel> works, string filterString);

        IEnumerable<WorkResponseModel> Sort(IEnumerable<WorkResponseModel> works, string sortString);
    }
}
