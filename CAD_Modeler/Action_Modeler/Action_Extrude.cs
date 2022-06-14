using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler.Action_Modeler
{
    class Action_Extrude : ActionBase
    {
        public Action_Extrude(Model model) : base(model)
        {

        }
        public async override void Run()
        {
            await RunAsync();
        }
        public async Task<Entity> RunAsync()
        {
            StartAction();

            var en_sketch = await GetEntity();

            EndAction();
            return en_sketch;
        }

        public void Stop()
        {
            Canceled = true;
        }
    }
}
