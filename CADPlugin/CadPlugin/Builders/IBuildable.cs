using System.Collections.Generic;

namespace CadPlugin.Builders
{
    /// <summary>
    /// Сущность, описывающая построители стола
    /// </summary>
    public interface IBuildable
    {
        /// <summary>
        /// Метод, выполняющий построение стола
        /// </summary>
        void Build();

        /// <summary>
        /// Параметры
        /// </summary>
        Dictionary<string, double> Parameters { get; }
    }
}
