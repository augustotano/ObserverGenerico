using System;

namespace Observer
{
    public class TemperatureReporter : IObserver
    {
        private bool first = true;

        private IObject last;
        
        private IObservable provider;

        public void StartReporting(IObservable provider)
        {
            this.provider = provider;
            this.first = true;
            this.provider.Subscribe(this);
        }

        public void StopReporting()
        {
            this.provider.Unsubscribe(this);
        }

        public void Update(IObject value)
        {
            Console.WriteLine($"The temperature is {value.ObjectValue}°C at {value.Date:g}");
            if (first)
            {
                last = value;
                first = false;
            }
            else
            {
                Console.WriteLine($"   Change: {value.ObjectValue - last.ObjectValue}° in " +
                    $"{value.Date.ToUniversalTime() - last.Date.ToUniversalTime():g}");
            }
        }
    }
}