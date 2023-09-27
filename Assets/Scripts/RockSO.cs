using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class RockSO : ScriptableObject
{
    public ElementType type;
    public Color color;
    public AudioClip clip;
}
