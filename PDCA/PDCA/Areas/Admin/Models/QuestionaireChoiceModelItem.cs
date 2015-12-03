using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDCA.Areas.Admin.Models
{
    public class QuestionaireChoiceModelItem
    {
        public long Id { get; set; }
        public int Questionaire { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public string Rescription { get; set; }
    }
}
