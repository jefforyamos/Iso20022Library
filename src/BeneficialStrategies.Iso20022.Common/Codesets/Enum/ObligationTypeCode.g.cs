﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ObligationTypeCode.  ISO2002 ID# _YZ95pNp-Ed-ak6NoX_4Aeg_878628292.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the obligation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZ95pNp-Ed-ak6NoX_4Aeg_878628292")]
[Description(@"Specifies the type of the obligation.")]
public enum ObligationTypeCode
{
    /// <summary>
    /// Specifies that the obligation is related to a failed trade.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_YZ95pdp-Ed-ak6NoX_4Aeg_2016902374")]
    [Description(@"Specifies that the obligation is related to a failed trade.")]
    Fails,
    
    /// <summary>
    /// Specifies that the obligation is related to new a trade.
    /// Encoded/decoded by serializers as "NEW1".
    /// </summary>
    [EnumMember(Value = "NEW1")]
    [IsoId("_YZ95ptp-Ed-ak6NoX_4Aeg_-692422985")]
    [Description(@"Specifies that the obligation is related to new a trade.")]
    New,
    
    /// <summary>
    /// Specifies that the obligation is related to a corporate event.
    /// Encoded/decoded by serializers as "COEV".
    /// </summary>
    [EnumMember(Value = "COEV")]
    [IsoId("_YZ95p9p-Ed-ak6NoX_4Aeg_1882565158")]
    [Description(@"Specifies that the obligation is related to a corporate event.")]
    CorporateEvent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ObligationTypeCodeMetadataExtensions
{
    private static readonly ObligationTypeCodeDropdownSource _dropdownSource = new ObligationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IObligationTypeCodeDropdownRow GetMetadata(this ObligationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


