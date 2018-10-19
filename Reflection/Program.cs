using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberHomeWork = -1;
            bool isTrue = false;
            while (!isTrue || numberHomeWork<1 || numberHomeWork>2)
            {
                Console.Write("Тема Рефлексия, введите номер домашки(1,2): ");
                isTrue = int.TryParse(Console.ReadLine(), out numberHomeWork);
            }
            isTrue = false;

            //1-DZ
            if (numberHomeWork == 1)
            {
                Type type = typeof(Console);
                MemberInfo[] memberInfo = type.GetMembers();
                foreach (MemberInfo member in memberInfo)
                {
                    if (member.MemberType == MemberTypes.Method)
                    {
                        Console.WriteLine(member.Name);
                    }
                }
            }


            //2-DZ
            else
            {
                User user = new User("MyLogin", "myPassword");
                user.Age = 59;
                user.Name = "Федя";

                Type type = user.GetType();
                MemberInfo[] memberInfo = type.GetMembers();

                foreach (MemberInfo member in memberInfo)
                {
                    if (member.MemberType == MemberTypes.Property)
                    {
                        Console.WriteLine(member.Name+" : "+ typeof(User).GetProperty(member.Name, BindingFlags.Public | BindingFlags.Instance).GetValue(user));
                    }
                }                            
            }

        }
    }
}
