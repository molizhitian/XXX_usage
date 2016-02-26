using UnityEngine;
using System.Collections;

[ExecuteInEditMode]//在编辑界面让你的功能（类）起作用，就是你不用点开始，就可你让你的功能起作用，打个比方，NGUI里面的Slider的滑动条就是酱紫……
[RequireComponent(typeof(Rigidbody))]//就是在你把被这句话标记的类拖到（或者AddComponent）GameObject上时，自动再给你加上“ClassName”这个类……
public class TestWolf : MonoBehaviour {

    
    public int wolf = 0;

    void Start()
    {
        wolf = 5;
    }

    [ContextMenu("Wolf")]//在Inspector版面中，右击包含这条标记的类，在菜单中会出现名为“XXX”的选项，点击选项，会执行被标记的功能（注：此乃标记功能也，非标记类）,只是个例子，名字乱写了的……一般来说“XXX”就是被执行的功能的名字，方便查找……
    void CaoNiMa()
    {
        wolf += 7;
    }
}
