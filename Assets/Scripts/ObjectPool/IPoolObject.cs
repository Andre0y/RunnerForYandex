using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ObjectPool
{
    public interface IPoolObject
    {
        void Construct(ObjectPull objectPull);
        void Active();
        void Deactive();
    }
}
