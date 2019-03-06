using System.Data.Entity;

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
