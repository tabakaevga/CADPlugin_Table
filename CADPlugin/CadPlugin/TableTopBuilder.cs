using System.Collections.Generic;
using SldWorks;

namespace CadPlugin
{
    /// <summary>
    /// Класс построения крышки стола
    /// </summary>
    public class TableTopBuilder : BaseTableBuilder
    {
        /// <inheritdoc />
        public TableTopBuilder(IModelDoc2 modelDoc, Dictionary<string, double> tableTopParameters) 
            : base(modelDoc, tableTopParameters)
        {
        }

        /// <inheritdoc />
        public override void Build()
        {
            BuildTop();
        }

        /// <summary>
        /// Метод, выполняющий непосредственное построение крышки стола
        /// </summary>
        private void BuildTop()
        {
            ModelDoc.Extension.SelectByID2("Сверху", "PLANE", 0, 0, 0, true, 0, null, 0);
            ModelDoc.SketchManager.InsertSketch(true);
            ModelDoc.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            var xAbs = TableTopParameters["Length"] / 2;
            var yAbs = TableTopParameters["Width"] / 2;
            ModelDoc.SketchManager.CreateCornerRectangle(-xAbs, yAbs, 0, xAbs, -yAbs, 0);

            ModelDoc.ClearSelection2(true);
            ModelDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            ModelDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            ModelDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            ModelDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            FeatureManager swFeatureMgr = ModelDoc.FeatureManager;

            swFeatureMgr.FeatureExtrusion2(true, false, false, 0, 0, TableTopParameters["Height"], 0,
                false, false, false, false, 0.01745329251994, 0.01745329251994, false, false, false,
                false, true, true, true, 0, 0, false);
        }
        
    }
}
