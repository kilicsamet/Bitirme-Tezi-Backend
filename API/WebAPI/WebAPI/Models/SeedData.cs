using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DatabaseContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DatabaseContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            DateTime DateNow = DateTime.Now;

            if (!context.urunlers.Any())
            {
                context.urunlers.AddRange(
                    new Urunler
                    {
                        UrunlerName ="Solar Panel",
                        MusteriIsim = "Abdulsamet",
                        MusteriSoyisim = "Kilic",
                        MusteriAdres = "Sehitler Mah.",
                        PanelMetrekare = "10 metrekare",
                        Fiyat = "32.000 TL",
                    }
                );
                context.SaveChanges();
            }

            if (!context.araclars.Any())
            {
                context.araclars.AddRange(
                    new Araclar
                    {
                        AraclarName = "2021 Model S",
                        AraclarModel = "Model S",
                        AraclarYil = "2021",
                        AraclarSeri = "Tesla",
                        AraclarRenk = "Gümüş",
                        AraclarDurum = "İkinci El",
                        AraclarHiz = "125 mph",
                        AraclarYakit = "Elektrik",
                        AraclarFiyat = "200.000 TL",
                        AraclarURL = "WIP.PNG",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
