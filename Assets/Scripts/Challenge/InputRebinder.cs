using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputRebinder : MonoBehaviour
{
    public InputActionAsset actionAsset;
    private InputAction spaceAction;

    void Start()
    {
        // [�������� 1] actionAsset���� Space �׼��� ã�� Ȱ��ȭ�մϴ�.
        spaceAction = actionAsset.actionMaps[0].FindAction("Boost");
        spaceAction.Enable();
    }

    // [�������� 2] ContextMenu ��Ʈ����Ʈ�� Ȱ���ؼ� �ν�����â���� ������ �� �ֵ��� ��
    [ContextMenu("Process RebindSpaceToEscape Method")]
    public void RebindSpaceToEscape()
    {
        if (spaceAction == null)
            return;

        // [�������� 3] ���� ���ε��� ��Ȱ��ȭ�ϰ� �� Ű�� ����ε�

        // ���� ���ε� ��Ȱ��ȭ -> ���ο� ���ε� �߰��Ͽ� ���� �� Ȱ��ȭ?
        spaceAction.AddBinding("<Keyboard>/escape");

        // ���� ���ε� -> Ű �� ���游?
        spaceAction.ChangeBinding(0).WithPath("<Keyboard>/escape");

        Debug.Log("Done!");
    }

    void OnDestroy()
    {
        // �׼��� ��Ȱ��ȭ�մϴ�.
        spaceAction?.Disable();
    }
}
