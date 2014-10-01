using System;
using System.Text;
using Microsoft.SPOT;
using Microsoft.SPOT.Input;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Hardware;
using System.IO.Ports;
using STM32F429I_Discovery.Netmf.Hardware;

namespace L3GD20Example
{
  
    public class MyL3GD20Example : Microsoft.SPOT.Application
    {
     
        public class MainWindow : Window
        {
            /* Przygotowanie zmiennych u¿ywanych do 
            * wypisywania danych na wyœwietlaczu
            * konfirugacji akcelerometru
            * przycisku, przesy³ania danych przez UART
            * 
            */

            SolidColorBrush brush = new SolidColorBrush(Color.White);
            Text text1 = new Text();
            Text text2 = new Text();
            Text help = new Text();
            Panel panel = new Panel();
            private DispatcherTimer clockTimer;
            private static InterruptPort button;

            const int GyroThreshold = 10;
            static int NbrReceivedBytes = 0;

            static SerialPort serialPort;

            static byte[] outBuffer = new byte[100];
            static byte[] inBuffer1 = new byte[100];

            int XAbs = (int)System.Math.Abs(Gyro.x);
            int YAbs = (int)System.Math.Abs(Gyro.y);
            int ZAbs = (int)System.Math.Abs(Gyro.z);


            public MainWindow()
            {

                /*
                 * Przypisanie pól tekstowych oraz okreœlenie ich parametrów
                 */

                text1.TextContent = " Podstawy technik mikroprocesorowych";
                text1.TextWrap = true;
                text1.Font = Resources.GetFont(Resources.FontResources.small);
                text1.HorizontalAlignment = HorizontalAlignment.Center;
                text1.VerticalAlignment = VerticalAlignment.Stretch;

                text2.TextContent = " Projekt C# na p³ytce STM ";
                text2.TextWrap = true;
                text2.Font = Resources.GetFont(Resources.FontResources.small);
                text2.ForeColor = Colors.Green;
                text2.HorizontalAlignment = HorizontalAlignment.Center;
                text2.VerticalAlignment = VerticalAlignment.Bottom;

                help.TextContent = "Aby projekt dzialal poprawnie nalezy podlaczyc modul UART! \n      TX: PA9 \n      RX: PA10 \n    Wykorzystujemy COM1 ";
                help.TextWrap = true;
                help.Font = Resources.GetFont(Resources.FontResources.small);
                help.ForeColor = Colors.Brown;
                help.HorizontalAlignment = HorizontalAlignment.Center;
                help.VerticalAlignment = VerticalAlignment.Center;



                /* 
                 * Dodawanie tekstów do okna g³ównego
                 */
                this.Child = panel;
                panel.Children.Add(text1);
                panel.Children.Add(text2);
                panel.Children.Add(help);

                /*
                 * Inicjalizacja akcelerometru na szynie SPI
                 * Podstawowa kalibracja 
                 */
                L3GD20 = new L3GD20_SPI();
                L3GD20.Init();
                L3GD20.SimpleCalibration();

                /* 
                 * Ustawienie timera wywo³uj¹cego przerwanie 
                 */
                clockTimer = new DispatcherTimer(this.Dispatcher);
                clockTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
                clockTimer.Tick += new EventHandler(TimerTick);
                clockTimer.Start();

                /*
                 * Przypisanie przycisku
                 */
                InterruptPort button = new InterruptPort((Cpu.Pin)0, false, Port.ResistorMode.PullDown, Port.InterruptMode.InterruptEdgeHigh);
                button.OnInterrupt += new NativeEventHandler(wcisniety_przycisk);
                /*
                 * Inicjalizacja diod 
                 */
                LED.LEDInit();

                /* Configure the USART1 (COM1):
                 * BaudRate = 9600 baud  
                 * Word Length = 8 Bits (default settings)
                 * One Stop Bit         (default settings)
                 * Parity none          (default settings)
                 * Hardware flow control disabled (default settings)
                 */
                serialPort = new SerialPort(SerialPorts.SerialCOM1, 9600);

                /* Register the DataReceived interrupt handler*/
               serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived_Interrupt);

                /*
                 * Otwarcie portu COM1
                 */
              serialPort.Open();
              serialPort.Write(outBuffer, 0, outBuffer.Length);

            }

