using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class StrengthEquipEffect : EquipmentItem.EquippedEffect
{
     private StatSystem.StatModifier strengthModifier;
     public override void Equipped(CharacterData user)
     {
          if (strengthModifier == null)
          {
               strengthModifier = new StatSystem.StatModifier
               {
                    ModifierMode = StatSystem.StatModifier.Mode.Absolute,
                    Stats = new StatSystem.Stats { strength = 1 }
               };
          }

          user.Stats.AddModifier(strengthModifier);
     }
     
     public override void Removed(CharacterData user)
     {
          if (strengthModifier != null)
          {
               user.Stats.RemoveModifier(strengthModifier);
          }
     }
}
