using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StarMove : MonoBehaviour
{
    [SerializeField] private GameObject _star;
    private Vector3 _startPos = new Vector3(-310f, 170f, 370f);
    private Vector3 _endPos = new Vector3(-310f, 120f, -400);

    private void Start()
    {
        _star.transform.position = _startPos;
        StartCoroutine(Move());

    }

    private IEnumerator Move()
    {
        yield return new WaitForSeconds(3f);
        MoveStar();
        yield return new WaitForSeconds(2f);
        _star.transform.position = _startPos;
        StartCoroutine(Move());
    }

    private void MoveStar()
    {
        _star.transform.position = Vector3.Lerp(_startPos, _endPos, 2f);
    }
}