       internal void DataReceived_Interrupt(object com, SerialDataReceivedEventArgs arg)
            {

                 NbrReceivedBytes += serialPort.Read(inBuffer1, NbrReceivedBytes, inBuffer1.Length - NbrReceivedBytes);
                // serialPort.DiscardInBuffer();
                // serialPort.DiscardOutBuffer();
                 NbrReceivedBytes = 0;
                 rozmawiaj_z_ukladem(inBuffer1);
                 return;
            }


       void rozmawiaj_z_ukladem(byte[] inBuffer)
       {
           
           switch (inBuffer[0+NbrReceivedBytes])
           {
               case ((byte)'a'):
                   LED.GreenLedOn();
                   break;
               case ((byte)'z'):
                   LED.RedLedOn();
                   break;
               case ((byte)'A'):
                   LED.GreenLedOff();
                   break;
               case ((byte)'Z'):
                   LED.RedLedOff();
                   break;
               default:
                   break;
           }
           return;
           
       }


       static void wcisniety_przycisk(UInt32 port, UInt32 state, DateTime time)
       {
           LED.GreenLedToggle();
           LED.RedLedToggle();

       }

            void TimerTick(object sender, EventArgs e)
            {
                int XAbs = (int)System.Math.Abs(Gyro.x);
                int YAbs = (int)System.Math.Abs(Gyro.y);
                int ZAbs = (int)System.Math.Abs(Gyro.z);

                L3GD20.ReadAngRate(out Gyro);
                text2.TextContent = ("X = " + (int)Gyro.x + "\nY = " + (int)Gyro.y + "\nZ = " + (int)Gyro.z);
               
              
  
                if ((XAbs > GyroThreshold) && (XAbs > YAbs ) && (XAbs > ZAbs ))
                {
                     text1.TextContent = "  Obrot wokol osi X";
                }
                else if ((YAbs > GyroThreshold) && (YAbs > XAbs) && (YAbs > ZAbs)) 
                {
                    text1.TextContent = "  Obrot wokol osi Y  ";
                }
                else if ((ZAbs > GyroThreshold) && (ZAbs > XAbs ) && (ZAbs > YAbs ))
                {
                    text1.TextContent = "  Obrot wokol osi Z  ";
                }
                else
                    text1.TextContent = "Polozenie poczatkowe";
                
                Invalidate();
     
            }      

            
            

            bool isTouchDown = false;

            protected override void OnTouchDown(TouchEventArgs e)
            {
                base.OnTouchDown(e);
                
                isTouchDown = true;
                    string temp = "Dane odczytane z akcelerometru: X = " + (int)Gyro.x + " Y = " + (int)Gyro.y + " Z = " + (int)Gyro.z + "\n";
                    outBuffer = Encoding.UTF8.GetBytes(temp);
                    serialPort.Write(outBuffer,0,outBuffer.Length);
                    Invalidate();

                e.Handled = true;
            }

          
        }

        static MyL3GD20Example myApplication;
        static L3GD20_SPI L3GD20;
        static AngDPS Gyro = new AngDPS();
        /// <summary>
        /// Main function(entry point).
        /// </summary>
        /// 

        static void wcisniety_przycisk(UInt32 port, UInt32 state, DateTime time) {

            LED.GreenLedOn();
        
        }
        public static void Main()
        {
            myApplication = new MyL3GD20Example();

            /* Enable Touch engine */
            Microsoft.SPOT.Touch.Touch.Initialize(myApplication);

            /* Create window object */
            Window mainWindow = myApplication.CreateWindow();

            /* Start the application */
            myApplication.Run(mainWindow);
        }

        
        private MainWindow mainWindow;

        /// <summary>
        /// Create window object with button focus.
        /// </summary>
        /// <returns></returns>
        public Window CreateWindow()
        {
            /* Create window object */
            mainWindow = new MainWindow();
            mainWindow.Height = SystemMetrics.ScreenHeight;
            mainWindow.Width = SystemMetrics.ScreenWidth;
            mainWindow.Visibility = Visibility.Visible;
            Buttons.Focus(mainWindow);

            return mainWindow;
        }
    }
}