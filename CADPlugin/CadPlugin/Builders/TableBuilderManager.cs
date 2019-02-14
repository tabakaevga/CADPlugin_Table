using System.Collections.Generic;
using System.Linq;
using CadPlugin.Parameters;
using SldWorks;

namespace CadPlugin.Builders
{
    /// <summary>
    /// Класс-менеджер построения
    /// </summary>
    public class TableBuilderManager
    {
        /// <summary>
        /// Построители ножек
        /// </summary>
        private readonly IBuildable _legBuilder;

        /// <summary>
        /// Построители Крышки стола
        /// </summary>
        private readonly IBuildable _tableTopBuilder;


        /// <summary>
        /// Конструктор класса TableBuilderManager
        /// </summary>
        /// <param name="modelDoc">Документ детали</param>
        /// <param name="parameters">Параметры стола</param>
        public TableBuilderManager(IModelDoc2 modelDoc, TableParameters parameters)
        {
            Dictionary<string, double> topParameters = parameters.Parameters
                .Select(t => new {t.Key, t.Value})
                .Where(t => t.Key.Contains("Top")).ToDictionary(t => t.Key, t => t.Value);
            
            _tableTopBuilder = new TableTopBuilder(modelDoc, topParameters);

            Dictionary<string, double> legParameters = parameters.Parameters
                .Select(t => new { t.Key, t.Value })
                .Where(t => !t.Key.Contains("Top Height"))
                .ToDictionary(t => t.Key, t => t.Value);

            if (legParameters.ContainsKey("Strut Height") || legParameters.ContainsKey("Strut Thickness"))
            {
                _legBuilder = new LegsWithStrutsBuilder(modelDoc, legParameters);
            }
            else
            {
                _legBuilder = new TableLegsBuilder(modelDoc, legParameters);
            }

        }

        /// <summary>
        /// Построить модель
        /// </summary>
        public void Build()
        {
            _tableTopBuilder.Build();

            _legBuilder.Build();
        }
    }
}