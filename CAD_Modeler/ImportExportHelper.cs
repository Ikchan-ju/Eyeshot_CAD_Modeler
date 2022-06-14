using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler
{
    /// <summary>
    /// Helper class for import and export operations.
    /// </summary>
    public class ImportExportHelper
    {
        /// <summary>
        /// Returns a ReadFileAsync object based on the filename extension.
        /// </summary>
        public static ReadFileAsync GetImportReader(string fileName)
        {
            string ext = System.IO.Path.GetExtension(fileName);

            if (ext != null)
            {
                ext = ext.TrimStart('.').ToLower();

                switch (ext)
                {
                    case "asc":
                        return new ReadASC(fileName);
                    case "jt":
                        return new ReadJT(fileName);
                    case "stl":
                        return new ReadSTL(fileName);
                    case "obj":
                        return new ReadOBJ(fileName);
                    case "las":
                        return new ReadLAS(fileName, ReadLAS.formatType.Colors);
                    case "3ds":
                        return new Read3DS(fileName);
                    case "nc":
                    case "ncc":
                    case "cnc":
                    case "tap":
                        return new ReadGCode(fileName);
                    case "pdf":
                        return new ReadPDF(fileName);
                    case "igs":
                    case "iges":
                        return new ReadIGES(fileName);
                    case "stp":
                    case "step":
                        return new ReadSTEP(fileName);
                    case "ifc":
                    case "ifczip":
                        return new ReadIFC(fileName);
                    case "mesh":
                        return new ReadMedit(fileName);
                    case "bdf":
                        return new ReadNastran(fileName);
                    case "dat":
                        return new ReadLusas(fileName);
                }
            }
            return null;
        }

        /// <summary>
        /// Returns WriteFileAsync object based on the file name extension.
        /// </summary>
        public static WriteFileAsync GetExportWriter(string fileName, devDept.Eyeshot.Model env)
        {
            WriteParams dataParams;
            string ext = System.IO.Path.GetExtension(fileName);

            if (ext != null)
            {
                ext = ext.TrimStart('.').ToLower();

                switch (ext)
                {
                    case "obj":
                        dataParams = new WriteParamsWithMaterials(env);
                        return new WriteOBJ((WriteParamsWithMaterials)dataParams, fileName);
                    case "stl":
                        dataParams = new WriteParams(env);
                        return new WriteSTL(dataParams, fileName);
                    case "las":
                        dataParams = null;
                        return new WriteLAS(env.Entities.Where(x => x is devDept.Eyeshot.Entities.FastPointCloud).FirstOrDefault() as devDept.Eyeshot.Entities.FastPointCloud, fileName);
                    case "html":
                        dataParams = new WriteParamsWithMaterials(env);
                        return new WriteWebGL((WriteParamsWithMaterials)dataParams, env.DefaultMaterial, fileName);
                    case "step":
                        dataParams = new WriteParamsWithUnits(env);
                        return new WriteSTEP((WriteParamsWithUnits)dataParams, fileName);
                    case "iges":
                        dataParams = new WriteParamsWithUnits(env);
                        return new WriteIGES((WriteParamsWithUnits)dataParams, fileName);
                }
            }
            return null;
        }

        /// <summary>
        /// Returns a chained filter string with extensions and descriptions for the import function
        /// </summary>
        /// <param name="pointCloud">When true, point cloud file formats are enabled.</param>
        /// <param name="surfaceBrep">When true, surface and BRep file format are enabled.</param>
        /// <param name="autodesk">When true, Autodesk file formats are enabled.</param>
        /// <param name="mesh">When true, triangle mesh file formats are enabled.</param>
        /// <param name="cnc">When true, CNC file formats are enabled.</param>
        /// <param name="ifc">When true, IFC file formats are enabled.</param>
        /// <param name="fem">When true, Finite Element Analysis file formats are enabled.</param>
        /// <param name="pdf">When true, PDF file formats are enabled.</param>
        public static string GetImportFilter(bool pointCloud, bool surfaceBrep, bool autodesk, bool mesh, bool cnc, bool ifc, bool fem, bool pdf)
        {
            string extensions = "All compatible file types (*.*)|";
            string descriptions = "";

            if (pointCloud)
            {
                extensions += "*.asc;*.las;";
                descriptions += "|Points (*.asc)|*.asc|Laser LAS (*.las)|*.las";
            }
            if (surfaceBrep)
            {
                extensions += "*.stp; *.step; *.igs; *.iges;";
                descriptions += "|Standard for the Exchange of Product Data (*.stp; *.step)|*.stp; *.step|Initial Graphics Exchange Specification (*.igs; *.iges)|*.igs; *.iges";
            }
            if (autodesk)
            {
                extensions += "*.dxf; *.dwg; *.dwf; *.dwfx;";
                descriptions += "|Drawing Exchange Format (*.dxf)|*.dxf|CAD drawings (*.dwg)|*.dwg|Design Web Format (*.dwf; *.dwfx)|*.dwf; *.dwfx";
            }

            if (mesh)
            {
                extensions += "*.obj; *.stl; *.3ds; *.jt;";
                descriptions += "|WaveFront OBJ (*.obj)|*.obj|Stereolithography (*.stl)|*.stl|3D Studio Max (*.3ds)|*.3ds|JT (*.jt)|*.jt";
            }

            if (cnc)
            {
                extensions += "*.nc; *.ncc; *.cnc; *.tap;";
                descriptions += "|CNC (*.nc; *.ncc; *.cnc; *.tap)|*.nc; *.ncc; *.cnc; *.tap";
            }
            if (ifc)
            {
                extensions += "*.ifc;*.ifczip;";
                descriptions += "|IFC (*.ifc; *.ifczip)|*.ifc; *.ifczip";
            }

            if (fem)
            {
                extensions += "*.mesh;*.dat;";
                descriptions += "|Medit (*.mesh)|*.mesh|Lusas (*.dat)|*.dat";
            }

            if (pdf)
            {
                extensions += "*.pdf;";
                descriptions += "|PDF (*.pdf)|*.pdf;";
            }

            if (string.IsNullOrEmpty(descriptions))

                throw new Exception("Please specify at least one filter.");

            return extensions + descriptions;
        }

        /// <summary>
        /// Returns chained filter string with extensions and descriptions for the export function.
        /// </summary>
        /// <param name="pointCloud">When true, point cloud file formats are enabled.</param>
        /// <param name="surfaceBrep">When true, surface and BRep file format are enabled.</param>
        /// <param name="autodesk">When true, Autodesk file formats are enabled.</param>
        /// <param name="mesh">When true, triangle mesh file formats are enabled.</param>
        public static string GetExportFilter(bool pointCloud, bool surfaceBrep, bool autodesk, bool mesh)
        {
            string descriptions = "";

            if (pointCloud)
            {
                descriptions += "|Laser LAS (*.las)|*.las";
            }

            if (surfaceBrep)
            {
                descriptions += "|Standard for the Exchange of Product Data (*.step)|*.step|Initial Graphics Exchange Specification (*.iges)|*.iges";
            }

            if (autodesk)
            {
                descriptions += "|Drawing Exchange Format (*.dxf)|*.dxf|CAD drawings (*.dwg)|*.dwg|3D PDF (*.pdf)|*.pdf";
            }

            if (mesh)
            {
                descriptions += "|WaveFront OBJ (*.obj)|*.obj|Stereolithography (*.stl)|*.stl|WebGL (*.html)|*.html";
            }

            if (string.IsNullOrEmpty(descriptions))

                throw new Exception("Please specify at least one filter.");

            return descriptions.TrimStart('|');
        }

        public static BlockReference InsertAsBlock(Model model, ReadFileAsyncWithBlocks rfb, RegenOptions ro = null)
        {
            Hashtable renamedBlocks = new Hashtable();
            string fileName = System.IO.Path.GetFileNameWithoutExtension(rfb.FileName);
            BlockReference rootBlockRef = null;

            // Looking for duplicated block names

            foreach (Block block in rfb.Blocks)
            {
                string blockName = block.Name;
                if (model.Blocks.Contains(blockName))
                {
                    string newBlockName = UtilityEx.GetUnusedBlockName(block.Name, model.Blocks, true);

                    if (rfb.Blocks.RootBlockName != null && rfb.Blocks.RootBlockName.Equals(blockName))
                    {
                        // File contains a root block with a name already presents in the scene.
                        newBlockName = UtilityEx.GetUnusedBlockName(fileName, model.Blocks, true);
                        rootBlockRef = new BlockReference(newBlockName);
                    }

                    renamedBlocks.Add(blockName, newBlockName);
                    block.Name = newBlockName;
                }
            }

            if (renamedBlocks.Count > 0)
            {
                // Fixes BlockReference's block name

                foreach (Block block in rfb.Blocks)
                {
                    foreach (Entity entity in block.Entities)
                    {
                        if (entity is BlockReference)
                        {
                            BlockReference br = (BlockReference)entity;

                            if (renamedBlocks.Contains(br.BlockName))
                            {
                                br.BlockName = (string)renamedBlocks[br.BlockName];
                            }
                        }
                    }
                }
            }

            // Merges master collection read with the ones of the model.
            rfb.FillAllCollectionsData(model);

            if (rootBlockRef == null)
            {
                if (!string.IsNullOrEmpty(rfb.Blocks.RootBlockName))
                {
                    // File contains a root block with a name not presents in the scene, so I just add a BlockReference related to it.

                    rootBlockRef = new BlockReference(rfb.Blocks.RootBlockName);

                }
                else
                {
                    // File does not contain a root block, so I create a new one with the entities stored in the ReadFile.Entities property.
                    var blockName = UtilityEx.GetUnusedBlockName(fileName, model.Blocks, true);

                    Block block = new Block(blockName);
                    block.Entities.AddRange(rfb.Entities);
                    model.Blocks.Add(block);
                    rootBlockRef = new BlockReference(block.Name);

                }
            }

            // Adds the BlockReference related to the RootBlock of the file to insert.

            model.Entities.Add(rootBlockRef, ro);
            return rootBlockRef;

        }
    }
}
