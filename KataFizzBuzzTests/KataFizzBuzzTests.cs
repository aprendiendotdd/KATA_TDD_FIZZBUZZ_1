using NUnit.Framework;

namespace KataFizzBuzzTests
{
  [TestFixture]
  public class KataFizzBuzzTests
  {


    [Test]
    public void Pasamos_Numero_Uno_Debe_Devolver_Uno()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("1", iKataFizzBuzz.Game("1"));
    }

    [Test]
    public void Pasamos_Numero_Dos_Debe_Devolver_Dos()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("2", iKataFizzBuzz.Game("2"));
    }

    [Test]
    public void Pasamos_Numero_Divisible_Tres_Al_Juego_Debe_Devolver_Fizz()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("Fizz", iKataFizzBuzz.Game("3"));
      Assert.AreEqual("Fizz", iKataFizzBuzz.Game("6"));
    }

    [Test]
    public void Pasamos_Numero_Divisible_Cinco_Al_Juego_Debe_Devolver_Buzz()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("Buzz", iKataFizzBuzz.Game("5"));
      Assert.AreEqual("Buzz", iKataFizzBuzz.Game("10"));
    }

    [Test]
    public void Pasamos_Numero_Divisible_Tres_Cinco_Al_Juego_Debe_Devolver_FizzBuzz()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("FizzBuzz", iKataFizzBuzz.Game("60"));
      Assert.AreEqual("FizzBuzz", iKataFizzBuzz.Game("15"));
    }

    [Test]
    public void Pasamos_Numero_Que_Contiene_Tres_Pero_No_Es_Divisible_Tres_Debe_Devolver_Fizz()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("Fizz", iKataFizzBuzz.Game("23"));
      Assert.AreEqual("Fizz", iKataFizzBuzz.Game("13"));
    }

    [Test]
    public void Pasamos_Numero_Que_Contiene_Cinco_Pero_No_Es_Divisible_Tres_Debe_Devolver_Buzz()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("Buzz", iKataFizzBuzz.Game("52"));
    }

    [Test]
    public void Pasamos_Numero_Que_Contiene_Tres_Y_Cinco_Debe_Devolver_FizzBuzz()
    {
      var iKataFizzBuzz = new KataFizzBuzz.KataFizzBuzz();
      Assert.AreEqual("FizzBuzz", iKataFizzBuzz.Game("53"));
    }

  }
}
