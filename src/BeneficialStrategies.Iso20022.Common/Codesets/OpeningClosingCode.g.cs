﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OpeningClosingCode.  ISO2002 ID# _aO8eQNp-Ed-ak6NoX_4Aeg_492685359.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information relative to the processing of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aO8eQNp-Ed-ak6NoX_4Aeg_492685359")]
[Description(@"Specifies additional information relative to the processing of the trade.")]
[Derivations(typeof(OpeningClosing1Code))]
public enum OpeningClosingCode
{
    /// <summary>
    /// Indicates that the trade is to close a position.
    /// Encoded/decoded by serializers as &quot;CLOP&quot;.
    /// </summary>
    [EnumMember(Value = "CLOP")]
    [IsoId("_aO8eQdp-Ed-ak6NoX_4Aeg_-1120350445")]
    [Description(@"Indicates that the trade is to close a position.")]
    ClosePosition,
    
    /// <summary>
    /// Indicates that the trade is to open a position.
    /// Encoded/decoded by serializers as &quot;OPEP&quot;.
    /// </summary>
    [EnumMember(Value = "OPEP")]
    [IsoId("_aO8eQtp-Ed-ak6NoX_4Aeg_-724160897")]
    [Description(@"Indicates that the trade is to open a position.")]
    OpenPosition,
    
}
