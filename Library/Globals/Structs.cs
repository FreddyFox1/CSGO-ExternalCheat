namespace Engine.Globals
{
    public static class Structs
    {
        /// <summary>
        /// Glow effect in CSGO
        /// </summary>
        public class GlowEffects
        {
            public float colorRed { get; set; } = 1;
            public float colorGreen { get; set; } = 1;
            public float colorBlue { get; set; } = 0;
            public float colorAlpha { get; set; } = 1;
            public bool rwo { get; set; } = true;
            public bool rwuo { get; set; } = true;
        }
    }
}
