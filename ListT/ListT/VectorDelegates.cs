using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    public static class VectorDelegates
    {
        public static int Compare(Vector x,Vector y)    // 比较/排序
        {
            if (x.R > y.R)
                return 1;
            else if (x.R < y.R)
                return -1;
            return 0;
        }
        public static bool TopRightQuadrant(Vector target)  // 搜索第一象限
        {
            if (target.Theta >= 0.0 && target.Theta <= 90.0)
                return true;
            else
                return false;
        }
    }
}
