﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalAgentInstructionCode.  ISO2002 ID# _KTAyqtA4EeeCAfThR1cp_Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions for the agent concerning the processing of an instruction.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTAyqtA4EeeCAfThR1cp_Q")]
[Description(@"Specifies further instructions for the agent concerning the processing of an instruction.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalAgentInstruction1Code))]
public enum ExternalAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque. 
    /// Encoded/decoded by serializers as "CHQB".
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_KTBZsNA4EeeCAfThR1cp_Q")]
    [Description(@"(Ultimate) creditor must be paid by cheque. ")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification. 
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_KTBZstA4EeeCAfThR1cp_Q")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification. ")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Additional Information to an inquiry reason must be provided. 
    /// Encoded/decoded by serializers as "INQR".
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_etQCMNA4EeeCAfThR1cp_Q")]
    [Description(@"Additional Information to an inquiry reason must be provided. ")]
    InquiryReason,
    
    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity. 
    /// Encoded/decoded by serializers as "PBEN".
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_KTBZttA4EeeCAfThR1cp_Q")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity. ")]
    PayTheBeneficiary,
    
    /// <summary>
    /// Please advise/contact next agent by phone. 
    /// Encoded/decoded by serializers as "PHOA".
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_KTBZt9A4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact next agent by phone. ")]
    PhoneNextAgent,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone. 
    /// Encoded/decoded by serializers as "PHOB".
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_KTBZuNA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone. ")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication. 
    /// Encoded/decoded by serializers as "TELA".
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_KTBZtNA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact next agent by the most efficient means of telecommunication. ")]
    TelecomNextAgent,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication. 
    /// Encoded/decoded by serializers as "TELB".
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_KTBZsdA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication. ")]
    Telecom,
    
    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated. 
    /// Encoded/decoded by serializers as "TFRO".
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_KTBZs9A4EeeCAfThR1cp_Q")]
    [Description(@"Payment instruction will be valid and eligible for execution from the date and time stipulated. ")]
    TimeFrom,
    
    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected. 
    /// Encoded/decoded by serializers as "TTIL".
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_KTBZtdA4EeeCAfThR1cp_Q")]
    [Description(@"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected. ")]
    TimeTill,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalAgentInstructionCodeMetadataExtensions
{
    private static readonly ExternalAgentInstructionCodeDropdownSource _dropdownSource = new ExternalAgentInstructionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalAgentInstructionCodeDropdownRow GetMetadata(this ExternalAgentInstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


