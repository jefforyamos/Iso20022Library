﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarketClientSide1Code.  ISO2002 ID# _YJO4wJ05Eeet_4BCDEBLdQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an instruction is for a market or client side transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YJO4wJ05Eeet_4BCDEBLdQ")]
[Description(@"Specifies if an instruction is for a market or client side transaction.")]
[DerivedFrom(typeof(MarketClientSideCode))]
public enum MarketClientSide1Code
{
    /// <summary>
    /// Instruction is for a client side transaction.
    /// Encoded/decoded by serializers as "CLNT".
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_ZWTI0Z05Eeet_4BCDEBLdQ")]
    [Description(@"Instruction is for a client side transaction.")]
    ClientSide = MarketClientSideCode.ClientSide, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is for a market side transaction.
    /// Encoded/decoded by serializers as "MAKT".
    /// </summary>
    [EnumMember(Value = "MAKT")]
    [IsoId("_ZbqJ8Z05Eeet_4BCDEBLdQ")]
    [Description(@"Instruction is for a market side transaction.")]
    MarketSide = MarketClientSideCode.MarketSide, // same ordinal as derivation source for type conversions
    
}
