﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction7Code.  ISO2002 ID# _ha36YInyEeS9F4Qrq_eaVA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha36YInyEeS9F4Qrq_eaVA")]
[Description(@"Identifies the type of process related to an ATM message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction7Code
{
    /// <summary>
    /// Provide the ATM counters resettting those that are applicable.
    /// Encoded/decoded by serializers as "ATMBalance".
    /// </summary>
    [EnumMember(Value = "BALN")]
    [IsoId("_nT2f8YnyEeS9F4Qrq_eaVA")]
    [Description(@"Provide the ATM counters resettting those that are applicable.")]
    ATMBalance,
    
    /// <summary>
    /// Acknowledgement of a completion advice.
    /// Encoded/decoded by serializers as "ATMCompletionAcknowledgement".
    /// </summary>
    [EnumMember(Value = "CMPA")]
    [IsoId("_neu6Q4nyEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a completion advice.")]
    ATMCompletionAcknowledgement,
    
    /// <summary>
    /// Advice of an ATM transaction completion.
    /// Encoded/decoded by serializers as "ATMCompletionAdvice".
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_nksYU4nyEeS9F4Qrq_eaVA")]
    [Description(@"Advice of an ATM transaction completion.")]
    ATMCompletionAdvice,
    
    /// <summary>
    /// Global ATM commands.
    /// Encoded/decoded by serializers as "ATMControl".
    /// </summary>
    [EnumMember(Value = "ACMD")]
    [IsoId("_nq01g4nyEeS9F4Qrq_eaVA")]
    [Description(@"Global ATM commands.")]
    ATMControl,
    
    /// <summary>
    /// Maintenance commands to perform.
    /// Encoded/decoded by serializers as "ATMDeviceControl".
    /// </summary>
    [EnumMember(Value = "DVCC")]
    [IsoId("_nwyTk4nyEeS9F4Qrq_eaVA")]
    [Description(@"Maintenance commands to perform.")]
    ATMDeviceControl,
    
    /// <summary>
    /// Request for a diagnostic.
    /// Encoded/decoded by serializers as "ATMDiagnosticRequest".
    /// </summary>
    [EnumMember(Value = "DIAQ")]
    [IsoId("_n4FOY4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a diagnostic.")]
    ATMDiagnosticRequest,
    
    /// <summary>
    /// Response to a diagnostic request.
    /// Encoded/decoded by serializers as "ATMDiagnosticResponse".
    /// </summary>
    [EnumMember(Value = "DIAP")]
    [IsoId("_n-Csc4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a diagnostic request.")]
    ATMDiagnosticResponse,
    
    /// <summary>
    /// Global status of the ATM.
    /// Encoded/decoded by serializers as "ATMGlobalStatus".
    /// </summary>
    [EnumMember(Value = "GSTS")]
    [IsoId("_oEJ7g4nyEeS9F4Qrq_eaVA")]
    [Description(@"Global status of the ATM.")]
    ATMGlobalStatus,
    
    /// <summary>
    /// Request for an inquiry.
    /// Encoded/decoded by serializers as "ATMInquiryRequest".
    /// </summary>
    [EnumMember(Value = "INQQ")]
    [IsoId("_oKHZk4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for an inquiry.")]
    ATMInquiryRequest,
    
    /// <summary>
    /// Response to an inquiry request.
    /// Encoded/decoded by serializers as "ATMInquiryResponse".
    /// </summary>
    [EnumMember(Value = "INQP")]
    [IsoId("_oQOoo4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to an inquiry request.")]
    ATMInquiryResponse,
    
    /// <summary>
    /// Request for a key download.
    /// Encoded/decoded by serializers as "ATMKeyDownloadRequest".
    /// </summary>
    [EnumMember(Value = "KYAQ")]
    [IsoId("_oWMGs4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a key download.")]
    ATMKeyDownloadRequest,
    
    /// <summary>
    /// Response to a key download.
    /// Encoded/decoded by serializers as "ATMKeyDownloadResponse".
    /// </summary>
    [EnumMember(Value = "KYAP")]
    [IsoId("_ocT804nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a key download.")]
    ATMKeyDownloadResponse,
    
    /// <summary>
    /// Request for a cardholder PIN management.
    /// Encoded/decoded by serializers as "ATMPINManagementRequest".
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_oibL44nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a cardholder PIN management.")]
    ATMPINManagementRequest,
    
    /// <summary>
    /// Response to a cardholder PIN management request.
    /// Encoded/decoded by serializers as "ATMPINManagementResponse".
    /// </summary>
    [EnumMember(Value = "PINP")]
    [IsoId("_okqAgYnyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a cardholder PIN management request.")]
    ATMPINManagementResponse,
    
    /// <summary>
    /// Rejected request message.
    /// Encoded/decoded by serializers as "ATMRequestReject".
    /// </summary>
    [EnumMember(Value = "RJAQ")]
    [IsoId("_osj_U4nyEeS9F4Qrq_eaVA")]
    [Description(@"Rejected request message.")]
    ATMRequestReject,
    
    /// <summary>
    /// Rejected response message.
    /// Encoded/decoded by serializers as "ATMResponseReject".
    /// </summary>
    [EnumMember(Value = "RJAP")]
    [IsoId("_oyqnU4nyEeS9F4Qrq_eaVA")]
    [Description(@"Rejected response message.")]
    ATMResponseReject,
    
    /// <summary>
    /// Response of a withdrawal transaction.
    /// Encoded/decoded by serializers as "ATMWithdrawalAdvice".
    /// </summary>
    [EnumMember(Value = "WITV")]
    [IsoId("_o4oFY4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response of a withdrawal transaction.")]
    ATMWithdrawalAdvice,
    
    /// <summary>
    /// Acknowledgement of a withdrawal transaction advice.
    /// Encoded/decoded by serializers as "ATMWithdrawalAknowledgement".
    /// </summary>
    [EnumMember(Value = "WITK")]
    [IsoId("_o6twEYnyEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a withdrawal transaction advice.")]
    ATMWithdrawalAknowledgement,
    
    /// <summary>
    /// Request for a withdrawal transaction.
    /// Encoded/decoded by serializers as "ATMWithdrawalRequest".
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_pEsyg4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request for a withdrawal transaction.")]
    ATMWithdrawalRequest,
    
    /// <summary>
    /// Response to a withdrawal transaction request.
    /// Encoded/decoded by serializers as "ATMWithdrawalResponse".
    /// </summary>
    [EnumMember(Value = "WITP")]
    [IsoId("_pLIKo4nyEeS9F4Qrq_eaVA")]
    [Description(@"Response to a withdrawal transaction request.")]
    ATMWithdrawalResponse,
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as "CountersInquiry".
    /// </summary>
    [EnumMember(Value = "INQC")]
    [IsoId("_rAP5M4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry,
    
    /// <summary>
    /// Acknowledgement of a request from a host to an ATM for contacting.
    /// Encoded/decoded by serializers as "HostToATMAcknowledgement".
    /// </summary>
    [EnumMember(Value = "H2AP")]
    [IsoId("_tMFeo4nyEeS9F4Qrq_eaVA")]
    [Description(@"Acknowledgement of a request from a host to an ATM for contacting.")]
    HostToATMAcknowledgement,
    
    /// <summary>
    /// Request from a host to an ATM to be contacted by this ATM.
    /// Encoded/decoded by serializers as "HostToATMRequest".
    /// </summary>
    [EnumMember(Value = "H2AQ")]
    [IsoId("_tSMts4nyEeS9F4Qrq_eaVA")]
    [Description(@"Request from a host to an ATM to be contacted by this ATM.")]
    HostToATMRequest,
    
    /// <summary>
    /// Logical or physical operation on the ATM.
    /// Encoded/decoded by serializers as "ATMOperation".
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_uYV2Y4nyEeS9F4Qrq_eaVA")]
    [Description(@"Logical or physical operation on the ATM.")]
    ATMOperation,
    
    /// <summary>
    /// Security Commands.
    /// Encoded/decoded by serializers as "SecurityControl".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_untvI4nyEeS9F4Qrq_eaVA")]
    [Description(@"Security Commands.")]
    SecurityControl,
    
    /// <summary>
    /// Security detailed report.
    /// Encoded/decoded by serializers as "SecurityDetails".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_vaugc4nyEeS9F4Qrq_eaVA")]
    [Description(@"Security detailed report.")]
    SecurityDetails,
    
    /// <summary>
    /// Result of the key download with the status of the downloaded keys including key check values.
    /// Encoded/decoded by serializers as "SecurityKeyCompletion".
    /// </summary>
    [EnumMember(Value = "SKSC")]
    [IsoId("_v9qOY4nyEeS9F4Qrq_eaVA")]
    [Description(@"Result of the key download with the status of the downloaded keys including key check values.")]
    SecurityKeyCompletion,
    
    /// <summary>
    /// Status of cryptographic keys.
    /// Encoded/decoded by serializers as "SecurityKeyStatus".
    /// </summary>
    [EnumMember(Value = "SSTS")]
    [IsoId("_whAMA4nyEeS9F4Qrq_eaVA")]
    [Description(@"Status of cryptographic keys.")]
    SecurityKeyStatus,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction7CodeMetadataExtensions
{
    private static readonly MessageFunction7CodeDropdownSource _dropdownSource = new MessageFunction7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction7CodeDropdownRow GetMetadata(this MessageFunction7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


