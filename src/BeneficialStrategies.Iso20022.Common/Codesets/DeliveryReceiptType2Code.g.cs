﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryReceiptType2Code.  ISO2002 ID# _azJXhdp-Ed-ak6NoX_4Aeg_11908462.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the transaction is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azJXhdp-Ed-ak6NoX_4Aeg_11908462")]
[Description(@"Specifies how the transaction is to be settled.")]
[DerivedFrom(typeof(DeliveryReceiptTypeCode))]
public enum DeliveryReceiptType2Code
{
    /// <summary>
    /// Settlement of the financial instrument and cash is separate.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_azJXhtp-Ed-ak6NoX_4Aeg_-2033362077")]
    [Description(@"Settlement of the financial instrument and cash is separate.")]
    SeparateSettlement = DeliveryReceiptTypeCode.SeparateSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement of the financial instrument and cash takes place in a delivery versus payment (DVP) environment, that is, through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;APMT&quot;.
    /// </summary>
    [EnumMember(Value = "APMT")]
    [IsoId("_azJXh9p-Ed-ak6NoX_4Aeg_-2033361692")]
    [Description(@"Settlement of the financial instrument and cash takes place in a delivery versus payment (DVP) environment, that is, through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).")]
    AgainstPaymentSettlement = DeliveryReceiptTypeCode.AgainstPaymentSettlement, // same ordinal as derivation source for type conversions
    
}
