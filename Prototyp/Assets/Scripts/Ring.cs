using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RingElement", menuName = "RingMenu/Radial", order = 1)]

public class Ring : ScriptableObject
{
    public RingElement[] Elements;
}
