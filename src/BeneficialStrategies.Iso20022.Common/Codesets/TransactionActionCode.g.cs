﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionActionCode.  ISO2002 ID# _VgL1MNuTEeiB5uLfkg9ZJA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action to realise on a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VgL1MNuTEeiB5uLfkg9ZJA")]
[Description(@"Action to realise on a transaction.")]
[Derivations(typeof(TransactionAction1Code))]
public enum TransactionActionCode
{
    /// <summary>
    /// Start a transaction by a swipe ahead mechanism, with the services which are enabled.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_ZrkQgNuTEeiB5uLfkg9ZJA")]
    [Description(@"Start a transaction by a swipe ahead mechanism, with the services which are enabled.")]
    StartTransaction,
    
    /// <summary>
    /// Keep quite after a swipe ahead mechanism.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_-0oHoOzHEeiojesOXOKoug")]
    [Description(@"Keep quite after a swipe ahead mechanism.")]
    Stop,
    
}
