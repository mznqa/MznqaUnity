namespace Mznqa
{
    /*!
     * \struct  Size
     *
     * \brief   尺寸
     *
     */

    public struct Size
    {
        /*! \brief   零尺寸 */
        public static Size Zero = new Size(0, 0);

        /*! \brief   宽度 */
        private int _width;
        /*! \brief   高度 */
        private int _height;

        /*!
         * \property    public int width
         *
         * \brief   宽度
         *
         */

        public int width
        {
            get { return this._width; }
            set { if (value >= 0) this._width = value; }
        }

        /*!
         * \property    public int height
         *
         * \brief   高度
         *
         * \return  The height.
         */

        public int height
        {
            get { return this._height; }
            set { if (value >= 0) this._height = value; }
        }

        /*!
         * \fn  public Size(int width = 0, int height = 0)
         *
         * \brief   构造函数
         *
         * \param   width   指定宽度
         * \param   height  指定高度
         */

        public Size(int width = 0, int height = 0)
        {
            this._width = Zero.width;
            this._height = Zero.height;
            setValue(width, height);
        }

        /*!
         * \fn  public Size(Size size)
         *
         * \brief   拷贝构造函数
         *
         */

        public Size(Size size)
        {
            this._width = Zero.width;
            this._height = Zero.height;
            setValue(width, height);
        }

        /*!
         * \fn  public bool setValue(int width, int height)
         *
         * \brief   设置值
         *
         * \param   width   指定宽度
         * \param   height  指定高度
         */

        public bool setValue(int width, int height)
        {
            if (width >= 0 && height >= 0)
            {
                this._width = width;
                this._height = height;
                return true;
            }
            return false;
        }

        /*!
         * \fn  public void setZero()
         *
         * \brief   置为0
         *
         */

        public void setZero()
        {
            this._width = 0;
            this._height = 0;
        }
    }
}