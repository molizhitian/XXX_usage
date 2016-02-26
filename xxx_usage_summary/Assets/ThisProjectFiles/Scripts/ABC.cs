using UnityEngine;
using System.Collections;

public class ABC : MonoBehaviour{

    [SerializeField]
    int aaa = 3;//在Inspector版面中显示非public属性，并且序列化；若写在public前面，等于没写……（至于序列化是啥，自行脑补……）

    [System.NonSerialized]
    public int bbb;//在Inspector版面中隐藏public属性，并且序列化；如果写在非public属性前面，等于没写……

    [HideInInspector]
    public int ccc;//在Inspector版面中隐藏public属性，与上面相比，只是隐藏，没有序不序列化的功能……
    
}

