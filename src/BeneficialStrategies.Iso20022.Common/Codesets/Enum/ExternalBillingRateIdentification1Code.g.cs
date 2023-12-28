﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalBillingRateIdentification1Code.  ISO2002 ID# _6WzSlpqlEeGSON8vddiWzQ_1145255535.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of billing rate or factor, as published in an external billing rate identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WzSlpqlEeGSON8vddiWzQ_1145255535")]
[Description(@"Specifies the type of billing rate or factor, as published in an external billing rate identification code list. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalBillingRateIdentificationCode))]
public enum ExternalBillingRateIdentification1Code
{
    /// <summary>
    /// Per annum earnings rate, adjusted for reserves, applied to the current analysis period’s investable balance for calculation of the earnings allowance credit.  The ECR, Net of Reserves, is calculated as:    ECR, Net of Reserves  =  ECR, Not Net (00 01 22) * (1 – Reserve Rate)
    /// Encoded/decoded by serializers as "AdjustedEarningsAllowanceRate".
    /// </summary>
    [EnumMember(Value = "AEAR")]
    [IsoId("_uNpde_RYEeuLhpyIdtJzwg")]
    [Description(@"Per annum earnings rate, adjusted for reserves, applied to the current analysis period’s investable balance for calculation of the earnings allowance credit.  The ECR, Net of Reserves, is calculated as:    ECR, Net of Reserves  =  ECR, Not Net (00 01 22) * (1 – Reserve Rate)")]
    AdjustedEarningsAllowanceRate,
    
    /// <summary>
    /// The anticpated earnings allowance rate, as adjusted, to be used next month in the calculation of the earnings allowance. See AEAR AdjustedEarningsAllowance Rate
    /// Encoded/decoded by serializers as "AdjustedNextMonthEarningsRate".
    /// </summary>
    [EnumMember(Value = "ANXE")]
    [IsoId("_uNpdfvRYEeuLhpyIdtJzwg")]
    [Description(@"The anticpated earnings allowance rate, as adjusted, to be used next month in the calculation of the earnings allowance. See AEAR AdjustedEarningsAllowance Rate")]
    AdjustedNextMonthEarningsRate,
    
    /// <summary>
    /// The current CD (Certificate of Deposit) rate as published by the bank.
    /// Encoded/decoded by serializers as "CDRate".
    /// </summary>
    [EnumMember(Value = "CDRA")]
    [IsoId("_uNynYvRYEeuLhpyIdtJzwg")]
    [Description(@"The current CD (Certificate of Deposit) rate as published by the bank.")]
    CDRate,
    
    /// <summary>
    /// The per annum rate used to calculate the Deficiency Interest amount to be paid to the bank. 
    /// Encoded/decoded by serializers as "DeficiencyInterestRate".
    /// </summary>
    [EnumMember(Value = "DINR")]
    [IsoId("_uNynZfRYEeuLhpyIdtJzwg")]
    [Description(@"The per annum rate used to calculate the Deficiency Interest amount to be paid to the bank. ")]
    DeficiencyInterestRate,
    
    /// <summary>
    /// The per annum rate used to calculate a surcharge based on the Deficiency Interest amount to be paid to the bank. 
    /// Encoded/decoded by serializers as "DeficiencySurchargeRate".
    /// </summary>
    [EnumMember(Value = "DSCR")]
    [IsoId("_uNynaPRYEeuLhpyIdtJzwg")]
    [Description(@"The per annum rate used to calculate a surcharge based on the Deficiency Interest amount to be paid to the bank. ")]
    DeficiencySurchargeRate,
    
    /// <summary>
    /// Per annum earnings rate applied to the current statement period’s investable balance for calculation of the earnings allowance credit. The earnings allowance credit is used to offset the charges for balance compensable services. This rate has NOT been adjusted for reserves. The ECR, Not Net of Reserves, is calculated as:    ECR, Not Net  =  ECR, Net of Reserves (00 01 20)  /  (1 – Reserve Rate)
    /// Encoded/decoded by serializers as "EarningsAllowanceRate".
    /// </summary>
    [EnumMember(Value = "EALR")]
    [IsoId("_uNyna_RYEeuLhpyIdtJzwg")]
    [Description(@"Per annum earnings rate applied to the current statement period’s investable balance for calculation of the earnings allowance credit. The earnings allowance credit is used to offset the charges for balance compensable services. This rate has NOT been adjusted for reserves. The ECR, Not Net of Reserves, is calculated as:    ECR, Not Net  =  ECR, Net of Reserves (00 01 20)  /  (1 – Reserve Rate)")]
    EarningsAllowanceRate,
    
    /// <summary>
    /// The current FDIC rate used in the US to calculate the Federal Deposit Insurance premium paid by the banks to the FDIC.
    /// Encoded/decoded by serializers as "FDICRate".
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_uN8YYvRYEeuLhpyIdtJzwg")]
    [Description(@"The current FDIC rate used in the US to calculate the Federal Deposit Insurance premium paid by the banks to the FDIC.")]
    FDICRate,
    
    /// <summary>
    /// Per annum interest rate used to calculate the interest amount credited to a designated account. The amount of interest credited, if any, is reported in a Compensation Section with a Compensation Identifier of TtlInterestCredited
    /// Encoded/decoded by serializers as "InterestCreditedRate".
    /// </summary>
    [EnumMember(Value = "ICDR")]
    [IsoId("_uN8YZfRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate the interest amount credited to a designated account. The amount of interest credited, if any, is reported in a Compensation Section with a Compensation Identifier of TtlInterestCredited")]
    InterestCreditedRate,
    
    /// <summary>
    /// The collected balance required to offset $1.00 of balance compensable service charges.  This factor can be used to calculate the balance equivalent of balance compensable service charges.  The multiplier is calculated in one of three different ways depending on whether the Earnings Allowance Rate (ECR) is adjusted for reserves or not (net of reserves or not)  and, in the case where the ECR is not adjusted for reserves, whether the multiplier is adjusted for reserves or not.
    /// Encoded/decoded by serializers as "Multiplier".
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_uN8YaPRYEeuLhpyIdtJzwg")]
    [Description(@"The collected balance required to offset $1.00 of balance compensable service charges.  This factor can be used to calculate the balance equivalent of balance compensable service charges.  The multiplier is calculated in one of three different ways depending on whether the Earnings Allowance Rate (ECR) is adjusted for reserves or not (net of reserves or not)  and, in the case where the ECR is not adjusted for reserves, whether the multiplier is adjusted for reserves or not.")]
    Multiplier,
    
    /// <summary>
    /// Per annum interest rate used to calculate overdraft compensation on an average net collected balance which is negative (AFP balance 00 00 10).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.
    /// Encoded/decoded by serializers as "NetCollectedBalanceOverdraftRate".
    /// </summary>
    [EnumMember(Value = "NCBO")]
    [IsoId("_uN8Ya_RYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate overdraft compensation on an average net collected balance which is negative (AFP balance 00 00 10).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.")]
    NetCollectedBalanceOverdraftRate,
    
    /// <summary>
    /// Per annum interest rate applied to NEGATIVE collected balances (AFP balance 00 00 13) for calculation of overdraft compensation.
    /// Encoded/decoded by serializers as "NegativeCollectedOverdraftRate".
    /// </summary>
    [EnumMember(Value = "NGCO")]
    [IsoId("_uN8YbvRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate applied to NEGATIVE collected balances (AFP balance 00 00 13) for calculation of overdraft compensation.")]
    NegativeCollectedOverdraftRate,
    
    /// <summary>
    /// Per annum interest rate applied to NEGATIVE ledger balances (AFP balance 00 00 03) for calculation of overdraft compensation.
    /// Encoded/decoded by serializers as "NegativeLedgerOverdraftRate".
    /// </summary>
    [EnumMember(Value = "NGLO")]
    [IsoId("_uOGJYvRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate applied to NEGATIVE ledger balances (AFP balance 00 00 03) for calculation of overdraft compensation.")]
    NegativeLedgerOverdraftRate,
    
    /// <summary>
    /// Per annum interest rate used to calculate overdraft compensation on an average net ledger balance which is negative (AFP balance 00 00 00).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.
    /// Encoded/decoded by serializers as "NetLedgerBalanceOverdraftRate".
    /// </summary>
    [EnumMember(Value = "NLBO")]
    [IsoId("_uOGJZfRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate overdraft compensation on an average net ledger balance which is negative (AFP balance 00 00 00).  An average NET balance is negative when the sum of the daily ending POSITIVE and NEGATIVE balances is negative.")]
    NetLedgerBalanceOverdraftRate,
    
    /// <summary>
    /// The anticpated earnings allowance rate to be used next month in the calculation of the earnings allowance. See EALR EarningsAllowance Rate
    /// Encoded/decoded by serializers as "NextMonthEarningsAllowanceRate".
    /// </summary>
    [EnumMember(Value = "NXME")]
    [IsoId("_uOGJaPRYEeuLhpyIdtJzwg")]
    [Description(@"The anticpated earnings allowance rate to be used next month in the calculation of the earnings allowance. See EALR EarningsAllowance Rate")]
    NextMonthEarningsAllowanceRate,
    
    /// <summary>
    /// The anticipated Multiplier to be used next month. See MULT Multiplier.
    /// Encoded/decoded by serializers as "NextMonthMultiplier".
    /// </summary>
    [EnumMember(Value = "NXMU")]
    [IsoId("_uOGJa_RYEeuLhpyIdtJzwg")]
    [Description(@"The anticipated Multiplier to be used next month. See MULT Multiplier.")]
    NextMonthMultiplier,
    
    /// <summary>
    /// The current per annum Prime rate as published by the bank.
    /// Encoded/decoded by serializers as "PrimeRate".
    /// </summary>
    [EnumMember(Value = "PRIR")]
    [IsoId("_uOGJbvRYEeuLhpyIdtJzwg")]
    [Description(@"The current per annum Prime rate as published by the bank.")]
    PrimeRate,
    
    /// <summary>
    /// The per annum reserve rate as applied to non demand deposit accounts such as time deposit or CD accounts.
    /// Encoded/decoded by serializers as "ReserveRequirementRateNonDDA".
    /// </summary>
    [EnumMember(Value = "RRQR")]
    [IsoId("_uOP6YvRYEeuLhpyIdtJzwg")]
    [Description(@"The per annum reserve rate as applied to non demand deposit accounts such as time deposit or CD accounts.")]
    ReserveRequirementRateNonDDA,
    
    /// <summary>
    /// Per annum interest rate used to calculate that portion of the CollectedBal-AvgPositive that US banks must keep on deposit at the US Federal Reserve.
    /// Encoded/decoded by serializers as "ReserveRequirementRate".
    /// </summary>
    [EnumMember(Value = "RSRV")]
    [IsoId("_uOP6ZfRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate used to calculate that portion of the CollectedBal-AvgPositive that US banks must keep on deposit at the US Federal Reserve.")]
    ReserveRequirementRate,
    
    /// <summary>
    /// Per annum interest rate assessed on that portion of the account balance which is the difference between the average negative ledger and the average negative collected balance (AFP balance 00 00 15).  This rate is used to assess compensation on the portion of the negative collected balance that represents the use of uncollected funds.
    /// Encoded/decoded by serializers as "UncollectedFundsUsageRate".
    /// </summary>
    [EnumMember(Value = "UFUR")]
    [IsoId("_uOP6aPRYEeuLhpyIdtJzwg")]
    [Description(@"Per annum interest rate assessed on that portion of the account balance which is the difference between the average negative ledger and the average negative collected balance (AFP balance 00 00 15).  This rate is used to assess compensation on the portion of the negative collected balance that represents the use of uncollected funds.")]
    UncollectedFundsUsageRate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalBillingRateIdentification1CodeMetadataExtensions
{
    private static readonly ExternalBillingRateIdentification1CodeDropdownSource _dropdownSource = new ExternalBillingRateIdentification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalBillingRateIdentification1CodeDropdownRow GetMetadata(this ExternalBillingRateIdentification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


