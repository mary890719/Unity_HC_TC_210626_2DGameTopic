using UnityEngine;
using UnityEngine.SceneManagement;  // �ޥ� �����޲z API

public class SceneController : MonoBehaviour
{
    // Unity �L�k���W�}������j��]
    // 1. �}����������L�C�A����@��
    // 2. ���O�P�ɮצW�٤��P

    // Unity ���s�p��P�}�����q
    // 1. ���}����k
    // 2. �ݭn���骫�󱾦��}��

    /// <summary>
    /// ���J�C������
    /// </summary>
    public void LoadGameScene()
    {
        // �����A���J����
        // ����I�s(��k�W�١A����ɶ�)
        // �@�ΡG���ݫ��w�ɶ���A�I�s���w��k
        Invoke("DelayLoadGameScene", 2);        
    }

    // ���ݤ@�q�ɶ��b�����k
    // Invoke ����I�s
    /// <summary>
    /// ������J����
    /// </summary>
    private void DelayLoadGameScene() 
    {
        // �����޲z.���J����(�����W��) - ���J���w������
        SceneManager.LoadScene("�C������");
    }

    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Invoke("DelayQuitGame", 2);
    }
    
    /// <summary>
    /// �������}�C��
    /// </summary>
    private void DelayQuitGame() 
    {
        Application.Quit();     //���ε{��.���}() - �����C��
        print("���}�C��");       // Quit �b�s�边�����|����
    }        
}
