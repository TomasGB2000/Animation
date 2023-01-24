using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public Animator SecondCharacterAnimator;
    public CameraFollow cameraFollow;
    public GameObject npcCharacter;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Player")
        {
        SecondCharacterAnimator.SetBool("isTriggered", true);
        other.GetComponent<PlayerMovement>().enabled = false;
        other.GetComponent<Animator>().SetBool("isWalking", false);
        cameraFollow.target = npcCharacter.transform;

        }
    }
}
