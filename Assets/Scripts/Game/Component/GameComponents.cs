using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Game
{
    /// <summary>
    /// �������״̬ ���ݴ�״̬�ĸı䲥���������
    /// </summary>
    [Game,Event(EventTarget.Self),Unique]
    public class CameraState : IComponent
    {
        public CameraAniName State;
    }

 
}