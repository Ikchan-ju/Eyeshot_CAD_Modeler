using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler.Constraints
{
    public class ConstraintManager
    {
        public List<ConstraintItem> items { get; set; }

        public ConstraintManager()
        {
            items = new List<ConstraintItem>();

        }

        // 모든 제약조건을 일괄적으로 실행
        public void Run()
        {
            foreach (var item in items)
            {
                item.Run();
            }
        }
    }
}
