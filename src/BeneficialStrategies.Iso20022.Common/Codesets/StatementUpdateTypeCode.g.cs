﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementUpdateTypeCode.  ISO2002 ID# _ZQWvEdp-Ed-ak6NoX_4Aeg_-1582551543.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of a statement update, eg, it is a complete statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQWvEdp-Ed-ak6NoX_4Aeg_-1582551543")]
[Description(@"Specifies the nature of a statement update, eg, it is a complete statement.")]
public enum StatementUpdateTypeCode
{
    /// <summary>
    /// Statement is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQWvEtp-Ed-ak6NoX_4Aeg_-1582551317")]
    [Description(@"Statement is complete.")]
    Complete,
    
    /// <summary>
    /// Statement contains changes only.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ZQWvE9p-Ed-ak6NoX_4Aeg_-1582551316")]
    [Description(@"Statement contains changes only.")]
    Delta,
    
}
