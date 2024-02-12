﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnableToApplyMissingInfo1Code.  ISO2002 ID# _Y1YqVNp-Ed-ak6NoX_4Aeg_1310461274.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Used when the unable to apply is due to missing information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y1YqVNp-Ed-ak6NoX_4Aeg_1310461274")]
[Description(@"Used when the unable to apply is due to missing information.")]
public enum UnableToApplyMissingInfo1Code
{
    /// <summary>
    /// RemittanceInformation is missing.
    /// Encoded/decoded by serializers as "MS01".
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_Y1YqVdp-Ed-ak6NoX_4Aeg_-1626866520")]
    [Description(@"RemittanceInformation is missing.")]
    MissingRemittanceInformation,
    
    /// <summary>
    /// SenderToReceiverInformation is missing.
    /// Encoded/decoded by serializers as "MS02".
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_Y1YqVtp-Ed-ak6NoX_4Aeg_-1626866194")]
    [Description(@"SenderToReceiverInformation is missing.")]
    MissingSenderToReceiverInformation,
    
    /// <summary>
    /// Debtor is missing.
    /// Encoded/decoded by serializers as "MS03".
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_Y1YqV9p-Ed-ak6NoX_4Aeg_-1626866159")]
    [Description(@"Debtor is missing.")]
    MissingDebtor,
    
    /// <summary>
    /// DebtorAccount is missing.
    /// Encoded/decoded by serializers as "MS04".
    /// </summary>
    [EnumMember(Value = "MS04")]
    [IsoId("_Y1YqWNp-Ed-ak6NoX_4Aeg_-1626866134")]
    [Description(@"DebtorAccount is missing.")]
    MissingDebtorAccount,
    
    /// <summary>
    /// FirstAgent is missing.
    /// Encoded/decoded by serializers as "MS05".
    /// </summary>
    [EnumMember(Value = "MS05")]
    [IsoId("_Y1YqWdp-Ed-ak6NoX_4Aeg_-1626866099")]
    [Description(@"FirstAgent is missing.")]
    MissingFirstAgent,
    
    /// <summary>
    /// Amount is missing.
    /// Encoded/decoded by serializers as "MS06".
    /// </summary>
    [EnumMember(Value = "MS06")]
    [IsoId("_Y1ibUNp-Ed-ak6NoX_4Aeg_-1626866057")]
    [Description(@"Amount is missing.")]
    MissingAmount,
    
    /// <summary>
    /// Nostro_VostroAccount is missing.
    /// Encoded/decoded by serializers as "MS07".
    /// </summary>
    [EnumMember(Value = "MS07")]
    [IsoId("_Y1ibUdp-Ed-ak6NoX_4Aeg_-1626866022")]
    [Description(@"Nostro_VostroAccount is missing.")]
    MissingNostroVostroAccount,
    
    /// <summary>
    /// Intermediary is missing.
    /// Encoded/decoded by serializers as "MS08".
    /// </summary>
    [EnumMember(Value = "MS08")]
    [IsoId("_Y1ibUtp-Ed-ak6NoX_4Aeg_-1626865979")]
    [Description(@"Intermediary is missing.")]
    MissingIntermediary,
    
    /// <summary>
    /// ReimbursementAgent (53) is missing.
    /// Encoded/decoded by serializers as "MS09".
    /// </summary>
    [EnumMember(Value = "MS09")]
    [IsoId("_Y1ibU9p-Ed-ak6NoX_4Aeg_-1626865702")]
    [Description(@"ReimbursementAgent (53) is missing.")]
    MissingReimbursementAgent1,
    
    /// <summary>
    /// ReimbursementAgent (54) is missing.
    /// Encoded/decoded by serializers as "MS10".
    /// </summary>
    [EnumMember(Value = "MS10")]
    [IsoId("_Y1ibVNp-Ed-ak6NoX_4Aeg_-1626865667")]
    [Description(@"ReimbursementAgent (54) is missing.")]
    MissingReimbursementAgent2,
    
    /// <summary>
    /// ReimbursementAgent (55) is missing.
    /// Encoded/decoded by serializers as "MS11".
    /// </summary>
    [EnumMember(Value = "MS11")]
    [IsoId("_Y1ibVdp-Ed-ak6NoX_4Aeg_-1626865632")]
    [Description(@"ReimbursementAgent (55) is missing.")]
    MissingReimbursementAgent,
    
    /// <summary>
    /// Creditor is missing.
    /// Encoded/decoded by serializers as "MS12".
    /// </summary>
    [EnumMember(Value = "MS12")]
    [IsoId("_Y1ibVtp-Ed-ak6NoX_4Aeg_-1626865590")]
    [Description(@"Creditor is missing.")]
    MissingCreditor,
    
    /// <summary>
    /// CreditorAccount is missing.
    /// Encoded/decoded by serializers as "MS13".
    /// </summary>
    [EnumMember(Value = "MS13")]
    [IsoId("_Y1ibV9p-Ed-ak6NoX_4Aeg_-1626865247")]
    [Description(@"CreditorAccount is missing.")]
    MissingCreditorAccount,
    
    /// <summary>
    /// Indicates the payment instruction (MT103) is missing.
    /// Encoded/decoded by serializers as "MS14".
    /// </summary>
    [EnumMember(Value = "MS14")]
    [IsoId("_Y1ibWNp-Ed-ak6NoX_4Aeg_-1299769718")]
    [Description(@"Indicates the payment instruction (MT103) is missing.")]
    MissingInstruction,
    
}
