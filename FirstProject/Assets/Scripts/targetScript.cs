using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    [SerializeField] float hitPrize = 0;
    public GameObject GO;
    void Start()
    {
        StartCoroutine(cycleGenerator());
    }

    void Update()
    {
        
    }

    IEnumerator cycleGenerator()
    {
        while (true)
        {
            GameObject newCycle = Instantiate(GO, new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0), Quaternion.identity);
            Destroy(newCycle, 7);
            yield return new WaitForSeconds(5);
        }
    }

    void OnMouseDown()
    {

        Destroy(gameObject);
        hitPrize += 20;
        Debug.Log("You have earned new score!, your currnet score is equal to = "+ hitPrize);

    }
}
