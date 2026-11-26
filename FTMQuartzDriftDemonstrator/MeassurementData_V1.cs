using System.Globalization;
using System.Numerics;

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
    public Color initiatorTempColor => getColorOfField(initiatorTempCelsius, colorFieldConnector.Temp);
    public Color responderTempColor => getColorOfField(responderTempCelsius, colorFieldConnector.Temp);
    public Color compPPMColor => getColorOfField(compPPM, colorFieldConnector.compValue);
    public Color quartzDriftColor => getColorOfField(currentQuartzDriftPPM, colorFieldConnector.quartzDrift);
    public Color rssiColor => getColorOfField(rssi, colorFieldConnector.rssi);

    private enum colorFieldConnector { Temp, compValue, quartzDrift, rssi}

    private static Dictionary<colorFieldConnector, List<(int, Color)>> colorDictionary = new()
    {
        {
            colorFieldConnector.Temp,
            new()
            {
                (45, Color.Green),
                (65, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
        {
            colorFieldConnector.compValue,
            new()
            {
                (10, Color.Green),
                (20, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
        {
            colorFieldConnector.quartzDrift,
            new()
            {
                (2, Color.Green),
                (4, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
        {
            colorFieldConnector.rssi,
            new()
            {
                (10, Color.Green),
                (20, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
    };


    internal MeassurementData_V1(string serialLine)
    {
        string[] lineParts = serialLine.Split(';');
        if (lineParts.Length != expectedPartsCount+1)
            throw new ArgumentException("Invalid serial line format");
        try
        {
            //data;28724226;6;10;83887409767429;28612659256457;28612745530208;83887496049304;8124;43;-4.603296;43;3.040762
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

    private static Color getColorOfField<T>(T value, colorFieldConnector keyOfDict) where T : INumber<T>
    {
        List<(int, Color)> listOfColors = colorDictionary[keyOfDict];
        if (listOfColors is null)
            return Color.Black;

        int i = 0;
        while (i < listOfColors.Count)
        {
            if (value < T.CreateChecked(listOfColors[i].Item1))
                return listOfColors[i].Item2;
            ++i;
        }
        return Color.Black;
    }
}
