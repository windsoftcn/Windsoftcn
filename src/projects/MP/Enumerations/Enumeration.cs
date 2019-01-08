using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MP.Enumerations
{
    public abstract class Enumeration : IComparable
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        protected Enumeration() { }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;

        public override int GetHashCode() => Id.GetHashCode();

        public int CompareTo(object obj) => Id.CompareTo(((Enumeration)obj).Id);

        public override bool Equals(object obj)
        {
            if (!(obj is Enumeration otherValue))
                return false;

            var isTypeMatch = GetType().Equals(obj.GetType());
            var isValueMatch = Id.Equals(otherValue.Id);

            return isTypeMatch && isValueMatch;
        }
        
        /* Static methods */

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        
        public static int AbsoluteDifferent(Enumeration leftValue, Enumeration rightValue)
        {
            var absoluteDifferent = Math.Abs(leftValue.Id - rightValue.Id);
            return absoluteDifferent;
        }

        public static T FromValue<T>(int value) where T : Enumeration
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Id == value);
            return matchingItem;
        }

        public static T FromDisplayName<T>(string displayName) where T : Enumeration
        {
            var matchingItem = Parse<T, string>(displayName, "display name", item => item.Name == displayName);
            return matchingItem;
        }

        private static T Parse<T,K>(K value, string description, Func<T,bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);
            return matchingItem ?? throw new InvalidOperationException($"'{value}' is not a valid {description} in {typeof(T)}");
        }
    }
}
