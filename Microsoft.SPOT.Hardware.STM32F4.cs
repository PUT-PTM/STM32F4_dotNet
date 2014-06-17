using System;
using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;
using Microsoft.SPOT.Hardware;
using System.IO.Ports;

namespace Microsoft.SPOT.Hardware.STM32F4
{

    ///
    /// Specifies identifiers for hardware I/O pins.
    ///
    public static class Pins
    {
        ///
        /// GPIO port A bit 0
        ///
        public const Cpu.Pin GPIO_PIN_A_0 = (Cpu.Pin)0;
        ///
        /// GPIO port A bit 1
        ///
        public const Cpu.Pin GPIO_PIN_A_1 = (Cpu.Pin)1;
        ///
        /// GPIO port A bit 2
        ///
        public const Cpu.Pin GPIO_PIN_A_2 = (Cpu.Pin)2;
        ///
        /// GPIO port A bit 3
        ///
        public const Cpu.Pin GPIO_PIN_A_3 = (Cpu.Pin)3;
        ///
        /// GPIO port A bit 4
        ///
        public const Cpu.Pin GPIO_PIN_A_4 = (Cpu.Pin)4;
        ///
        /// GPIO port A bit 5
        ///
        public const Cpu.Pin GPIO_PIN_A_5 = (Cpu.Pin)5;
        ///
        /// GPIO port A bit 6
        ///
        public const Cpu.Pin GPIO_PIN_A_6 = (Cpu.Pin)6;
        ///
        /// GPIO port A bit 7
        ///
        public const Cpu.Pin GPIO_PIN_A_7 = (Cpu.Pin)7;
        ///
        /// GPIO port A bit 8
        ///
        public const Cpu.Pin GPIO_PIN_A_8 = (Cpu.Pin)8;
        ///
        /// GPIO port A bit 9
        ///
        public const Cpu.Pin GPIO_PIN_A_9 = (Cpu.Pin)9;
        ///
        /// GPIO port A bit 10
        ///
        public const Cpu.Pin GPIO_PIN_A_10 = (Cpu.Pin)10;
        ///
        /// GPIO port A bit 11
        ///
        public const Cpu.Pin GPIO_PIN_A_11 = (Cpu.Pin)11;
        ///
        /// GPIO port A bit 12
        ///
        public const Cpu.Pin GPIO_PIN_A_12 = (Cpu.Pin)12;
        ///
        /// GPIO port A bit 13
        ///
        public const Cpu.Pin GPIO_PIN_A_13 = (Cpu.Pin)13;
        ///
        /// GPIO port A bit 14
        ///
        public const Cpu.Pin GPIO_PIN_A_14 = (Cpu.Pin)14;
        ///
        /// GPIO port A bit 15
        ///
        public const Cpu.Pin GPIO_PIN_A_15 = (Cpu.Pin)15;
        ///
        /// GPIO port B bit 0
        ///
        public const Cpu.Pin GPIO_PIN_B_0 = (Cpu.Pin)16;
        ///
        /// GPIO port B bit 1
        ///
        public const Cpu.Pin GPIO_PIN_B_1 = (Cpu.Pin)17;
        ///
        /// GPIO port B bit 2
        ///
        public const Cpu.Pin GPIO_PIN_B_2 = (Cpu.Pin)18;
        ///
        /// GPIO port B bit 3
        ///
        public const Cpu.Pin GPIO_PIN_B_3 = (Cpu.Pin)19;
        ///
        /// GPIO port B bit 4
        ///
        public const Cpu.Pin GPIO_PIN_B_4 = (Cpu.Pin)20;
        ///
        /// GPIO port B bit 5
        ///
        public const Cpu.Pin GPIO_PIN_B_5 = (Cpu.Pin)21;
        ///
        /// GPIO port B bit 6
        ///
        public const Cpu.Pin GPIO_PIN_B_6 = (Cpu.Pin)22;
        ///
        /// GPIO port B bit 7
        ///
        public const Cpu.Pin GPIO_PIN_B_7 = (Cpu.Pin)23;
        ///
        /// GPIO port B bit 8
        ///
        public const Cpu.Pin GPIO_PIN_B_8 = (Cpu.Pin)24;
        ///
        /// GPIO port B bit 9
        ///
        public const Cpu.Pin GPIO_PIN_B_9 = (Cpu.Pin)25;
        ///
        /// GPIO port B bit 10
        ///
        public const Cpu.Pin GPIO_PIN_B_10 = (Cpu.Pin)26;
        ///
        /// GPIO port B bit 11
        ///
        public const Cpu.Pin GPIO_PIN_B_11 = (Cpu.Pin)27;
        ///
        /// GPIO port B bit 12
        ///
        public const Cpu.Pin GPIO_PIN_B_12 = (Cpu.Pin)28;
        ///
        /// GPIO port B bit 13
        ///
        public const Cpu.Pin GPIO_PIN_B_13 = (Cpu.Pin)29;
        ///
        /// GPIO port B bit 14
        ///
        public const Cpu.Pin GPIO_PIN_B_14 = (Cpu.Pin)30;
        ///
        /// GPIO port B bit 15
        ///
        public const Cpu.Pin GPIO_PIN_B_15 = (Cpu.Pin)31;
        ///
        /// GPIO port C bit 0
        ///
        public const Cpu.Pin GPIO_PIN_C_0 = (Cpu.Pin)32;
        ///
        /// GPIO port C bit 1
        ///
        public const Cpu.Pin GPIO_PIN_C_1 = (Cpu.Pin)33;
        ///
        /// GPIO port C bit 2
        ///
        public const Cpu.Pin GPIO_PIN_C_2 = (Cpu.Pin)34;
        ///
        /// GPIO port C bit 3
        ///
        public const Cpu.Pin GPIO_PIN_C_3 = (Cpu.Pin)35;
        ///
        /// GPIO port C bit 4
        ///
        public const Cpu.Pin GPIO_PIN_C_4 = (Cpu.Pin)36;
        ///
        /// GPIO port C bit 5
        ///
        public const Cpu.Pin GPIO_PIN_C_5 = (Cpu.Pin)37;
        ///
        /// GPIO port C bit 6
        ///
        public const Cpu.Pin GPIO_PIN_C_6 = (Cpu.Pin)38;
        ///
        /// GPIO port C bit 7
        ///
        public const Cpu.Pin GPIO_PIN_C_7 = (Cpu.Pin)39;
        ///
        /// GPIO port C bit 8
        ///
        public const Cpu.Pin GPIO_PIN_C_8 = (Cpu.Pin)40;
        ///
        /// GPIO port C bit 9
        ///
        public const Cpu.Pin GPIO_PIN_C_9 = (Cpu.Pin)41;
        ///
        /// GPIO port C bit 10
        ///
        public const Cpu.Pin GPIO_PIN_C_10 = (Cpu.Pin)42;
        ///
        /// GPIO port C bit 11
        ///
        public const Cpu.Pin GPIO_PIN_C_11 = (Cpu.Pin)43;
        ///
        /// GPIO port C bit 12
        ///
        public const Cpu.Pin GPIO_PIN_C_12 = (Cpu.Pin)44;
        ///
        /// GPIO port C bit 13
        ///
        public const Cpu.Pin GPIO_PIN_C_13 = (Cpu.Pin)45;
        ///
        /// GPIO port C bit 14
        ///
        public const Cpu.Pin GPIO_PIN_C_14 = (Cpu.Pin)46;
        ///
        /// GPIO port C bit 15
        ///
        public const Cpu.Pin GPIO_PIN_C_15 = (Cpu.Pin)47;
        ///
        /// GPIO port D bit 0
        ///
        public const Cpu.Pin GPIO_PIN_D_0 = (Cpu.Pin)48;
        ///
        /// GPIO port D bit 1
        ///
        public const Cpu.Pin GPIO_PIN_D_1 = (Cpu.Pin)49;
        ///
        /// GPIO port D bit 2
        ///
        public const Cpu.Pin GPIO_PIN_D_2 = (Cpu.Pin)50;
        ///
        /// GPIO port D bit 3
        ///
        public const Cpu.Pin GPIO_PIN_D_3 = (Cpu.Pin)51;
        ///
        /// GPIO port D bit 4
        ///
        public const Cpu.Pin GPIO_PIN_D_4 = (Cpu.Pin)52;
        ///
        /// GPIO port D bit 5
        ///
        public const Cpu.Pin GPIO_PIN_D_5 = (Cpu.Pin)53;
        ///
        /// GPIO port D bit 6
        ///
        public const Cpu.Pin GPIO_PIN_D_6 = (Cpu.Pin)54;
        ///
        /// GPIO port D bit 7
        ///
        public const Cpu.Pin GPIO_PIN_D_7 = (Cpu.Pin)55;
        ///
        /// GPIO port D bit 8
        ///
        public const Cpu.Pin GPIO_PIN_D_8 = (Cpu.Pin)56;
        ///
        /// GPIO port D bit 9
        ///
        public const Cpu.Pin GPIO_PIN_D_9 = (Cpu.Pin)57;
        ///
        /// GPIO port D bit 10
        ///
        public const Cpu.Pin GPIO_PIN_D_10 = (Cpu.Pin)58;
        ///
        /// GPIO port D bit 11
        ///
        public const Cpu.Pin GPIO_PIN_D_11 = (Cpu.Pin)59;
        ///
        /// GPIO port D bit 12
        ///
        public const Cpu.Pin GPIO_PIN_D_12 = (Cpu.Pin)60;
        ///
        /// GPIO port D bit 13
        ///
        public const Cpu.Pin GPIO_PIN_D_13 = (Cpu.Pin)61;
        ///
        /// GPIO port D bit 14
        ///
        public const Cpu.Pin GPIO_PIN_D_14 = (Cpu.Pin)62;
        ///
        /// GPIO port D bit 15
        ///
        public const Cpu.Pin GPIO_PIN_D_15 = (Cpu.Pin)63;
        ///
        /// GPIO port E bit 0
        ///
        public const Cpu.Pin GPIO_PIN_E_0 = (Cpu.Pin)64;
        ///
        /// GPIO port E bit 1
        ///
        public const Cpu.Pin GPIO_PIN_E_1 = (Cpu.Pin)65;
        ///
        /// GPIO port E bit 2
        ///
        public const Cpu.Pin GPIO_PIN_E_2 = (Cpu.Pin)66;
        ///
        /// GPIO port E bit 3
        ///
        public const Cpu.Pin GPIO_PIN_E_3 = (Cpu.Pin)67;
        ///
        /// GPIO port E bit 4
        ///
        public const Cpu.Pin GPIO_PIN_E_4 = (Cpu.Pin)68;
        ///
        /// GPIO port E bit 5
        ///
        public const Cpu.Pin GPIO_PIN_E_5 = (Cpu.Pin)69;
        ///
        /// GPIO port E bit 6
        ///
        public const Cpu.Pin GPIO_PIN_E_6 = (Cpu.Pin)70;
        ///
        /// GPIO port E bit 7
        ///
        public const Cpu.Pin GPIO_PIN_E_7 = (Cpu.Pin)71;
        ///
        /// GPIO port E bit 8
        ///
        public const Cpu.Pin GPIO_PIN_E_8 = (Cpu.Pin)72;
        ///
        /// GPIO port E bit 9
        ///
        public const Cpu.Pin GPIO_PIN_E_9 = (Cpu.Pin)73;
        ///
        /// GPIO port E bit 10
        ///
        public const Cpu.Pin GPIO_PIN_E_10 = (Cpu.Pin)74;
        ///
        /// GPIO port E bit 11
        ///
        public const Cpu.Pin GPIO_PIN_E_11 = (Cpu.Pin)75;
        ///
        /// GPIO port E bit 12
        ///
        public const Cpu.Pin GPIO_PIN_E_12 = (Cpu.Pin)76;
        ///
        /// GPIO port E bit 13
        ///
        public const Cpu.Pin GPIO_PIN_E_13 = (Cpu.Pin)77;
        ///
        /// GPIO port E bit 14
        ///
        public const Cpu.Pin GPIO_PIN_E_14 = (Cpu.Pin)78;
        ///
        /// GPIO port E bit 15
        ///
        public const Cpu.Pin GPIO_PIN_E_15 = (Cpu.Pin)79;
        ///
        /// GPIO port F bit 0
        ///
        public const Cpu.Pin GPIO_PIN_F_0 = (Cpu.Pin)80;
        ///
        /// GPIO port F bit 1
        ///
        public const Cpu.Pin GPIO_PIN_F_1 = (Cpu.Pin)81;
        ///
        /// GPIO port F bit 2
        ///
        public const Cpu.Pin GPIO_PIN_F_2 = (Cpu.Pin)82;
        ///
        /// GPIO port F bit 3
        ///
        public const Cpu.Pin GPIO_PIN_F_3 = (Cpu.Pin)83;
        ///
        /// GPIO port F bit 4
        ///
        public const Cpu.Pin GPIO_PIN_F_4 = (Cpu.Pin)84;
        ///
        /// GPIO port F bit 5
        ///
        public const Cpu.Pin GPIO_PIN_F_5 = (Cpu.Pin)85;
        ///
        /// GPIO port F bit 6
        ///
        public const Cpu.Pin GPIO_PIN_F_6 = (Cpu.Pin)86;
        ///
        /// GPIO port F bit 7
        ///
        public const Cpu.Pin GPIO_PIN_F_7 = (Cpu.Pin)87;
        ///
        /// GPIO port F bit 8
        ///
        public const Cpu.Pin GPIO_PIN_F_8 = (Cpu.Pin)88;
        ///
        /// GPIO port F bit 9
        ///
        public const Cpu.Pin GPIO_PIN_F_9 = (Cpu.Pin)89;
        ///
        /// GPIO port F bit 10
        ///
        public const Cpu.Pin GPIO_PIN_F_10 = (Cpu.Pin)90;
        ///
        /// GPIO port F bit 11
        ///
        public const Cpu.Pin GPIO_PIN_F_11 = (Cpu.Pin)91;
        ///
        /// GPIO port F bit 12
        ///
        public const Cpu.Pin GPIO_PIN_F_12 = (Cpu.Pin)92;
        ///
        /// GPIO port F bit 13
        ///
        public const Cpu.Pin GPIO_PIN_F_13 = (Cpu.Pin)93;
        ///
        /// GPIO port F bit 14
        ///
        public const Cpu.Pin GPIO_PIN_F_14 = (Cpu.Pin)94;
        ///
        /// GPIO port F bit 15
        ///
        public const Cpu.Pin GPIO_PIN_F_15 = (Cpu.Pin)95;
        ///
        /// GPIO port G bit 0
        ///
        public const Cpu.Pin GPIO_PIN_G_0 = (Cpu.Pin)96;
        ///
        /// GPIO port G bit 1
        ///
        public const Cpu.Pin GPIO_PIN_G_1 = (Cpu.Pin)97;
        ///
        /// GPIO port G bit 2
        ///
        public const Cpu.Pin GPIO_PIN_G_2 = (Cpu.Pin)98;
        ///
        /// GPIO port G bit 3
        ///
        public const Cpu.Pin GPIO_PIN_G_3 = (Cpu.Pin)99;
        ///
        /// GPIO port G bit 4
        ///
        public const Cpu.Pin GPIO_PIN_G_4 = (Cpu.Pin)100;
        ///
        /// GPIO port G bit 5
        ///
        public const Cpu.Pin GPIO_PIN_G_5 = (Cpu.Pin)101;
        ///
        /// GPIO port G bit 6
        ///
        public const Cpu.Pin GPIO_PIN_G_6 = (Cpu.Pin)102;
        ///
        /// GPIO port G bit 7
        ///
        public const Cpu.Pin GPIO_PIN_G_7 = (Cpu.Pin)103;
        ///
        /// GPIO port G bit 8
        ///
        public const Cpu.Pin GPIO_PIN_G_8 = (Cpu.Pin)104;
        ///
        /// GPIO port G bit 9
        ///
        public const Cpu.Pin GPIO_PIN_G_9 = (Cpu.Pin)105;
        ///
        /// GPIO port G bit 10
        ///
        public const Cpu.Pin GPIO_PIN_G_10 = (Cpu.Pin)106;
        ///
        /// GPIO port G bit 11
        ///
        public const Cpu.Pin GPIO_PIN_G_11 = (Cpu.Pin)107;
        ///
        /// GPIO port G bit 12
        ///
        public const Cpu.Pin GPIO_PIN_G_12 = (Cpu.Pin)108;
        ///
        /// GPIO port G bit 13
        ///
        public const Cpu.Pin GPIO_PIN_G_13 = (Cpu.Pin)109;
        ///
        /// GPIO port G bit 14
        ///
        public const Cpu.Pin GPIO_PIN_G_14 = (Cpu.Pin)110;
        ///
        /// GPIO port G bit 15
        ///
        public const Cpu.Pin GPIO_PIN_G_15 = (Cpu.Pin)111;
        ///
        /// GPIO port H bit 0
        ///
        public const Cpu.Pin GPIO_PIN_H_0 = (Cpu.Pin)112;
        ///
        /// GPIO port H bit 1
        ///
        public const Cpu.Pin GPIO_PIN_H_1 = (Cpu.Pin)113;
        ///
        /// GPIO port H bit 2
        ///
        public const Cpu.Pin GPIO_PIN_H_2 = (Cpu.Pin)114;
        ///
        /// GPIO port H bit 3
        ///
        public const Cpu.Pin GPIO_PIN_H_3 = (Cpu.Pin)115;
        ///
        /// GPIO port H bit 4
        ///
        public const Cpu.Pin GPIO_PIN_H_4 = (Cpu.Pin)116;
        ///
        /// GPIO port H bit 5
        ///
        public const Cpu.Pin GPIO_PIN_H_5 = (Cpu.Pin)117;
        ///
        /// GPIO port H bit 6
        ///
        public const Cpu.Pin GPIO_PIN_H_6 = (Cpu.Pin)118;
        ///
        /// GPIO port H bit 7
        ///
        public const Cpu.Pin GPIO_PIN_H_7 = (Cpu.Pin)119;
        ///
        /// GPIO port H bit 8
        ///
        public const Cpu.Pin GPIO_PIN_H_8 = (Cpu.Pin)120;
        ///
        /// GPIO port H bit 9
        ///
        public const Cpu.Pin GPIO_PIN_H_9 = (Cpu.Pin)121;
        ///
        /// GPIO port H bit 10
        ///
        public const Cpu.Pin GPIO_PIN_H_10 = (Cpu.Pin)122;
        ///
        /// GPIO port H bit 11
        ///
        public const Cpu.Pin GPIO_PIN_H_11 = (Cpu.Pin)123;
        ///
        /// GPIO port H bit 12
        ///
        public const Cpu.Pin GPIO_PIN_H_12 = (Cpu.Pin)124;
        ///
        /// GPIO port H bit 13
        ///
        public const Cpu.Pin GPIO_PIN_H_13 = (Cpu.Pin)125;
        ///
        /// GPIO port H bit 14
        ///
        public const Cpu.Pin GPIO_PIN_H_14 = (Cpu.Pin)126;
        ///
        /// GPIO port H bit 15
        ///
        public const Cpu.Pin GPIO_PIN_H_15 = (Cpu.Pin)127;
        ///
        /// GPIO port I bit 0
        ///
        public const Cpu.Pin GPIO_PIN_I_0 = (Cpu.Pin)128;
        ///
        /// GPIO port I bit 1
        ///
        public const Cpu.Pin GPIO_PIN_I_1 = (Cpu.Pin)129;
        ///
        /// GPIO port I bit 2
        ///
        public const Cpu.Pin GPIO_PIN_I_2 = (Cpu.Pin)130;
        ///
        /// GPIO port I bit 3
        ///
        public const Cpu.Pin GPIO_PIN_I_3 = (Cpu.Pin)131;
        ///
        /// GPIO port I bit 4
        ///
        public const Cpu.Pin GPIO_PIN_I_4 = (Cpu.Pin)132;
        ///
        /// GPIO port I bit 5
        ///
        public const Cpu.Pin GPIO_PIN_I_5 = (Cpu.Pin)133;
        ///
        /// GPIO port I bit 6
        ///
        public const Cpu.Pin GPIO_PIN_I_6 = (Cpu.Pin)134;
        ///
        /// GPIO port I bit 7
        ///
        public const Cpu.Pin GPIO_PIN_I_7 = (Cpu.Pin)135;
        ///
        /// GPIO port I bit 8
        ///
        public const Cpu.Pin GPIO_PIN_I_8 = (Cpu.Pin)136;
        ///
        /// GPIO port I bit 9
        ///
        public const Cpu.Pin GPIO_PIN_I_9 = (Cpu.Pin)137;
        ///
        /// GPIO port I bit 10
        ///
        public const Cpu.Pin GPIO_PIN_I_10 = (Cpu.Pin)138;
        ///
        /// GPIO port I bit 11
        ///
        public const Cpu.Pin GPIO_PIN_I_11 = (Cpu.Pin)139;
        ///
        /// GPIO port I bit 12
        ///
        public const Cpu.Pin GPIO_PIN_I_12 = (Cpu.Pin)140;
        ///
        /// GPIO port I bit 13
        ///
        public const Cpu.Pin GPIO_PIN_I_13 = (Cpu.Pin)141;
        ///
        /// GPIO port I bit 14
        ///
        public const Cpu.Pin GPIO_PIN_I_14 = (Cpu.Pin)142;
        ///
        /// GPIO port I bit 15
        ///
        public const Cpu.Pin GPIO_PIN_I_15 = (Cpu.Pin)143;

