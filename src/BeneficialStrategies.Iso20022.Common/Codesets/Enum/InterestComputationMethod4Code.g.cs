﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestComputationMethod4Code.  ISO2002 ID# _RHkKgHitEeqKjIYaFgh_2g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to compute accruing interest of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RHkKgHitEeqKjIYaFgh_2g")]
[Description(@"Specifies the method used to compute accruing interest of a financial instrument.")]
[DerivedFrom(typeof(InterestComputationMethodCode))]
public enum InterestComputationMethod4Code
{
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 360-day year.
    /// Encoded/decoded by serializers as "A004".
    /// </summary>
    [EnumMember(Value = "A004")]
    [IsoId("_TRedUXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 360-day year.")]
    Actual360 = InterestComputationMethodCode.Actual360, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period, excluding any leap day from the count, and a 360-day year.
    /// Encoded/decoded by serializers as "A019".
    /// </summary>
    [EnumMember(Value = "A019")]
    [IsoId("_TW03YXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period, excluding any leap day from the count, and a 360-day year.")]
    Actual360NL = InterestComputationMethodCode.Actual360NL, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period divided by 364.
    /// Method equal to Act364 in the FixML model.
    /// Encoded/decoded by serializers as "A017".
    /// </summary>
    [EnumMember(Value = "A017")]
    [IsoId("_TbcRoXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period divided by 364.|Method equal to Act364 in the FixML model.")]
    Actual364 = InterestComputationMethodCode.Actual364, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 365-day year.
    /// Encoded/decoded by serializers as "A005".
    /// </summary>
    [EnumMember(Value = "A005")]
    [IsoId("_TgM10XitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period and a 365-day year.")]
    Actual365Fixed = InterestComputationMethodCode.Actual365Fixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days and a 365-day year (if the coupon payment date is NOT in a leap year) or a 366-day year (if the coupon payment date is in a leap year).
    /// Encoded/decoded by serializers as "A009".
    /// </summary>
    [EnumMember(Value = "A009")]
    [IsoId("_TltA4XitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days and a 365-day year (if the coupon payment date is NOT in a leap year) or a 366-day year (if the coupon payment date is in a leap year).")]
    Actual365LorActuActubasisRule = InterestComputationMethodCode.Actual365LorActuActubasisRule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days in the interest period, excluding any leap day from the count, and a 365-day year.
    /// Encoded/decoded by serializers as "A014".
    /// </summary>
    [EnumMember(Value = "A014")]
    [IsoId("_TqnWEXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days in the interest period, excluding any leap day from the count, and a 365-day year.")]
    Actual365NL = InterestComputationMethodCode.Actual365NL, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days and a 366-day year (if 29 Feb falls in the coupon period) or a 365-day year (if 29 Feb does not fall in the coupon period). If a coupon period is longer than one year, it is split by repetitively separating full year subperiods counting backwards from the end of the coupon period (a year backwards from 28 Feb being 29 Feb, if it exists). The first of the subperiods starts on the start date of the accrued interest period and thus is possibly shorter than a year. Then the interest computation is operated separately on each subperiod and the intermediate results are summed up.
    /// Encoded/decoded by serializers as "A010".
    /// </summary>
    [EnumMember(Value = "A010")]
    [IsoId("_TvX6QXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days and a 366-day year (if 29 Feb falls in the coupon period) or a 365-day year (if 29 Feb does not fall in the coupon period). If a coupon period is longer than one year, it is split by repetitively separating full year subperiods counting backwards from the end of the coupon period (a year backwards from 28 Feb being 29 Feb, if it exists). The first of the subperiods starts on the start date of the accrued interest period and thus is possibly shorter than a year. Then the interest computation is operated separately on each subperiod and the intermediate results are summed up.")]
    ActualActualAFB = InterestComputationMethodCode.ActualActualAFB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days and the assumed number of days in a year, that is, the actual number of days in the coupon period multiplied by the number of interest payments in the year. If the coupon period is irregular (first or last coupon), it is extended or split into quasi-interest periods that have the length of a regular coupon period and the computation is operated separately on each quasi-interest period and the intermediate results are summed up.
    /// Encoded/decoded by serializers as "A006".
    /// </summary>
    [EnumMember(Value = "A006")]
    [IsoId("_T0JFgXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days and the assumed number of days in a year, that is, the actual number of days in the coupon period multiplied by the number of interest payments in the year. If the coupon period is irregular (first or last coupon), it is extended or split into quasi-interest periods that have the length of a regular coupon period and the computation is operated separately on each quasi-interest period and the intermediate results are summed up.")]
    ActualActualICMA = InterestComputationMethodCode.ActualActualICMA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of accrued days of the interest period that fall (falling on a normal year, year) divided by 365, added to the actual number of days of the interest period that fall (falling on a leap year, year) divided by 366.
    /// Encoded/decoded by serializers as "A008".
    /// </summary>
    [EnumMember(Value = "A008")]
    [IsoId("_T6iBYXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of accrued days of the interest period that fall (falling on a normal year, year) divided by 365, added to the actual number of days of the interest period that fall (falling on a leap year, year) divided by 366.")]
    ActualActualISDA = InterestComputationMethodCode.ActualActualISDA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of days in the coupon period divided by the actual number of days in the year. This method is a variation of the ActualActualICMA method with the exception that it assumes that the coupon always falls on the last day of the month. Method equal to ACT/ACT.ISMA in the FpML model and Act/Act (ICSMA Ultimo) in the FixML model.
    /// Encoded/decoded by serializers as "A015".
    /// </summary>
    [EnumMember(Value = "A015")]
    [IsoId("_T-svsXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of days in the coupon period divided by the actual number of days in the year. This method is a variation of the ActualActualICMA method with the exception that it assumes that the coupon always falls on the last day of the month. Method equal to ACT/ACT.ISMA in the FpML model and Act/Act (ICSMA Ultimo) in the FixML model.")]
    ActualActualUltimo = InterestComputationMethodCode.ActualActualUltimo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on the actual number of business days in the interest period divided by 252. 
    /// Usage: Brazilian Currency Swaps. 
    /// Method equal to BUS/252 in the FpML model and BusTwoFiftyTwo in the FixML model.
    /// Encoded/decoded by serializers as "A018".
    /// </summary>
    [EnumMember(Value = "A018")]
    [IsoId("_UDdT4XitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on the actual number of business days in the interest period divided by 252. |Usage: Brazilian Currency Swaps. |Method equal to BUS/252 in the FpML model and BusTwoFiftyTwo in the FixML model.")]
    Business252 = InterestComputationMethodCode.Business252, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). It is the most commonly used 30/360 method for non-US straight and convertible bonds issued before 1 January 1999.
    /// Encoded/decoded by serializers as "A011".
    /// </summary>
    [EnumMember(Value = "A011")]
    [IsoId("_UJj74XitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). It is the most commonly used 30/360 method for non-US straight and convertible bonds issued before 1 January 1999.")]
    IC30360ICMAor30360basicrule = InterestComputationMethodCode.IC30360ICMAor30360basicrule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February, and provided that the interest period started on a 30th or a 31st. This means that a 31st is assumed to be a 30th if the period started on a 30th or a 31st and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). This is the most commonly used 30/360 method for US straight and convertible bonds.
    /// Encoded/decoded by serializers as "A001".
    /// </summary>
    [EnumMember(Value = "A001")]
    [IsoId("_UUuDAXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February, and provided that the interest period started on a 30th or a 31st. This means that a 31st is assumed to be a 30th if the period started on a 30th or a 31st and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). This is the most commonly used 30/360 method for US straight and convertible bonds.")]
    IC30360ISDAor30360AmericanBasicRule = InterestComputationMethodCode.IC30360ISDAor30360AmericanBasicRule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and a 365-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that a 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th).
    /// Encoded/decoded by serializers as "A002".
    /// </summary>
    [EnumMember(Value = "A002")]
    [IsoId("_UdzGgXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and a 365-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that a 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th).")]
    IC30365 = InterestComputationMethodCode.IC30365, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and the assumed number of days in a year in a way similar to the Actual/Actual (ICMA). Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). The assumed number of days in a year is computed as the actual number of days in the coupon period multiplied by the number of interest payments in the year.
    /// Encoded/decoded by serializers as "A003".
    /// </summary>
    [EnumMember(Value = "A003")]
    [IsoId("_UlYVMXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month in a way similar to the 30/360 (basic rule) and the assumed number of days in a year in a way similar to the Actual/Actual (ICMA). Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for February. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be the 28th (or 29th). The assumed number of days in a year is computed as the actual number of days in the coupon period multiplied by the number of interest payments in the year.")]
    IC30Actual = InterestComputationMethodCode.IC30Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for the last day of February whose day of the month value shall be adapted to the value of the first day of the interest period if the latter is higher and if the period is one of a regular schedule. This means that the 31st is assumed to be the 30th and 28 Feb of a non-leap year is assumed to be equivalent to 29 Feb when the first day of the interest period is the 29th, or to 30 Feb when the first day of the interest period is the 30th or the 31st. The 29th day of February in a leap year is assumed to be equivalent to 30 Feb when the first day of the interest period is the 30th or the 31st. Similarly, if the coupon period starts on the last day of February, it is assumed to produce only one day of interest in February as if it was starting on 30 Feb when the end of the period is the 30th or the 31st, or two days of interest in February when the end of the period is the 29th, or three days of interest in February when it is 28 Feb of a non-leap year and the end of the period is before the 29th.
    /// Encoded/decoded by serializers as "A012".
    /// </summary>
    [EnumMember(Value = "A012")]
    [IsoId("_Us-K8XitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month, except for the last day of February whose day of the month value shall be adapted to the value of the first day of the interest period if the latter is higher and if the period is one of a regular schedule. This means that the 31st is assumed to be the 30th and 28 Feb of a non-leap year is assumed to be equivalent to 29 Feb when the first day of the interest period is the 29th, or to 30 Feb when the first day of the interest period is the 30th or the 31st. The 29th day of February in a leap year is assumed to be equivalent to 30 Feb when the first day of the interest period is the 30th or the 31st. Similarly, if the coupon period starts on the last day of February, it is assumed to produce only one day of interest in February as if it was starting on 30 Feb when the end of the period is the 30th or the 31st, or two days of interest in February when the end of the period is the 29th, or three days of interest in February when it is 28 Feb of a non-leap year and the end of the period is before the 29th.")]
    IC30E2360orEurobondbasismodel2 = InterestComputationMethodCode.IC30E2360orEurobondbasismodel2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. It is a variation of the 30E/360 (or Eurobond basis) method where the last day of February is always assumed to be the 30th, even if it is the last day of the maturity coupon period.
    /// Encoded/decoded by serializers as "A013".
    /// </summary>
    [EnumMember(Value = "A013")]
    [IsoId("_Uxb0MXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. It is a variation of the 30E/360 (or Eurobond basis) method where the last day of February is always assumed to be the 30th, even if it is the last day of the maturity coupon period.")]
    IC30E3360orEurobondbasismodel3 = InterestComputationMethodCode.IC30E3360orEurobondbasismodel3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. However, if the last day of the maturity coupon period is the last day of February, it will not be assumed to be the 30th. It is a variation of the 30/360 (ICMA) method commonly used for eurobonds. The usage of this variation is only relevant when the coupon periods are scheduled to end on the last day of the month.
    /// Encoded/decoded by serializers as "A007".
    /// </summary>
    [EnumMember(Value = "A007")]
    [IsoId("_U7sjcXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and the 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. However, if the last day of the maturity coupon period is the last day of February, it will not be assumed to be the 30th. It is a variation of the 30/360 (ICMA) method commonly used for eurobonds. The usage of this variation is only relevant when the coupon periods are scheduled to end on the last day of the month.")]
    IC30E360orEuroBondBasismodel1 = InterestComputationMethodCode.IC30E360orEuroBondBasismodel1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. This method is a variation of the 30E360 method with the exception that if the coupon falls on the last day of the month, change it to 1 and increase the month by 1 (ie next month). Method equal to ThirtyEPlusThreeSixty in the FixML model.
    /// Encoded/decoded by serializers as "A016".
    /// </summary>
    [EnumMember(Value = "A016")]
    [IsoId("_VBDkkXitEeqKjIYaFgh_2g")]
    [Description(@"Method whereby interest is calculated based on a 30-day month and a 360-day year. Accrued interest to a value date on the last day of a month shall be the same as to the 30th calendar day of the same month. This means that the 31st is assumed to be the 30th and 28 Feb (or 29 Feb for a leap year) is assumed to be equivalent to 30 Feb. This method is a variation of the 30E360 method with the exception that if the coupon falls on the last day of the month, change it to 1 and increase the month by 1 (ie next month). Method equal to ThirtyEPlusThreeSixty in the FixML model.")]
    IC30EPlus360 = InterestComputationMethodCode.IC30EPlus360, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other method than A001-A020. See Narrative.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_VF0IwXitEeqKjIYaFgh_2g")]
    [Description(@"Other method than A001-A020. See Narrative.")]
    Narrative = InterestComputationMethodCode.Narrative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Also named 1/1. |
    /// ELABORATION: If parties specify the Day Count Fraction to be 1/1 then in calculating the applicable amount, 1 is simply input into the calculation as the relevant Day Count Fraction. See also 2006 ISDA Definitions, Section 4.16. Day Count Fraction, paragraph (a).
    /// Encoded/decoded by serializers as "A020".
    /// </summary>
    [EnumMember(Value = "A020")]
    [IsoId("_VLUT0XitEeqKjIYaFgh_2g")]
    [Description(@"Also named 1/1. ||ELABORATION: If parties specify the Day Count Fraction to be 1/1 then in calculating the applicable amount, 1 is simply input into the calculation as the relevant Day Count Fraction. See also 2006 ISDA Definitions, Section 4.16. Day Count Fraction, paragraph (a).")]
    OneOne = InterestComputationMethodCode.OneOne, // same ordinal as derivation source for type conversions
    
}
