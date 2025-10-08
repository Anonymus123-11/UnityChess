using UnityEngine;
using UnityEngine.UI;

public class CapturedPiecesUI : MonoBehaviour
{
    public Transform whiteArea;
    public Transform blackArea;
    public Sprite whitePawnSprite;
    public Sprite whiteRookSprite;
    public Sprite whiteKnightSprite;
    public Sprite whiteBishopSprite;
    public Sprite whiteQueenSprite;
    public Sprite blackPawnSprite;
    public Sprite blackRookSprite;
    public Sprite blackKnightSprite;
    public Sprite blackBishopSprite;
    public Sprite blackQueenSprite;


    public void AddCapturedPiece(bool isWhite)
    {
        GameObject go = new GameObject("CapturedPiece", typeof(Image));
        go.transform.SetParent(isWhite ? whiteArea : blackArea);
        go.transform.localScale = Vector3.one;
        go.transform.localPosition = Vector3.zero;

        Image img = go.GetComponent<Image>();
        img.sprite = isWhite ? whitePawnSprite : blackPawnSprite;
        img.preserveAspect = true;
    }
}
