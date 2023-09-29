using System;

namespace IDGenerator.Dependencies
{
    public interface IDateGeneratorProxy
    {
        string FormatDate(DateTime dateTime);
    }
}