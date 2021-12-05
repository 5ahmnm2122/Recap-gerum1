using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text counterText;
    [SerializeField] int scoreCount;
    [SerializeField] GameObject winText;
    [SerializeField] GameObject shootingSound;

    public void RaiseScore()
    {
        scoreCount++;
        shootingSound.GetComponent<AudioSource>().Play();
        counterText.text=scoreCount.ToString();
        if (scoreCount==10) {
            winText.SetActive(true);
            Destroy(this.gameObject);
        }

    }
}
