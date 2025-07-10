using System;

namespace ConsoleApp
{

    //Encapsulation and Inheritance
    class Device 
    {
        private bool isOn;
        private string deviceName;

        public string DeviceName
        {
            get { return deviceName; }
            private set { deviceName = value; }
        }

        public bool IsOn
        {
            get { return isOn; }
            protected set { isOn = value; }
        }

        public Device(string name)
        {
            DeviceName = name;
            IsOn = false;
        }

        public void PowerToggle()
        {
            IsOn = !IsOn;
            Console.WriteLine($"{DeviceName} is now {(IsOn ? "ON" : "OFF")}");
        }

        public virtual void ShowStatus()
        {
            Console.WriteLine($"Device: {DeviceName}, Status: {(IsOn ? "ON" : "OFF")}");
        }
    }

    // Inheriting class
    class SmartLight : Device
    {
        private int brightness;

        public SmartLight(string name) : base(name)
        {
            brightness = 50;
        }

        public void SetBrightness(int value)
        {
            if (value >= 0 && value <= 100)
            {
                brightness = value;
                Console.WriteLine($"{DeviceName} brightness set to {brightness}%");
            }
            else
            {
                Console.WriteLine("Brightness must be between 0 and 100.");
            }
        }

        public override void ShowStatus()
        {
            base.ShowStatus();
            Console.WriteLine($"Brightness: {brightness}%");
        }
    }

    // Another inheriting class
    class SmartDoorLock : Device
    {
        private bool isLocked;

        public SmartDoorLock(string name) : base(name)
        {
            isLocked = true; 
        }

        public void Unlock()
        {
            if (IsOn)
            {
                isLocked = false;
                Console.WriteLine($"{DeviceName} is now UNLOCKED.");
            }
            else
            {
                Console.WriteLine("Turn on the device to unlock.");
            }
        }

        public override void ShowStatus()
        {
            base.ShowStatus();
            Console.WriteLine($"Lock Status: {(isLocked ? "Locked" : "Unlocked")}");
        }
    }
}
