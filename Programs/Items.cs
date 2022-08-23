using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ConsoleTest.Programs
{
      public class Items
      {
            public int ItemId { get; set; }
            public string ItemName { get; set; }
            public int Price { get; set; }
            public int TotalQuantity { get; set; }
            public bool ItemActive { get; set; }
            public int FoodCategoryId { get; set; }

            public override string ToString()
            {
                  return $"{ItemId} {ItemName} {Price}";
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