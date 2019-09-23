using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCharacterController : MonoBehaviour {
    /*
    *   Copyright(c) 2019 Tomohisa Handa
    *   Released under the MIT license
    *   https://github.com/YukinobuKurata/YouTubeMagicBuyButton/blob/master/MIT-LICENSE.txt
    */
    private Dictionary<string, SpriteRenderer> parts = new Dictionary<string, SpriteRenderer>();

    private string effectTag = "effect";

    private string frontHairTag = "frontHair";

    private string faceOptionTag = "faceOption";

    private string mouthTag = "mouse";

    private string bllowTag = "bllow";

    private string earTag = "ear";

    private string eyeTag = "eye";
    
    private string backHairTag = "backHair";

    private string bodyTag = "body";


    private void Awake() {
        for(int i = 0; i < transform.childCount; i++) {
            var part = transform.GetChild(i).gameObject;

            parts.Add(part.name, part.GetComponentInChildren<SpriteRenderer>());
        }
    }

    public Sprite Effect {
        get {
            parts.TryGetValue(effectTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(effectTag, out SpriteRenderer renderer);
            if(renderer!=null)
                renderer.sprite = value;
        }
    }

    public Sprite FrontHair {
        get {
            parts.TryGetValue(frontHairTag,out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(frontHairTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }

    public Sprite FaceOption {
        get {
            parts.TryGetValue(faceOptionTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(faceOptionTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }

    public Sprite Mouth {
        get {
            parts.TryGetValue(mouthTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(mouthTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }

    public Sprite Bllow {
        get {
            parts.TryGetValue(bllowTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(bllowTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }

    public Sprite Eye {
        get {
            parts.TryGetValue(faceOptionTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(faceOptionTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }

    public Sprite BackHair {
        get {
            parts.TryGetValue(backHairTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(backHairTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }

    public Sprite Body {
        get {
            parts.TryGetValue(bodyTag, out SpriteRenderer renderer);
            return renderer?.sprite;
        }
        set {
            parts.TryGetValue(bodyTag, out SpriteRenderer renderer);
            if(renderer != null)
                renderer.sprite = value;
        }
    }
}
