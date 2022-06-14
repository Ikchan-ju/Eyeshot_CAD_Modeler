using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using Color = System.Drawing.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler.Action_Sketch
{
    class Action_Sketch_SketchOut : ActionBase
    {
        Sketch sketch = null;
        public Region region = null;

        public Action_Sketch_SketchOut(Model model, Sketch sketch) : base(model)
        {
            this.sketch = sketch;
        }

        public async override void Run()
        {
            await RunAsync();
        }

        public async Task<bool> RunAsync()
        {
            StartAction();

            int count = -1;
            foreach(List<ICurve> curveList in sketch.contourList)
            {
                count++;
                // curvelist가 닫혀있는지 확인. 안닫혔으면 임의로 닫아줌
                CompositeCurve cc = new CompositeCurve(curveList);
                if (!cc.IsClosed)
                {
                    foreach (Entity ent in curveList)
                    {
                        ent.EntityData = sketch;
                    }
                    // model 갱신
                    model1.Entities.Regen();
                    model1.Invalidate();

                    continue;
                }

                //sketch 에서 compositecurve 가져와 region 만들기. curvelist 넣으니까 안됨.
                region = new Region(cc);

                // region의 entitiydata로 sketch 객체 넣기
                region.EntityData = sketch;

                // 스케치의 curvelist를 model.entitites에서 제거하기
                foreach (Entity ent in curveList)
                {
                    if (model1.Entities.Contains(ent))
                        model1.Entities.Remove(ent);
                }

                // region 속성 설정
                region.Color = Color.Transparent;
                region.LineWeight = 3;
                region.ColorMethod = colorMethodType.byEntity;

                // Entities에 region 추가하기
                model1.Entities.Add(region);

            }

            foreach(Point pt in sketch.pointList)
            {
                model1.Entities.Remove(pt);
            }

            // model 갱신
            model1.Entities.Regen();
            model1.Invalidate();

            EndAction();
            return true;
        }

    }
}
