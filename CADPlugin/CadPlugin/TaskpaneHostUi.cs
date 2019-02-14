using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CadPlugin.Builders;
using CadPlugin.Parameters;
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
        /// Параметры крышки стола
        /// </summary>
        private readonly TableParameters _tableParameters = new TableParameters();

        /// <summary>
        /// Миллиметровая доля
        /// </summary>
        private const double MillRange = 1e3;

        #endregion

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TaskpaneHostUi()
        {
            InitializeComponent();
            SetTextsToDefault();
        }



        #region Private Methods

        /// <summary>
        /// Установить значения текстовых полей в стандартные
        /// </summary>
        private void SetTextsToDefault()
        {
            TextToDefault("Strut Height", StrutHeightText);
            TextToDefault("Strut Thickness", StrutThicknessText);
        }

        /// <summary>
        /// Установить значение конкретного контрола к дефолтному значению
        /// </summary>
        /// <param name="key">Ключ параметра</param>
        /// <param name="control">Контрол</param>
        private void TextToDefault(string key, Control control)
        {
            var minValue = Convert.ToInt32(_tableParameters.ParametersMin[key] * MillRange);
            control.Text = minValue.ToString();
        }

        /// <summary>
        /// Получить параметры стола
        /// </summary>
        private void GetParameters()
        {
            _tableParameters.Parameters = new Dictionary<string, double>
            {
                {"Top Length", GetParameter(TableTopLengthNumeric.Value)},
                {"Top Width", GetParameter(TableTopWidthNumeric.Value)},
                {"Top Height", GetParameter(TableTopHeightNumeric.Value)},
                {"Legs Height", GetParameter(LegHeightNumeric.Value)},
                {"Legs Radius", GetParameter(LegRadiusNumeric.Value)},
                {"Edge Offset", GetParameter(LegEdgeOffsetNumeric.Value)},
                {"Strut Height", GetParameter(StrutHeightText.Text)},
                {"Strut Thickness", GetParameter(StrutThicknessText.Text)},
            };
        }

        /// <summary>
        /// Конвертация параметра 
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private static double GetParameter(object field)
        {
            return Convert.ToDouble(field) / MillRange;
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
                (IModelDoc2)_thiSldWorksSession.NewDocument(
                    $"C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2016\\templates\\gost-part.prtdot",
                    0, 0, 0);

            GetParameters();

            if (!StrutsCheckBox.Checked)
            {
                _tableParameters.Parameters.Remove("Strut Height");
                _tableParameters.Parameters.Remove("Strut Thickness");
            }

            TableBuilderManager builder = new TableBuilderManager(modelDoc, _tableParameters);
            builder.Build();
            
            
        }

        /// <summary>
        /// Обработка нажатия на чекбокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrutsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StrutsPanel.Visible = StrutsCheckBox.Checked;
            SetTextsToDefault();
        }

        /// <summary>
        /// Обработка валидации текстовых полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrutsTexts_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = (TextBox)sender;
            try
            {
                GetParameters();
            }
            catch (ArgumentException exception)
            {

                ErrorProvider.SetError(control, exception.Message);
                e.Cancel = true;
            }
            catch (FormatException)
            {
                ErrorProvider.SetError(control, "Type some integer value in");
                e.Cancel = true;
            }

        }

        /// <summary>
        /// Обработка завершения валидации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrutsTexts_Validated(object sender, EventArgs e)
        {
            ErrorProvider.SetError((TextBox)sender, "");
        }

        #endregion


    }
}
