using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SldWorks;

namespace CadPlugin
{
    /// <summary>
    /// UI Плагина
    /// </summary>
    [ProgId(PluginIntegration.SwPluginProgId)]
    public partial class TaskpaneHostUi : UserControl
    {
        #region Private Fields

        /// <summary>
        /// Текущая сессия SolidWorks
        /// </summary>
        private readonly SldWorks.SldWorks _thiSldWorksSession =
            (SldWorks.SldWorks)Marshal.GetActiveObject("SldWorks.Application");

        /// <summary>
        /// Параметры ножек
        /// </summary>
        private Dictionary<string, double> _legParameters;

        /// <summary>
        /// Параметры крышки стола
        /// </summary>
        private Dictionary<string, double> _tableTopParameters;

        #endregion

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TaskpaneHostUi()
        {
            InitializeComponent();
        }

        #region Private Methods

        /// <summary>
        /// Получить параметры стола
        /// </summary>
        private void GetParameters()
        {
            _tableTopParameters = new Dictionary<string, double>
            {
                {"Length", Convert.ToDouble(TableTopLengthNumeric.Value)*0.001},
                {"Width", Convert.ToDouble(TableTopWidthNumeric.Value)*0.001},
                {"Height", Convert.ToDouble(TableTopHeightNumeric.Value)*0.001}
            };
            _legParameters = new Dictionary<string, double>
            {
                {"Height", Convert.ToDouble(LegHeightNumeric.Value)*0.001},
                {"Radius", Convert.ToDouble(LegRadiusNumeric.Value)*0.001},
                {"Edge Offset", Convert.ToDouble(LegEdgeOffsetNumeric.Value)*0.001}
            };
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Клик по кнопке Build
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, System.EventArgs e)
        {

            IModelDoc2 modelDoc =
                (IModelDoc2)_thiSldWorksSession.NewDocument("C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2016\\templates\\gost-part.prtdot", 0, 0, 0);

            GetParameters();
            
            IBuilder builder = new TableBuilderManager(
                new TableTopBuilder(modelDoc, _tableTopParameters),
                new TableLegsBuilder(modelDoc, _tableTopParameters, _legParameters));
            builder.Build();
        }

        #endregion

    }
}
