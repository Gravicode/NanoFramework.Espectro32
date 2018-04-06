using System;
using System.Text;
using System.Threading;
using Windows.Devices.Pwm;

namespace SeeedGroveStarterKit
{
    public class RgbLed
    {
        static double dutyCycleMax = .3;
        static void HsvToRgb(double hue, double saturation, double brightValue, out double r, out double g, out double b)
        {
            double H = hue;
            double R, G, B;

            // hue parameter checking/fixing
            if (H < 0 || H >= 360)
            {
                H = 0;
            }
            // if Brightness is turned off, then everything is zero.
            if (brightValue <= 0)
            {
                R = G = B = 0;
            }

            // if saturation is turned off, then there is no color/hue. it's grayscale.
            else if (saturation <= 0)
            {
                R = G = B = brightValue;
            }
            else // if we got here, then there is a color to create.
            {
                double hf = H / 60.0;
                int i = (int)System.Math.Floor(hf);
                double f = hf - i;
                double pv = brightValue * (1 - saturation);
                double qv = brightValue * (1 - saturation * f);
                double tv = brightValue * (1 - saturation * (1 - f));

                switch (i)
                {

                    // Red Dominant
                    case 0:
                        R = brightValue;
                        G = tv;
                        B = pv;
                        break;

                    // Green Dominant
                    case 1:
                        R = qv;
                        G = brightValue;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = brightValue;
                        B = tv;
                        break;

                    // Blue Dominant
                    case 3:
                        R = pv;
                        G = qv;
                        B = brightValue;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = brightValue;
                        break;

                    // Red Red Dominant
                    case 5:
                        R = brightValue;
                        G = pv;
                        B = qv;
                        break;

                    // In case the math is out of bounds, this is a fix.
                    case 6:
                        R = brightValue;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = brightValue;
                        G = pv;
                        B = qv;
                        break;

                    // If the color is not defined, go grayscale
                    default:
                        R = G = B = brightValue;
                        break;
                }
            }
            r = Clamp(R);
            g = Clamp(G);
            b = Clamp(B);
        }
        public PwmPin Lamp { get; set; }
        public RgbLed(int PwmPinNumber)
        {
            //PWM redLed = new PWM(PWMChannels.PWM_PIN_D11, 100, 0, false);
            PwmController PWM = PwmController.GetDefault();

            Lamp = PWM.OpenPin(PwmPinNumber);

            PWM.SetDesiredFrequency(100);
        }

        public void Demo()
        {
            Thread th1 = new Thread(Rotate);
            th1.Start();
        }

        public void Rotate()
        {
            while (true)
            {
                Lamp.Start();

                double r, g, b;

                for (int i = 0; i < 360; i++)
                {
                    HsvToRgb(i, 1, 1, out r, out g, out b);

                    Lamp.SetActiveDutyCyclePercentage(r * dutyCycleMax);


                    // for a fun, fast rotation through the hue spectrum:
                    //Thread.Sleep (1);
                    // for a gentle walk through the forest of colors;
                    Thread.Sleep(18);
                }
            }
        }
        /// <summary>
        /// Clamp a value to 0 to 1
        /// </summary>
        static double Clamp(double i)
        {
            if (i < 0) return 0;
            if (i > 1) return 1;
            return i;
        }
    }
}
