namespace Mznqa
{
    /*!
     * \struct  SizeF
     *
     * \brief   尺寸
     *
     */

    public struct SizeF
    {
        /*! \brief   零尺寸 */
        public static SizeF Zero = new SizeF(0.0f, 0.0f);

        /*! \brief   宽度 */
        private float _width;
        /*! \brief   高度 */
        private float _height;

        /*!
         * \property    public float width
         *
         * \brief   宽度
         *
         */

        public float width
        {
            get { return this._width; }
            set { if (value >= 0.0f) this._width = value; }
        }

        /*!
         * \property    public float height
         *
         * \brief   高度
         *
         */

        public float height
        {
            get { return this._height; }
            set { if (value >= 0.0f) this._height = value; }
        }

        /*!
         * \fn  public SizeF(float width = 0.0f, float height = 0.0f)
         *
         * \brief   构造函数
         *
         * \param   width   指定宽度
         * \param   height  指定高度
         */

        public SizeF(float width = 0.0f, float height = 0.0f)
        {
            this._width = Zero.width;
            this._height = Zero.height;
            setValue(width, height);
        }

        /*!
         * \fn  public SizeF(SizeF sizeF)
         *
         * \brief   拷贝构造函数
         *
         */

        public SizeF(SizeF sizeF)
        {
            this._width = Zero.width;
            this._height = Zero.height;
            setValue(width, height);
        }

        /*!
         * \fn  public bool setValue(float width, float height)
         *
         * \brief   设置值
         *
         * \param   width   指定宽度
         * \param   height  指定高度
         */

        public bool setValue(float width, float height)
        {
            if (width >= 0.0f && height >= 0.0f)
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
            this._width = 0.0f;
            this._height = 0.0f;
        }
    }
}