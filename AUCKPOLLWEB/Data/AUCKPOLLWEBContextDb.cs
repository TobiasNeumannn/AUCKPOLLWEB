using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AUCKPOLLWEB.Models;

    public class AUCKPOLLWEBContextDb : DbContext
    {
        public AUCKPOLLWEBContextDb (DbContextOptions<AUCKPOLLWEBContextDb> options)
            : base(options)
        {
        }

        public DbSet<AUCKPOLLWEB.Models.regions> regions { get; set; } = default!;

        public DbSet<AUCKPOLLWEB.Models.airQuality> airQuality { get; set; } = default!;

        public DbSet<AUCKPOLLWEB.Models.estuaryQuality> estuaryQuality { get; set; } = default!;

        public DbSet<AUCKPOLLWEB.Models.gWaterQuality> gWaterQuality { get; set; } = default!;
    }
