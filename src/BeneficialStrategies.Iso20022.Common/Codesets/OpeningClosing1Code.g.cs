﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OpeningClosing1Code.  ISO2002 ID# _aOytRtp-Ed-ak6NoX_4Aeg_1505902353.
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
[IsoId("_aOytRtp-Ed-ak6NoX_4Aeg_1505902353")]
[Description(@"Specifies additional information relative to the processing of the trade.")]
[DerivedFrom(typeof(OpeningClosingCode))]
public enum OpeningClosing1Code
{
    /// <summary>
    /// Indicates that the trade is to close a position.
    /// Encoded/decoded by serializers as &quot;CLOP&quot;.
    /// </summary>
    [EnumMember(Value = "CLOP")]
    [IsoId("_aOytR9p-Ed-ak6NoX_4Aeg_1340458350")]
    [Description(@"Indicates that the trade is to close a position.")]
    ClosePosition = OpeningClosingCode.ClosePosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the trade is to open a position.
    /// Encoded/decoded by serializers as &quot;OPEP&quot;.
    /// </summary>
    [EnumMember(Value = "OPEP")]
    [IsoId("_aOytSNp-Ed-ak6NoX_4Aeg_1926405376")]
    [Description(@"Indicates that the trade is to open a position.")]
    OpenPosition = OpeningClosingCode.OpenPosition, // same ordinal as derivation source for type conversions
    
}
