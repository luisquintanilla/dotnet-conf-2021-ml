using System;
using System.Collections.Generic;

namespace Manufaktura.Core
{
    public interface IMeasureDeserializationPerformance
    {
        int NumberOfAccessedMethods { get; }
        IDictionary<string, TimeSpan> PerformanceLog { get; }

        TimeSpan TotalTimeSpentOnDeserialization { get; }

        TimeSpan GetTotalDeserializationTimeWithChildElements();

        int GetTotalNumberOfAccessedMethodsWithChildElements();
    }
}