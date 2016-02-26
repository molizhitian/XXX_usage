using UnityEngine;
public class PlayerProfile : MonoBehaviour
{

    [Space(10, order = 0)]
    [Header("Header with some space around it", order = 1)]
    [Space(40, order = 2)]//好像是控制Inspector面板距离的

    public string playerName = "Unnamed";
}