using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour

{
    
    [SerializeField] private Slider _slider;
    [SerializeField] private Animator _animator; 
     
    public void ChangeMovementParameter(){
        _animator.SetFloat("MovementSpeed", _slider.value * 1.8f);
        Debug.Log(_slider.value * 1.8f);
    }

    public void DanceRumba(){
        _animator.SetTrigger("Rumba");
    }

    public void DanceSillyDance(){
        _animator.SetTrigger("SillyDance");

    }
    
    public void Jump(){
        _animator.SetTrigger("Jump");

    }
    }
