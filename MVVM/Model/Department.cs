using Proect_8.MVVM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect_8.MVVM.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public List<Position> Positions { get; set; }

        [NotMapped]
        public List<Position> DepartmentPositions
        {
            get
            {
                return DataWorker.GetAllPositionsByDepartmentID(ID);
            }
        }
    }
}
