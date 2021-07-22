using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelEventSystemsCaller : MonoBehaviour
{
    public GameObject targetObj;

    void Start()
    {
        DoMyEvent();
    }

    /// <Summary>
    /// EventSystems���g�p���ăC�x���g�����s���܂��B
    /// </Summary>
    void DoMyEvent()
    {
        NotifyEvent(targetObj);
    }

    /// <Summary>
    /// �Ώۂ̃I�u�W�F�N�g�ɃC�x���g��ʒm���܂��B
    /// </Summary>
    /// <param name="targetObj">�Ώۂ̃I�u�W�F�N�g</param>
    void NotifyEvent(GameObject targetObj)
    {
        ExecuteEvents.Execute<IEventCaller>(
                        target: targetObj,
                        eventData: null,
                        functor: CallMyEvent
                        );
    }

    /// <Summary>
    /// ���̃C�x���g�Ŏw�肷��C���^�t�F�[�X�̃��\�b�h�ł��B
    /// </Summary>
    void CallMyEvent(IEventCaller inf, BaseEventData eventData)
    {
        inf.EventCall();
    } 
}