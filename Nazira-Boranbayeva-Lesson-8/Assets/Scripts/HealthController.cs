using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _health;
    [SerializeField] private float _fillSpeed;
    private float _healthPersents;
    // Start is called before the first frame update
    void Start()
    {
        _healthPersents = _health / 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        _healthBar.value = Mathf.Lerp(_healthBar.value, _healthPersents, _fillSpeed * Time.deltaTime);
        
    }

    public void MakeDamage(float damage){
        if (_health > 0){
            _health -= damage;
        }
        else {
            _health = 100;
        }

        _healthPersents = _health / 100;
        
    }
}
