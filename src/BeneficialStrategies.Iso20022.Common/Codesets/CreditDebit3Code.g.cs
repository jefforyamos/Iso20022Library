﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CreditDebit3Code.  ISO2002 ID# _s9EFxjzcEeWg1_uD_bF5Og.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is an increase or a decrease.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s9EFxjzcEeWg1_uD_bF5Og")]
[Description(@"Specifies if an operation is an increase or a decrease.")]
[DerivedFrom(typeof(AmountDirectionCode))]
public enum CreditDebit3Code
{
    /// <summary>
    /// Operation is an increase.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_s9EFxzzcEeWg1_uD_bF5Og")]
    [Description(@"Operation is an increase.")]
    Credit = AmountDirectionCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Operation is a decrease.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_s9EFyDzcEeWg1_uD_bF5Og")]
    [Description(@"Operation is a decrease.")]
    Debit = AmountDirectionCode.Debit, // same ordinal as derivation source for type conversions
    
}
