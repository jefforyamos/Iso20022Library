﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NonEligibleProceedsIndicator1Code.  ISO2002 ID# _aNcpdtp-Ed-ak6NoX_4Aeg_1631723636.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information regarding the non eligibility of the outturn resources.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNcpdtp-Ed-ak6NoX_4Aeg_1631723636")]
[Description(@"Specifies information regarding the non eligibility of the outturn resources.")]
[DerivedFrom(typeof(NonEligibleProceedsIndicatorCode))]
public enum NonEligibleProceedsIndicator1Code
{
    /// <summary>
    /// Currency not eligible for settlement in the Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as "NonEligibleCurrency".
    /// </summary>
    [EnumMember(Value = "NELC")]
    [IsoId("_aNcpd9p-Ed-ak6NoX_4Aeg_-1557787681")]
    [Description(@"Currency not eligible for settlement in the Central Securities Depository (CSD).")]
    NonEligibleCurrency,
    
    /// <summary>
    /// Participant's account limitation.
    /// Encoded/decoded by serializers as "AccountLimitation".
    /// </summary>
    [EnumMember(Value = "ACLI")]
    [IsoId("_aNmacNp-Ed-ak6NoX_4Aeg_-1557787656")]
    [Description(@"Participant's account limitation.")]
    AccountLimitation,
    
    /// <summary>
    /// Other source of non eligibility.
    /// Encoded/decoded by serializers as "OtherNonEligibility".
    /// </summary>
    [EnumMember(Value = "ONEL")]
    [IsoId("_aNmacdp-Ed-ak6NoX_4Aeg_-1557787373")]
    [Description(@"Other source of non eligibility.")]
    OtherNonEligibility,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NonEligibleProceedsIndicator1CodeMetadataExtensions
{
    private static readonly NonEligibleProceedsIndicator1CodeDropdownSource _dropdownSource = new NonEligibleProceedsIndicator1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INonEligibleProceedsIndicator1CodeDropdownRow GetMetadata(this NonEligibleProceedsIndicator1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


