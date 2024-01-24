﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType12Code.  ISO2002 ID# _bmQ2gtp-Ed-ak6NoX_4Aeg_1716764065.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmQ2gtp-Ed-ak6NoX_4Aeg_1716764065")]
[Description(@"Specifies the balance type.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType12Code
{
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as "XPCD".
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_bmQ2g9p-Ed-ak6NoX_4Aeg_1717684427")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.")]
    Expected = BalanceTypeCode.Expected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "OPAV".
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_bmQ2hNp-Ed-ak6NoX_4Aeg_1717685653")]
    [Description(@"Opening balance of amount of money that is at the disposal of the account owner on the date specified.")]
    OpeningAvailable = BalanceTypeCode.OpeningAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "ITAV".
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_bmQ2hdp-Ed-ak6NoX_4Aeg_1717685654")]
    [Description(@"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    InterimAvailable = BalanceTypeCode.InterimAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "CLAV".
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_bmQ2htp-Ed-ak6NoX_4Aeg_1717685683")]
    [Description(@"Closing balance of amount of money that is at the disposal of the account owner on the date specified.")]
    ClosingAvailable = BalanceTypeCode.ClosingAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "FWAV".
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_bmQ2h9p-Ed-ak6NoX_4Aeg_1717685684")]
    [Description(@"Forward available balance of money that is at the disposal of the account owner on the date specified.")]
    ForwardAvailable = BalanceTypeCode.ForwardAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as "CLBD".
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_bmQ2iNp-Ed-ak6NoX_4Aeg_1717685714")]
    [Description(@"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.")]
    ClosingBooked = BalanceTypeCode.ClosingBooked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as "ITBD".
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_bmQ2idp-Ed-ak6NoX_4Aeg_1717685744")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.")]
    InterimBooked = BalanceTypeCode.InterimBooked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as "OPBD".
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_bmaAcNp-Ed-ak6NoX_4Aeg_1717685745")]
    [Description(@"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.")]
    OpeningBooked = BalanceTypeCode.OpeningBooked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as "PRCD".
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_bmaAcdp-Ed-ak6NoX_4Aeg_1717685775")]
    [Description(@"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.")]
    PreviouslyClosedBooked = BalanceTypeCode.PreviouslyClosedBooked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance for informational purposes.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_bmaActp-Ed-ak6NoX_4Aeg_-1574337323")]
    [Description(@"Balance for informational purposes.")]
    Information = BalanceTypeCode.Information, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceType12CodeMetadataExtensions
{
    private static readonly BalanceType12CodeDropdownSource _dropdownSource = new BalanceType12CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceType12CodeDropdownRow GetMetadata(this BalanceType12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


