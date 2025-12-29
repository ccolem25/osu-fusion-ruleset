using System.Collections.Generic;
using System.Threading;
using osu.Game.Beatmaps;
using osu.Game.Rulesets;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Mania.Beatmaps;
using osu.Game.Rulesets.Mania.Objects; // Required for ManiaHitObject

namespace osu.Game.Rulesets.Scratch.Beatmaps
{
    public class ScratchBeatmapConverter : ManiaBeatmapConverter
    {
        public ScratchBeatmapConverter(IBeatmap beatmap, Ruleset ruleset)
            : base(beatmap, ruleset)
        {
        }

        // FIX: Changed return type from IEnumerable<HitObject> to IEnumerable<ManiaHitObject>
        protected override IEnumerable<ManiaHitObject> ConvertHitObject(HitObject original, IBeatmap beatmap, CancellationToken cancellationToken)
        {
            // The base call also returns IEnumerable<ManiaHitObject>, so this now matches perfectly
            return base.ConvertHitObject(original, beatmap, cancellationToken);
        }
    }
}