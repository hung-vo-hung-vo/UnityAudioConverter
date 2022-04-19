using UnityEngine;

namespace HerbiDino.Audio
{
    public class HDDistortionEffectSO : HDAudioEffectSO
    {
        public override HDEffectType Type => HDEffectType.Distortion;
        [SerializeField] private float distortionLevel;

        public override Component CreateFilter(GameObject audioSource)
        {
            var filter = audioSource.AddComponent(typeof(AudioDistortionFilter)) as AudioDistortionFilter;

            filter.distortionLevel = distortionLevel;

            return filter;
        }
    }
}