        public const Cpu.Pin GPIO_NONE = Cpu.Pin.GPIO_NONE;
    }

    public static class SerialPorts
    {
        public const string COM1 = "COM1";
        public const string COM2 = "COM2";
        public const string COM3 = "COM3";
        public const string COM4 = "COM4";
        public const string COM5 = "COM5";
        public const string COM6 = "COM6";
    }

    public static class BaudRates
    {
        public const BaudRate Baud9600 = BaudRate.Baudrate9600;
        public const BaudRate Baud19200 = BaudRate.Baudrate19200;
        public const BaudRate Baud38400 = BaudRate.Baudrate38400;
        public const BaudRate Baud57600 = BaudRate.Baudrate57600;
        public const BaudRate Baud115200 = BaudRate.Baudrate115200;
        public const BaudRate Baud230400 = BaudRate.Baudrate230400;
    }

    public static class ResistorModes
    {
        public const Port.ResistorMode PullUp = Port.ResistorMode.PullUp;
        public const Port.ResistorMode PullDown = Port.ResistorMode.PullDown;
        public const Port.ResistorMode Disabled = Port.ResistorMode.Disabled;
    }

    public static class InterruptModes
    {
        public const Port.InterruptMode InterruptEdgeLow = Port.InterruptMode.InterruptEdgeLow;
        public const Port.InterruptMode InterruptEdgeHigh = Port.InterruptMode.InterruptEdgeHigh;
        public const Port.InterruptMode InterruptEdgeBoth = Port.InterruptMode.InterruptEdgeBoth;
        public const Port.InterruptMode InterruptEdgeLevelHigh = Port.InterruptMode.InterruptEdgeLevelHigh;
        public const Port.InterruptMode InterruptEdgeLevelLow = Port.InterruptMode.InterruptEdgeLevelLow;
        public const Port.InterruptMode InterruptNone = Port.InterruptMode.InterruptNone;
    }

    public static class SPI_Devices
    {
        public const Microsoft.SPOT.Hardware.SPI.SPI_module SPI1 = Microsoft.SPOT.Hardware.SPI.SPI_module.SPI1;
        public const Microsoft.SPOT.Hardware.SPI.SPI_module SPI2 = Microsoft.SPOT.Hardware.SPI.SPI_module.SPI2;
        public const Microsoft.SPOT.Hardware.SPI.SPI_module SPI3 = Microsoft.SPOT.Hardware.SPI.SPI_module.SPI3;
    }

}
