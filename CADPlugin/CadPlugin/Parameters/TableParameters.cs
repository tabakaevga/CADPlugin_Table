using System;
using System.Collections.Generic;

namespace CadPlugin.Parameters
{
    /// <summary>
    /// Параметры стола
    /// </summary>
    public class TableParameters
    {
        private Dictionary<string, double> _parameters;

        /// <summary>
        /// Параметры
        /// </summary>
        public Dictionary<string, double> Parameters { get => _parameters;
            set
            {
                ParametersMax["Strut Height"] = value["Legs Height"]/2;
                ParametersMax["Strut Thickness"] = value["Legs Radius"];
                ValidateParameters(value);
                _parameters = value;
            }
        }

        /// <summary>
        /// Максимальные параметры крышки стола
        /// </summary>
        public Dictionary<string, double> ParametersMax { get; }
            = new Dictionary<string, double>
        {
            {"Top Length",      3.2 },
            {"Top Width",       1.2 },
            {"Top Height",      0.1 },
            {"Legs Radius",     0.1 },
            {"Legs Height",     1   },
            {"Edge Offset",     0.2 },
            {"Strut Height",    0.1 },
            {"Strut Thickness", 0.01}
        };

        /// <summary>
        /// Минимальные параметры стола
        /// </summary>
        public Dictionary<string, double> ParametersMin { get; } 
            = new Dictionary<string, double>
        {
            {"Top Length",      0.7  },
            {"Top Width",       0.7  },
            {"Top Height",      0.025},
            {"Legs Radius",     0.05 },
            {"Legs Height",     0.2  },
            {"Edge Offset",     0.02 },  
            {"Strut Height",    0.1  },
            {"Strut Thickness", 0.01 }
        };

        /// <summary>
        /// Валидация параметров
        /// </summary>
        private void ValidateParameters(Dictionary<string, double> parameters)
        {
            string errorMessage = string.Empty;
            foreach (var parameter in parameters)
            {
                if (!(ParametersMin.ContainsKey(parameter.Key) 
                      || ParametersMax.ContainsKey(parameter.Key)))
                {
                    throw new ArgumentException($"No {parameter.Key} in this class' Parameters");
                }

                const double rangeOffset = 1e3;

                if (parameter.Value < ParametersMin[parameter.Key])
                {
                    var minValue = Convert.ToInt32(ParametersMin[parameter.Key] * rangeOffset);
                    errorMessage += $"Table {parameter.Key} is lower than {minValue}mm. \n";
                }
                else if (parameter.Value > ParametersMax[parameter.Key])
                {
                    var maxValue = Convert.ToInt32(ParametersMax[parameter.Key] * rangeOffset);
                    errorMessage += $"Table {parameter.Key} is higher than {maxValue}mm. \n";
                }
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

        }
    }
}