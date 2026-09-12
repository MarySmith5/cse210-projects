using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void setNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int getNumerator()
    {
        return _numerator;
    }

    public void setDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public int getDenominator()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        return _numerator + "/" + _denominator;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}