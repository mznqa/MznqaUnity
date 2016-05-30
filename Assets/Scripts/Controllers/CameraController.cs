using UnityEngine;

/*!
 * \class   CameraController
 *
 * \brief   相机控制器
 *
 */

public class CameraController : MonoBehaviour
{
    /*! \brief   可移动范围 */
    private Mznqa.RangeF2 _moveRange = new Mznqa.RangeF2();

    /*!
     * \property    public Mznqa.RangeF2 moveRange
     *
     * \brief   可移动范围
     *
     */

    public Mznqa.RangeF2 moveRange
    {
        get { return this._moveRange; }
    }

    /*!
     * \fn  private void Start()
     *
     * \brief   Start 方法
     *
     */

    private void Start()
    {
        GameObject.Find("InputController").GetComponent<InputController>()
            .moveCamera += move;
        GameObjectManager.Instance.character.characterPositionChanged += updateMoveRangeAndLookAtCharacter;
    }

    /*!
     * \fn  private void Update()
     *
     * \brief   Update 方法
     *
     */

    private void Update()
    {
    }

    /*!
     * \fn  public void move(Vector3 delta)
     *
     * \brief   移动相机
     *
     * \param   delta   指定移动增减量
     */

    public void move(Vector3 delta)
    {
        if (this._moveRange.horizontal.isInclusive(transform.position.x + delta.x))
            transform.position += new Vector3(delta.x, 0.0f, 0.0f);
        if (this._moveRange.vertical.isInclusive(transform.position.y + delta.y))
            transform.position += new Vector3(0.0f, delta.y, 0.0f);
    }

    /*!
     * \fn  public void moveTo(Vector2 position)
     *
     * \brief   移动相机到指定位置
     *
     * \param   position    指定目标位置
     */

    public void moveTo(Vector2 position)
    {
        if (this._moveRange.horizontal.isInclusive(position.x))
            transform.position = new Vector3(position.x, transform.position.y, transform.position.z);
        else if (position.x <= this._moveRange.horizontal.min)
            transform.position = new Vector3(this._moveRange.horizontal.min, transform.position.y, transform.position.z);
        else if (this._moveRange.horizontal.max <= position.x)
            transform.position = new Vector3(this._moveRange.horizontal.max, transform.position.y, transform.position.z);

        if (this._moveRange.vertical.isInclusive(position.y))
            transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
        else if (position.y <= this._moveRange.vertical.min)
            transform.position = new Vector3(transform.position.x, this._moveRange.vertical.min, transform.position.z);
        else if (this._moveRange.vertical.max <= position.y)
            transform.position = new Vector3(transform.position.x, this._moveRange.vertical.max, transform.position.z);
    }

    /*!
     * \fn  public void lookAtCharacter()
     *
     * \brief   注视角色
     *
     */

    public void lookAtCharacter()
    {
        var pos = MapController.mapPostion2ScreenPosition(GameObjectManager.Instance.character.position);
        moveTo(new Vector2(pos.x, pos.y));
    }

    /*!
     * \fn  public void updateMoveRange()
     *
     * \brief   更新可移动范围
     *
     */

    public void updateMoveRange()
    {
        float viewSizeWithHalf = SizeController.Instance.viewSize.width * 0.5f;
        float viewSizeHeightHalf = SizeController.Instance.viewSize.height * 0.5f;
        Vector3 characterPosition = MapController.mapPostion2ScreenPosition(
            GameObjectManager.Instance.character.position
            );

        Mznqa.RangeF rangeX = new Mznqa.RangeF(
                viewSizeWithHalf,
                GameObjectManager.Instance.gameMap.mapSizePixel.width - viewSizeWithHalf
                );
        rangeX.move(
            Mznqa.Direction.Negative,
            SizeDefine.MapTileSizePixelHalf
            );
        if (rangeX.min + viewSizeWithHalf <= characterPosition.x)
        {
            rangeX.min += characterPosition.x - (rangeX.min + viewSizeWithHalf) +
                SizeDefine.MapTileSizePixelHalf;
        }
        if (characterPosition.x <= rangeX.max - viewSizeWithHalf)
        {
            rangeX.max -= (rangeX.max - viewSizeWithHalf) - characterPosition.x +
                SizeDefine.MapTileSizePixelHalf;
        }
        Mznqa.RangeF rangeY = new Mznqa.RangeF(
                0.0f - (
                GameObjectManager.Instance.gameMap.mapSizePixel.height -
                viewSizeHeightHalf
                ),
                0.0f - viewSizeHeightHalf
                );
        rangeY.move(
            Mznqa.Direction.Positive,
            SizeDefine.MapTileSizePixelHalf
            );
        if (rangeY.min + viewSizeHeightHalf <= characterPosition.y)
        {
            rangeY.min += characterPosition.y - (rangeY.min + viewSizeHeightHalf) +
                SizeDefine.MapTileSizePixelHalf;
        }
        if (characterPosition.y <= rangeY.max - viewSizeHeightHalf)
        {
            rangeY.max -= (rangeY.max - viewSizeHeightHalf) - characterPosition.y +
                SizeDefine.MapTileSizePixelHalf;
        }
        this._moveRange.setValue(rangeX, rangeY);
    }

    /*!
     * \fn  public void updateMoveRangeAndLookAtCharacter()
     *
     * \brief   更新移动范围并注视角色
     *
     */

    public void updateMoveRangeAndLookAtCharacter()
    {
        updateMoveRange();
        lookAtCharacter();
    }
}