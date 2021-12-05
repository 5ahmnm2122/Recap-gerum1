using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetHit : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.FindWithTag("Gamemanager").GetComponent<ScoreManager>().RaiseScore();
        Destroy(this.gameObject);
    }
}
