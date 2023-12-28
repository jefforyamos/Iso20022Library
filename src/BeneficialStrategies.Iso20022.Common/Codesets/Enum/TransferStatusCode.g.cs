﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferStatusCode.  ISO2002 ID# _YvRbQ9p-Ed-ak6NoX_4Aeg_-141526851.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YvRbQ9p-Ed-ak6NoX_4Aeg_-141526851")]
[Description(@"Specifies the transfer or settlement instruction status.")]
[Derivations(typeof(TransferStatus1Code),typeof(TransferStatus2Code),typeof(TransferStatus3Code),typeof(TransferStatus4Code),typeof(TransferStatus6Code))]
// External derivations that should be provided by the proper interface are: 
public enum TransferStatusCode
{
    /// <summary>
    /// Transfer or settlement instruction has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_YvRbRNp-Ed-ak6NoX_4Aeg_-57488337")]
    [Description(@"Transfer or settlement instruction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as "STNP".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_YvRbRdp-Ed-ak6NoX_4Aeg_-57487407")]
    [Description(@"Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Transfer or settlement instruction has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YvRbRtp-Ed-ak6NoX_4Aeg_593328820")]
    [Description(@"Transfer or settlement instruction has been acknowledged / accepted for further processing.")]
    Accepted,
    
    /// <summary>
    /// Transfer or settlement instruction has been executed, confirmed and then the confirmation has been reversed.
    /// Encoded/decoded by serializers as "RVSD".
    /// </summary>
    [EnumMember(Value = "RVSD")]
    [IsoId("_YvRbR9p-Ed-ak6NoX_4Aeg_-1794302245")]
    [Description(@"Transfer or settlement instruction has been executed, confirmed and then the confirmation has been reversed.")]
    Reversed,
    
    /// <summary>
    /// Transfer or settlement instruction is matched.
    /// Encoded/decoded by serializers as "MACH".
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_YvbMQNp-Ed-ak6NoX_4Aeg_1040312490")]
    [Description(@"Transfer or settlement instruction is matched.")]
    Matched,
    
    /// <summary>
    /// Transfer or settlement instruction is fully executed and the confirmation is sent.
    /// Encoded/decoded by serializers as "COSE".
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_YvbMQdp-Ed-ak6NoX_4Aeg_1458667502")]
    [Description(@"Transfer or settlement instruction is fully executed and the confirmation is sent.")]
    AlreadyExecuted,
    
    /// <summary>
    /// Transfer or settlement instruction is in repair.
    /// Encoded/decoded by serializers as "REPR".
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_YvbMQtp-Ed-ak6NoX_4Aeg_1566721757")]
    [Description(@"Transfer or settlement instruction is in repair.")]
    InRepair,
    
    /// <summary>
    /// Transfer or settlement instruction is unmatched.
    /// Encoded/decoded by serializers as "NMAT".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_YvbMQ9p-Ed-ak6NoX_4Aeg_1639679493")]
    [Description(@"Transfer or settlement instruction is unmatched.")]
    Unmatched,
    
    /// <summary>
    /// Transfer or settlement instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_YvbMRNp-Ed-ak6NoX_4Aeg_913854987")]
    [Description(@"Transfer or settlement instruction has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Transfer cancellation instruction or settlement cancellation instruction is pending.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_YvbMRdp-Ed-ak6NoX_4Aeg_2126556345")]
    [Description(@"Transfer cancellation instruction or settlement cancellation instruction is pending.")]
    CancellationPending,
    
    /// <summary>
    /// Transfer or settlement instruction is settled.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YvbMRtp-Ed-ak6NoX_4Aeg_823239905")]
    [Description(@"Transfer or settlement instruction is settled.")]
    Settled,
    
    /// <summary>
    /// Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_Q03ocBwfEeOIveEnnb_1-A")]
    [Description(@"Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received,
    
    /// <summary>
    /// Portfolio transfer is complete.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_snBMQCY-EeW_ZNn8gbfY7Q")]
    [Description(@"Portfolio transfer is complete.")]
    Complete,
    
    /// <summary>
    /// Transfer or settlement instruction is delayed.
    /// Encoded/decoded by serializers as "DELY".
    /// </summary>
    [EnumMember(Value = "DELY")]
    [IsoId("_Bmb04LsYEeiTr4dQrTCaYA")]
    [Description(@"Transfer or settlement instruction is delayed.")]
    Delayed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferStatusCodeMetadataExtensions
{
    private static readonly TransferStatusCodeDropdownSource _dropdownSource = new TransferStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferStatusCodeDropdownRow GetMetadata(this TransferStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


