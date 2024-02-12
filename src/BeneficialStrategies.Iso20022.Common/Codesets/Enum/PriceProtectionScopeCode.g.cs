﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceProtectionScopeCode.  ISO2002 ID# _aI1PNtp-Ed-ak6NoX_4Aeg_413321420.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of price protection the customer requires on their order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aI1PNtp-Ed-ak6NoX_4Aeg_413321420")]
[Description(@"Defines the type of price protection the customer requires on their order.")]
[Derivations(typeof(PriceProtectionScope1Code),typeof(PriceProtectionScope2Code))]
public enum PriceProtectionScopeCode
{
    /// <summary>
    /// Price protection is local (for example, Exchange, ECN, ATS).
    /// Encoded/decoded by serializers as "LOCA".
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aI1PN9p-Ed-ak6NoX_4Aeg_1048703534")]
    [Description(@"Price protection is local (for example, Exchange, ECN, ATS).")]
    Local,
    
    /// <summary>
    /// Price protection is national (across all national markets).
    /// Encoded/decoded by serializers as "NATI".
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_aI_AMNp-Ed-ak6NoX_4Aeg_-936209086")]
    [Description(@"Price protection is national (across all national markets).")]
    National,
    
    /// <summary>
    /// Price protection is global (across all markets).
    /// Encoded/decoded by serializers as "GLOB".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aI_AMdp-Ed-ak6NoX_4Aeg_-861403951")]
    [Description(@"Price protection is global (across all markets).")]
    Global,
    
    /// <summary>
    /// Price protection is national (across all national markets) excluding local price protection.
    /// Encoded/decoded by serializers as "NAEL".
    /// </summary>
    [EnumMember(Value = "NAEL")]
    [IsoId("_aI_AMtp-Ed-ak6NoX_4Aeg_-442386317")]
    [Description(@"Price protection is national (across all national markets) excluding local price protection.")]
    NationalExcludingLocal,
    
}
