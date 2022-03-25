using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs11test
{
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(Type t) => ParamType = t;

        public Type ParamType { get; }
    }

    // You must set <LangVersion>preview<LangVersion> in project file
    public class GenericAttribute<T> : Attribute { }

    public class Test
    {
        // C# 11 feature
        [TypeAttribute(typeof(string))]
        public string TestOldFeature() => default;

        [GenericAttribute<string>()]
        public string TestNewFeature() => default;

        // Wrong example;
        //[GenericAttribute<T>()] // Generic attributes must be fully constructed types.
        //public string NotAllowedMethod() => default;
    }
}
