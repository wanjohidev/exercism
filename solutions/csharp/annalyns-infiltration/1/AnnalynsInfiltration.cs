static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake != true)
        {
            return true;
        }
        return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake == true && archerIsAwake == false)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent == true && archerIsAwake == false && knightIsAwake == true || prisonerIsAwake == true && knightIsAwake == false && archerIsAwake == false || petDogIsPresent == true && archerIsAwake == false && knightIsAwake == false && prisonerIsAwake == false)
        {
            return true;
        }
        return false;
    }
}
