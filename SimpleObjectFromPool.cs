using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectFromPool : MonoBehaviour, IPooledObject
{
    [SerializeField]
    private float timeToUnspawn = 0.5f;

    public void OnObjectSpawn()
    {
        StartCoroutine(Unspawn());
    }

    private IEnumerator Unspawn() 
    {
        yield return new WaitForSeconds(timeToUnspawn);

        gameObject.SetActive(false);
    }
}
