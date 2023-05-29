using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Tablo { get; }
    }
}
