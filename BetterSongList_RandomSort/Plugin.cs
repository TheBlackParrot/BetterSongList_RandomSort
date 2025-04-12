using BetterSongList_RandomSort.Classes;
using BetterSongList;
using IPA;
using JetBrains.Annotations;
using IPALogger = IPA.Logging.Logger;

namespace BetterSongList_RandomSort;

[Plugin(RuntimeOptions.SingleStartInit)]
[NoEnableDisable]
[UsedImplicitly]
internal class Plugin
{
    private static RandomSorter RandomSorterInstance => new();
    private static IPALogger Log { get; set; } = null!;

    [Init]
    public Plugin(IPALogger logger)
    {
        Log = logger;
        
        SortMethods.RegisterPrimitiveSorter(RandomSorterInstance);
        Log.Info("Plugin loaded");
    }
}