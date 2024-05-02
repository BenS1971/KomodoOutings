﻿namespace OutingsRepo.repository;

public enum OutingType
{
    AmusementPark = 1,
    Golfing,
    BaseballGame,
    Bowling,
    SmashingMailboxes,
    Concert,
    BeachTrip,
    MiscOuting,
}

//This is the repository for the Komodo outings with the POCOs...
 public class Outings
{
    public DateTime OutingDate { get; set;}

    public double NumberOfPeople { get; set; }

    public double CostPerPerson { get; set;}

    public double TotalCostOfOuting { get; set;}

    public OutingType TypeOfOuting { get; set; }
}