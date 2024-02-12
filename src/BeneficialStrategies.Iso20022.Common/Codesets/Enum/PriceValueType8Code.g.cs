﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType8Code.  ISO2002 ID# _UVsIweEJEd-udr336SN7mQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of price value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UVsIweEJEd-udr336SN7mQ")]
[Description(@"Specifies a type of price value.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType8Code
{
    /// <summary>
    /// Price to be specified by account owner.
    /// Encoded/decoded by serializers as "TBSP".
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_q5RTNmtdEeCY4-KZ9JEyUQ_2120036301")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified = PriceValueTypeCode.ToBeSpecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as "UNSP".
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_q5bEMGtdEeCY4-KZ9JEyUQ_945022265")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified = PriceValueTypeCode.Unspecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5bEMWtdEeCY4-KZ9JEyUQ_-52050088")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price will not be paid.
    /// Encoded/decoded by serializers as "NILP".
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_q5bEMmtdEeCY4-KZ9JEyUQ_1399109534")]
    [Description(@"Price will not be paid.")]
    NilPayment = PriceValueTypeCode.NilPayment, // same ordinal as derivation source for type conversions
    
}
