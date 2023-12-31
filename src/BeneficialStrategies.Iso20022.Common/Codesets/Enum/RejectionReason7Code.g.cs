﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason7Code.  ISO2002 ID# _Zl0BuNp-Ed-ak6NoX_4Aeg_1693452570.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zl0BuNp-Ed-ak6NoX_4Aeg_1693452570")]
[Description(@"Specifies the reason of a rejection cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason7Code
{
    /// <summary>
    /// Rejected as the deactivation of the event is already completed.
    /// Encoded/decoded by serializers as "EventAlreadyDeactivated".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_Zl9ysNp-Ed-ak6NoX_4Aeg_476926389")]
    [Description(@"Rejected as the deactivation of the event is already completed.")]
    EventAlreadyDeactivated,
    
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FailedValidation".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zl9ysdp-Ed-ak6NoX_4Aeg_476926419")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation,
    
    /// <summary>
    /// The cancellation request is rejected as there is no pending deactivation instruction.
    /// Encoded/decoded by serializers as "NoPendingDeactivationInstruction".
    /// </summary>
    [EnumMember(Value = "PDEA")]
    [IsoId("_Zl9ystp-Ed-ak6NoX_4Aeg_476926450")]
    [Description(@"The cancellation request is rejected as there is no pending deactivation instruction.")]
    NoPendingDeactivationInstruction,
    
    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as "InvalidIdentification".
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_Zl9ys9p-Ed-ak6NoX_4Aeg_476926481")]
    [Description(@"Instruction contains an invalid message identification, identification is unknown.")]
    InvalidIdentification,
    
    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as "InvalidCAIdentification".
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_Zl9ytNp-Ed-ak6NoX_4Aeg_476926728")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification,
    
    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as "InvalidAgent".
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_Zl9ytdp-Ed-ak6NoX_4Aeg_476926759")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent,
    
    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as "SameIdentification".
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Zl9yttp-Ed-ak6NoX_4Aeg_476926790")]
    [Description(@"Several message with the same identification.")]
    SameIdentification,
    
    /// <summary>
    /// Rejected as the deactivation of the option is already completed.
    /// Encoded/decoded by serializers as "OptionAlreadyDeactivated".
    /// </summary>
    [EnumMember(Value = "DEAO")]
    [IsoId("_Zl9yt9p-Ed-ak6NoX_4Aeg_476926820")]
    [Description(@"Rejected as the deactivation of the option is already completed.")]
    OptionAlreadyDeactivated,
    
    /// <summary>
    /// CA Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as "InvalidEventType".
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("_Zl9yuNp-Ed-ak6NoX_4Aeg_476926851")]
    [Description(@"CA Event Type does not correspond with the relating Corporate Action.")]
    InvalidEventType,
    
    /// <summary>
    /// Underlying Security Identification does not correspond with the Corporate Action Reference supplied.
    /// Encoded/decoded by serializers as "InvalidUnderlyingSecurity".
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_Zl9yudp-Ed-ak6NoX_4Aeg_476926882")]
    [Description(@"Underlying Security Identification does not correspond with the Corporate Action Reference supplied.")]
    InvalidUnderlyingSecurity,
    
    /// <summary>
    /// Event Processing Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as "InvalidEventProcessingType".
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_ZmG8oNp-Ed-ak6NoX_4Aeg_476927160")]
    [Description(@"Event Processing Type does not correspond with the relating Corporate Action.")]
    InvalidEventProcessingType,
    
    /// <summary>
    /// Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as "InvalidMandatoryVoluntaryEventType".
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("_ZmG8odp-Ed-ak6NoX_4Aeg_476927191")]
    [Description(@"Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.")]
    InvalidMandatoryVoluntaryEventType,
    
    /// <summary>
    /// Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "InvalidCorporateActionInformation".
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_ZmG8otp-Ed-ak6NoX_4Aeg_476927244")]
    [Description(@"Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message.")]
    InvalidCorporateActionInformation,
    
    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "InvalidDetails".
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_ZmG8o9p-Ed-ak6NoX_4Aeg_476927275")]
    [Description(@"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.")]
    InvalidDetails,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason7CodeMetadataExtensions
{
    private static readonly RejectionReason7CodeDropdownSource _dropdownSource = new RejectionReason7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason7CodeDropdownRow GetMetadata(this RejectionReason7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


