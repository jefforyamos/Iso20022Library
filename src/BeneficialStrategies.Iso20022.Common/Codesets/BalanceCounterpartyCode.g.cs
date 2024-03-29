﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceCounterpartyCode.  ISO2002 ID# _bkBa1dp-Ed-ak6NoX_4Aeg_678189971.
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
[IsoId("_bkBa1dp-Ed-ak6NoX_4Aeg_678189971")]
[Description(@"Specifies the type of counterparty to be taken into account for calculation of the balance.")]
[Derivations(typeof(BalanceCounterparty1Code))]
public enum BalanceCounterpartyCode
{
    /// <summary>
    /// Balance calculated regarding one member in the system.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_bkBa1tp-Ed-ak6NoX_4Aeg_678189972")]
    [Description(@"Balance calculated regarding one member in the system.")]
    Bilateral,
    
    /// <summary>
    /// Balance calculated regarding all members in the system.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_bkBa19p-Ed-ak6NoX_4Aeg_678189973")]
    [Description(@"Balance calculated regarding all members in the system.")]
    Multilateral,
    
}
