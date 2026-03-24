public static class LineUp
{
    public static string Format(string name, int number)
    {
        if (number.ToString().EndsWith("1") && !number.ToString().EndsWith("11"))
            return $"{name}, you are the {number}st customer we serve today. Thank you!";
        if (number.ToString().EndsWith("2") && !number.ToString().EndsWith("12"))
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        if (number.ToString().EndsWith("3") && !number.ToString().EndsWith("13"))
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        return $"{name}, you are the {number}th customer we serve today. Thank you!";
    }
}
