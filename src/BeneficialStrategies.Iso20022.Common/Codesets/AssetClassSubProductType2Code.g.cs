﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType2Code.  ISO2002 ID# _7HmpgAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Softs.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7HmpgAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Softs.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType2Code
{
    /// <summary>
    /// Commodity of type softs.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_MkTJ4QnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type softs.")]
    Softs = AssetClassSubProductTypeCode.Softs, // same ordinal as derivation source for type conversions
    
}
