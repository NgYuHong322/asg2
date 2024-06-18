using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    private AudioClip collectAudio;

    public virtual int GetScoreValue()
    {
        return 0; // Default score, should be overridden by child classes
    }

    public void Collected(Player player)
    {
        
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        GameManager.Instance.IncreaseScore(GetScoreValue());
        Destroy(gameObject); // destroy gameobject when collected
    }
}
