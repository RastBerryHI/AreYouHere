using UnityEngine.Events;
using UnityEngine;

public class GenericEvents : MonoBehaviour
{
    public static GenericEvents s_instance;

    public UnityEvent onStartPickCode;
    public UnityEvent onEndPickCode;
    public UnityEvent onSuccessPickCode;
    public UnityEvent<Transform> onGetCameraPosition;

    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            Destroy(s_instance.gameObject);
        }

        DontDestroyOnLoad(gameObject);

        onStartPickCode ??= new UnityEvent();
        onEndPickCode ??= new UnityEvent();
        onGetCameraPosition ??= new UnityEvent<Transform>();
    }
}
