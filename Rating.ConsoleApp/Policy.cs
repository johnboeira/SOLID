﻿using System;

namespace Rating.ConsoleApp;

public class Policy
{
    public string Type { get; set; }

    #region Life Insurance

    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsSmoker { get; set; }
    public decimal Amount { get; set; }

    #endregion Life Insurance

    #region Land

    public string Address { get; set; }
    public decimal Size { get; set; }
    public decimal Valuation { get; set; }
    public decimal BondAmount { get; set; }

    #endregion Land

    #region Flood In Addition To Land

    public int ElevationAboveSeaLevelFeet { get; set; }

    #endregion Flood In Addition To Land

    #region Auto

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Miles { get; set; }
    public decimal Deductible { get; set; }

    #endregion Auto
}