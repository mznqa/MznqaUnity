using UnityEngine;

/*!
 * \class   SizeController
 *
 * \brief   尺寸控制器
 *
 */

public class SizeController
{
    /*! \brief   单例 */
    public static readonly SizeController Instance = new SizeController();

    /*! \brief   设备实际屏幕尺寸 */
    private Mznqa.SizeF _screenSize;

    /*! \brief   可视区域尺寸 */
    private Mznqa.SizeF _viewSize;

    /*!
     * \property    public Mznqa.SizeF screenSize
     *
     * \brief   设备实际像素尺寸
     *
     */

    public Mznqa.SizeF screenSize
    {
        get { return this._screenSize; }
    }

    /*!
     * \property    public Mznqa.SizeF viewSize
     *
     * \brief   可视区域尺寸
     *
     */

    public Mznqa.SizeF viewSize
    {
        get { return this._viewSize; }
    }

    /*!
     * \fn  private SizeController()
     *
     * \brief   构造函数
     *
     */

    private SizeController()
    {
        this._screenSize = Mznqa.SizeF.Zero;
        updateScreenSize();

        this._viewSize = Mznqa.SizeF.Zero;
        updateViewSize();
    }

    /*!
     * \fn  public void updateScreenSize()
     *
     * \brief   更新设备屏幕实际尺寸
     *
     */

    public void updateScreenSize()
    {
        this._screenSize.setValue(
            Screen.width * SizeDefine.pixelPerUnit,
            Screen.height * SizeDefine.pixelPerUnit
            );
    }

    /*!
     * \fn  public void updateViewSize()
     *
     * \brief   更新可视区域尺寸
     *
     */

    public void updateViewSize()
    {
        float orthographicSizeTemp = GameObject.Find("Main Camera")
            .GetComponent<Camera>().orthographicSize * 2.0f;

        this._viewSize = new Mznqa.SizeF(
            (Screen.width * SizeDefine.pixelPerUnit) * (orthographicSizeTemp / (Screen.height * SizeDefine.pixelPerUnit)),
            orthographicSizeTemp
            );
    }
}