using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    protected override void Talk()
    {
        Debug.Log("Im a Mystic Wizard");
        this.textField.text = "Im a Mystic Wizard";
        audioSource.PlayOneShot(soundEffects[0]);
    }

    protected override void UseAbility()
    {
        Debug.Log("Thunder Bolt ! BzZzzZ");
        this.textField.text = "Thunder Bolt! BzZzzZ";
        audioSource.PlayOneShot(soundEffects[1]);
    }

    protected override void UseAbility2()
    {
        Debug.Log("Teleport ! Im now out out your sight");
        this.textField.text = "Teleport ! Im now out out your sight";
        audioSource.PlayOneShot(soundEffects[2]);
    }
}
