﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason14Code.  ISO2002 ID# _Zg5Fddp-Ed-ak6NoX_4Aeg_1895706471.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of a movement cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zg5Fddp-Ed-ak6NoX_4Aeg_1895706471")]
[Description(@"Specifies the reason of a rejection of a movement cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason14Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zg5Fdtp-Ed-ak6NoX_4Aeg_-1511085978")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as "LATT".
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_Zg5Fd9p-Ed-ak6NoX_4Aeg_-1511085947")]
    [Description(@"Instruction/Request arrives too late.")]
    Late = RejectionReasonCode.Late, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CA Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as "INET".
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("_Zg5FeNp-Ed-ak6NoX_4Aeg_-1511085917")]
    [Description(@"CA Event Type does not correspond with the relating Corporate Action.")]
    InvalidEventType = RejectionReasonCode.InvalidEventType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying Security Identification does not correspond with the Corporate Action Reference supplied.
    /// Encoded/decoded by serializers as "INUS".
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_Zg5Fedp-Ed-ak6NoX_4Aeg_-1511085608")]
    [Description(@"Underlying Security Identification does not correspond with the Corporate Action Reference supplied.")]
    InvalidUnderlyingSecurity = RejectionReasonCode.InvalidUnderlyingSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event Processing Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as "INPT".
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_ZhC2cNp-Ed-ak6NoX_4Aeg_-1511085577")]
    [Description(@"Event Processing Type does not correspond with the relating Corporate Action.")]
    InvalidEventProcessingType = RejectionReasonCode.InvalidEventProcessingType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as "INMV".
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("_ZhC2cdp-Ed-ak6NoX_4Aeg_-1511085546")]
    [Description(@"Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.")]
    InvalidMandatoryVoluntaryEventType = RejectionReasonCode.InvalidMandatoryVoluntaryEventType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "INDE".
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_ZhC2ctp-Ed-ak6NoX_4Aeg_-1511085524")]
    [Description(@"Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message.")]
    InvalidCorporateActionInformation = RejectionReasonCode.InvalidCorporateActionInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as "AGIN".
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_ZhC2c9p-Ed-ak6NoX_4Aeg_-1511085493")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent = RejectionReasonCode.InvalidAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Details specified in the MOVEMENT GENERAL INFORMATION block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "INMO".
    /// </summary>
    [EnumMember(Value = "INMO")]
    [IsoId("_ZhC2dNp-Ed-ak6NoX_4Aeg_-1511085462")]
    [Description(@"Details specified in the MOVEMENT GENERAL INFORMATION block are inconsistent with those that were specified in the relating original message.")]
    InvalidMovementInformation = RejectionReasonCode.InvalidMovementInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as "SAID".
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_ZhC2ddp-Ed-ak6NoX_4Aeg_-1511085432")]
    [Description(@"Several message with the same identification.")]
    SameIdentification = RejectionReasonCode.SameIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as "INID".
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_ZhMncNp-Ed-ak6NoX_4Aeg_-1511085370")]
    [Description(@"Instruction contains an invalid message identification, identification is unknown.")]
    InvalidIdentification = RejectionReasonCode.InvalidIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One or more of the underlying movements have already settled.
    /// Encoded/decoded by serializers as "MOSE".
    /// </summary>
    [EnumMember(Value = "MOSE")]
    [IsoId("_ZhMncdp-Ed-ak6NoX_4Aeg_-1511085340")]
    [Description(@"One or more of the underlying movements have already settled.")]
    MovementAlreadySettled = RejectionReasonCode.MovementAlreadySettled, // same ordinal as derivation source for type conversions
    
}
