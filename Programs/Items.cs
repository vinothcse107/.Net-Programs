using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ConsoleTest.Programs
{
      public class Items
      {
            public string ItemId { get; set; }
            public string ItemName { get; set; }
            public string Price { get; set; }
            private string id { get; set; }

            public override string ToString()
            {
                  return $"{ItemId} {ItemName} {Price} {id}";
            }
      }

      public static class GenericPropAssigner<T> where T : new()
      {

            public static T DynamicValues()
            {
                  Type extendedType = typeof(T);
                  var extendedObject = Activator.CreateInstance(extendedType);

                  PropertyInfo[] properties = extendedObject.GetType().GetProperties();
                  foreach (var p in properties)
                  {

                        extendedType.GetProperty(p.Name)
                              .SetValue(extendedObject, "Val", null);
                  }

                  return (T)extendedObject;
            }


      }
}