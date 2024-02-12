﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalShipmentCondition1Code.  ISO2002 ID# _H6MiMdNAEeSDLevdaFPXHw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a shipment conditions code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H6MiMdNAEeSDLevdaFPXHw")]
[Description(@"Specifies a shipment conditions code, as published in the external ISO 20022 external code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalShipmentConditionCode))]
public enum ExternalShipmentCondition1Code
{
    /// <summary>
    /// Goods/service delivered after payment
    /// Encoded/decoded by serializers as "ADVN".
    /// </summary>
    [EnumMember(Value = "ADVN")]
    [IsoId("_uUDne_RYEeuLhpyIdtJzwg")]
    [Description(@"Goods/service delivered after payment")]
    AdvancePayment = ExternalShipmentConditionCode.AdvancePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Goods/service delivered at the same time as payment.
    /// Encoded/decoded by serializers as "PMNT".
    /// </summary>
    [EnumMember(Value = "PMNT")]
    [IsoId("_uUDnfvRYEeuLhpyIdtJzwg")]
    [Description(@"Goods/service delivered at the same time as payment.")]
    DeliveryversusPayment = ExternalShipmentConditionCode.DeliveryversusPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Goods/service delivered before payment
    /// Encoded/decoded by serializers as "TRLN".
    /// </summary>
    [EnumMember(Value = "TRLN")]
    [IsoId("_uUMxYvRYEeuLhpyIdtJzwg")]
    [Description(@"Goods/service delivered before payment")]
    TradeLoan = ExternalShipmentConditionCode.TradeLoan, // same ordinal as derivation source for type conversions
    
}
