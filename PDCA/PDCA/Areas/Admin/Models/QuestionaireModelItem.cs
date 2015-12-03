using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCA.Areas.Admin.Models
{
    public class QuestionaireModelItem
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public int? PlanId { get; set; }

        public List<QuestionaireChoiceModelItem> Choices
        {
            get
            {
                return _choices;
            }

            set
            {
                _choices = value;
            }
        }

        private List<QuestionaireChoiceModelItem> _choices = new List<QuestionaireChoiceModelItem>();
    }
}
