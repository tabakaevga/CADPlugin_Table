using System;
using System.Collections.Generic;
using SldWorks;

namespace CadPlugin
{
    /// <summary>
    /// Базовый построитель столов
    /// </summary>
    public abstract class BaseTableBuilder : IBuilder
    {
        #region Protected Properties

        /// <summary>
        /// Параметры крышки стола
        /// </summary>
        protected Dictionary<string, double> TableTopParameters { get; set; }

        /// <summary>
        /// Текущий документ, в котором происходит построение
        /// </summary>
        protected IModelDoc2 ModelDoc { get; set; }

        #endregion

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        /// <param name="modelDoc">Текущий документ, в котором происходит построение</param>
        /// <param name="tableTopParameters">Параметры крышки стола</param>
        protected BaseTableBuilder(IModelDoc2 modelDoc, Dictionary<string, double> tableTopParameters)
        {
            ModelDoc = modelDoc ?? throw new ArgumentNullException("modelDoc is null");
            TableTopParameters = tableTopParameters ?? throw new ArgumentNullException("tableTopParameters are null"); 
        }

        /// <inheritdoc />
        public abstract void Build();
    }
}
