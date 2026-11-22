using System.Globalization;

namespace FTMQuartzDriftDemonstrator;
internal class MeassurementData_V1
{
    const int expectedPartsCount = 12;
    public double timeSec { get; init; }
    public uint dialogToken { get; init; }
    public int rssi { get; init; }

    public ulong t1 { get; init; }
    public ulong t2 { get; init; }
    public ulong t3 { get; init; }
    public ulong t4 { get; init; }

    public uint rtt { get; init; }
    public int initiatorTempCelsius { get; init; }
    public double compPPM { get; init; }
    public int responderTempCelsius { get; init; }
    public double currentQuartzDriftPPM { get; init; }

    internal MeassurementData_V1(string serialLine)
    {
        string[] lineParts = serialLine.Split(';');
        if (lineParts.Length != expectedPartsCount+1)
            throw new ArgumentException("Invalid serial line format");
        try
        {
            timeSec = ulong.Parse(lineParts[1]) / 1000000.0;
            dialogToken = uint.Parse(lineParts[2]);
            rssi = int.Parse(lineParts[3]);
            t1 = ulong.Parse(lineParts[4]);
            t2 = ulong.Parse(lineParts[5]);
            t3 = ulong.Parse(lineParts[6]);
            t4 = ulong.Parse(lineParts[7]);
            rtt = uint.Parse(lineParts[8]);
            initiatorTempCelsius = int.Parse(lineParts[9]);
            compPPM = double.Parse(lineParts[10], CultureInfo.InvariantCulture);
            responderTempCelsius = int.Parse(lineParts[11]);
            currentQuartzDriftPPM = double.Parse(lineParts[12], CultureInfo.InvariantCulture);
        }
        catch (FormatException ex)
        {
            throw new ArgumentException("Invalid serial line format", ex);
        }
    }
}
