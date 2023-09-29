using IDGenerator.Enums;
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

        public string GenerateInstanceId(int length, int type)
        {
            string characters = string.Empty;

            if (length <= 0)
            {
                throw new ArgumentException("Length must be greater than zero.", nameof(length));
            }
            Random random = new Random();
            {
                if (type == (int)IDType.Alphanumeric)
                {
                    characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                }
                else if (type == (int)IDType.Numeric)
                {
                    characters = "0123456789";
                }

                char[] instanceIdChars = new char[length];
                for (int i = 0; i < length; i++)
                {
                    instanceIdChars[i] = characters[random.Next(0, characters.Length)];
                }


                return new string(instanceIdChars);
            }

        }
    }
}
