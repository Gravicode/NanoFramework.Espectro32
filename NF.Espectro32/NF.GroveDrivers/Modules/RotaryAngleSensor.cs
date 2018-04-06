
using Windows.Devices.Adc;

namespace SeeedGroveStarterKit {
    public class RotaryAngleSensor {
        private AdcChannel Channel;
        public RotaryAngleSensor(int ChannelNumber) {
            var AdcCtl = AdcController.GetDefault();
            Channel = AdcCtl.OpenChannel(ChannelNumber);
        }
        // between 0 and 100
        public double GetAngle() {
            return Channel.ReadRatio() * 100;
        }
    }
}
