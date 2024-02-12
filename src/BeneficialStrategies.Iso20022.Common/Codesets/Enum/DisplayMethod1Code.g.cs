﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisplayMethod1Code.  ISO2002 ID# _awK8B9p-Ed-ak6NoX_4Aeg_1593903007.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instructions for the use of display quantity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awK8B9p-Ed-ak6NoX_4Aeg_1593903007")]
[Description(@"Instructions for the use of display quantity.")]
[DerivedFrom(typeof(DisplayMethodCode))]
public enum DisplayMethod1Code
{
    /// <summary>
    /// Indicates that original quantity must be used.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_awK8CNp-Ed-ak6NoX_4Aeg_1639154433")]
    [Description(@"Indicates that original quantity must be used.")]
    Initial = DisplayMethodCode.Initial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that Quantity must be refreshed.
    /// Encoded/decoded by serializers as "NEW1".
    /// </summary>
    [EnumMember(Value = "NEW1")]
    [IsoId("_awUtANp-Ed-ak6NoX_4Aeg_1639154468")]
    [Description(@"Indicates that Quantity must be refreshed.")]
    New = DisplayMethodCode.New, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Randomize value.
    /// Encoded/decoded by serializers as "RAND".
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_awUtAdp-Ed-ak6NoX_4Aeg_1639154503")]
    [Description(@"Randomize value.")]
    Random = DisplayMethodCode.Random, // same ordinal as derivation source for type conversions
    
}
