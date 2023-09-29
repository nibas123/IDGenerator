using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGenerator.Dependencies
{
    internal class GuidGeneratorProxy : IGuidGeneratorProxy
    {
        public Guid GenerateGuid()
        {
            return Guid.NewGuid();
        }

        public string GenerateInstanceId(int length,int type)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length must be greater than zero.", nameof(length));
            }
            Random random = new Random();
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] instanceIdChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                instanceIdChars[i] = characters[random.Next(0, characters.Length)];
            }


            return new string(instanceIdChars);
        }

    }
}
