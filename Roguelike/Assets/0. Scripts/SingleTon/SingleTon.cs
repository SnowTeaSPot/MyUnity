using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class SingleTon<T> : MonoBehaviour where T : SingleTon<T>
{
    private static T instance = null;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                // 인스턴스 찾기.
                instance = FindObjectOfType<T>();

                if (instance == null)
                {
                    // 오브젝트 생성
                    GameObject obj = new GameObject(typeof(T).Name);

                    // 생성한 오브젝트에 T 타입의 컴포넌트를 할당.
                    instance = obj.AddComponent<T>();
                }
            }

            // 이미 존재한다면 그냥 반환(이미 있잖아.)
            // 존재하지 않는다면 한번 찾아보고(오류 방지), 그래도 없으면 새로 생성함.
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            // 인스턴스를 미리 넣어주는 작업
            // -> Instance 프로퍼티를 통해 접근 시 객체를 찾거나 생성하는 과정을 생략한다.
            instance = this as T;

            DontDestroyOnLoad(gameObject);

        }
        // 인스턴스가 있다면?
        else
        {
            // 파라미터로 넘긴 게임 오브젝트를 파괴.
            Destroy(gameObject);
        }
    }
}
