﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NonEligibleProceedsIndicatorCode.  ISO2002 ID# _aNmactp-Ed-ak6NoX_4Aeg_975102968.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information regarding the non eligibility of the outturn resources.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNmactp-Ed-ak6NoX_4Aeg_975102968")]
[Description(@"Specifies information regarding the non eligibility of the outturn resources.")]
public enum NonEligibleProceedsIndicatorCode
{
    /// <summary>
    /// Security not eligible in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "NELS".
    /// </summary>
    [EnumMember(Value = "NELS")]
    [IsoId("_aNmac9p-Ed-ak6NoX_4Aeg_-1729563943")]
    [Description(@"Security not eligible in the Central Securities Depository (CSD).")]
    NonEligibleSecurity,
    
    /// <summary>
    /// Currency not eligible for settlement in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "NELC".
    /// </summary>
    [EnumMember(Value = "NELC")]
    [IsoId("_aNmadNp-Ed-ak6NoX_4Aeg_-1670456685")]
    [Description(@"Currency not eligible for settlement in the Central Securities Depository (CSD).")]
    NonEligibleCurrency,
    
    /// <summary>
    /// Participant's account limitation.
    /// Encoded/decoded by serializers as "ACLI".
    /// </summary>
    [EnumMember(Value = "ACLI")]
    [IsoId("_aNmaddp-Ed-ak6NoX_4Aeg_-1627052409")]
    [Description(@"Participant's account limitation.")]
    AccountLimitation,
    
    /// <summary>
    /// Other source of non eligibility.
    /// Encoded/decoded by serializers as "ONEL".
    /// </summary>
    [EnumMember(Value = "ONEL")]
    [IsoId("_aNmadtp-Ed-ak6NoX_4Aeg_-1602117129")]
    [Description(@"Other source of non eligibility.")]
    OtherNonEligibility,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NonEligibleProceedsIndicatorCodeMetadataExtensions
{
    private static readonly NonEligibleProceedsIndicatorCodeDropdownSource _dropdownSource = new NonEligibleProceedsIndicatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INonEligibleProceedsIndicatorCodeDropdownRow GetMetadata(this NonEligibleProceedsIndicatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

