using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class StrengthEquipEffect : EquipmentItem.EquippedEffect
{     
     private StatSystem.StatModifier strengthModifier;
     private StatSystem.StatModifier appliedModifier; // Store the applied modifier

     public override void Equipped(CharacterData user)
     {
          if (strengthModifier == null)
          {
               strengthModifier = new StatSystem.StatModifier
               {
                    ModifierMode = StatSystem.StatModifier.Mode.Absolute,
                    Stats = new StatSystem.Stats { strength = 100 }
               };
          }
          // Create and set up a new stat modifier
          StatSystem.StatModifier myStatModifier = new StatSystem.StatModifier();
          myStatModifier.Stats.agility = 10; // Set agility stat modification

          // Apply modifiers to the user
          user.Stats.AddModifier(strengthModifier);
          user.Stats.AddModifier(myStatModifier);

          // Save the applied modifier for later removal
          appliedModifier = myStatModifier;
     }
     
     public override void Removed(CharacterData user)
     {
          if (strengthModifier != null)
          {
               user.Stats.RemoveModifier(strengthModifier);
          }

          if (appliedModifier != null)
          {
               user.Stats.RemoveModifier(appliedModifier); // Remove agility modifier
          }
     }
}
