using System.Threading;
using System.Threading.Tasks;
using BetterSongList.Interfaces;
using BetterSongList.SortModels;
using UnityEngine;

namespace BetterSongList_RandomSort.Classes;

internal class RandomSorter : ISorterPrimitive, ITransformerPlugin
{
    public string name => "Random";
    public bool visible => true;
    public bool isReady => true;

    public Task Prepare(CancellationToken cancelToken) => Task.CompletedTask;
    
#if V1_29_1
    public float? GetValueFor(IPreviewBeatmapLevel level)
#else
    public float? GetValueFor(BeatmapLevel level)
#endif
    {
        return Random.Range(float.MinValue, float.MaxValue);
    }

#if V1_29_1
    public void ContextSwitch(SelectLevelCategoryViewController.LevelCategory levelCategory, IAnnotatedBeatmapLevelCollection? playlist)
#else
    public void ContextSwitch(SelectLevelCategoryViewController.LevelCategory levelCategory, BeatmapLevelPack? playlist)
#endif
    {
        // do nothing
    }
}