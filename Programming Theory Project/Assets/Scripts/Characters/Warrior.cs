using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    protected override void Talk()
    {
        Debug.Log("Im a Brave Warrior");
        this.textField.text = "Im a Brave Warrior";
        audioSource.PlayOneShot(soundEffects[0]);

    }

    protected override void UseAbility()
    {
        Debug.Log("Power Slash! HYAAAAT");
        this.textField.text = "Power Slash! Swoosh!";
        audioSource.PlayOneShot(soundEffects[1]);
    }

    protected override void UseAbility2()
    {
        Debug.Log("Battle Roar! Im ready to fight!");
        this.textField.text = "Battle Roar! Im ready to fight!";
        audioSource.PlayOneShot(soundEffects[2]);
    }
}
