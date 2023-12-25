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
[Description(@"Specifies further instructions for the agent concerning the processing of an instruction. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque. 
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_KTBZsNA4EeeCAfThR1cp_Q")]
    [Description(@"(Ultimate) creditor must be paid by cheque. ")]
    CHQB,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification. 
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_KTBZstA4EeeCAfThR1cp_Q")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification. ")]
    HOLD,
    
    /// <summary>
    /// Additional Information to an inquiry reason must be provided. 
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_etQCMNA4EeeCAfThR1cp_Q")]
    [Description(@"Additional Information to an inquiry reason must be provided. ")]
    INQR,
    
    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity. 
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_KTBZttA4EeeCAfThR1cp_Q")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity. ")]
    PBEN,
    
    /// <summary>
    /// Please advise/contact next agent by phone. 
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_KTBZt9A4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact next agent by phone. ")]
    PHOA,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone. 
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_KTBZuNA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone. ")]
    PHOB,
    
    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication. 
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_KTBZtNA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact next agent by the most efficient means of telecommunication. ")]
    TELA,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication. 
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_KTBZsdA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication. ")]
    TELB,
    
    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated. 
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_KTBZs9A4EeeCAfThR1cp_Q")]
    [Description(@"Payment instruction will be valid and eligible for execution from the date and time stipulated. ")]
    TFRO,
    
    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected. 
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_KTBZtdA4EeeCAfThR1cp_Q")]
    [Description(@"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected. ")]
    TTIL,
    
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


