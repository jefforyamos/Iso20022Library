﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDebtorActivationAmendmentReason1Code.  ISO2002 ID# _90jEx_GAEemQ7oqCO5NTQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_90jEx_GAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDebtorActivationAmendmentReasonCode))]
public enum ExternalDebtorActivationAmendmentReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as "AM05".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuSFW_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalDebtorActivationAmendmentReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as "RF01".
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uubPQvRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalDebtorActivationAmendmentReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as "RR04".
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uulAQvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalDebtorActivationAmendmentReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as "TRJT".
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uulARfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalDebtorActivationAmendmentReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as "UCRD".
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uuuxQvRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor = ExternalDebtorActivationAmendmentReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
    
}
