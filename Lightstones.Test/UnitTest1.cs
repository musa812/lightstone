using Lightstone;

namespace Lightstones.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Case1()
        {
            //arrange
            string input = "this is a test";
            string output = "test a is this";

            //action 
           string results = Problem.ReverseSentence(input);

            //assert
            Assert.That(output, Is.EqualTo(results), "Case 1");
            Console.WriteLine($"Case 1 {results}");
        }
        [Test]
        public void Case2()
        {
            //arrange
            string input = "all your base";
            string output = "base your all";

            //action 
            string results = Problem.ReverseSentence(input);

            //assert
            Assert.That(output, Is.EqualTo(results), "Case 2");
            Console.WriteLine($"Case 2 {results}");
        }
        [Test]
        public void Case3()
        {
            //arrange
            string input = "foobar";
            string output = "foobar";

            //action 
            string results = Problem.ReverseSentence(input);

            //assert
            Assert.That(output, Is.EqualTo(results),"Case 3");
            Console.WriteLine($"Case 3 {results}");
        }
    }
}