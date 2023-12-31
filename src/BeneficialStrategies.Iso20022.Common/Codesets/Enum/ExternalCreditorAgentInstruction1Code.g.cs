﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalCreditorAgentInstruction1Code.  ISO2002 ID# _gVopcMP-Eemsic1bQcEtLA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gVopcMP-Eemsic1bQcEtLA")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.")]
[DerivedFrom(typeof(ExternalCreditorAgentInstructionCode))]
public enum ExternalCreditorAgentInstruction1Code
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as "PayCreditorByCheque".
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_uwEOAvRYEeuLhpyIdtJzwg")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as "HoldCashForCreditor".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_uwEOBfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as "PhoneBeneficiary".
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_uwEOCPRYEeuLhpyIdtJzwg")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as "PayerTokenRequested".
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("_uwN_AvRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested,
    
    /// <summary>
    /// Further information regarding the intended recipient. 
    /// Encoded/decoded by serializers as "ReceiverCustomerInformation".
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_uwN_BfRYEeuLhpyIdtJzwg")]
    [Description(@"Further information regarding the intended recipient. ")]
    ReceiverCustomerInformation,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as "Telecom".
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_uwN_CPRYEeuLhpyIdtJzwg")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom,
    
    /// <summary>
    /// Token found with counterparty mismatch. 
    /// Encoded/decoded by serializers as "TokenCounterpartyMismatch".
    /// </summary>
    [EnumMember(Value = "TKCM")]
    [IsoId("_uwN_C_RYEeuLhpyIdtJzwg")]
    [Description(@"Token found with counterparty mismatch. ")]
    TokenCounterpartyMismatch,
    
    /// <summary>
    /// Single Use Token already used. 
    /// Encoded/decoded by serializers as "TokenSingleUse".
    /// </summary>
    [EnumMember(Value = "TKSG")]
    [IsoId("_uwXwAvRYEeuLhpyIdtJzwg")]
    [Description(@"Single Use Token already used. ")]
    TokenSingleUse,
    
    /// <summary>
    /// Token found with suspended status.
    /// Encoded/decoded by serializers as "TokenSuspended".
    /// </summary>
    [EnumMember(Value = "TKSP")]
    [IsoId("_uwXwBfRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with suspended status.")]
    TokenSuspended,
    
    /// <summary>
    /// Token found with value limit rule violation. 
    /// Encoded/decoded by serializers as "TokenValueLimitExceeded".
    /// </summary>
    [EnumMember(Value = "TKVE")]
    [IsoId("_uwXwCPRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with value limit rule violation. ")]
    TokenValueLimitExceeded,
    
    /// <summary>
    /// Token expired. 
    /// Encoded/decoded by serializers as "TokenExpired".
    /// </summary>
    [EnumMember(Value = "TKXP")]
    [IsoId("_uwXwC_RYEeuLhpyIdtJzwg")]
    [Description(@"Token expired. ")]
    TokenExpired,
    
    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as "Token".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_uwg58vRYEeuLhpyIdtJzwg")]
    [Description(@"Token information.")]
    Token,
    
    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as "TokenValidation".
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("_uwg59fRYEeuLhpyIdtJzwg")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalCreditorAgentInstruction1CodeMetadataExtensions
{
    private static readonly ExternalCreditorAgentInstruction1CodeDropdownSource _dropdownSource = new ExternalCreditorAgentInstruction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalCreditorAgentInstruction1CodeDropdownRow GetMetadata(this ExternalCreditorAgentInstruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


