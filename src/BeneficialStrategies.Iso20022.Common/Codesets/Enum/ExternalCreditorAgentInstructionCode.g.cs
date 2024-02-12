﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorAgentInstructionCode.  ISO2002 ID# _mn2q4MP9Eemsic1bQcEtLA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mn2q4MP9Eemsic1bQcEtLA")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.")]
[Derivations(typeof(ExternalCreditorAgentInstruction1Code))]
public enum ExternalCreditorAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as "CHQB".
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_mn2q4cP9Eemsic1bQcEtLA")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_mn3R8cP9Eemsic1bQcEtLA")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as "PHOB".
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_mn3R98P9Eemsic1bQcEtLA")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as "PRTK".
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("_EGLpwMQBEemsic1bQcEtLA")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested,
    
    /// <summary>
    /// Further information regarding the intended recipient. 
    /// Encoded/decoded by serializers as "RECI".
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_uwN_A_RYEeuLhpyIdtJzwg")]
    [Description(@"Further information regarding the intended recipient. ")]
    ReceiverCustomerInformation,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as "TELB".
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_mn3R9sP9Eemsic1bQcEtLA")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom,
    
    /// <summary>
    /// Token found with counterparty mismatch. 
    /// Encoded/decoded by serializers as "TKCM".
    /// </summary>
    [EnumMember(Value = "TKCM")]
    [IsoId("_uwN_CfRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with counterparty mismatch. ")]
    TokenCounterpartyMismatch,
    
    /// <summary>
    /// Single Use Token already used. 
    /// Encoded/decoded by serializers as "TKSG".
    /// </summary>
    [EnumMember(Value = "TKSG")]
    [IsoId("_uwXwAPRYEeuLhpyIdtJzwg")]
    [Description(@"Single Use Token already used. ")]
    TokenSingleUse,
    
    /// <summary>
    /// Token found with suspended status.
    /// Encoded/decoded by serializers as "TKSP".
    /// </summary>
    [EnumMember(Value = "TKSP")]
    [IsoId("_uwXwA_RYEeuLhpyIdtJzwg")]
    [Description(@"Token found with suspended status.")]
    TokenSuspended,
    
    /// <summary>
    /// Token found with value limit rule violation. 
    /// Encoded/decoded by serializers as "TKVE".
    /// </summary>
    [EnumMember(Value = "TKVE")]
    [IsoId("_uwXwBvRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with value limit rule violation. ")]
    TokenValueLimitExceeded,
    
    /// <summary>
    /// Token expired. 
    /// Encoded/decoded by serializers as "TKXP".
    /// </summary>
    [EnumMember(Value = "TKXP")]
    [IsoId("_uwXwCfRYEeuLhpyIdtJzwg")]
    [Description(@"Token expired. ")]
    TokenExpired,
    
    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as "TOKN".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_Dz9RUMQBEemsic1bQcEtLA")]
    [Description(@"Token information.")]
    Token,
    
    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as "VLTK".
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("_D8MAQMQBEemsic1bQcEtLA")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation,
    
}
