﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType8Code.  ISO2002 ID# _baC_dNp-Ed-ak6NoX_4Aeg_-528666353.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_baC_dNp-Ed-ak6NoX_4Aeg_-528666353")]
[Description(@"Specifies the nature of the balance, eg, opening balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType8Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as "OpeningBooked".
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_baC_ddp-Ed-ak6NoX_4Aeg_176637942")]
    [Description(@"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.")]
    OpeningBooked,
    
    /// <summary>
    /// Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "InterimBooked".
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_baC_dtp-Ed-ak6NoX_4Aeg_176637967")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    InterimBooked,
    
    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as "ClosingBooked".
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_baMJYNp-Ed-ak6NoX_4Aeg_176637984")]
    [Description(@"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.")]
    ClosingBooked,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "Expected".
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_baMJYdp-Ed-ak6NoX_4Aeg_215426165")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected,
    
    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "OpeningAvailable".
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_baMJYtp-Ed-ak6NoX_4Aeg_244055871")]
    [Description(@"Opening balance of amount of money that is at the disposal of the account owner on the date specified.")]
    OpeningAvailable,
    
    /// <summary>
    /// Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "InterimAvailable".
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_baMJY9p-Ed-ak6NoX_4Aeg_244055896")]
    [Description(@"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    InterimAvailable,
    
    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "ClosingAvailable".
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_baMJZNp-Ed-ak6NoX_4Aeg_244055931")]
    [Description(@"Closing balance of amount of money that is at the disposal of the account owner on the date specified.")]
    ClosingAvailable,
    
    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "ForwardAvailable".
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_baMJZdp-Ed-ak6NoX_4Aeg_758454777")]
    [Description(@"Forward available balance of money that is at the disposal of the account owner on the date specified.")]
    ForwardAvailable,
    
    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as "PreviouslyClosedBooked".
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_baMJZtp-Ed-ak6NoX_4Aeg_120487110")]
    [Description(@"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.")]
    PreviouslyClosedBooked,
    
    /// <summary>
    /// Investment opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "InvestmentOpeningAvailable".
    /// </summary>
    [EnumMember(Value = "IOPA")]
    [IsoId("_baMJZ9p-Ed-ak6NoX_4Aeg_120487141")]
    [Description(@"Investment opening balance of amount of money that is at the disposal of the account owner on the date specified.")]
    InvestmentOpeningAvailable,
    
    /// <summary>
    /// Investment available balance for calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "InvestmentInterimAvailable".
    /// </summary>
    [EnumMember(Value = "IITA")]
    [IsoId("_baMJaNp-Ed-ak6NoX_4Aeg_120487142")]
    [Description(@"Investment available balance for calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    InvestmentInterimAvailable,
    
    /// <summary>
    /// Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "InvestmentClosingAvailable".
    /// </summary>
    [EnumMember(Value = "ICLA")]
    [IsoId("_baMJadp-Ed-ak6NoX_4Aeg_120487171")]
    [Description(@"Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified.")]
    InvestmentClosingAvailable,
    
    /// <summary>
    /// Investment forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "InvestmentForwardAvailable".
    /// </summary>
    [EnumMember(Value = "IFWA")]
    [IsoId("_baV6YNp-Ed-ak6NoX_4Aeg_120487172")]
    [Description(@"Investment forward available balance of money that is at the disposal of the account owner on the date specified.")]
    InvestmentForwardAvailable,
    
    /// <summary>
    /// Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as "InvestmentClosingBooked".
    /// </summary>
    [EnumMember(Value = "ICLB")]
    [IsoId("_baV6Ydp-Ed-ak6NoX_4Aeg_120487173")]
    [Description(@"Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.")]
    InvestmentClosingBooked,
    
    /// <summary>
    /// Investment balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "InvestmentInterimBooked".
    /// </summary>
    [EnumMember(Value = "IITB")]
    [IsoId("_baV6Ytp-Ed-ak6NoX_4Aeg_120487202")]
    [Description(@"Investment balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    InvestmentInterimBooked,
    
    /// <summary>
    /// Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as "InvestmentOpeningBooked".
    /// </summary>
    [EnumMember(Value = "IOPB")]
    [IsoId("_baV6Y9p-Ed-ak6NoX_4Aeg_120487203")]
    [Description(@"Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.")]
    InvestmentOpeningBooked,
    
    /// <summary>
    /// Investment balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "InvestmentExpected".
    /// </summary>
    [EnumMember(Value = "IXPC")]
    [IsoId("_baV6ZNp-Ed-ak6NoX_4Aeg_120487233")]
    [Description(@"Investment balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    InvestmentExpected,
    
    /// <summary>
    /// Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "DisbursementOpeningAvailable".
    /// </summary>
    [EnumMember(Value = "DOPA")]
    [IsoId("_baV6Zdp-Ed-ak6NoX_4Aeg_120487234")]
    [Description(@"Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified.")]
    DisbursementOpeningAvailable,
    
    /// <summary>
    /// Disbursement available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "DisbursementInterimAvailable".
    /// </summary>
    [EnumMember(Value = "DITA")]
    [IsoId("_baV6Ztp-Ed-ak6NoX_4Aeg_120487504")]
    [Description(@"Disbursement available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    DisbursementInterimAvailable,
    
    /// <summary>
    /// Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "DisbursementClosingAvailable".
    /// </summary>
    [EnumMember(Value = "DCLA")]
    [IsoId("_baV6Z9p-Ed-ak6NoX_4Aeg_120487512")]
    [Description(@"Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified.")]
    DisbursementClosingAvailable,
    
    /// <summary>
    /// Disbursement forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "DisbursementForwardAvailable".
    /// </summary>
    [EnumMember(Value = "DFWA")]
    [IsoId("_baV6aNp-Ed-ak6NoX_4Aeg_120487535")]
    [Description(@"Disbursement forward available balance of money that is at the disposal of the account owner on the date specified.")]
    DisbursementForwardAvailable,
    
    /// <summary>
    /// Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as "DisbursementClosingBooked".
    /// </summary>
    [EnumMember(Value = "DCLB")]
    [IsoId("_baV6adp-Ed-ak6NoX_4Aeg_120487565")]
    [Description(@"Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.")]
    DisbursementClosingBooked,
    
    /// <summary>
    /// Disbursement balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "DisbursementInterimBooked".
    /// </summary>
    [EnumMember(Value = "DITB")]
    [IsoId("_baV6atp-Ed-ak6NoX_4Aeg_120487566")]
    [Description(@"Disbursement balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    DisbursementInterimBooked,
    
    /// <summary>
    /// Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as "DisbursementOpeningBooked".
    /// </summary>
    [EnumMember(Value = "DOPB")]
    [IsoId("_bafEUNp-Ed-ak6NoX_4Aeg_120487596")]
    [Description(@"Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.")]
    DisbursementOpeningBooked,
    
    /// <summary>
    /// Disbursement balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "DisbursementExpected".
    /// </summary>
    [EnumMember(Value = "DXPC")]
    [IsoId("_bafEUdp-Ed-ak6NoX_4Aeg_120487597")]
    [Description(@"Disbursement balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    DisbursementExpected,
    
    /// <summary>
    /// Collection opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "CollectionOpeningAvailable".
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_bafEUtp-Ed-ak6NoX_4Aeg_120487627")]
    [Description(@"Collection opening balance of amount of money that is at the disposal of the account owner on the date specified.")]
    CollectionOpeningAvailable,
    
    /// <summary>
    /// Collection available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "CollectionInterimAvailable".
    /// </summary>
    [EnumMember(Value = "CITA")]
    [IsoId("_bafEU9p-Ed-ak6NoX_4Aeg_120487628")]
    [Description(@"Collection available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    CollectionInterimAvailable,
    
    /// <summary>
    /// Collection closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "CollectionClosingAvailable".
    /// </summary>
    [EnumMember(Value = "CCLA")]
    [IsoId("_bafEVNp-Ed-ak6NoX_4Aeg_120487657")]
    [Description(@"Collection closing balance of amount of money that is at the disposal of the account owner on the date specified.")]
    CollectionClosingAvailable,
    
    /// <summary>
    /// Collection forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "CollectionForwardAvailable".
    /// </summary>
    [EnumMember(Value = "CFWA")]
    [IsoId("_bafEVdp-Ed-ak6NoX_4Aeg_120487688")]
    [Description(@"Collection forward available balance of money that is at the disposal of the account owner on the date specified.")]
    CollectionForwardAvailable,
    
    /// <summary>
    /// Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as "CollectionClosingBooked".
    /// </summary>
    [EnumMember(Value = "CCLB")]
    [IsoId("_bafEVtp-Ed-ak6NoX_4Aeg_120487689")]
    [Description(@"Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.")]
    CollectionClosingBooked,
    
    /// <summary>
    /// Collection balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "CollectionInterimBooked".
    /// </summary>
    [EnumMember(Value = "CITB")]
    [IsoId("_bafEV9p-Ed-ak6NoX_4Aeg_120487719")]
    [Description(@"Collection balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    CollectionInterimBooked,
    
    /// <summary>
    /// Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as "CollectionOpeningBooked".
    /// </summary>
    [EnumMember(Value = "COPB")]
    [IsoId("_bafEWNp-Ed-ak6NoX_4Aeg_120487720")]
    [Description(@"Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.")]
    CollectionOpeningBooked,
    
    /// <summary>
    /// Collection balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "CollectionExpected".
    /// </summary>
    [EnumMember(Value = "CXPC")]
    [IsoId("_bafEWdp-Ed-ak6NoX_4Aeg_120487749")]
    [Description(@"Collection balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    CollectionExpected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceType8CodeMetadataExtensions
{
    private static readonly BalanceType8CodeDropdownSource _dropdownSource = new BalanceType8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceType8CodeDropdownRow GetMetadata(this BalanceType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


