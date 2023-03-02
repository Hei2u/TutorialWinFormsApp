using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialWinFormsApp
{
    internal class Instrument
    {
        public DateTime RegisterDate { get; }
        private string sensorName;
        public string SensorName
        {
            get { return sensorName; }
            set { sensorName = value; }
        }
        public string SerialNumber { get; set; }
        public string SignalType { get; set; }
        public string MeasurementType { get; set; }
        public string Options { get; set; }
        public string Comments { get; set; }
        public double LRV { get; set; }
        public double URV { get; set; }
        public string Unit { get; set; }

        public Instrument( string SensorName,
            string SerialNumber,
            string SignalType,
            string MeasurementType,
            string Options,
            string Comments)
        {
            this.RegisterDate = DateTime.Now;
            this.SensorName = SensorName;
            this.SerialNumber = SerialNumber;
            this.SignalType = SignalType;
            this.MeasurementType = MeasurementType;
            this.Options = Options;
            this.Comments = Comments;
        }

        public Instrument( string SensorName,
            string SerialNumber,
            string SignalType,
            string MeasurementType,
            string Options,
            string Comments,
            double LRV,
            double URV,
            string Unit) 
        { 
            this.RegisterDate=DateTime.Now;
            this.SensorName = SensorName;
            this.SerialNumber = SerialNumber;
            this.SignalType = SignalType;
            this.MeasurementType = MeasurementType;
            this.Options = Options;
            this.Comments = Comments;
            this.LRV = LRV;
            this.URV = URV;
            this.Unit = Unit;
        }
        // method declaration
        public double Span ()
        {
            return URV - LRV;
        }
        public override string ToString()
        {
            //switch ()
            return RegisterDate.ToString() + ";" + SensorName
                + ";" + SerialNumber
                + ";" + SignalType
                + ";" + MeasurementType
                + ";" + Options
                + ";" + Comments 
                + ";" + Span() + Unit;
        }
    }
}
