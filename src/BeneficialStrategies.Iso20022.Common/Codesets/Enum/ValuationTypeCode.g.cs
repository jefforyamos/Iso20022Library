﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValuationTypeCode.  ISO2002 ID# _YQhLUPP4EeS_qLctCs2aRQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type used for the calculation of the valuation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YQhLUPP4EeS_qLctCs2aRQ")]
[Description(@"Specifies the type used for the calculation of the valuation.")]
[Derivations(typeof(ValuationType1Code))]
public enum ValuationTypeCode
{
    /// <summary>
    /// Mark to market valuation.
    /// Encoded/decoded by serializers as "MTMA".
    /// </summary>
    [EnumMember(Value = "MTMA")]
    [IsoId("_dEVfoPP4EeS_qLctCs2aRQ")]
    [Description(@"Mark to market valuation.||")]
    MarkToMarket,
    
    /// <summary>
    /// Mark to model valuation.
    /// Encoded/decoded by serializers as "MTMO".
    /// </summary>
    [EnumMember(Value = "MTMO")]
    [IsoId("_dKIloPP4EeS_qLctCs2aRQ")]
    [Description(@"Mark to model valuation.|")]
    MarkToModel,
    
    /// <summary>
    /// Central counterparty (CCP) valuation.
    /// Encoded/decoded by serializers as "CCPV".
    /// </summary>
    [EnumMember(Value = "CCPV")]
    [IsoId("_db2AsPP4EeS_qLctCs2aRQ")]
    [Description(@"Central counterparty (CCP) valuation.")]
    CCPValuation,
    
    /// <summary>
    /// Amortised cost valuation.
    /// Encoded/decoded by serializers as "AMCS".
    /// </summary>
    [EnumMember(Value = "AMCS")]
    [IsoId("_BQ7LEOZeEeiwYuOX3XC2zQ")]
    [Description(@"Amortised cost valuation.")]
    AmortisedCost,
    
}
