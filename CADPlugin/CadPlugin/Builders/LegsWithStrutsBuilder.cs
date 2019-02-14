using System.Collections.Generic;
using SldWorks;

namespace CadPlugin.Builders
{
    /// <summary>
    /// Построитель ножек стола с усилениями
    /// </summary>
    public class LegsWithStrutsBuilder : BaseTableBuilder
    {
        /// <inheritdoc />
        public LegsWithStrutsBuilder(IModelDoc2 modelDoc, Dictionary<string, double> parameters) 
            : base(modelDoc, parameters)
        {
        }

        /// <inheritdoc />
        public override void Build()
        {
            var struttedLegsParameters = new Dictionary<string, double>
            {
                {"Top Length", Parameters["Top Length"]},
                {"Top Width", Parameters["Top Width"]},
                {"Legs Height", Parameters["Strut Height"]},
                {"Legs Radius", Parameters["Legs Radius"]},
                {"Edge Offset", Parameters["Edge Offset"] }
            };
            var legsBuilder = new TableLegsBuilder(ModelDoc, struttedLegsParameters);
            legsBuilder.Build();

            var x = Parameters["Top Length"] / 2 - Parameters["Legs Radius"] - 
                    Parameters["Edge Offset"];
            var strutsHeight = Parameters["Strut Height"];
            var z = Parameters["Top Width"] / 2 - Parameters["Legs Radius"] -
                    Parameters["Edge Offset"];
            SelectForSketch(x, strutsHeight, z);

            ModelDoc.SketchManager.InsertSketch(true);
            ModelDoc.ClearSelection2(true);
            ModelDoc.SketchManager.CreateCornerRectangle(x, z, 0, -x, -z, 0);
            ModelDoc.ClearSelection2(true);
            RectangleLineSelection();

            ModelDoc.FeatureManager.InsertRib(true, false, Parameters["Strut Thickness"], 0, false,
                false, true, 0, true, false);

            SelectLegSurface(x, -strutsHeight, z);
            ModelDoc.SketchManager.InsertSketch(true);
            ModelDoc.ClearSelection2(true);

            SketchCircles(-x, -z);
            SketchCircles(x, -z);
            SketchCircles(-x, z);
            SketchCircles(x, z);
            ModelDoc.ClearSelection2(true);
            ModelDoc.Extension.SelectByID2("Arc4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);

            var remainingLegs = Parameters["Legs Height"] - strutsHeight;
            ModelDoc.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0,
                remainingLegs, 0, false, false, false, false, 0, 0,
                false, false, false, false, true, true, true, 0, 0, false);
            ModelDoc.SelectionManager.EnableContourSelection = false;

        }

        /// <summary>
        /// Выбор линий для прямоугольника
        /// </summary>
        private void RectangleLineSelection()
        {
            ModelDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            ModelDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            ModelDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            ModelDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
        }


        /// <summary>
        /// Выбор поверхностей для эскиза
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="height">Высота поверхности</param>
        /// <param name="z">Координата Z</param>
        private void SelectForSketch(double x, double height, double z)
        {
            SelectLegSurface(-x, -height, -z);
            SelectLegSurface(-x, -height, z);
            SelectLegSurface(x, -height, z);
            SelectLegSurface(x, -height, -z);
        }

        /// <summary>
        /// Выбор поверхности ножки стола
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="height">Высота, на которой находится поверхность</param>
        /// <param name="z">Координата Z</param>
        private void SelectLegSurface(double x, double height, double z)
        {
            ModelDoc.Extension.SelectByID2("", "FACE", x, height, z,
                false, 0, null, 0);
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
    }
}
