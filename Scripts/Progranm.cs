using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progranm : MonoBehaviour
{
    [SerializeField] private GameObject _cat1;
    [SerializeField] private GameObject _cat2;
    [SerializeField] private GameObject _cat3;
    [SerializeField] private GameObject _cat4;
    [SerializeField] private GameObject _cat5;
    [SerializeField] private GameObject _cat6;
    [SerializeField] private GameObject _cat7;

    private int[] _cats = new int[7];
    private int _rand;

    void Start()
    {
        _cat1.SetActive(false);
        _cat2.SetActive(false);
        _cat3.SetActive(false);
        _cat4.SetActive(false);
        _cat5.SetActive(false);
        _cat6.SetActive(false);
        _cat7.SetActive(false);
        _cats = new int[] {0, 1, 2, 3, 4, 5, 6};
        _rand = Random.Range(_cats[0], _cats[6]);
        Debug.Log(_rand);
    }

    void Update()
    {
        if (_rand == _cats[0])
        {
            _cat1.SetActive(true);
        }
        else if(_rand == _cats[1])
        {
            _cat2.SetActive(true);
        }
        else if (_rand == _cats[2])
        {
            _cat3.SetActive(true);
        }
        else if (_rand == _cats[3])
        {
            _cat4.SetActive(true);
        }
        else if (_rand == _cats[4])
        {
            _cat5.SetActive(true);
        }
        else if (_rand == _cats[5])
        {
            _cat6.SetActive(true);
        }
        else if (_rand == _cats[6])
        {
            _cat7.SetActive(true);
        }
    }
}