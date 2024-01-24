﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDebtorAgentInstructionCode.  ISO2002 ID# _hokV-ssaEemxFbEZK-FMzw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hokV-ssaEemxFbEZK-FMzw")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.")]
// [Derivations(typeof(ExternalDebtorAgentInstruction1Code))]
public enum ExternalDebtorAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as "CHQB".
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_hokV_ssaEemxFbEZK-FMzw")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_hokV-8saEemxFbEZK-FMzw")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as "PHOB".
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_hokWAcsaEemxFbEZK-FMzw")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as "TELB".
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_hokWAMsaEemxFbEZK-FMzw")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom,
    
    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as "TOKN".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_hokV_MsaEemxFbEZK-FMzw")]
    [Description(@"Token information.")]
    Token,
    
    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as "VLTK".
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("_hokV_8saEemxFbEZK-FMzw")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation,
    
    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as "PRTK".
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("_hokV_csaEemxFbEZK-FMzw")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDebtorAgentInstructionCodeMetadataExtensions
{
    private static readonly ExternalDebtorAgentInstructionCodeDropdownSource _dropdownSource = new ExternalDebtorAgentInstructionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDebtorAgentInstructionCodeDropdownRow GetMetadata(this ExternalDebtorAgentInstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


