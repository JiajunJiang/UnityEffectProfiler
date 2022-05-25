using UnityEngine;

namespace Editor
{
    public class ParticleInfo : ScriptableObject
    {
        public string particleName;
        public string particlePath;

        public int textureMemory;
        public int textureCount;

        public AnimationCurve drawCall = new AnimationCurve();
        public AnimationCurve overDraw = new AnimationCurve();
    }
}