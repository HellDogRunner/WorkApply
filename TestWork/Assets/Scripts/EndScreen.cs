using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private Canvas losescreen;
    [SerializeField] private Canvas winCanvas;
    private GameObject _player;
    private Health _playerHealth;
    private KillCounter _killCounter;
    private int _score;
    private float _health;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _killCounter = _player.GetComponent<KillCounter>();
        _playerHealth = _player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        _score = _killCounter.ReturnPoints();
        _health = _playerHealth.GetHealth();
        if (_score>=500)
        {
            winCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (_health<=0)
        {
            losescreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
