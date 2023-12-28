﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValuationTiming1Code.  ISO2002 ID# _Y81WJtp-Ed-ak6NoX_4Aeg_1401456437.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y81WJtp-Ed-ak6NoX_4Aeg_1401456437")]
[Description(@"Specifies how the price valuation timing is done based on the timeline defined in the prospectus.")]
[DerivedFrom(typeof(ValuationTimingCode))]
public enum ValuationTiming1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Exceptional".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y81WJ9p-Ed-ak6NoX_4Aeg_1401456439")]
    [Description(@"??")]
    Exceptional,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Usual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y81WKNp-Ed-ak6NoX_4Aeg_1401456440")]
    [Description(@"??")]
    Usual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Particular".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y81WKdp-Ed-ak6NoX_4Aeg_1401456441")]
    [Description(@"??")]
    Particular,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValuationTiming1CodeMetadataExtensions
{
    private static readonly ValuationTiming1CodeDropdownSource _dropdownSource = new ValuationTiming1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValuationTiming1CodeDropdownRow GetMetadata(this ValuationTiming1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

