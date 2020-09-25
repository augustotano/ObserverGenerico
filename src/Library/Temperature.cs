using System;

namespace Observer
{
    public struct Temperature: IObject
    {
        public decimal ObjectValue{get;}

        public DateTime Date {get;}

        public Temperature(decimal temperature, DateTime dateAndTime)
        {
            this.ObjectValue = temperature;
            this.Date = dateAndTime;
        }
    }
}