using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Diagnostics;
using Microsoft.SPOT.Hardware.STM32F4;
using System.Threading;
namespace MFConsoleApplication1
{
    public class Program
    {
        static SPI MySPI = null;
        public static void TimerCallback(object state)
        {
            Debug.Print(DateTime.Now.Second.ToString());
        }
        public static void WriteRegister(byte register, byte data)
        {
            byte[] tx_data = new byte[2];
            byte[] rx_data = new byte[2];
            tx_data[0] = (byte)(register | 0x00); //MSB needs to be 0 for Write (so or with 00000000) - This isn't needed but is helpful for code/learning
            tx_data[1] = data;
            MySPI.Write(tx_data);
        }
        public static byte ReadRegister(byte register)
        {
            byte[] tx_data = new byte[2];
            byte[] rx_data = new byte[2];
            tx_data[0] = (byte)(register | 0x80); //MSB needs to be 1 for Read (so OR the register address with hex 80 which is 10000000)
            tx_data[1] = 0; //You have to write 2 bytes to get the device to respond - so in byte 2 just write 0
            MySPI.WriteRead(tx_data, rx_data);
            return rx_data[1];
        }
        public static int Config()
        {
            if (ReadRegister(0x0F) == 0x3b)
                Debug.Print("Work"); 
            else 
                Debug.Print("Dont work"); 
            WriteRegister(0x20, 0xC7);
            return 0;
        }
        public static void Main()
        {
            var green = new PWM(Cpu.PWMChannel.PWM_0, 300, 0, false);
            var orange = new PWM(Cpu.PWMChannel.PWM_1, 300, 0, false);
            var red = new PWM(Cpu.PWMChannel.PWM_2, 300, 0, false); 
            var blue = new PWM(Cpu.PWMChannel.PWM_3, 300, 0, false);
            green.Start();
            orange.Start();
            red.Start();
            blue.Start();
            int x;
            var timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
            SPI.Configuration MyConfig =
                new SPI.Configuration(Pins.GPIO_PIN_E_3, false, 0, 0, true, true, 1000, SPI.SPI_module.SPI1);
            MySPI = new SPI(MyConfig);
            Config();
            while (true)
            {
                red.DutyCycle = 0;
                green.DutyCycle = 0;
                blue.DutyCycle = 0;
                orange.DutyCycle = 0;
                if((ReadRegister(0x2D)>150)&&(ReadRegister(0x2D)<230))
                {
                    red.DutyCycle = 1;
                    green.DutyCycle = 1;
                    blue.DutyCycle = 1;
                    orange.DutyCycle = 1;
                }
                if ((ReadRegister(0x29) > 160) && (ReadRegister(0x29) < 230))
                    blue.DutyCycle = 1;
                if ((ReadRegister(0x29) < 140) && (ReadRegister(0x29) > 20))
                    orange.DutyCycle = 1;
                if ((ReadRegister(0x2B) > 160) && (ReadRegister(0x2B) < 230))
                    red.DutyCycle = 1;
                if ((ReadRegister(0x2B) < 140) && (ReadRegister(0x2B) > 20))
                    green.DutyCycle = 1;
                x = DateTime.Now.Millisecond;
                if (x + 200 >= 999) x -= 999; 
                Debug.Print(ReadRegister(0x29).ToString() + " " + ReadRegister(0x2B).ToString() + " " + ReadRegister(0x2D).ToString() + " " + x);
                while (DateTime.Now.Millisecond<= x + 200) { }
            }
            
        }
    }
}
