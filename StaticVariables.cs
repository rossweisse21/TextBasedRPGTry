using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBased
{
    public class StaticVariables
    {
        public static float RaceCalculator(ClassMultiplier _multiplier)
        {
            float rv = 0.0f;
            float ad = 0.0f;

            switch (_multiplier)
            {
                case ClassMultiplier.Human: rv = GameSettingValues.HumanHP; break;
                case ClassMultiplier.Skeleton: rv = GameSettingValues.SkeletonHP; break;

            }

            switch (_multiplier)
            {
                case ClassMultiplier.Human: ad = GameSettingValues.HumanAttack; break;
                case ClassMultiplier.Skeleton: ad = GameSettingValues.SkeletonAttack; break;
            }

            return rv;


        }
        public enum ClassMultiplier
        {
            Human, Skeleton
        }

    }

}
