using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int _score;
    public Text _scoreComponent;

    private void Start()
    {
        _score = 0;
        _scoreComponent = transform.GetComponent<Text>();
        _scoreComponent.text = "0";
    }

    public void AddScorePoint()
    {
        _score += 10;
        _scoreComponent.text = _score.ToString();
    }
}
