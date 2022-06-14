using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler
{
    public class DataTree
    {
        public List<Custom_Plane> basicPlaneList;
        public List<Custom_Plane> planeList;
        public List<Sketch> sketchList;
        public List<Entity> entityList;
        public List<Region> regionList;

        public Custom_Plane selectedPlane;
        public Sketch selectedSketch;
        public Entity selectedEntity;

        public DataTree()
        {
            this.basicPlaneList = new List<Custom_Plane>();
            this.planeList = new List<Custom_Plane>();
            this.sketchList = new List<Sketch>();
            this.entityList = new List<Entity>();
            this.regionList = new List<Region>();
        }
    }
}
