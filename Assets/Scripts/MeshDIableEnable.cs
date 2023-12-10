using UnityEngine;

public class MeshDisableEnable : MonoBehaviour
{
    public void ToggleMesh()
    {
        if(this.gameObject.activeInHierarchy)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
}
