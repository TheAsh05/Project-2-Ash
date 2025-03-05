using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class HealthDecrease : UsableItem.UsageEffect
{
    public int HealthAmount;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthAmount);
        return true;
    }
}
