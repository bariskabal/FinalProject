using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EFCore.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EFCore
{
    public class EFCategoryRepository : EFGenericRepositoryBase<Category, NortwindContext>,ICategoryDal
    {
    }
}
