using System.Collections.Generic;
using SldWorks;

namespace CadPlugin.Builders
{
    /// <summary>
    /// Класс построения ножек стола
    /// </summary>
    public class TableLegsBuilder : BaseTableBuilder
    {
        #region Constructors

        /// <inheritdoc />
        public TableLegsBuilder(IModelDoc2 modelDoc,
            Dictionary<string, double> parameters): 
            base(modelDoc, parameters)
        {
        }

        #endregion
        
        #region Public Methods

        /// <inheritdoc />
        public override void Build()
        {
            BuildLegs();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Метод, выполняющий построение ножек стола
        /// </summary>
        private void BuildLegs()
        {
            ModelDoc.Extension.SelectByID2("", "FACE", 0, 0,
                0, false, 0, null, 0);
            ModelDoc.SketchManager.InsertSketch(true);

            ModelDoc.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            var xCenterLeft = -Parameters["Top Length"] / 2 
                              + Parameters["Edge Offset"] + Parameters["Legs Radius"];
            var yCenterLeft = -Parameters["Top Width"] / 2 
                              + Parameters["Edge Offset"] + Parameters["Legs Radius"];
            var yCenterRight = -yCenterLeft;
            var xCenterRight = -xCenterLeft;

            SketchCircles(xCenterLeft, yCenterLeft);

            SketchCircles(xCenterLeft, yCenterRight);

            SketchCircles(xCenterRight, yCenterLeft);

            SketchCircles(xCenterRight, yCenterRight);

            ModelDoc.ClearSelection2(true);
            ModelDoc.Extension.SelectByID2("Arc4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);

            ModelDoc.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 
                Parameters["Legs Height"], 0, false, false, false, false, 0, 0, 
                false, false, false, false, true, true, true, 0, 0, false);
            ModelDoc.SelectionManager.EnableContourSelection = false;
        }

        /// <summary>
        /// Метод, выполняющий построение окружностей на эскизе
        /// </summary>
        /// <param name="xCenter">Центр окружности по оси Х</param>
        /// <param name="yCenter">Центр окружности по оси У</param>
        private void SketchCircles(double xCenter, double yCenter)
        {
            ModelDoc.ClearSelection2(true);
            ModelDoc.SketchManager.CreateCircleByRadius(xCenter, yCenter, 0, 
                Parameters["Legs Radius"]);
        }

        #endregion

        
    }
}
