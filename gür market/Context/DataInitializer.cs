using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gür_market.Context
{
    class DataInitializer:DropCreateDatabaseIfModelChanges<GurMarContext>
    {
        protected override void Seed(GurMarContext context)
        {
            base.Seed(context);
        }

    }
}
