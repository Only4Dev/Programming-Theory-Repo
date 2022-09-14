using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Character
{
    // Polymorphism
    protected override void Talk()
    {
        Debug.Log("Roar im ij orc !");
        this.textField.text = "Roar im ij orc !";
        audioSource.PlayOneShot(soundEffects[0]);
    }

    // Polymorphism
    protected override void UseAbility()
    {
        Debug.Log("Asht kopuk smash! YEEARG !");
        this.textField.text = "Asht kopuk smash! YEEARG !";
        audioSource.PlayOneShot(soundEffects[1]);
    }

    // Polymorphism
    protected override void UseAbility2()
    {
        Debug.Log("Throwing axes ! Lat dont gonna ozon !");
        this.textField.text = "Lat dont gonna ozon !";
        audioSource.PlayOneShot(soundEffects[2]);
    }
}
