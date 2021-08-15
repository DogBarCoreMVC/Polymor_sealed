using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor_sealed
{
    public sealed class Animal//ถ้าใส่ key word "sealed" ตั้งแต่ใน class จะไม่สามารถทำการทืบทอดคลาสได้เลย 
    {
        /*public virtual void Goes ()//และ method นี้จะไม่ทำงานเพราะว่ามี key word "virtual" อยู่ แต่ถ้าต้องการจะให้ method นี้ทำงานให้ลบ key word "virtual" ออกไป
        {
            Console.WriteLine("Goes Class Animal");
        }*///ตัวอย่าง

        public void Goes()
        {
            Console.WriteLine("Goes Class Animal");
        }
    }

    public class Dog : Animal//คลาสนี้จะไม่ทำงานเพราะว่า key word "sealed" ที่อยู่ใน class Animal หรือ คลาสแม่
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
