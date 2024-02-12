﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType31Code.  ISO2002 ID# _sJUiQbv3EeiLRYqS-r-R-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Natural Gas.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sJUiQbv3EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Natural Gas.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType31Code
{
    /// <summary>
    /// Commodity attribute of type GASPOOL.
    /// Encoded/decoded by serializers as "GASP".
    /// </summary>
    [EnumMember(Value = "GASP")]
    [IsoId("_sTWoAbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type GASPOOL.")]
    GasPool = AssetClassDetailedSubProductTypeCode.GasPool, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type liquid natural gas.
    /// Encoded/decoded by serializers as "LNGG".
    /// </summary>
    [EnumMember(Value = "LNGG")]
    [IsoId("_sTWoA7v3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type liquid natural gas.")]
    LNG = AssetClassDetailedSubProductTypeCode.LNG, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type NCG (NetConnect Germany).
    /// Encoded/decoded by serializers as "NCGG".
    /// </summary>
    [EnumMember(Value = "NCGG")]
    [IsoId("_sTWoBbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type NCG (NetConnect Germany).")]
    NCG = AssetClassDetailedSubProductTypeCode.NCG, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type TTF (Dutch Title Transfer Facility).
    /// Encoded/decoded by serializers as "TTFG".
    /// </summary>
    [EnumMember(Value = "TTFG")]
    [IsoId("_sTWoB7v3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type TTF (Dutch Title Transfer Facility).")]
    TTF = AssetClassDetailedSubProductTypeCode.TTF, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type NBP (National Balancing Point).
    /// Encoded/decoded by serializers as "NBPG".
    /// </summary>
    [EnumMember(Value = "NBPG")]
    [IsoId("_sTWoCbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type NBP (National Balancing Point).")]
    NBP = AssetClassDetailedSubProductTypeCode.NBP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ubxtEbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
