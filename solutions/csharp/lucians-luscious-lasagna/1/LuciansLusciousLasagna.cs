class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int cookTime = 40;
        return cookTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeInOven)
    {
        var lasagna = new Lasagna();
        int cookTime = lasagna.ExpectedMinutesInOven();
        int timeRemaining = cookTime - timeInOven;
        return timeRemaining;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int prepTime = layers * 2;
        return prepTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        var lasagna = new Lasagna();
        int prepTime = lasagna.PreparationTimeInMinutes(layers);
        int elapsedTime = prepTime + timeInOven;
        return elapsedTime;
    }
}
