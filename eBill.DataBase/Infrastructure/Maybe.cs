using NullGuard;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase
{
    public interface IMaybe<T>
    {
        bool HasValue { get; }
        T Value { get; }
    }

    public class Maybe<T> : IMaybe<T>
    {
        public static readonly Maybe<T> Nothing = new Maybe<T>();

        public bool HasValue { get; private set; }
        public T Value { get; private set; }

        private Maybe()
        {
            HasValue = false;
            Value = default(T);
        }

        internal Maybe([AllowNull] T value)
        {
            HasValue = !object.Equals(value, null);
            Value = value;
        }

        public static implicit operator Maybe<T>([AllowNull]T value)
        {
            return new Maybe<T>(value);
        }


        //private Maybe([AllowNull] T value)
        //{
        //    _value = value;
        //}
        //
        //public static implicit operator Maybe<T>([AllowNull] T value)
        //{
        //    return new Maybe<T>(value);
        //}


    }

    public static class Maybe
    {
        public static Maybe<T> ToMaybe<T>(this T value)
        {
            Maybe<T> maybe = value as Maybe<T>;
            if (maybe != null)
                return maybe;

            return new Maybe<T>(value);
        }

        // Monadic Bind operator
        public static Maybe<TResult> Bind<TSource, TResult>(this Maybe<TSource> m, Func<TSource, Maybe<TResult>> f)
        {
            if (!m.HasValue)
                return Maybe<TResult>.Nothing;

            return f(m.Value);
        }

        public static Maybe<TResult> Select<TSource, TResult>(this Maybe<TSource> m, Func<TSource, TResult> f)
        {
            return m.Bind(x => f(x).ToMaybe());
        }

        public static Maybe<TResult> SelectMany<TSource, TResult>(this Maybe<TSource> m, Func<TSource, TResult> f)
        {
            return m.Bind(x => f(x).ToMaybe());
        }

        public static Maybe<TResult> SelectMany<TSource, TMaybe, TResult>(this Maybe<TSource> m, Func<TSource, Maybe<TMaybe>> f, Func<TSource, TMaybe, TResult> g)
        {
            return m.Bind(x => f(x).Bind(y => g(x, y).ToMaybe()));
        }

        // Simplified form, check for null or use Nullable<T>.HasValue instead of Maybe.
        // This form is not as strictly correct but it results in a more useable syntax in C#.
        public static TResult Select<TSource, TResult>(this TSource m, Func<TSource, TResult> f)
        {
            return m.ToMaybe().Bind(x => f(x).ToMaybe()).Value;
        }

        public static TResult SelectMany<TSource, TResult>(this TSource m, Func<TSource, TResult> f)
        {
            return m.ToMaybe().Bind(x => f(x).ToMaybe()).Value;
        }

        public static TResult SelectMany<TSource, TMaybe, TResult>(this TSource m, Func<TSource, TMaybe> f, Func<TSource, TMaybe, TResult> g)
        {
            return m.ToMaybe().Bind(x => f(x).ToMaybe().Bind(y => g(x, y).ToMaybe())).Value;
        }
    }
}
