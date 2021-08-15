using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor_sealed
{
    public class Animal
    {
        public virtual void Goes ()
        {
            Console.WriteLine("Goes Class Animal");
        }
    }

    public class Dog : Animal
    {
        public override void Goes()
        {
            Console.WriteLine("Woof!!");
        }
    }

    public class Senberner : Dog
    {
        public sealed override void Goes()//key word "sealed" จะไม่อนุญาตให้คลาสลูกเอา method Goes ใน คลาสแม่ ไปใช้งานได้
        {
            Console.WriteLine("Woof Senberner !!");
        }
    }

    /*public class MiniSenberner : Senberner
    {
        public override void Goes()//method ที่ทำการทืบทอดมาจาก class แม่ จะ error เพราะ key word "sealed"
        {
            Console.WriteLine("");
        }
    }*/
}
