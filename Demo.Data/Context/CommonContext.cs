using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Context
{
    public class CommonContext : DbContext
    {
        public CommonContext()
            : base("name=DemoEntities")
        {

        }
    }
}
