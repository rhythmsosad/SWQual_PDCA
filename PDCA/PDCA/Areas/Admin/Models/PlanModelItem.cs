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
    public class PlanModelItem : plan
    {
        // Properties
        public int? PlanId { get; set; }

        // Display
        public string PlanName { get; set; }

        // Methods
        public ModelResult Update()
        {
            using (var entities = new DB_SWQUALEntities())
            {
                int actorId = SessionUtil.GetUserId();

                using (var transaction = entities.Database.BeginTransaction())
                {
                    if (PlanId.HasValue) // Update
                    {
                        try
                        {
                            plan item = entities.plan.Find(PlanId.Value);
                            item.name = name;
                            item.objective = objective;
                            item.problem = problem;
                            item.steps = steps;
                            item.update_date = DateTime.Now;

                            entities.SaveChanges();

                            transaction.Commit();
                            return new ModelResult() { Success = true };
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();

                            return new ModelResult() { DisplayMessage = true, Message = Core.CoreFunction.InnermostException(ex), Success = false };
                        }
                    }
                    else // Insert
                    {
                        try
                        {
                            entities.plan.Add(new plan() {
                                create_date = DateTime.Now,
                                name = name,
                                objective = objective,
                                owner_id = actorId,
                                problem = problem,
                                steps = steps,
                                update_date = update_date
                            });

                            entities.SaveChanges();

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
