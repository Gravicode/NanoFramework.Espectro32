using System;
using System.Text;

namespace NF.GroveDrivers.Boards
{


    public static class Espectro32
    {
        /// <summary>GPIO pin definitions.</summary>
        public static class GpioPin
        {

            /// <summary>Debug LED definition</summary>
            public const int BoardLed = D15;


            /// <summary>SD Card Dectect definition</summary>
            public const int SdCardCS = 33;

            public const int ESPECTRO32_PHOTO_TR_ANALOG_CHANNEL = 0;

            public const int ESPECTRO32_SDAPIN = 21;
            public const int ESPECTRO32_SCLPIN = 22;

            public const int ESPECTRO32_BUTTON_A_PIN = 0;
            public const int ESPECTRO32_BUTTON_B_PIN = 4;

            public const int ESPECTRO32_RGBLED_GPIO = D27;
            public const int ESPECTRO32_RGBLED_COUNT = 1;

            public const int ESPECTRO32_TOUCH_COUNT = 3;

            /// <summary>GPIO pin.</summary>
            public const int D0 = 0;
            /// <summary>GPIO pin.</summary>
            public const int D1 = 1;
            /// <summary>GPIO pin.</summary>
            public const int D2 = 2;
            /// <summary>GPIO pin.</summary>
            public const int D3 = 3;
            /// <summary>GPIO pin.</summary>
            public const int D4 = 4;
            /// <summary>GPIO pin.</summary>
            public const int D5 = 5;
            /// <summary>GPIO pin.</summary>
            public const int D6 = 6;
            /// <summary>GPIO pin.</summary>
            public const int D7 = 7;
            /// <summary>GPIO pin.</summary>
            public const int D8 = 8;
            /// <summary>GPIO pin.</summary>
            public const int D9 = 9;
            /// <summary>GPIO pin.</summary>
            public const int D10 = 10;
            /// <summary>GPIO pin.</summary>
            public const int D11 = 11;
            /// <summary>GPIO pin.</summary>
            public const int D12 = 12;
            /// <summary>GPIO pin.</summary>
            public const int D13 = 13;
            /// <summary>GPIO pin.</summary>
            public const int D14 = 14;
            /// <summary>GPIO pin.</summary>
            public const int D15 = 15;
            /// <summary>GPIO pin.</summary>
            public const int D16 = 16;
            /// <summary>GPIO pin.</summary>
            public const int D17 = 17;
            /// <summary>GPIO pin.</summary>
            public const int D18 = 18;
            /// <summary>GPIO pin.</summary>
            public const int D19 = 19;

            /// <summary>GPIO pin.</summary>
            public const int D21 = 21;
            /// <summary>GPIO pin.</summary>
            public const int D23 = 23;
            /// <summary>GPIO pin.</summary>
            public const int D25 = 25;
            /// <summary>GPIO pin.</summary>
            public const int D26 = 26;
            /// <summary>GPIO pin.</summary>
            public const int D27 = 27;
            /// <summary>GPIO pin.</summary>
            public const int D32 = 32;
            /// <summary>GPIO pin.</summary>
            public const int D33 = 33;
            /// <summary>GPIO pin.</summary>
            public const int D34 = 34;
            /// <summary>GPIO pin.</summary>
            public const int D35 = 35;
            /// <summary>GPIO pin.</summary>
            public const int D36 = 36;
            /// <summary>GPIO pin.</summary>
            public const int D37 = 37;
            /// <summary>GPIO pin.</summary>
            public const int D38 = 38;
            /// <summary>GPIO pin.</summary>
            public const int D39 = 39;

