using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmationBehaviour : MonoBehaviour
{
    [SerializeField] private Image _maskConfirmationCircle;
    [SerializeField] private GameObject _cube;
    private bool _isPlayerPressing;
    private float _pressingTimeElapsed;

    [SerializeField] private float _maxTimePressing;

    void Start()
    {
        _cube.SetActive(true);
    }

    void Update()
    {
        if (_pressingTimeElapsed < _maxTimePressing)
        {
            if (_isPlayerPressing)
            {
                _pressingTimeElapsed += Time.deltaTime;
            }
            else if(!_isPlayerPressing && _pressingTimeElapsed > 0)
            {
                _pressingTimeElapsed -= Time.deltaTime;
            }
        }
        else if(_pressingTimeElapsed >= _maxTimePressing)
        {
            _cube.SetActive(!_cube.activeSelf);
            _pressingTimeElapsed = 0;
            _isPlayerPressing = false;
        }

        _maskConfirmationCircle.fillAmount = (_pressingTimeElapsed / _maxTimePressing);


    }

    public void MouseDown()
    {
        Debug.Log("Mouse down void");
        _isPlayerPressing = true;
    }

    public void MouseUp()
    {
        Debug.Log("Mouse up void");
        _isPlayerPressing = false;
    }
}
