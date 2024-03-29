﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralPurpose1Code.  ISO2002 ID# _YZXctdp-Ed-ak6NoX_4Aeg_527391185.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZXctdp-Ed-ak6NoX_4Aeg_527391185")]
[Description(@"Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.")]
[DerivedFrom(typeof(CollateralPurposeCode))]
public enum CollateralPurpose1Code
{
    /// <summary>
    /// Collateral has been posted against the variation margin.
    /// Encoded/decoded by serializers as &quot;VAMA&quot;.
    /// </summary>
    [EnumMember(Value = "VAMA")]
    [IsoId("_YZXcttp-Ed-ak6NoX_4Aeg_-761638906")]
    [Description(@"Collateral has been posted against the variation margin.")]
    VariationMargin = CollateralPurposeCode.VariationMargin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral has been posted against the segregated independent amount.
    /// Encoded/decoded by serializers as &quot;SINA&quot;.
    /// </summary>
    [EnumMember(Value = "SINA")]
    [IsoId("_YZXct9p-Ed-ak6NoX_4Aeg_2062598685")]
    [Description(@"Collateral has been posted against the segregated independent amount.")]
    SegregatedIndependentAmount = CollateralPurposeCode.SegregatedIndependentAmount, // same ordinal as derivation source for type conversions
    
}
