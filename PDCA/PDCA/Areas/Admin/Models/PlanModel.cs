using PDCA.Models;
using PDCA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCA.Areas.Admin.Models
{
    public class PlanModel
    {
        // Properties
        public PlanModelItem Item { get; set; }
        public _DatatableResponseModel Items { get; set; }

        //Selector
        Func<plan, PlanModelItem> MediaItemSelector = o => new PlanModelItem()
        {
            PlanId = o.id,
            PlanName = o.name
        };

        public void Search(PlanSearch condition)
        {
            using (var entities = new DB_SWQUALEntities())
            {
                Items = new _DatatableResponseModel();

                var result = from o in entities.plan
                             select o;

                Items.data = result.ToList().Skip(condition.start).Take(condition.length).Select(MediaItemSelector).Cast<object>().ToList();

                Items.draw = condition.draw;
                Items.recordsFiltered = result.Count();
                Items.recordsTotal = result.Count();
            }
        }
    }
}
