﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDepositType1Code.  ISO2002 ID# _355HIC7TEemIy6A-26wnAg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the type of deposit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_355HIC7TEemIy6A-26wnAg")]
[Description(@"Contains the type of deposit.")]
[DerivedFrom(typeof(CardDepositTypeCode))]
public enum CardDepositType1Code
{
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6AbV0S7TEemIy6A-26wnAg")]
    [Description(@"Other Private")]
    OtherPrivate = CardDepositTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6EiZwS7TEemIy6A-26wnAg")]
    [Description(@"Other National")]
    OtherNational = CardDepositTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Envelope
    /// Encoded/decoded by serializers as "ENVL".
    /// </summary>
    [EnumMember(Value = "ENVL")]
    [IsoId("_6JHXwS7TEemIy6A-26wnAg")]
    [Description(@"Envelope")]
    Envelope = CardDepositTypeCode.Envelope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque
    /// Encoded/decoded by serializers as "CHEC".
    /// </summary>
    [EnumMember(Value = "CHEC")]
    [IsoId("_6KROUS7TEemIy6A-26wnAg")]
    [Description(@"Cheque")]
    Cheque = CardDepositTypeCode.Cheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_6L8CQS7TEemIy6A-26wnAg")]
    [Description(@"Cash")]
    Cash = CardDepositTypeCode.Cash, // same ordinal as derivation source for type conversions
    
}
