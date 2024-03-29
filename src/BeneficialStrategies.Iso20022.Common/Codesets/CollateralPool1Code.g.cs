﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralPool1Code.  ISO2002 ID# _A695wN7GEeSaBeqd_btViQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the collateral is a pool collateral or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A695wN7GEeSaBeqd_btViQ")]
[Description(@"Specifies whether the collateral is a pool collateral or not.")]
[DerivedFrom(typeof(CollateralPoolCode))]
public enum CollateralPool1Code
{
    /// <summary>
    /// Collateral is not of pool type.
    /// Encoded/decoded by serializers as &quot;NOPL&quot;.
    /// </summary>
    [EnumMember(Value = "NOPL")]
    [IsoId("_CvAqQd7GEeSaBeqd_btViQ")]
    [Description(@"Collateral is not of pool type.")]
    NoPool = CollateralPoolCode.NoPool, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral is of pool type.
    /// Encoded/decoded by serializers as &quot;POOL&quot;.
    /// </summary>
    [EnumMember(Value = "POOL")]
    [IsoId("_Czndcd7GEeSaBeqd_btViQ")]
    [Description(@"Collateral is of pool type.")]
    Pool = CollateralPoolCode.Pool, // same ordinal as derivation source for type conversions
    
}
