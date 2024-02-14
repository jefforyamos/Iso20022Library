﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType4Code.  ISO2002 ID# _tE68cAnzEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Freight.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tE68cAnzEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Freight.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType4Code
{
    /// <summary>
    /// Commodity of type freight.
    /// Encoded/decoded by serializers as &quot;FRGT&quot;.
    /// </summary>
    [EnumMember(Value = "FRGT")]
    [IsoId("_w4AMgQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type freight.")]
    Freight = AssetClassProductTypeCode.Freight, // same ordinal as derivation source for type conversions
    
}
