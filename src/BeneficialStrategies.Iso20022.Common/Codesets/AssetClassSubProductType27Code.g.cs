﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType27Code.  ISO2002 ID# _omSLIVrKEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Light Ends.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_omSLIVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Light Ends.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType27Code
{
    /// <summary>
    /// Commodity of type light ends.
    /// Encoded/decoded by serializers as &quot;LGHT&quot;.
    /// </summary>
    [EnumMember(Value = "LGHT")]
    [IsoId("_oxn4d1rKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type light ends.")]
    LightEnds = AssetClassSubProductTypeCode.LightEnds, // same ordinal as derivation source for type conversions
    
}
