using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    private int _difficulty;

    // Start is called before the first frame update
    void Start()
    {
        _difficulty = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetDifficulty()
    {
        return _difficulty;
    }

    public void SetDifficulty(int difficulty)
    {
        _difficulty = difficulty;
    }
}
