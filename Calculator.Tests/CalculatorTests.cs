using Module._16.HW;

namespace CalculatorTests;

[TestFixture]
public class CalculatorTests
{
    public Calculator calculator = new Calculator();

    [Test]
    public void AdditionalMustReturnCorrectValue() // Проверяем корректность работы метода сложения
    {
        Assert.That(4, Is.EqualTo(calculator.Additional(2, 2)));
        Assert.That(8, Is.EqualTo(calculator.Additional(5, 3)));
    }

    [Test]
    public void SubtractionMustReturnCorrectValue() // Проверяем корректность работы метода вычитания
    {
        Assert.That(0, Is.EqualTo(calculator.Subtraction(2, 2)));
        Assert.That(-4, Is.EqualTo(calculator.Subtraction(2, 6)));
    }

    [Test]
    public void MiltiplicationMustReturnCorrectValue() // Проверяем корректность работы метода умножения
    {
        Assert.That(4, Is.EqualTo(calculator.Miltiplication(2, 2)));
        Assert.That(20, Is.EqualTo(calculator.Miltiplication(2, 10)));
    }

    [Test]
    public void DivisionMustReturnCorrectValue() // // Проверяем корректность работы метода деления
    {
        Assert.That(1, Is.EqualTo(calculator.Division(2, 2)));
        Assert.That(12, Is.EqualTo(calculator.Division(60, 5)));
        Assert.That(3, Is.EqualTo(calculator.Division(7, 2)));
        Assert.That(0, Is.EqualTo(calculator.Division(7, 8)));
    }

    [Test]
    public void DivisionMustThrowException() // Деление на 0 должно вызвать ошибку
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Division(2, 0));
    }
}
