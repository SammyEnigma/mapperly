﻿//HintName: BaseMapper.g.cs
// <auto-generated />
#nullable enable
public partial class BaseMapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public virtual partial global::B AToB(global::A source)
    {
        var target = new global::B();
        target.Value = source.Value.ToString();
        target.Value2 = IntToShort(source.Value2);
        return target;
    }

    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    public partial short IntToShort(int value)
    {
        return (short)value;
    }
}