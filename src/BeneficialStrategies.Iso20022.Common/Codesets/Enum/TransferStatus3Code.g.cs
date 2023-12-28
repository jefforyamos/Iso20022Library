﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferStatus3Code.  ISO2002 ID# _pHI5gBwfEeOIveEnnb_1-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pHI5gBwfEeOIveEnnb_1-A")]
[Description(@"Specifies the transfer or settlement instruction status.")]
[DerivedFrom(typeof(TransferStatusCode))]
public enum TransferStatus3Code
{
    /// <summary>
    /// Transfer or settlement instruction is fully executed and the confirmation is sent.
    /// Encoded/decoded by serializers as "AlreadyExecuted".
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_tuKvABwfEeOIveEnnb_1-A")]
    [Description(@"Transfer or settlement instruction is fully executed and the confirmation is sent.")]
    AlreadyExecuted,
    
    /// <summary>
    /// Transfer or settlement instruction is matched.
    /// Encoded/decoded by serializers as "Matched".
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_uABUARwfEeOIveEnnb_1-A")]
    [Description(@"Transfer or settlement instruction is matched.")]
    Matched,
    
    /// <summary>
    /// Transfer or settlement instruction has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_uwqt0RwfEeOIveEnnb_1-A")]
    [Description(@"Transfer or settlement instruction has been acknowledged / accepted for further processing.")]
    Accepted,
    
    /// <summary>
    /// Transfer or settlement instruction is settled.
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ve8JERwfEeOIveEnnb_1-A")]
    [Description(@"Transfer or settlement instruction is settled.")]
    Settled,
    
    /// <summary>
    /// Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as "SentToNextParty".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_wFUzoRwfEeOIveEnnb_1-A")]
    [Description(@"Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_wkHocRwfEeOIveEnnb_1-A")]
    [Description(@"Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferStatus3CodeMetadataExtensions
{
    private static readonly TransferStatus3CodeDropdownSource _dropdownSource = new TransferStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferStatus3CodeDropdownRow GetMetadata(this TransferStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


