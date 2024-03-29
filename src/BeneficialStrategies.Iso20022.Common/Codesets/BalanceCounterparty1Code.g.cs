﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceCounterparty1Code.  ISO2002 ID# _bkBa0tp-Ed-ak6NoX_4Aeg_678189976.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of counterparty to be taken into account for calculation of the balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bkBa0tp-Ed-ak6NoX_4Aeg_678189976")]
[Description(@"Specifies the type of counterparty to be taken into account for calculation of the balance.")]
[DerivedFrom(typeof(BalanceCounterpartyCode))]
public enum BalanceCounterparty1Code
{
    /// <summary>
    /// Balance calculated regarding one member in the system.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_bkBa09p-Ed-ak6NoX_4Aeg_678189977")]
    [Description(@"Balance calculated regarding one member in the system.")]
    Bilateral = BalanceCounterpartyCode.Bilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance calculated regarding all members in the system.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_bkBa1Np-Ed-ak6NoX_4Aeg_678189978")]
    [Description(@"Balance calculated regarding all members in the system.")]
    Multilateral = BalanceCounterpartyCode.Multilateral, // same ordinal as derivation source for type conversions
    
}
