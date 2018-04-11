using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    public class Vectors : List<Vector>
    {
        public Vectors()
        {
        }
        public Vectors(IEnumerable<Vector> initialItems)    // 构造函数用于List<Vector>
        {
            foreach (Vector vector in initialItems)
            {
                Add(vector);
            }
        }
        public string Sum()
        {
            StringBuilder sb = new StringBuilder(); // 构建响应字符串
            Vector currentPoint = new Vector(0.0, 0.0);
            sb.Append("origin");
            foreach (Vector vector in this)
            {
                sb.AppendFormat($" + {vector}");
                currentPoint += vector; // 向量计算
            }
            sb.AppendFormat($" = {currentPoint}");
            return sb.ToString();
        }
    }
}
