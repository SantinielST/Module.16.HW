﻿using Module._16.HW;

namespace CalculatorTests;

[TestFixture]
public class CalculatorTests
{
    public Calculator calculator = new Calculator();

    [Test]
    public void AdditionalMustReturnCorrectValue()
    {
        Assert.That(4, Is.EqualTo(calculator.Additional(2, 2)));
    }

    [Test]
    public void SubtractionMustReturnCorrectValue()
    {
        Assert.That(0, Is.EqualTo(calculator.Subtraction(2, 2)));
    }
}
