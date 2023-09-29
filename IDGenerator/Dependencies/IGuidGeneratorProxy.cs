using System;

namespace IDGenerator.Dependencies
{
   public interface IGuidGeneratorProxy
    {
        Guid GenerateGuid();
        string GenerateInstanceId(int lengtht,int type);
    }
}