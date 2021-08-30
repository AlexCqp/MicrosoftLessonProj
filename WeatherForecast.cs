using System;

namespace ContosoPizza
{
    /// <summary>
    /// Описание объекта прогноза погоды
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Дата и время
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Температура в градусах Цельсия
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Температура в градусах Фаренгейта
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Краткое обозначение температуры
        /// </summary>
        public string Summary { get; set; }
    }
}
