namespace Mznqa
{
    /*!
     * \struct  Range
     *
     * \brief   范围
     *
     */

    public struct Range
    {
        /*! \brief   最小值 */
        private int _min;
        /*! \brief   最大值 */
        private int _max;

        /*!
         * \property    public int min
         *
         * \brief   最小值
         *
         */

        public int min
        {
            get { return this._min; }
            set { if (value <= this._max) this._min = value; }
        }

        /*!
         * \property    public int max
         *
         * \brief   最大值
         *
         */

        public int max
        {
            get { return this._max; }
            set { if (this._min <= value) this._max = value; }
        }

        /*!
         * \fn  public Range(int min, int max)
         *
         * \brief   构造函数
         *
         * \param   min 指定最小值
         * \param   max 指定最大值
         */

        public Range(int min = 0, int max = 0)
        {
            this._min = 0;
            this._max = 0;
            setValue(min, max);
        }

        /*!
         * \fn  public Range(Range range)
         *
         * \brief   拷贝构造函数
         *
         */

        public Range(Range range)
        {
            this._min = 0;
            this._max = 0;
            setValue(min, max);
        }

        /*!
         * \fn  public bool setValue(int min, int max)
         *
         * \brief   设置值
         *
         * \param   min 指定最小值
         * \param   max 指定最大值
         *
         */

        public bool setValue(int min, int max)
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
         * \fn  public bool isInclusive(int num)
         *
         * \brief   判断是否含有指定数
         *
         * \param   num 指定待判断的数
         *
         */

        public bool isInclusive(int num)
        {
            return (this._min <= num && num <= this._max);
        }

        /*!
         * \fn  public void move(Mznqa.Direction direction, int delta)
         *
         * \brief   整体移动
         *
         * \param   direction   指定移动方向
         * \param   delta       指定移动增减量
         */

        public void move(Mznqa.Direction direction, int delta)
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
         * \fn  public bool expand(int delta)
         *
         * \brief   扩大范围
         *
         * \param   delta   指定增减量
         */

        public bool expand(int delta)
        {
            return setValue(this._min - delta, this._max + delta);
        }

        /*!
         * \fn  public bool shrink(int delta)
         *
         * \brief   缩小范围
         *
         * \param   delta   指定增减量
         */

        public bool shrink(int delta)
        {
            return setValue(this._min + delta, this._max - delta);
        }
    }
}