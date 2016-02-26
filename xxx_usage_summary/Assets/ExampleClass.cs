using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    [Tooltip("Health value between 0 and 100.")]//鼠标Hover属性时会有提示
    public int health = 0;
}