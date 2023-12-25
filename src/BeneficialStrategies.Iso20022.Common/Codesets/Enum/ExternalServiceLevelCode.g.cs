﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalServiceLevelCode.  ISO2002 ID# _jo7HwIMlEeeBDNMiErKunw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jo7HwIMlEeeBDNMiErKunw")]
[Description(@"Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalServiceLevelCode
{
    /// <summary>
    /// Payment through internal book transfer.
    /// </summary>
    [EnumMember(Value = "BKTR")]
    [IsoId("_t8zlFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment through internal book transfer.")]
    BKTR,
    
    /// <summary>
    /// Tracked Customer Credit Transfer.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_t8zlGfRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Customer Credit Transfer.")]
    G001,
    
    /// <summary>
    /// Tracked Stop and Recall 
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_t8zlHPRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Stop and Recall ")]
    G002,
    
    /// <summary>
    /// Tracked Outbound Corporate Transfer.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_t89WEPRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Outbound Corporate Transfer.")]
    G003,
    
    /// <summary>
    /// Tracked Financial Institution Transfer.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_t89WE_RYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Financial Institution Transfer.")]
    G004,
    
    /// <summary>
    /// Payments must be executed following the NPC Area Payment scheme.
    /// </summary>
    [EnumMember(Value = "NPCA")]
    [IsoId("_t89WFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payments must be executed following the NPC Area Payment scheme.")]
    NPCA,
    
    /// <summary>
    /// Payment must be executed as a non-urgent transaction with priority settlement.
    /// </summary>
    [EnumMember(Value = "NUGP")]
    [IsoId("_t9GgAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as a non-urgent transaction with priority settlement.")]
    NUGP,
    
    /// <summary>
    /// Payment must be executed as a non-urgent transaction, which is typically identified as an ACH or low value transaction. 
    /// </summary>
    [EnumMember(Value = "NURG")]
    [IsoId("_t9GgA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as a non-urgent transaction, which is typically identified as an ACH or low value transaction. ")]
    NURG,
    
    /// <summary>
    /// Transaction must be processed according to the EBA Priority Service.
    /// </summary>
    [EnumMember(Value = "PRPT")]
    [IsoId("_t9GgBvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction must be processed according to the EBA Priority Service.")]
    PRPT,
    
    /// <summary>
    /// Payment must be executed with same day value to the creditor.
    /// </summary>
    [EnumMember(Value = "SDVA")]
    [IsoId("_t9GgCfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed with same day value to the creditor.")]
    SDVA,
    
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_t9GgDPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SEPA,
    
    /// <summary>
    /// Payment execution following the cheque agreement and traveller cheque agreement of the German Banking Industry Committee (Die Deutsche Kreditwirtschaft - DK) and Deutsche Bundesbank – Scheck Verrechnung Deutschland
    /// </summary>
    [EnumMember(Value = "SVDE")]
    [IsoId("_t9QRAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment execution following the cheque agreement and traveller cheque agreement of the German Banking Industry Committee (Die Deutsche Kreditwirtschaft - DK) and Deutsche Bundesbank – Scheck Verrechnung Deutschland")]
    SVDE,
    
    /// <summary>
    /// Payment must be executed as an urgent transaction cleared through a real-time gross settlement system, which is typically identified as a wire or high value transaction.  
    /// </summary>
    [EnumMember(Value = "URGP")]
    [IsoId("_t9QRA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as an urgent transaction cleared through a real-time gross settlement system, which is typically identified as a wire or high value transaction.  ")]
    URGP,
    
    /// <summary>
    /// Payment must be executed as an urgent transaction cleared through a real-time net settlement system, which is typically identified as a wire or high value transaction.  
    /// </summary>
    [EnumMember(Value = "URNS")]
    [IsoId("_t9aCAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as an urgent transaction cleared through a real-time net settlement system, which is typically identified as a wire or high value transaction.  ")]
    URNS,
    
    /// <summary>
    /// Used for payment initiation to identify that a Payment or Direct Debit initiation must be executed as an instant or real-time payment instrument.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_JkJM8FD9Eey6cYDbEubNXg")]
    [Description(@"Used for payment initiation to identify that a Payment or Direct Debit initiation must be executed as an instant or real-time payment instrument.")]
    INST,
    
    /// <summary>
    /// Request to Pay (RTP) transaction refers to an RTP scheme (such as for example the SEPA Request to Pay (SRTP) scheme).
    /// </summary>
    [EnumMember(Value = "SRTP")]
    [IsoId("_BrMeQFD-Eey6cYDbEubNXg")]
    [Description(@"Request to Pay (RTP) transaction refers to an RTP scheme (such as for example the SEPA Request to Pay (SRTP) scheme).")]
    SRTP,
    
    /// <summary>
    /// Scheck Verarbeitung Austria (Cheque Processing).
    /// </summary>
    [EnumMember(Value = "SVAT")]
    [IsoId("_4Rs2II5EEeyANo-d7JlQ1A")]
    [Description(@"Scheck Verarbeitung Austria (Cheque Processing).")]
    SVAT,
    
    /// <summary>
    /// Tracked Instant Customer Credit Transfer.
    /// 
    /// 
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_adonkOAhEey0k8vo1GQhqQ")]
    [Description(@"Tracked Instant Customer Credit Transfer.  ")]
    G005,
    
    /// <summary>
    /// Specifies the service conditions applicable to a tracked exceptions and investigations case.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("__L4RIOAhEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service conditions applicable to a tracked exceptions and investigations case.")]
    G006,
    
    /// <summary>
    /// Specifies the service level for a tracked inbound customer credit transfer.
    /// </summary>
    [EnumMember(Value = "G007")]
    [IsoId("_MKyXkOAiEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service level for a tracked inbound customer credit transfer.")]
    G007,
    
    /// <summary>
    /// Specifies the service level for a tracked low-value cross-border customer credit transfer.
    /// </summary>
    [EnumMember(Value = "G009")]
    [IsoId("_h5ZZEOAiEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service level for a tracked low-value cross-border customer credit transfer.")]
    G009,
    
    /// <summary>
    /// Transaction is to be treated as an advice and only applied to the account of the creditor or next agent after settlement of the cover has been confirmed.
    /// </summary>
    [EnumMember(Value = "WFSM")]
    [IsoId("_T8HuAGvcEe2F6NrIyOmXcA")]
    [Description(@"Transaction is to be treated as an advice and only applied to the account of the creditor or next agent after settlement of the cover has been confirmed.")]
    WFSM,
    
    /// <summary>
    /// Payment is executed following a Euro One-Leg Out Scheme.
    /// </summary>
    [EnumMember(Value = "EOLO")]
    [IsoId("_9m6qUP7KEe2ORYPQEd-Clg")]
    [Description(@"Payment is executed following a Euro One-Leg Out Scheme.")]
    EOLO,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalServiceLevelCodeMetadataExtensions
{
    private static readonly ExternalServiceLevelCodeDropdownSource _dropdownSource = new ExternalServiceLevelCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalServiceLevelCodeDropdownRow GetMetadata(this ExternalServiceLevelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


