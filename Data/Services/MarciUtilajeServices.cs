using eTransport.Data.Base;
using eTransport.Models;

namespace eTransport.Data.Services
{
    public class MarciUtilajeServices:EntityBaseRepository<MarcaUtilaj>, IMarciUtilajeServices
    {
        public MarciUtilajeServices(AppDbContext context) : base(context) { }
            
        }
    }
