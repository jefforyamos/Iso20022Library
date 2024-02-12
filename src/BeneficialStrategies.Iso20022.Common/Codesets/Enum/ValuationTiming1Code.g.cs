﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValuationTiming1Code.  ISO2002 ID# _Y81WJtp-Ed-ak6NoX_4Aeg_1401456437.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Price valuation is done exceptionally, outside the timeframe specified in the prospectus.
    /// Encoded/decoded by serializers as "EXCP".
    /// </summary>
    [EnumMember(Value = "EXCP")]
    [IsoId("_Y81WJ9p-Ed-ak6NoX_4Aeg_1401456439")]
    [Description(@"Price valuation is done exceptionally, outside the timeframe specified in the prospectus.")]
    Exceptional = ValuationTimingCode.Exceptional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price valuation is done within the timeframe specified in the prospectus.
    /// Encoded/decoded by serializers as "USUA".
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_Y81WKNp-Ed-ak6NoX_4Aeg_1401456440")]
    [Description(@"Price valuation is done within the timeframe specified in the prospectus.")]
    Usual = ValuationTimingCode.Usual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price valuation that is done outside the usual timeframe, but in conformance with a case specified in the prospectus, eg, market closing day.
    /// Encoded/decoded by serializers as "PATC".
    /// </summary>
    [EnumMember(Value = "PATC")]
    [IsoId("_Y81WKdp-Ed-ak6NoX_4Aeg_1401456441")]
    [Description(@"Price valuation that is done outside the usual timeframe, but in conformance with a case specified in the prospectus, eg, market closing day.")]
    Particular = ValuationTimingCode.Particular, // same ordinal as derivation source for type conversions
    
}
