﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LockStatus1Code.  ISO2002 ID# _mrGisGjMEeiRg5NzP0jkQg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the lock status of a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mrGisGjMEeiRg5NzP0jkQg")]
[Description(@"Specifies the lock status of a party.")]
[DerivedFrom(typeof(LockStatusCode))]
public enum LockStatus1Code
{
    /// <summary>
    /// Party has been locked for operations.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_oSkPwWjMEeiRg5NzP0jkQg")]
    [Description(@"Party has been locked for operations.")]
    Locked = LockStatusCode.Locked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party is ready for operations.
    /// Encoded/decoded by serializers as &quot;ULCK&quot;.
    /// </summary>
    [EnumMember(Value = "ULCK")]
    [IsoId("_oYLIgWjMEeiRg5NzP0jkQg")]
    [Description(@"Party is ready for operations.")]
    Unlocked = LockStatusCode.Unlocked, // same ordinal as derivation source for type conversions
    
}
