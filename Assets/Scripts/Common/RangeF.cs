namespace Mznqa
{
    /*!
     * \struct  RangeF
     *
     * \brief   范围
     *
     */

    public struct RangeF
    {
        /*! \brief   最小值 */
        private float _min;
        /*! \brief   最大值 */
        private float _max;

        /*!
         * \property    public float min
         *
         * \brief   最小值
         *
         */

        public float min
        {
            get { return this._min; }
            set { if (value <= this._max) this._min = value; }
        }

        /*!
         * \property    public float max
         *
         * \brief   最大值
         *
         */

        public float max
        {
            get { return this._max; }
            set { if (this._min <= value) this._max = value; }
        }

        /*!
         * \fn  public RangeF(float min, float max)
         *
         * \brief   构造函数
         *
         * \param   min 指定最小值
         * \param   max 指定最大值
         */

        public RangeF(float min = 0.0f, float max = 0.0f)
        {
            this._min = 0.0f;
            this._max = 0.0f;
            setValue(min, max);
        }

        /*!
         * \fn  public RangeF(RangeF rangeF)
         *
         * \brief   拷贝构造函数
         *
         */

        public RangeF(RangeF rangeF)
        {
            this._min = 0.0f;
            this._max = 0.0f;
            setValue(min, max);
        }

        /*!
         * \fn  public bool setValue(float min, float max)
         *
         * \brief   设置值
         *
         * \param   min 指定最小值
         * \param   max 指定最大值
         *
         */

        public bool setValue(float min, float max)
        {
            if (min <= max)
            {
                this._min = min;
                this._max = max;
                return true;
            }
            return false;
        }

        /*!
         * \fn  public bool isInclusive(float num)
         *
         * \brief   判断是否含有指定数
         *
         * \param   num 指定待判断的数
         *
         */

        public bool isInclusive(float num)
        {
            return (this._min <= num && num <= this._max);
        }

        /*!
         * \fn  public void move(Mznqa.Direction direction, float delta)
         *
         * \brief   整体移动
         *
         * \param   direction   指定移动方向
         * \param   delta       指定移动增减量
         */

        public void move(Mznqa.Direction direction, float delta)
        {
            switch (direction)
            {
                case Mznqa.Direction.Positive:
                    this._min += delta;
                    this._max += delta;
                    break;

                case Mznqa.Direction.Negative:
                    this._min -= delta;
                    this._max -= delta;
                    break;
            }
        }

        /*!
         * \fn  public bool expand(float delta)
         *
         * \brief   扩大范围
         *
         * \param   delta   指定增减量
         */

        public bool expand(float delta)
        {
            return setValue(this._min - delta, this._max + delta);
        }

        /*!
         * \fn  public bool shrink(float delta)
         *
         * \brief   缩小范围
         *
         * \param   delta   指定增减量
         */

        public bool shrink(float delta)
        {
            return setValue(this._min + delta, this._max - delta);
        }
    }
}