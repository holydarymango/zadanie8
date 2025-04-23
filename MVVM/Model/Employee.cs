using Proect_8.MVVM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect_8.MVVM.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int PositionID { get; set; }
        public virtual Position Position { get; set; }

        [NotMapped]

        public Position EmloyeePosition
        {
            get
            {
                return DataWorker.GetPositionByID(PositionID);
            }
        }
    }
}
