/*!
 * \class   SizeDefine
 *
 * \brief   尺寸预定义
 *
 */

public static class SizeDefine
{
    /*! \brief   像素换算比 */
    public static float pixelPerUnit = 100.0f;

    /*! \brief   预定的设计分辨率 */
    public static Mznqa.SizeF ExpectedDesignSize = new Mznqa.SizeF(1920.0f, 1080.0f);

    /*! \brief   瓦片地图单元的尺寸 */
    public static float MapTileSizePixel = 0.64f;
    /*! \brief   瓦片地图单元的尺寸的一半 */
    public static float MapTileSizePixelHalf = 0.32f;
}