using devDept.Eyeshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler.Constraints
{
    class Action_AddConstraintItem : ActionBase
    {
        private ConstraintManager ctManager;
        ConstraintItem.Type ctItemType;
        public Action_AddConstraintItem(Model model, ConstraintManager ctManager, ConstraintItem.Type ctItemType) : base(model)
        {
            this.ctManager = ctManager;
            this.ctItemType = ctItemType;
        }

        public async override void Run()
        {
            await RunAsync();
        }

        public async Task<bool> RunAsync()
        {
            StartAction();

            // targetEntity 선택
            var targetEntity = await GetEntity("target");
            // CTItem 추가
            ConstraintItem item = new ConstraintItem();
            item.targetEntity = targetEntity;

            switch (ctItemType)
            {
                // 지정된 선이 평면내 좌표계에서 수직하게 함
                case ConstraintItem.Type.Vertical_Line:
                // 지정된 선이 평면내 좌표계에서 수평하게 함
                case ConstraintItem.Type.Horizontal_Line:
                    {
                        // sourcePlane 선택
                        var sourcePlane = activatedPlane;
                        item.sourcePlane = sourcePlane;
                    }
                    break;

                default:
                    {
                        // sourceEntity 선택
                        var sourceEntity = await GetEntity("source");
                        item.sourceEntity = sourceEntity;
                    }
                    break;
            }
            item.type = ctItemType;
            ctManager.items.Add(item);

            // Run
            ctManager.Run();

            // regen
            model1.Entities.RegenAllCurved();
            model1.Invalidate();

            EndAction();
            return true;
        }

    }
}
