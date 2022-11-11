using System;

namespace MofelForEfficiency
{
    /// <summary>
    /// Класс, предназначенный для передачи информации
    /// о прогрессе расчёта для ProgressBar на графической форме
    /// </summary>
    public class EventForProgress : EventArgs
    {
        public int Step { get; set; }

        public EventForProgress(int step)
        {
            Step = step;
        }
    }
}
