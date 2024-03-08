
namespace TypeCheckTest.Models
{
    internal class A : IChainable
    {
        internal B B { get; set; } = new B();
    }
}
