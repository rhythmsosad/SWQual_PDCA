using PDCA.Core;
using PDCA.Models;
using PDCA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCA.Areas.Admin.Models
{
    public class __SampleModel
    {
        // Properties
        public int? SampleId { get; set; }

        // Methods
        public ModelResult Update()
        {
            using (var entities = new DB_SWQUALEntities())
            {
                int actorId = SessionUtil.GetUserId();

                using (var transaction = entities.Database.BeginTransaction())
                {
                    if (SampleId.HasValue) // Update
                    {
                        try
                        {

                            transaction.Commit();
                            return new ModelResult() { Success = true };
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();

                            return new ModelResult() { DisplayMessage = true, Message = Core.CoreFunction.InnermostException(ex), Success = false };
                        }
                    }
                    else // Insert
                    {
                        try
                        {

                            transaction.Commit();
                            return new ModelResult() { Success = true };
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();

                            return new ModelResult() { DisplayMessage = true, Message = Core.CoreFunction.InnermostException(ex), Success = false };
                        }
                    }
                }
            }
        }
    }
}
