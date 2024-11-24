using Business.Dtos.Requests;
using Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandsService
{
    CreatedBrandResponse Add(CreateBrandRequest brand);

    List<GetAllBrandResponse> GetAll();
}
