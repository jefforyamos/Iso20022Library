﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType14Code.  ISO2002 ID# _ZZfbYVrLEeWN79Bl6BUd3g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Official Economic Statistics.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZfbYVrLEeWN79Bl6BUd3g")]
[Description(@"Commodity derivative base product code list for Official Economic Statistics.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType14Code
{
    /// <summary>
    /// Commodity of type official economic statistic.
    /// Encoded/decoded by serializers as &quot;OEST&quot;.
    /// </summary>
    [EnumMember(Value = "OEST")]
    [IsoId("_Zkr-xVrLEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type official economic statistic.")]
    OfficialEconomicStatistic = AssetClassProductTypeCode.OfficialEconomicStatistic, // same ordinal as derivation source for type conversions
    
}
