﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public partial global::System.Linq.IQueryable<TTarget> Map<TSource, TTarget>(global::System.Linq.IQueryable<TSource> source)
    {
        return source switch
        {
            global::System.Linq.IQueryable<global::A> x when typeof(global::System.Linq.IQueryable<TTarget>).IsAssignableFrom(typeof(global::System.Linq.IQueryable<global::B>)) => (global::System.Linq.IQueryable<TTarget>)(object)ProjectToB(x),
            global::System.Linq.IQueryable<global::C> x when typeof(global::System.Linq.IQueryable<TTarget>).IsAssignableFrom(typeof(global::System.Linq.IQueryable<global::D>)) => (global::System.Linq.IQueryable<TTarget>)(object)ProjectToD(x),
            _ => throw new System.ArgumentException($"Cannot map {source.GetType()} to {typeof(global::System.Linq.IQueryable<TTarget>)} as there is no known type mapping", nameof(source)),
        };
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::System.Linq.IQueryable<global::B> ProjectToB(global::System.Linq.IQueryable<global::A> q)
    {
#nullable disable
        return System.Linq.Queryable.Select(
            q,
            x => new global::B()
            {
                Value = x.Value,
            }
        );
#nullable enable
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::System.Linq.IQueryable<global::D> ProjectToD(global::System.Linq.IQueryable<global::C> q)
    {
#nullable disable
        return System.Linq.Queryable.Select(
            q,
            x => new global::D()
            {
                Value2 = x.Value2,
            }
        );
#nullable enable
    }
}