﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceAdjustmentTypeCode.  ISO2002 ID# _6URjCJqlEeGSON8vddiWzQ_-920501493.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of allowed balance adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6URjCJqlEeGSON8vddiWzQ_-920501493")]
[Description(@"Defines the type of allowed balance adjustment.")]
[Derivations(typeof(BalanceAdjustmentType1Code))]
public enum BalanceAdjustmentTypeCode
{
    /// <summary>
    /// Adjustment applies to the average ledger (book) balance.
    /// Encoded/decoded by serializers as &quot;LDGR&quot;.
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_6Uas8JqlEeGSON8vddiWzQ_817535103")]
    [Description(@"Adjustment applies to the average ledger (book) balance.")]
    Ledger,
    
    /// <summary>
    /// Adjustment applies to the average float (unavailable) balance.
    /// Encoded/decoded by serializers as &quot;FLOT&quot;.
    /// </summary>
    [EnumMember(Value = "FLOT")]
    [IsoId("_6Uas8ZqlEeGSON8vddiWzQ_1333312355")]
    [Description(@"Adjustment applies to the average float (unavailable) balance.")]
    Float,
    
    /// <summary>
    /// Adjustment applies to the average collected (book less float) balance.
    /// Encoded/decoded by serializers as &quot;CLLD&quot;.
    /// </summary>
    [EnumMember(Value = "CLLD")]
    [IsoId("_6Uas8pqlEeGSON8vddiWzQ_-2029841198")]
    [Description(@"Adjustment applies to the average collected (book less float) balance.")]
    Collected,
    
}
