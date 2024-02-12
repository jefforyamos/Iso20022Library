﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType24Code.  ISO2002 ID# _e_R0oVrKEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Coal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e_R0oVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Coal.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType24Code
{
    /// <summary>
    /// Commodity of type coal.
    /// Encoded/decoded by serializers as "COAL".
    /// </summary>
    [EnumMember(Value = "COAL")]
    [IsoId("_fK85IVrKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type coal.")]
    Coal = AssetClassSubProductTypeCode.Coal, // same ordinal as derivation source for type conversions
    
}
