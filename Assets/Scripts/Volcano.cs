using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : MonoBehaviour
{
    [SerializeField] RockSO rockSO;
    [SerializeField] AudioClip rightEffect;
    [SerializeField] AudioClip wrongEffect;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Renderer lavaRenderer;

    private ElementType myElementType;

    private void Start()
    {
        lavaRenderer.material.color = rockSO.color;

        myElementType = rockSO.type;
    }

    private void OnTriggerEnter(Collider other)
    {
        Rock rock = other.GetComponent<Rock>();

        // if it is a rock
        if(rock != null)
        {
            if (rock.GetRockElementType() == myElementType)
            {
                // correct rock is thrown
                audioSource.PlayOneShot(rightEffect);
                GameManager.Instance.CorrectThrow();
            }
            else
            {
                // wrong rock is thrown
                audioSource.PlayOneShot(wrongEffect);
                GameManager.Instance.WrongThrow();
            }
        }
    }
}
