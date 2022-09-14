using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    public Transform[] character;

    public void Talk(int characterIndex)
    {
        character[characterIndex].SendMessage("Talk");
    }
    public void UseAbility(int characterIndex)
    {
        character[characterIndex].SendMessage("UseAbility");
    }
    public void UseAbility2(int characterIndex)
    {
        character[characterIndex].SendMessage("UseAbility2");
    }
}
