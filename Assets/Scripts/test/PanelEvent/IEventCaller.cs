using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <Summary>
/// EventSystems�Ŏg�p����C���^�t�F�[�X�ł��B
/// </Summary>
public interface IEventCaller : IEventSystemHandler
{
    // �C�x���g���Ăяo�����\�b�h�ł��B
    void EventCall();
}