using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            if (o == null)
            {
                return;
            }

            if (!observers.Contains(o))
            {
                observers.Add(o);
            }
        }

        public void RemoveObserver(Observer o)
        {
            if (o == null)
            {
                return;
            }

            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float tempereature, float humidity, float pressure)
        {
            this.temperature = tempereature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
