﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferInFunctionCode.  ISO2002 ID# _cP0N0CVNEeWI0orciOKunQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function of the transfer in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cP0N0CVNEeWI0orciOKunQ")]
[Description(@"Specifies the function of the transfer in.")]
public enum TransferInFunctionCode
{
    /// <summary>
    /// The transfer-in is an advice and request, that is, the message is used to inform the receiver to expect an unsolicited transfer in confirmation and to request account information for the transfer.
    /// Encoded/decoded by serializers as "ADRE".
    /// </summary>
    [EnumMember(Value = "ADRE")]
    [IsoId("_kBA5QCVNEeWI0orciOKunQ")]
    [Description(@"The transfer-in is an advice and request, that is, the message is used to inform the receiver to expect an unsolicited transfer in confirmation and to request account information for the transfer.")]
    AdviceAndRequest,
    
    /// <summary>
    /// The transfer-in is an instruction.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_Fq0hcCVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is an instruction.")]
    Instruction,
    
    /// <summary>
    /// The transfer-in provides advice about account information for a transfer.
    /// Encoded/decoded by serializers as "ADVI".
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_KOaocCVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in provides advice about account information for a transfer.")]
    Advice,
    
    /// <summary>
    /// The transfer-in is a confirmation (rather than an advice).
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_X8MAACVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is a confirmation (rather than an advice).")]
    Confirmation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferInFunctionCodeMetadataExtensions
{
    private static readonly TransferInFunctionCodeDropdownSource _dropdownSource = new TransferInFunctionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferInFunctionCodeDropdownRow GetMetadata(this TransferInFunctionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

