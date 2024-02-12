﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BidRangeType1Code.  ISO2002 ID# _EsjOkO3NEeqc-LCjwLsUVg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of acceptable bid range values.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EsjOkO3NEeqc-LCjwLsUVg")]
[Description(@"Types of acceptable bid range values.")]
[DerivedFrom(typeof(BidRangeTypeCode))]
public enum BidRangeType1Code
{
    /// <summary>
    /// All values (including minimum and maximum prices) are divisible by the bid interval.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_IuYsUe3NEeqc-LCjwLsUVg")]
    [Description(@"All values (including minimum and maximum prices) are divisible by the bid interval.")]
    Divisible = BidRangeTypeCode.Divisible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No values within the bid range are divisible by the bid interval including the minimum and maximum prices.  Each value between the minimum and maximum prices is incremented by the bid interval.
    /// Encoded/decoded by serializers as "INCR".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_Iy9DQe3NEeqc-LCjwLsUVg")]
    [Description(@"No values within the bid range are divisible by the bid interval including the minimum and maximum prices.  Each value between the minimum and maximum prices is incremented by the bid interval.")]
    Incremental = BidRangeTypeCode.Incremental, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minimum and maximum prices are not divisible by the bid interval.  All successive values between the minimum and maximum prices are in multiples of the bid interval.
    /// Encoded/decoded by serializers as "MULT".
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_I3mSse3NEeqc-LCjwLsUVg")]
    [Description(@"Minimum and maximum prices are not divisible by the bid interval.  All successive values between the minimum and maximum prices are in multiples of the bid interval.")]
    InMultiple = BidRangeTypeCode.InMultiple, // same ordinal as derivation source for type conversions
    
}
