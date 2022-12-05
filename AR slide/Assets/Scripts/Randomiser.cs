using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomiser : MonoBehaviour
{
    public GameObject[] puzzleTiles;
    public GameObject[] puzzlePoints;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(RandomiseCubes);
        RandomiseCubes();
    }

    private void RandomiseCubes()
    {
        List<GameObject> tileHolder = new List<GameObject>();
        List<GameObject> spawnHolder = new List<GameObject>();

        foreach (GameObject i in puzzleTiles)
        {
            tileHolder.Add(i);
        }

        spawnHolder.AddRange(tileHolder);

    }
}
