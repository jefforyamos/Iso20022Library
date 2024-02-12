﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMServiceType6Code.  ISO2002 ID# _MhPq4K3_EeWL1uap3dNhCQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of deposit service selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MhPq4K3_EeWL1uap3dNhCQ")]
[Description(@"Describes the type of deposit service selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType6Code
{
    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as "MCHG".
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_P5EiUa3_EeWL1uap3dNhCQ")]
    [Description(@"Making change between media types.")]
    MakingChange = ATMServiceTypeCode.MakingChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as "DPSN".
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_QHYEE63_EeWL1uap3dNhCQ")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit = ATMServiceTypeCode.NonVerifiedDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as "DPSV".
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_QbvKg63_EeWL1uap3dNhCQ")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit = ATMServiceTypeCode.VerifiedDeposit, // same ordinal as derivation source for type conversions
    
}
