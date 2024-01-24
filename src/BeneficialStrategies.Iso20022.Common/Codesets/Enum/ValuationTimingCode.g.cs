﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValuationTimingCode.  ISO2002 ID# _Y8_HINp-Ed-ak6NoX_4Aeg_1401456451.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y8_HINp-Ed-ak6NoX_4Aeg_1401456451")]
[Description(@"Specifies how the price valuation timing is done based on the timeline defined in the prospectus.")]
[Derivations(typeof(ValuationTiming1Code))]
public enum ValuationTimingCode
{
    /// <summary>
    /// Price valuation is done exceptionally, outside the timeframe specified in the prospectus.
    /// Encoded/decoded by serializers as "EXCP".
    /// </summary>
    [EnumMember(Value = "EXCP")]
    [IsoId("_Y8_HIdp-Ed-ak6NoX_4Aeg_1401456452")]
    [Description(@"Price valuation is done exceptionally, outside the timeframe specified in the prospectus.")]
    Exceptional,
    
    /// <summary>
    /// Price valuation is done within the timeframe specified in the prospectus.
    /// Encoded/decoded by serializers as "USUA".
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_Y8_HItp-Ed-ak6NoX_4Aeg_1401456453")]
    [Description(@"Price valuation is done within the timeframe specified in the prospectus.")]
    Usual,
    
    /// <summary>
    /// Price valuation that is done outside the usual timeframe, but in conformance with a case specified in the prospectus, eg, market closing day.
    /// Encoded/decoded by serializers as "PATC".
    /// </summary>
    [EnumMember(Value = "PATC")]
    [IsoId("_Y8_HI9p-Ed-ak6NoX_4Aeg_1401456454")]
    [Description(@"Price valuation that is done outside the usual timeframe, but in conformance with a case specified in the prospectus, eg, market closing day.")]
    Particular,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValuationTimingCodeMetadataExtensions
{
    private static readonly ValuationTimingCodeDropdownSource _dropdownSource = new ValuationTimingCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValuationTimingCodeDropdownRow GetMetadata(this ValuationTimingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


