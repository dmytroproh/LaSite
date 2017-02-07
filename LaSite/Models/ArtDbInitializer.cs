using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LaSite.Models
{
    public class ArtDbInitializer : DropCreateDatabaseAlways<WorkOfArtContext>
    {
        protected override void Seed(WorkOfArtContext db)
        {
            db.WorkOfArts.Add(new WorkOfArt { Description = "Война миров", CreationDate = new DateTime(2008, 11, 01), Picture = "Пока нет" });
            db.WorkOfArts.Add(new WorkOfArt { Description = "Апкелаба", CreationDate = new DateTime(2008, 11, 01), Picture = "Пока нет" });

            base.Seed(db);
        }
    }
}