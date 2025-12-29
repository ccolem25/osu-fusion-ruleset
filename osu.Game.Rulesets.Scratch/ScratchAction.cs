using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Scratch
{
    // Defines the 10 distinct input actions for the Scratch mode (6 VSRG + 4 Taiko)
    public enum ScratchAction
    {
        // ===================================
        // 1. MANIA CORE KEYS (VSRG Lanes) - 6 Keys
        // ===================================
        VSRG_Key1 = 0,
        VSRG_Key2 = 1,
        VSRG_Key3 = 2,
        VSRG_Key4 = 3,
        VSRG_Key5 = 4,
        VSRG_Key6 = 5,
        
        // ===================================
        // 2. TAIKO SCRATCH KEYS (Drum Inputs) - 4 Keys
        // ===================================
        Scratch_OuterLeft = 6,
        Scratch_InnerLeft = 7,
        Scratch_InnerRight = 8,
        Scratch_OuterRight = 9
        
        // YOUR CODE GOES HERE (Optional: Add special actions, like a dedicated scratch FX button)
    }
}