﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferInFunction2Code.  ISO2002 ID# _p7s5kCVOEeWI0orciOKunQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function of the transfer in confirmation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p7s5kCVOEeWI0orciOKunQ")]
[Description(@"Specifies the function of the transfer in confirmation.")]
[DerivedFrom(typeof(TransferInFunctionCode))]
public enum TransferInFunction2Code
{
    /// <summary>
    /// The transfer-in is a confirmation (rather than an advice).
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ukgQsSVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is a confirmation (rather than an advice).")]
    Confirmation = TransferInFunctionCode.Confirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transfer-in provides advice about account information for a transfer.
    /// Encoded/decoded by serializers as "ADVI".
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_uw_0kSVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in provides advice about account information for a transfer.")]
    Advice = TransferInFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferInFunction2CodeMetadataExtensions
{
    private static readonly TransferInFunction2CodeDropdownSource _dropdownSource = new TransferInFunction2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferInFunction2CodeDropdownRow GetMetadata(this TransferInFunction2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


