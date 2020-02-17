using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetramino : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Tetraminoes;
    void Start()
    {
        NewTetramino();
    }

    // Update is called once per frame
    public void NewTetramino()
    {
        Instantiate(Tetraminoes[Random.Range(0, Tetraminoes.Length)], transform.position, Quaternion.identity);
    }
}
