
using BenchmarkDotNet.Attributes;

namespace SealedClass;

[MemoryDiagnoser(false)]
public class BenchMarks
{
    private ClassTypes.BaseClass BaseClass => new ClassTypes.BaseClass();
    private readonly ClassTypes.SealedClass sealedClass = new ClassTypes.SealedClass();
    private readonly ClassTypes.OpenClass openClass = new ClassTypes.OpenClass();

    
    [Benchmark()]
    public void BaseVoidMethod() => BaseClass.VoidMethod();
    [Benchmark()]
    public void OpenVoidMethod() => openClass.VoidMethod();
    [Benchmark()]
    public void SealedVoidMethod() => sealedClass.VoidMethod();

    [Benchmark()]
    public string BaseStringMethod() => BaseClass.StringMethod;
    [Benchmark()]
    public string OpenStringMethod() => openClass.StringMethod;
    [Benchmark()]
    public string SealedStringMethod() => sealedClass.StringMethod;
    
    
    [Benchmark()]
    public int BaseIntMethod() => BaseClass.IntMethod;
    [Benchmark()]
    public int OpenIntMethod() => openClass.IntMethod;
    [Benchmark()]
    public int SealedIntMethod() => sealedClass.IntMethod;
}