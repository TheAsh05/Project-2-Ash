using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class EffectName : UsableItem.UsageEffect
{
    public int HealthAmount2;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthAmount2);
        return true;
    }
}
