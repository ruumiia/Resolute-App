using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stepper.Droid;


[assembly: Xamarin.Forms.Dependency(typeof(StepCounter))]
namespace Stepper.Droid
{
    public class StepCounter : Java.Lang.Object, IStepCounter, ISensorEventListener
    {

        private int StepsCounter = 0;
        private SensorManager sManager;
        public int Steps
        {
            get { return StepsCounter; }
            set { StepsCounter = value; }
        }
        public new void Dispose()
        {
            sManager.UnregisterListener(this);
            sManager.Dispose();
        }
        //private static final int sensorTypeD = Sensor.TYPE_STEP_DETECTOR;
        //  private static final int sensorTypeC = Sensor.TYPE_STEP_COUNTER;
        private Sensor mStepCount;
        private Sensor mStepDetector;
        public void InitSensorService()
        {
            sManager = Android.App.Application.Context.GetSystemService(Context.SensorService) as SensorManager;

            mStepCount = sManager.GetDefaultSensor(SensorType.StepDetector);
            mStepDetector = sManager.GetDefaultSensor(SensorType.StepCounter);
            sManager.RegisterListener(this, mStepCount, SensorDelay.Fastest);
            sManager.RegisterListener(this, mStepDetector, SensorDelay.Fastest);
        }
        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            Console.WriteLine("OnAccuracyChanged called");
        }
        public void OnSensorChanged(SensorEvent e)
        {
            // is called so it runs the increment
            // Steps++; test 
            Console.WriteLine(e.ToString());
            
            if (e.Sensor.Type == SensorType.StepCounter)
            {
                //setStepCount(event.values [0]);
            }
            if (e.Sensor.Type == SensorType.StepDetector)
            {
                // never reaches this condition
                if (e.Values[0] == 1.0)
                {
                    Steps++;
                }
            }
        }
        public void StopSensorService()
        {
            sManager.UnregisterListener(this);
        }
        public bool IsAvailable()
        {
            return Android.App.Application.Context.PackageManager.HasSystemFeature(Android.Content.PM.PackageManager.FeatureSensorStepCounter) && Android.App.Application.Context.PackageManager.HasSystemFeature(Android.Content.PM.PackageManager.FeatureSensorStepDetector);
        }

    }
}