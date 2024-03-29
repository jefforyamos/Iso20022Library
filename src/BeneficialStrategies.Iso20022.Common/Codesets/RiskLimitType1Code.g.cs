﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RiskLimitType1Code.  ISO2002 ID# _Vm240dp-Ed-ak6NoX_4Aeg_-1698330250.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vm240dp-Ed-ak6NoX_4Aeg_-1698330250")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum RiskLimitType1Code
{
    /// <summary>
    /// Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_Vm240tp-Ed-ak6NoX_4Aeg_-1698330241")]
    [Description(@"Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.")]
    Multilateral = LimitTypeCode.Multilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;BILI&quot;.
    /// </summary>
    [EnumMember(Value = "BILI")]
    [IsoId("_Vm2409p-Ed-ak6NoX_4Aeg_-1698330240")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    Bilateral = LimitTypeCode.Bilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_Vm241Np-Ed-ak6NoX_4Aeg_-1698330239")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.")]
    NetBilateral = LimitTypeCode.NetBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.
    /// Encoded/decoded by serializers as &quot;INBI&quot;.
    /// </summary>
    [EnumMember(Value = "INBI")]
    [IsoId("_Vm241dp-Ed-ak6NoX_4Aeg_-1698330238")]
    [Description(@"Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.")]
    IndirectBilateral = LimitTypeCode.IndirectBilateral, // same ordinal as derivation source for type conversions
    
}
