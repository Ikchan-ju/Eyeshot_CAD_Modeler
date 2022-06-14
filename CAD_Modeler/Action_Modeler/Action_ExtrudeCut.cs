using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler.Action_Modeler
{
    class Action_ExtrudeCut : ActionBase
    {
        public Action_ExtrudeCut(Model model) : base(model)
        {

        }
        public async override void Run()
        {
            await RunAsync();
        }
        public async Task<Region> RunAsync()
        {
            StartAction();

            var en_sketch = await GetEntity();
            var en_region = en_sketch as Region;

            EndAction();
            return en_region;
        }

        public void Stop()
        {
            Canceled = true;
        }
    }
}
