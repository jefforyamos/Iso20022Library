﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType8Code.  ISO2002 ID# _UVsIweEJEd-udr336SN7mQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "ToBeSpecified".
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_q5RTNmtdEeCY4-KZ9JEyUQ_2120036301")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified,
    
    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as "Unspecified".
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_q5bEMGtdEeCY4-KZ9JEyUQ_945022265")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified,
    
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5bEMWtdEeCY4-KZ9JEyUQ_-52050088")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown,
    
    /// <summary>
    /// Price will not be paid.
    /// Encoded/decoded by serializers as "NilPayment".
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_q5bEMmtdEeCY4-KZ9JEyUQ_1399109534")]
    [Description(@"Price will not be paid.")]
    NilPayment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType8CodeMetadataExtensions
{
    private static readonly PriceValueType8CodeDropdownSource _dropdownSource = new PriceValueType8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType8CodeDropdownRow GetMetadata(this PriceValueType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


