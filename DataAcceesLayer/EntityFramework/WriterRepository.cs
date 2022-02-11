using DataAcceesLayer.Abstract;
using DataAcceesLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceesLayer.EntityFramework
{
    public class WriterRepository: GenericRepository<Writer>, IWriterDal
    {
    }
}
