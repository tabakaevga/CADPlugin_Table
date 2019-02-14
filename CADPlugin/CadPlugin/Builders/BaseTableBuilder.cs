using System;
using System.Collections.Generic;
using SldWorks;

namespace CadPlugin.Builders
{
    /// <summary>
    /// Базовый построитель столов
    /// </summary>
    public abstract class BaseTableBuilder : IBuildable
    {
        /// <summary>
        /// Параметры крышки стола
        /// </summary>
        public Dictionary<string, double> Parameters { get; protected set; }


        /// <summary>
        /// Текущий документ, в котором происходит построение
        /// </summary>
        protected IModelDoc2 ModelDoc { get; set; }

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        /// <param name="modelDoc">Текущий документ, в котором происходит построение</param>
        /// <param name="parameters">Параметры</param>
        protected BaseTableBuilder(IModelDoc2 modelDoc, Dictionary<string, double> parameters)
        {
            ModelDoc = modelDoc 
                       ?? throw new ArgumentNullException("modelDoc is null");
            Parameters = parameters 
                                 ?? throw new ArgumentNullException("parameters are null");
            if (Parameters.Count == 0)
            {
                throw new ArgumentException("parameters are empty");
            }
        }

        /// <inheritdoc />
        public abstract void Build();

        
    }
}
