using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets;
using osu.Game.Rulesets.Mania;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.Mania.UI;
using osu.Game.Overlays;
using osu.Game.Overlays.Notifications;
using osu.Game.Rulesets.Scratch.Beatmaps;

namespace osu.Game.Rulesets.Scratch
{
    public partial class ScratchRuleset : ManiaRuleset
    {
        public override string Description => "osu!ScratchBase - preparing for osu!fusion";
        public override string ShortName => "scratchbase";

        //public override int? RulesetID => 9000;

        public ScratchRuleset() : base()
        {
        }

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) =>
            new ScratchBeatmapConverter(beatmap, this);

        public override DrawableRuleset CreateDrawableRulesetWith(IBeatmap beatmap, IReadOnlyList<Mod>? mods = null) =>
            new DrawableManiaRuleset(this, beatmap, mods);

        public override Drawable CreateIcon() => new ScratchIcon();

        public partial class ScratchIcon : SpriteIcon
        {
            public ScratchIcon()
            {
                Icon = FontAwesome.Solid.Cat;
            }

            [BackgroundDependencyLoader(true)]
            private void load(INotificationOverlay? notifications)
            {
                notifications?.Post(new SimpleNotification
                {
                    Text = "😺 ScratchBase has been discovered!",
                    Icon = FontAwesome.Solid.Cat
                });
            }
        }
    }
}
