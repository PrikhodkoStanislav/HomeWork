#pragma once

/// Very very very small number (in calculator the least result = -1 * 10^8)
/// negative 1 bilion ( - 1 * 10^9)
const int error = (int)(-1e9);

/// Class Calculator return the result of operation on two numbers.
class Calculator
{
public:

    /// Method which return the result of operation on two numbers.
    static double calc(int value1, int value2, char operation);
};
