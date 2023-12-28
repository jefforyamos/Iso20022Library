﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentInstructionStatusCode.  ISO2002 ID# _Zzq3h9p-Ed-ak6NoX_4Aeg_676865279.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of a payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zzq3h9p-Ed-ak6NoX_4Aeg_676865279")]
[Description(@"Specifies the state of a payment.")]
[Derivations(typeof(PaymentInstructionStatus1Code),typeof(PendingStatus1Code),typeof(FinalStatusCode),typeof(PendingStatus4Code),typeof(PendingStatus3Code),typeof(FinalStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum PaymentInstructionStatusCode
{
    /// <summary>
    /// Transaction has been accepted by the clearing agent.
    /// Encoded/decoded by serializers as "ACPD".
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_Zzq3iNp-Ed-ak6NoX_4Aeg_-1407038166")]
    [Description(@"Transaction has been accepted by the clearing agent.")]
    Accepted,
    
    /// <summary>
    /// Transaction has been validated by the clearing agent.
    /// Encoded/decoded by serializers as "VALD".
    /// </summary>
    [EnumMember(Value = "VALD")]
    [IsoId("_Zz0ogNp-Ed-ak6NoX_4Aeg_-1407038081")]
    [Description(@"Transaction has been validated by the clearing agent.")]
    Validated,
    
    /// <summary>
    /// Transaction has been authorised by the transaction administrator or authorised party.
    /// Encoded/decoded by serializers as "AUTD".
    /// </summary>
    [EnumMember(Value = "AUTD")]
    [IsoId("_Zz0ogdp-Ed-ak6NoX_4Aeg_-1407037891")]
    [Description(@"Transaction has been authorised by the transaction administrator or authorised party.")]
    Authorised,
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as "INVD".
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_Zz0ogtp-Ed-ak6NoX_4Aeg_-1407037579")]
    [Description(@"Transaction is invalid.")]
    Invalid,
    
    /// <summary>
    /// Transaction has been matched with a corresponding transaction by the clearing agent.
    /// Encoded/decoded by serializers as "MATD".
    /// </summary>
    [EnumMember(Value = "MATD")]
    [IsoId("_Zz0og9p-Ed-ak6NoX_4Aeg_-1407037986")]
    [Description(@"Transaction has been matched with a corresponding transaction by the clearing agent.")]
    Matched,
    
    /// <summary>
    /// Clearing agent attempted to match the transaction with a corresponding transaction but failed.
    /// Encoded/decoded by serializers as "UMAC".
    /// </summary>
    [EnumMember(Value = "UMAC")]
    [IsoId("_Zz0ohNp-Ed-ak6NoX_4Aeg_-1407037210")]
    [Description(@"Clearing agent attempted to match the transaction with a corresponding transaction but failed.")]
    Unmatched,
    
    /// <summary>
    /// Clearing agent attempted to match the transaction with a corresponding transaction, but some non-essential characteristics of both transactions failed to match.
    /// Encoded/decoded by serializers as "MMTD".
    /// </summary>
    [EnumMember(Value = "MMTD")]
    [IsoId("_Zz0ohdp-Ed-ak6NoX_4Aeg_-1406114014")]
    [Description(@"Clearing agent attempted to match the transaction with a corresponding transaction, but some non-essential characteristics of both transactions failed to match.")]
    Mismatched,
    
    /// <summary>
    /// Transaction is eligible for future settlement.
    /// Encoded/decoded by serializers as "STLE".
    /// </summary>
    [EnumMember(Value = "STLE")]
    [IsoId("_Zz0ohtp-Ed-ak6NoX_4Aeg_-1407037115")]
    [Description(@"Transaction is eligible for future settlement.")]
    SettlementEligible,
    
    /// <summary>
    /// Transaction is eligible for immediate settlement.
    /// Encoded/decoded by serializers as "STLM".
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_Zz0oh9p-Ed-ak6NoX_4Aeg_-1407036995")]
    [Description(@"Transaction is eligible for immediate settlement.")]
    SettlementMature,
    
    /// <summary>
    /// Transaction has been suspended by the clearing agent.
    /// Encoded/decoded by serializers as "SSPD".
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_Zz0oiNp-Ed-ak6NoX_4Aeg_-1407036683")]
    [Description(@"Transaction has been suspended by the clearing agent.")]
    Suspended,
    
    /// <summary>
    /// Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.
    /// Encoded/decoded by serializers as "PCAN".
    /// </summary>
    [EnumMember(Value = "PCAN")]
    [IsoId("_Zz0oidp-Ed-ak6NoX_4Aeg_-1407036571")]
    [Description(@"Clearing agent has received a cancellation request for the transaction, and needs either a matching request for cancellation from the counterparty or a confirmation from an authorised party.")]
    PendingCancellation,
    
    /// <summary>
    /// Transaction is eligible for settlement, but is pending.
    /// Encoded/decoded by serializers as "PSTL".
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_Zz9ycNp-Ed-ak6NoX_4Aeg_-1407036203")]
    [Description(@"Transaction is eligible for settlement, but is pending.")]
    PendingSettlement,
    
    /// <summary>
    /// Transaction eligible for immediate settlement, has failed to settle.
    /// Encoded/decoded by serializers as "PFST".
    /// </summary>
    [EnumMember(Value = "PFST")]
    [IsoId("_Zz9ycdp-Ed-ak6NoX_4Aeg_-1407036090")]
    [Description(@"Transaction eligible for immediate settlement, has failed to settle.")]
    PendingFailingSettlement,
    
    /// <summary>
    /// Transaction causes the 'Sender multilateral limit' to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as "SMLR".
    /// </summary>
    [EnumMember(Value = "SMLR")]
    [IsoId("_Zz9yctp-Ed-ak6NoX_4Aeg_-1407035970")]
    [Description(@"Transaction causes the 'Sender multilateral limit' to be exceeded and cannot currently be processed.")]
    SenderMultilateralLimitRelated,
    
    /// <summary>
    /// Transaction causes the 'Receiver multilateral limit' to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as "RMLR".
    /// </summary>
    [EnumMember(Value = "RMLR")]
    [IsoId("_Zz9yc9p-Ed-ak6NoX_4Aeg_-1407035641")]
    [Description(@"Transaction causes the 'Receiver multilateral limit' to be exceeded and cannot currently be processed.")]
    ReceiverMultilateralLimitRelated,
    
    /// <summary>
    /// Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.
    /// Encoded/decoded by serializers as "SRBL".
    /// </summary>
    [EnumMember(Value = "SRBL")]
    [IsoId("_Z0HjcNp-Ed-ak6NoX_4Aeg_-1406113628")]
    [Description(@"Transaction causes the bilateral limit fixed between Sender and Receiver to be exceeded and cannot currently be processed.")]
    SenderReceiverBilateralLimitRelated,
    
    /// <summary>
    /// Transaction has been successfully processed by the clearing agent.
    /// Encoded/decoded by serializers as "STLD".
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_Z0Hjcdp-Ed-ak6NoX_4Aeg_-1406115532")]
    [Description(@"Transaction has been successfully processed by the clearing agent.")]
    Settled,
    
    /// <summary>
    /// Transaction has been rejected by the clearing agent.
    /// Encoded/decoded by serializers as "RJTD".
    /// </summary>
    [EnumMember(Value = "RJTD")]
    [IsoId("_Z0Hjctp-Ed-ak6NoX_4Aeg_-1406115394")]
    [Description(@"Transaction has been rejected by the clearing agent.")]
    Rejected,
    
    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_Z0Hjc9p-Ed-ak6NoX_4Aeg_-1406115022")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system.
    /// Encoded/decoded by serializers as "FNLD".
    /// </summary>
    [EnumMember(Value = "FNLD")]
    [IsoId("_Z0HjdNp-Ed-ak6NoX_4Aeg_-1406114368")]
    [Description(@"Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system.")]
    Finalised,
    
    /// <summary>
    /// Specifies that the message is queued to the receiving payment system and is awaiting processing because the receiving payment system is not operational (open) at that point in time.
    /// Encoded/decoded by serializers as "AVLB".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_Z0Hjddp-Ed-ak6NoX_4Aeg_-1269303175")]
    [Description(@"Specifies that the message is queued to the receiving payment system and is awaiting processing because the receiving payment system is not operational (open) at that point in time.")]
    HeldForServiceAvailability,
    
    /// <summary>
    /// Transaction causes the multilateral limits fixed between Sender and Receiver to be exceeded by the total amount of submitted payments at the end of the day and cannot currently be processed.
    /// Encoded/decoded by serializers as "SRML".
    /// </summary>
    [EnumMember(Value = "SRML")]
    [IsoId("_Z0Hjdtp-Ed-ak6NoX_4Aeg_-1345470941")]
    [Description(@"Transaction causes the multilateral limits fixed between Sender and Receiver to be exceeded by the total amount of submitted payments at the end of the day and cannot currently be processed.")]
    SenderReceiverMultilateralLimitRelated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentInstructionStatusCodeMetadataExtensions
{
    private static readonly PaymentInstructionStatusCodeDropdownSource _dropdownSource = new PaymentInstructionStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentInstructionStatusCodeDropdownRow GetMetadata(this PaymentInstructionStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


