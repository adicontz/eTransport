using eTransport.Data.Base;
using eTransport.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTransport.Data.Services
{
    public class SoferiServices : EntityBaseRepository<Sofer>, ISoferiServices
    {

        public SoferiServices(AppDbContext context) : base(context) { }
            }
}

