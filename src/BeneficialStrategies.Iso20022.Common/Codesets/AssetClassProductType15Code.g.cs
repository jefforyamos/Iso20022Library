﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType15Code.  ISO2002 ID# _asQDwVrLEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Other.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asQDwVrLEeWN79Bl6BUd3g")]
[Description(@"Commodity derivative base product code list for Other.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType15Code
{
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a3iGs1rLEeWN79Bl6BUd3g")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
