﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalRejectedReason1Code.  ISO2002 ID# _cgC6IFj8EeOgwYxfAV02bg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a rejected status
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cgC6IFj8EeOgwYxfAV02bg")]
[Description(@"Specifies the reason for a rejected status The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalRejectedReasonCode))]
public enum ExternalRejectedReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uVsmNfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotBusinessDay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uVsmOPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NotBusinessDay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uVsmO_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ClosingTransaction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV1wIvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV1wJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InvalidDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV1wKPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    InvalidRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotAuthorised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV1wK_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NotAuthorised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoInstrument".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV_hIvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NoInstrument,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoAccessToService".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV_hJfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NoAccessToService,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uV_hKPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcknowledgementOfSettlementBatchReceived".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dCfacQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    AcknowledgementOfSettlementBatchReceived,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidAccountNumberForSettlementType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dIAMkQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidAccountNumberForSettlementType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidBatchSettlementInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dQMfQQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidBatchSettlementInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidConcurrentBatchSettlementInstructionSequenceNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dV3CYQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidConcurrentBatchSettlementInstructionSequenceNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidCreationDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dbX0gQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidCreationDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidRoutingCodeUtilised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dhCXoQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidRoutingCodeUtilised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSettlementAgreementNumberSpecified".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dqt4EQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidSettlementAgreementNumberSpecified,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSettlementWindow".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dw-4IQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    InvalidSettlementWindow,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingISIN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d3iMEQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    MissingISIN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OutstandingFundingForSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eB0JcQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    OutstandingFundingForSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParticipantInBCPNoCLSInstructionsAllowed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eH7YgQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    ParticipantInBCPNoCLSInstructionsAllowed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParticipantNotActiveMemberOfSADCRTGS".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eNvFkQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    ParticipantNotActiveMemberOfSADCRTGS,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParticipantNotActiveMemberSettlementType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eVMYcQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    ParticipantNotActiveMemberSettlementType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParticipantNotAnActiveMemberOfRTGS".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ebvsYQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    ParticipantNotAnActiveMemberOfRTGS,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementBatchRemovalNotification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eiTnYQTqEey95qpfbNuEwg")]
    [Description(@"??")]
    SettlementBatchRemovalNotification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalRejectedReason1CodeMetadataExtensions
{
    private static readonly ExternalRejectedReason1CodeDropdownSource _dropdownSource = new ExternalRejectedReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalRejectedReason1CodeDropdownRow GetMetadata(this ExternalRejectedReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


