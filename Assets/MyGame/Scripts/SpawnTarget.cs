using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab ;
    [SerializeField] GameObject canvas ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargetFunction());
    }
    IEnumerator SpawnTargetFunction()
    {
        int positionX = Random.Range(-960/2, 960/2);
        int positionY = Random.Range(-600/2, 600/2);
        GameObject targetInstance = Instantiate(targetPrefab, canvas.transform);
        targetInstance.GetComponent<RectTransform>().localPosition = new Vector2(positionX, positionY);
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnTargetFunction());
    }
}
