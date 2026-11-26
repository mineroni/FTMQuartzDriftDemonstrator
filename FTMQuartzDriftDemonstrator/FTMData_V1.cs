using System.Globalization;
using System.Numerics;

namespace FTMQuartzDriftDemonstrator;
internal class FTMData_V1
{
    public uint status { get; init; }
    public uint estimatedDistance { get; init; }
    public uint rttEstimated { get; init; }
    
    public Color statusColor => getColorOfField(status, colorFieldConnector.status);
    public Color estimatedDistanceColor => getColorOfField(estimatedDistance, colorFieldConnector.estimatedDistance);
    public Color rttEstimatedColor => getColorOfField(rttEstimated, colorFieldConnector.rttEstimated);

    private enum colorFieldConnector { status, estimatedDistance, rttEstimated}

    private static Dictionary<colorFieldConnector, List<(int, Color)>> colorDictionary = new()
    {
        {
            colorFieldConnector.status,
            new()
            {
                (1, Color.Green),
                (5, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
        {
            colorFieldConnector.estimatedDistance,
            new()
            {
                (200, Color.Green),
                (400, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
        {
            colorFieldConnector.rttEstimated,
            new()
            {
                (13, Color.Green),
                (26, Color.Orange),
                (int.MaxValue, Color.Red),
            }
        },
    };


    internal FTMData_V1(string serialLine)
    {
        try
        {
            //I (29045) ftm_demo: FTM report: status=0, dist_est=120 cm, rtt_est=8 ns
            string dataSection = serialLine.Split(':')[^1];
            if (dataSection.Length < 35)
                throw new ArgumentException("Invalid serial line format");
            status = uint.Parse(dataSection.Split('=')[1].Split(',')[0].Trim());
            estimatedDistance = uint.Parse(dataSection.Split('=')[2].Split(' ')[0].Trim());
            rttEstimated = uint.Parse(dataSection.Split('=')[3].Split(' ')[0].Trim());
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
