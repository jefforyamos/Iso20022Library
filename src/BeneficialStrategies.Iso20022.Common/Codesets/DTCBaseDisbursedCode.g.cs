﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCBaseDisbursedCode.  ISO2002 ID# _1qBZgDL3EeKU9IrkkToqcw_183881059.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the calculation basis is on base (original) or disbursed (distributed) security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1qBZgDL3EeKU9IrkkToqcw_183881059")]
[Description(@"Specifies whether the calculation basis is on base (original) or disbursed (distributed) security.")]
[Derivations(typeof(DTCBaseDisbursed1Code))]
public enum DTCBaseDisbursedCode
{
    /// <summary>
    /// Based on base security.
    /// Encoded/decoded by serializers as &quot;BASE&quot;.
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_1qBZgTL3EeKU9IrkkToqcw_682874645")]
    [Description(@"Based on base security.")]
    Base,
    
    /// <summary>
    /// Based on disbursed security.
    /// Encoded/decoded by serializers as &quot;DISB&quot;.
    /// </summary>
    [EnumMember(Value = "DISB")]
    [IsoId("_1qBZgjL3EeKU9IrkkToqcw_-1428030677")]
    [Description(@"Based on disbursed security.")]
    Disbursed,
    
}
