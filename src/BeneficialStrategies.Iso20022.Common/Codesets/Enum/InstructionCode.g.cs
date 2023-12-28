﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstructionCode.  ISO2002 ID# _aXbr6Np-Ed-ak6NoX_4Aeg_86377106.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aXbr6Np-Ed-ak6NoX_4Aeg_86377106")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction.")]
public enum InstructionCode
{
    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity.
    /// Encoded/decoded by serializers as "PBEN".
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_aXlc4Np-Ed-ak6NoX_4Aeg_170415723")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity.")]
    PayTheBeneficiary,
    
    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.
    /// Encoded/decoded by serializers as "TTIL".
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_aXlc4dp-Ed-ak6NoX_4Aeg_171341881")]
    [Description(@"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.")]
    TimeTill,
    
    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated.
    /// Encoded/decoded by serializers as "TFRO".
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_aXlc4tp-Ed-ak6NoX_4Aeg_171341923")]
    [Description(@"Payment instruction will be valid and eligible for execution from the date and time stipulated.")]
    TimeFrom,
    
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as "CHQB".
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_aXlc49p-Ed-ak6NoX_4Aeg_-849133974")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_aXlc5Np-Ed-ak6NoX_4Aeg_-849133957")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as "PHOB".
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_aXlc5dp-Ed-ak6NoX_4Aeg_715895574")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as "TELB".
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_aXlc5tp-Ed-ak6NoX_4Aeg_927383559")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom,
    
    /// <summary>
    /// Please advise/contact next agent by phone.
    /// Encoded/decoded by serializers as "PHOA".
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_aXlc59p-Ed-ak6NoX_4Aeg_1747493253")]
    [Description(@"Please advise/contact next agent by phone.")]
    PhoneNextAgent,
    
    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as "TELA".
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_aXlc6Np-Ed-ak6NoX_4Aeg_1750263880")]
    [Description(@"Please advise/contact next agent by the most efficient means of telecommunication.")]
    TelecomNextAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstructionCodeMetadataExtensions
{
    private static readonly InstructionCodeDropdownSource _dropdownSource = new InstructionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstructionCodeDropdownRow GetMetadata(this InstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

