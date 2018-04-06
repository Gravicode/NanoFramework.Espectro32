using System;
using System.Threading;
using System.Diagnostics;
using SeeedGroveStarterKit;

namespace NF.GroveDrivers
{
    public class Program
    {
        static LedSocket Led;
        public static void Main()
        {
            try
            {

                //var light = new LightSensor(Boards.Espectro32.GpioPin.ESPECTRO32_PHOTO_TR_ANALOG_CHANNEL);
                //var lcd = new LcdRgbBacklight();
                //var rgb = new RgbLed(Boards.Espectro32.GpioPin.ESPECTRO32_RGBLED_GPIO);
                //rgb.Demo();
                Led = new LedSocket(Boards.Espectro32.GpioPin.BoardLed);
                var btn = new Button(Boards.Espectro32.GpioPin.ESPECTRO32_BUTTON_A_PIN);
                btn.ButtonPressed += Btn_ButtonPressed;
                //int counter = 0;
                // User code goes here
                /*
                
                lcd.EnableDisplay(true);
                */
                //var rotary = new RotaryAngleSensor(Boards.Espectro32.AdcChannel.A7);
                while (true)
                {
                    //lcd.Clear();
                    //lcd.SetCursor(0, 0);
                    //lcd.Write("Hello : "+counter++);
                    //var lightVal = light.ReadLightLevel();
                    //Console.WriteLine(lightVal.ToString());
                    //Console.WriteLine("counter : "+counter++);
                    //var valRot = rotary.GetAngle();
                    Led.TurnOn();
                    Thread.Sleep(1000);
                    Led.TurnOff();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                // Do whatever please you with the exception caught
            }
        }

        private static void Btn_ButtonPressed()
        {
            //Led.Blink();
        }
    }
}
