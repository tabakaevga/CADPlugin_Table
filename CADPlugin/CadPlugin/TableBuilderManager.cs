using System;

namespace CadPlugin
{
    /// <summary>
    /// Класс-менеджер построения
    /// </summary>
    public class TableBuilderManager : IBuilder
    {
        /// <summary>
        /// Построители ножек
        /// </summary>
        private readonly IBuilder _legsBuilder;

        /// <summary>
        /// Построители Крышки стола
        /// </summary>
        private readonly IBuilder _tableTopBuilder;

        /// <summary>
        /// Конструктор класса TableBuilderManager
        /// </summary>
        /// <param name="tableTopBuilder">Построитель крышки стола</param>
        /// <param name="legsBuilder">Построитель ножек стола</param>
        public TableBuilderManager(IBuilder tableTopBuilder, IBuilder legsBuilder)
        {
            _tableTopBuilder = tableTopBuilder ?? throw new ArgumentNullException("tableTopBuilder is null");
            _legsBuilder = legsBuilder ?? throw new ArgumentNullException("legsBuilder is null"); ;
        }

        /// <inheritdoc />
        public void Build()
        {
            _tableTopBuilder.Build();

            _legsBuilder.Build();
        }
    }
}