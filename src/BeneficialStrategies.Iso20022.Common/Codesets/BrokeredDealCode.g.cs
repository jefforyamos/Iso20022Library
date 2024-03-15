﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BrokeredDealCode.  ISO2002 ID# _TXL5MHvREeWrWYBng3OpVw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the transaction is arranged via a third party broker or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TXL5MHvREeWrWYBng3OpVw")]
[Description(@"Specifies whether the transaction is arranged via a third party broker or not.")]
[Derivations(typeof(BrokeredDeal1Code))]
public enum BrokeredDealCode
{
    /// <summary>
    /// Transaction was arranged by a third party broking agent.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_WQ54UHvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged by a third party broking agent.||")]
    BrokeredTransaction,
    
    /// <summary>
    /// Transaction was arranged directly by the reporting agent.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_WXrOsHvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged directly by the reporting agent.")]
    BilateralTransaction,
    
}
