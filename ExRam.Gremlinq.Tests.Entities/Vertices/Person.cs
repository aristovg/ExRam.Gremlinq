using System;
using ExRam.Gremlinq.Core.GraphElements;

namespace ExRam.Gremlinq.Tests.Entities
{
    public interface IAged
    {
         int Age { get; set; }

    }


    public class Person : Authority, IAged
    {
        public VertexProperty<string>[] PhoneNumbers  { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }

        public VertexProperty<object> SomeObscureProperty { get; set; }
    }
}
