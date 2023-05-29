using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.RecordExample
{

    // A record can inherit from another record. However, a record can't inherit from a class, and a class can't inherit from a record.
    public abstract record Person6(string FirstName, string LastName);
    public record Teacher(string FirstName, string LastName, int Grade)  : Person6(FirstName, LastName);

    public record Student(string FirstName, string LastName, int Grade) : Person6(FirstName, LastName);



    public abstract record Person7(string FirstName, string LastName);
    public record Teacher7(string FirstName, string LastName, int Grade) : Person7(FirstName, LastName);
    public record Student7(string FirstName, string LastName, int Grade)  : Person7(FirstName, LastName);




    public struct WeatherObservation
    {
        public DateTime RecordedAt { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }

        public override string ToString() =>
            $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
            $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
    }



}
