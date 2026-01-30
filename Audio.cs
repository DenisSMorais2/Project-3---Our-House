// CollisionSound.cs
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollisionSound : MonoBehaviour
{
    private AudioSource audioSource;
    public float minImpact = 0.5f;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > minImpact)
        {
            audioSource.Play();
        }
    }
}