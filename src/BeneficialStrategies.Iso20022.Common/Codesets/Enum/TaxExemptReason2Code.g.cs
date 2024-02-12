﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxExemptReason2Code.  ISO2002 ID# _VlEJGNp-Ed-ak6NoX_4Aeg_-1078452737.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VlEJGNp-Ed-ak6NoX_4Aeg_-1078452737")]
[Description(@"Specifies the reason a specific tax has not been levied/deducted on a given transaction.")]
[DerivedFrom(typeof(TaxExemptReasonCode))]
public enum TaxExemptReason2Code
{
    /// <summary>
    /// Account is not tax exempt.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_VlN6ENp-Ed-ak6NoX_4Aeg_-1019348348")]
    [Description(@"Account is not tax exempt.")]
    None = TaxExemptReasonCode.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maxi Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). The Maxi ISA allows an investor to save all three of the different elements of ISA investments that are allowed, with one savings institution in a single account.
    /// Encoded/decoded by serializers as "MASA".
    /// </summary>
    [EnumMember(Value = "MASA")]
    [IsoId("_VlN6Edp-Ed-ak6NoX_4Aeg_-1019347790")]
    [Description(@"Maxi Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). The Maxi ISA allows an investor to save all three of the different elements of ISA investments that are allowed, with one savings institution in a single account.")]
    MaxiISA = TaxExemptReasonCode.MaxiISA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mini Cash Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). An investor can hold more than one Mini ISA to utilise the overall Mini ISA investment limit, and can invest with more than one savings institution, however only one of the three elements of ISA investment is allowed in a single account.
    /// Encoded/decoded by serializers as "MISA".
    /// </summary>
    [EnumMember(Value = "MISA")]
    [IsoId("_VlN6Etp-Ed-ak6NoX_4Aeg_-1019347478")]
    [Description(@"Mini Cash Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). An investor can hold more than one Mini ISA to utilise the overall Mini ISA investment limit, and can invest with more than one savings institution, however only one of the three elements of ISA investment is allowed in a single account.")]
    MiniCashISA = TaxExemptReasonCode.MiniCashISA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mini Stocks and Shares Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain stocks, shares and collective investments up to the prescribed annual subscription limit (required for UK).
    /// Encoded/decoded by serializers as "SISA".
    /// </summary>
    [EnumMember(Value = "SISA")]
    [IsoId("_VlN6E9p-Ed-ak6NoX_4Aeg_-1019347393")]
    [Description(@"Mini Stocks and Shares Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain stocks, shares and collective investments up to the prescribed annual subscription limit (required for UK).")]
    MiniStocksAndSharesISA = TaxExemptReasonCode.MiniStocksAndSharesISA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mini Insurance Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain life insurance investments up to the prescribed annual subscription limit (required for UK).
    /// Encoded/decoded by serializers as "IISA".
    /// </summary>
    [EnumMember(Value = "IISA")]
    [IsoId("_VlN6FNp-Ed-ak6NoX_4Aeg_-1019347358")]
    [Description(@"Mini Insurance Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain life insurance investments up to the prescribed annual subscription limit (required for UK).")]
    MiniInsuranceISA = TaxExemptReasonCode.MiniInsuranceISA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for current year payments into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "CUYP".
    /// </summary>
    [EnumMember(Value = "CUYP")]
    [IsoId("_VlN6Fdp-Ed-ak6NoX_4Aeg_-1019347033")]
    [Description(@"Account is for current year payments into an investment retirement account (required for US).")]
    CurrentYearPayment = TaxExemptReasonCode.CurrentYearPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for a prior year payment into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "PRYP".
    /// </summary>
    [EnumMember(Value = "PRYP")]
    [IsoId("_VlN6Ftp-Ed-ak6NoX_4Aeg_-1019346973")]
    [Description(@"Account is for a prior year payment into an investment retirement account (required for US).")]
    PriorYearPayment = TaxExemptReasonCode.PriorYearPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for an asset transfer into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "ASTR".
    /// </summary>
    [EnumMember(Value = "ASTR")]
    [IsoId("_VlN6F9p-Ed-ak6NoX_4Aeg_-1019346938")]
    [Description(@"Account is for an asset transfer into an investment retirement account (required for US).")]
    AssetTransfer = TaxExemptReasonCode.AssetTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for employee - prior year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "EMPY".
    /// </summary>
    [EnumMember(Value = "EMPY")]
    [IsoId("_VlN6GNp-Ed-ak6NoX_4Aeg_-1019346895")]
    [Description(@"Account is for employee - prior year contributions into an investment retirement account (required for US).")]
    EmployeePriorYear = TaxExemptReasonCode.EmployeePriorYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for employee - current year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "EMCY".
    /// </summary>
    [EnumMember(Value = "EMCY")]
    [IsoId("_VlN6Gdp-Ed-ak6NoX_4Aeg_-1019346860")]
    [Description(@"Account is for employee - current year contributions into an investment retirement account (required for US).")]
    EmployeeCurrentYear = TaxExemptReasonCode.EmployeeCurrentYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for employer - prior year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "EPRY".
    /// </summary>
    [EnumMember(Value = "EPRY")]
    [IsoId("_VlXEANp-Ed-ak6NoX_4Aeg_-1019346783")]
    [Description(@"Account is for employer - prior year contributions into an investment retirement account (required for US).")]
    EmployerPriorYear = TaxExemptReasonCode.EmployerPriorYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for employer - current year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "ECYE".
    /// </summary>
    [EnumMember(Value = "ECYE")]
    [IsoId("_VlXEAdp-Ed-ak6NoX_4Aeg_-1019346523")]
    [Description(@"Account is for employer - current year contributions into an investment retirement account (required for US).")]
    EmployerCurrentYear = TaxExemptReasonCode.EmployerCurrentYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for non-fund prototype Individual Retirement Account (IRA) into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "NFPI".
    /// </summary>
    [EnumMember(Value = "NFPI")]
    [IsoId("_VlXEAtp-Ed-ak6NoX_4Aeg_-1019346488")]
    [Description(@"Account is for non-fund prototype Individual Retirement Account (IRA) into an investment retirement account (required for US).")]
    NonFundPrototypeIRA = TaxExemptReasonCode.NonFundPrototypeIRA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for non-fund qualified plan into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as "NFQP".
    /// </summary>
    [EnumMember(Value = "NFQP")]
    [IsoId("_VlXEA9p-Ed-ak6NoX_4Aeg_-1019346411")]
    [Description(@"Account is for non-fund qualified plan into an investment retirement account (required for US).")]
    NonFundQualifiedPlan = TaxExemptReasonCode.NonFundQualifiedPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for a defined contribution plan (required for US).
    /// Encoded/decoded by serializers as "DECP".
    /// </summary>
    [EnumMember(Value = "DECP")]
    [IsoId("_VlXEBNp-Ed-ak6NoX_4Aeg_-1018426397")]
    [Description(@"Account is for a defined contribution plan (required for US).")]
    DefinedContributionPlan = TaxExemptReasonCode.DefinedContributionPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is an Individual Retirement Account (IRA) (required for US).
    /// Encoded/decoded by serializers as "IRAC".
    /// </summary>
    [EnumMember(Value = "IRAC")]
    [IsoId("_VlXEBdp-Ed-ak6NoX_4Aeg_-1018426344")]
    [Description(@"Account is an Individual Retirement Account (IRA) (required for US).")]
    IndividualRetirementAccount = TaxExemptReasonCode.IndividualRetirementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for an Individual Retirement Account (IRA) - Rollover (required for US).
    /// Encoded/decoded by serializers as "IRAR".
    /// </summary>
    [EnumMember(Value = "IRAR")]
    [IsoId("_VlXEBtp-Ed-ak6NoX_4Aeg_-1018426302")]
    [Description(@"Account is for an Individual Retirement Account (IRA) - Rollover (required for US).")]
    IndividualRetirementAccountRollover = TaxExemptReasonCode.IndividualRetirementAccountRollover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// KEOGH. Account is a tax-deferred retirement plan designed to help self-employed workers or individuals who earn self-employed income establish a retirement savings program (required for US).
    /// Encoded/decoded by serializers as "KEOG".
    /// </summary>
    [EnumMember(Value = "KEOG")]
    [IsoId("_VlXEB9p-Ed-ak6NoX_4Aeg_-1018426241")]
    [Description(@"KEOGH. Account is a tax-deferred retirement plan designed to help self-employed workers or individuals who earn self-employed income establish a retirement savings program (required for US).")]
    KEOGH = TaxExemptReasonCode.KEOGH, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is a Profit Sharing Plan (required for US).
    /// Encoded/decoded by serializers as "PFSP".
    /// </summary>
    [EnumMember(Value = "PFSP")]
    [IsoId("_VlXECNp-Ed-ak6NoX_4Aeg_-1018426163")]
    [Description(@"Account is a Profit Sharing Plan (required for US).")]
    ProfitSharingPlan = TaxExemptReasonCode.ProfitSharingPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// 401k. Account is an optional retirement plan supported by many companies, in which income is invested before it is taxed (required for US).
    /// Encoded/decoded by serializers as "401K".
    /// </summary>
    [EnumMember(Value = "401K")]
    [IsoId("_VlXECdp-Ed-ak6NoX_4Aeg_-1018425886")]
    [Description(@"401k. Account is an optional retirement plan supported by many companies, in which income is invested before it is taxed (required for US).")]
    FourHundredAndOneK = TaxExemptReasonCode.FourHundredAndOneK, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Self-Directed Individual Retirement Account (IRA) (required for US).
    /// Encoded/decoded by serializers as "SIRA".
    /// </summary>
    [EnumMember(Value = "SIRA")]
    [IsoId("_Vlg1ANp-Ed-ak6NoX_4Aeg_-1018425834")]
    [Description(@"Self-Directed Individual Retirement Account (IRA) (required for US).")]
    SelfDirectedIRA = TaxExemptReasonCode.SelfDirectedIRA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// 403(b). Account is a tax-deferred investment and savings program for employees of hospitals, educational institutions and other non-profit organisations, to save and invest in their own retirement. The name refers to the relevant section in the US Internal Revenue Code (required for US).
    /// Encoded/decoded by serializers as "403B".
    /// </summary>
    [EnumMember(Value = "403B")]
    [IsoId("_Vlg1Adp-Ed-ak6NoX_4Aeg_-1018425731")]
    [Description(@"403(b). Account is a tax-deferred investment and savings program for employees of hospitals, educational institutions and other non-profit organisations, to save and invest in their own retirement. The name refers to the relevant section in the US Internal Revenue Code (required for US).")]
    FourHundredAndThreeB = TaxExemptReasonCode.FourHundredAndThreeB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// 457. Account is a non-qualified deferred compensation program that is available to state and local governments and not-for-profit employers (required for US).
    /// Encoded/decoded by serializers as "457X".
    /// </summary>
    [EnumMember(Value = "457X")]
    [IsoId("_Vlg1Atp-Ed-ak6NoX_4Aeg_-1018425448")]
    [Description(@"457. Account is a non-qualified deferred compensation program that is available to state and local governments and not-for-profit employers (required for US).")]
    FourHundredFiftySeven = TaxExemptReasonCode.FourHundredFiftySeven, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Roth Individual Retirement Account (IRA) Fund Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).
    /// Encoded/decoded by serializers as "RIRA".
    /// </summary>
    [EnumMember(Value = "RIRA")]
    [IsoId("_Vlg1A9p-Ed-ak6NoX_4Aeg_-1018425388")]
    [Description(@"Roth Individual Retirement Account (IRA) Fund Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).")]
    RothIRAFundPrototype = TaxExemptReasonCode.RothIRAFundPrototype, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Roth Individual Retirement Account (IRA) Non-Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).
    /// Encoded/decoded by serializers as "RIAN".
    /// </summary>
    [EnumMember(Value = "RIAN")]
    [IsoId("_Vlg1BNp-Ed-ak6NoX_4Aeg_-1018425311")]
    [Description(@"Roth Individual Retirement Account (IRA) Non-Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).")]
    RothIRANonPrototype = TaxExemptReasonCode.RothIRANonPrototype, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Roth Conversion Individual Retirement Account (IRA) Fund Prototype. Account is a retirement account established when a party switches from a regular IRA ( required for US).
    /// Encoded/decoded by serializers as "RCRF".
    /// </summary>
    [EnumMember(Value = "RCRF")]
    [IsoId("_Vlg1Bdp-Ed-ak6NoX_4Aeg_-1018425258")]
    [Description(@"Roth Conversion Individual Retirement Account (IRA) Fund Prototype. Account is a retirement account established when a party switches from a regular IRA ( required for US).")]
    RothConversionIRAFundPrototype = TaxExemptReasonCode.RothConversionIRAFundPrototype, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Roth Conversion Individual Retirement Account (IRA) Non-Prototype. Account is a retirement account established when a party switches from a Regular IRA (required for US).
    /// Encoded/decoded by serializers as "RCIP".
    /// </summary>
    [EnumMember(Value = "RCIP")]
    [IsoId("_Vlg1Btp-Ed-ak6NoX_4Aeg_-1018425216")]
    [Description(@"Roth Conversion Individual Retirement Account (IRA) Non-Prototype. Account is a retirement account established when a party switches from a Regular IRA (required for US).")]
    RothConversionIRANonPrototype = TaxExemptReasonCode.RothConversionIRANonPrototype, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Education Individual Retirement Account Fund Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required for US).
    /// Encoded/decoded by serializers as "EIFP".
    /// </summary>
    [EnumMember(Value = "EIFP")]
    [IsoId("_Vlg1B9p-Ed-ak6NoX_4Aeg_-1018425156")]
    [Description(@"Education Individual Retirement Account Fund Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required for US).")]
    EducationIRAFundPrototype = TaxExemptReasonCode.EducationIRAFundPrototype, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Education Individual Retirement Account Non-Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required in the US).
    /// Encoded/decoded by serializers as "EIOP".
    /// </summary>
    [EnumMember(Value = "EIOP")]
    [IsoId("_Vlg1CNp-Ed-ak6NoX_4Aeg_-1018424861")]
    [Description(@"Education Individual Retirement Account Non-Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required in the US).")]
    EducationIRANonPrototype = TaxExemptReasonCode.EducationIRANonPrototype, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of tax exemption.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vlg1Cdp-Ed-ak6NoX_4Aeg_-745984629")]
    [Description(@"Another type of tax exemption.")]
    Other = TaxExemptReasonCode.Other, // same ordinal as derivation source for type conversions
    
}
