using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Character : MonoBehaviour // Parent Character Class
{

    // Encapsulation
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected TMP_Text textField;
    [SerializeField] protected AudioClip[] soundEffects;

    protected abstract void Talk();


    protected abstract void UseAbility();


    protected abstract void UseAbility2();

}