            //The GPIOs of 34,35,36,37,38 and 39 are input only.
            /*
            /// <summary>GPIO pin.</summary>
            public const int A0 = STM32F4.GpioPin.PC0;
            /// <summary>GPIO pin.</summary>
            public const int A1 = STM32F4.GpioPin.PC1;
            /// <summary>GPIO pin.</summary>
            public const int A2 = STM32F4.GpioPin.PC2;
            /// <summary>GPIO pin.</summary>
            public const int A3 = STM32F4.GpioPin.PC3;
            /// <summary>GPIO pin.</summary>
            public const int A4 = STM32F4.GpioPin.PC4;
            /// <summary>GPIO pin.</summary>
            public const int A5 = STM32F4.GpioPin.PC5;
            
            /// <summary>Socket definition.</summary>
            public static class GoPort1
            {
                /// <summary>Pin definition.</summary>
                public const int Pin3 = STM32F4.GpioPin.PD13;
                /// <summary>Pin definition.</summary>
                public const int Pin4 = STM32F4.GpioPin.PD8;
                /// <summary>Pin definition.</summary>
                public const int Pin5 = STM32F4.GpioPin.PD9;
                /// <summary>Pin definition.</summary>
                public const int Pin6 = STM32F4.GpioPin.PD0;
                /// <summary>LED definition.</summary>
                public const int Led = STM32F4.GpioPin.PE9;
                /// <summary>Power On definition.</summary>
                public const int PwrOn = STM32F4.GpioPin.PD7;
            }

            /// <summary>Socket definition.</summary>
            public static class GoPort2
            {
                /// <summary>Pin definition.</summary>
                public const int Pin3 = STM32F4.GpioPin.PD14;
                /// <summary>Pin definition.</summary>
                public const int Pin4 = STM32F4.GpioPin.PE8;
                /// <summary>Pin definition.</summary>
                public const int Pin5 = STM32F4.GpioPin.PE7;
                /// <summary>Pin definition.</summary>
                public const int Pin6 = STM32F4.GpioPin.PD1;
                /// <summary>LED definition.</summary>
                public const int Led = STM32F4.GpioPin.PE11;
                /// <summary>Power On definition.</summary>
                public const int PwrOn = STM32F4.GpioPin.PD10;
            }

            /// <summary>Socket definition.</summary>
            public static class GoPort3
            {
                /// <summary>Pin definition.</summary>
                public const int Pin3 = STM32F4.GpioPin.PD15;
                /// <summary>Pin definition.</summary>
                public const int Pin4 = STM32F4.GpioPin.PE1;
                /// <summary>Pin definition.</summary>
                public const int Pin5 = STM32F4.GpioPin.PE0;
                /// <summary>Pin definition.</summary>
                public const int Pin6 = STM32F4.GpioPin.PD2;
                /// <summary>LED definition.</summary>
                public const int Led = STM32F4.GpioPin.PB0;
                /// <summary>Power On definition.</summary>
                public const int PwrOn = STM32F4.GpioPin.PE14;
            }*/
        }
        public static class AdcChannel
        {
            //public const string Id = "GHIElectronics.TinyCLR.NativeApis.STM32F4.AdcProvider\\0";
            public const int A0 = 0;//32;
            public const int A1 = 1;//33;
            public const int A2 = 2;//34;
            public const int A3 = 3;//35;
            public const int A4 = 4;//36;
            public const int A5 = 5;//37;
            public const int A6 = 6;//38;
            public const int A7 = 7;//39;
        }
        /*
        /// <summary>Analog channel definition.</summary>
        public static class AdcChannel
        {
            /// <summary>Pin definition.</summary>
            public const int A0 = STM32F4.AdcChannel.Channel10;
            /// <summary>Pin definition.</summary>
            public const int A1 = STM32F4.AdcChannel.Channel11;
            /// <summary>Pin definition.</summary>
            public const int A2 = STM32F4.AdcChannel.Channel12;
            /// <summary>Pin definition.</summary>
            public const int A3 = STM32F4.AdcChannel.Channel13;
            /// <summary>Pin definition.</summary>
            public const int A4 = STM32F4.AdcChannel.Channel14;
            /// <summary>Pin definition.</summary>
            public const int A5 = STM32F4.AdcChannel.Channel15;
        }

        /// <summary>Uart port definition.</summary>
        public static class UartPort
        {

            /// <summary>Socket definition.</summary>
            public const string GoPort1 = STM32F4.UartPort.Usart3;
            /// <summary>Socket definition.</summary>
            public const string GoPort2 = STM32F4.UartPort.Uart7;
            /// <summary>Socket definition.</summary>
            public const string GoPort3 = STM32F4.UartPort.Uart8;

            /// <summary>UART D0 (RX) and D1 (TX).</summary>
            //public const string Uart6 = STM32F4.UartPort.Uart6;
        }

        /// <summary>SPI Bus definition.</summary>
        public static class SpiBus
        {

            /// <summary>Socket definition.</summary>
            public const string GoPort1 = STM32F4.SpiBus.Spi4;
            public const string GoPort2 = STM32F4.SpiBus.Spi4;
            public const string GoPort3 = STM32F4.SpiBus.Spi4;
            public const string Spi2 = STM32F4.SpiBus.Spi2;
        }
        */
    }

}
/*
 #ifndef Pins_Arduino_h
#define Pins_Arduino_h

#include <stdint.h>

#ifndef ESPECTRO32_VERSION
#define ESPECTRO32_VERSION 1
#endif 

#define EXTERNAL_NUM_INTERRUPTS 16
#define NUM_DIGITAL_PINS        40
#define NUM_ANALOG_INPUTS       16

#define analogInputToDigitalPin(p)  (((p)<20)?(esp32_adc2gpio[(p)]):-1)
#define digitalPinToInterrupt(p)    (((p)<40)?(p):-1)
#define digitalPinHasPWM(p)         (p < 34)

static const uint8_t LED_BUILTIN = 15;
#define BUILTIN_LED  LED_BUILTIN // backward compatibility

static const uint8_t TX = 1;
static const uint8_t RX = 3;

static const uint8_t SDA = 21;
static const uint8_t SCL = 22;

static const uint8_t SD_SS = 33;
static const uint8_t SS    = 5;
static const uint8_t MOSI  = 23;
static const uint8_t MISO  = 19;
static const uint8_t SCK   = 18;

static const uint8_t A0 = 36;
static const uint8_t A3 = 39;
static const uint8_t A4 = 32;
static const uint8_t A5 = 33;
static const uint8_t A6 = 34;
static const uint8_t A7 = 35;
static const uint8_t A10 = 4;
static const uint8_t A11 = 0;
static const uint8_t A12 = 2;
static const uint8_t A13 = 15;
static const uint8_t A14 = 13;
static const uint8_t A15 = 12;
static const uint8_t A16 = 14;
static const uint8_t A17 = 27;
static const uint8_t A18 = 25;
static const uint8_t A19 = 26;

static const uint8_t T0 = 4;
static const uint8_t T1 = 0;
static const uint8_t T2 = 2;
static const uint8_t T3 = 15;
static const uint8_t T4 = 13;
static const uint8_t T5 = 12;
static const uint8_t T6 = 14;
static const uint8_t T7 = 27;
static const uint8_t T8 = 33;
static const uint8_t T9 = 32;

static const uint8_t DAC1 = 25;
static const uint8_t DAC2 = 26;

#endif /* Pins_Arduino_h */


    