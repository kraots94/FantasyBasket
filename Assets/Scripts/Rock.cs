using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] private RockSO rockSO;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Renderer rockRenderer;

    public ElementType GetRockElementType()
    {
        return rockSO.type;
    }

    private void Start()
    {
        // change the color of the rock with the associated element color
        rockRenderer.material.color = rockSO.color;

        // play the element clip
        audioSource.PlayOneShot(rockSO.clip);
    }
}
