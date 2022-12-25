using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    [SerializeField] private Text counterText;
    private int _score=0;

    // Update is called once per frame
    void FixedUpdate()
    {
        ShowKills();
    }

    private void ShowKills()
    {
        counterText.text = _score.ToString();
    }

    public void AddPoints()
    {
        _score += 50;
    }
    public int ReturnPoints()
    {
        return _score;
    }
}
