﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction11Code.  ISO2002 ID# _evJWQa1xEeWMg5rOByfExw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_evJWQa1xEeWMg5rOByfExw")]
[Description(@"Identifies the type of process related to an ATM message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction11Code
{
    /// <summary>
    /// Provide the ATM counters resettting those that are applicable.
    /// Encoded/decoded by serializers as "ATMBalance".
    /// </summary>
    [EnumMember(Value = "BALN")]
    [IsoId("_e61o4a1xEeWMg5rOByfExw")]
    [Description(@"Provide the ATM counters resettting those that are applicable.")]
    ATMBalance,
    
    /// <summary>
    /// Acknowledgement of a completion advice.
    /// Encoded/decoded by serializers as "ATMCompletionAcknowledgement".
    /// </summary>
    [EnumMember(Value = "CMPA")]
    [IsoId("_e61o461xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a completion advice.")]
    ATMCompletionAcknowledgement,
    
    /// <summary>
    /// Advice of an ATM transaction completion.
    /// Encoded/decoded by serializers as "ATMCompletionAdvice".
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_e61o5a1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM transaction completion.")]
    ATMCompletionAdvice,
    
    /// <summary>
    /// Global ATM commands.
    /// Encoded/decoded by serializers as "ATMControl".
    /// </summary>
    [EnumMember(Value = "ACMD")]
    [IsoId("_e61o561xEeWMg5rOByfExw")]
    [Description(@"Global ATM commands.")]
    ATMControl,
    
    /// <summary>
    /// Maintenance commands to perform.
    /// Encoded/decoded by serializers as "ATMDeviceControl".
    /// </summary>
    [EnumMember(Value = "DVCC")]
    [IsoId("_e61o6a1xEeWMg5rOByfExw")]
    [Description(@"Maintenance commands to perform.")]
    ATMDeviceControl,
    
    /// <summary>
    /// Request for a diagnostic.
    /// Encoded/decoded by serializers as "ATMDiagnosticRequest".
    /// </summary>
    [EnumMember(Value = "DIAQ")]
    [IsoId("_e61o661xEeWMg5rOByfExw")]
    [Description(@"Request for a diagnostic.")]
    ATMDiagnosticRequest,
    
    /// <summary>
    /// Response to a diagnostic request.
    /// Encoded/decoded by serializers as "ATMDiagnosticResponse".
    /// </summary>
    [EnumMember(Value = "DIAP")]
    [IsoId("_e61o7a1xEeWMg5rOByfExw")]
    [Description(@"Response to a diagnostic request.")]
    ATMDiagnosticResponse,
    
    /// <summary>
    /// Global status of the ATM.
    /// Encoded/decoded by serializers as "ATMGlobalStatus".
    /// </summary>
    [EnumMember(Value = "GSTS")]
    [IsoId("_e61o761xEeWMg5rOByfExw")]
    [Description(@"Global status of the ATM.")]
    ATMGlobalStatus,
    
    /// <summary>
    /// Request for an inquiry.
    /// Encoded/decoded by serializers as "ATMInquiryRequest".
    /// </summary>
    [EnumMember(Value = "INQQ")]
    [IsoId("_e61o8a1xEeWMg5rOByfExw")]
    [Description(@"Request for an inquiry.")]
    ATMInquiryRequest,
    
    /// <summary>
    /// Response to an inquiry request.
    /// Encoded/decoded by serializers as "ATMInquiryResponse".
    /// </summary>
    [EnumMember(Value = "INQP")]
    [IsoId("_e61o861xEeWMg5rOByfExw")]
    [Description(@"Response to an inquiry request.")]
    ATMInquiryResponse,
    
    /// <summary>
    /// Request for a key download.
    /// Encoded/decoded by serializers as "ATMKeyDownloadRequest".
    /// </summary>
    [EnumMember(Value = "KYAQ")]
    [IsoId("_e61o9a1xEeWMg5rOByfExw")]
    [Description(@"Request for a key download.")]
    ATMKeyDownloadRequest,
    
    /// <summary>
    /// Response to a key download.
    /// Encoded/decoded by serializers as "ATMKeyDownloadResponse".
    /// </summary>
    [EnumMember(Value = "KYAP")]
    [IsoId("_e61o961xEeWMg5rOByfExw")]
    [Description(@"Response to a key download.")]
    ATMKeyDownloadResponse,
    
    /// <summary>
    /// Request for a cardholder PIN management.
    /// Encoded/decoded by serializers as "ATMPINManagementRequest".
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_e61o-a1xEeWMg5rOByfExw")]
    [Description(@"Request for a cardholder PIN management.")]
    ATMPINManagementRequest,
    
    /// <summary>
    /// Response to a cardholder PIN management request.
    /// Encoded/decoded by serializers as "ATMPINManagementResponse".
    /// </summary>
    [EnumMember(Value = "PINP")]
    [IsoId("_e61o-61xEeWMg5rOByfExw")]
    [Description(@"Response to a cardholder PIN management request.")]
    ATMPINManagementResponse,
    
    /// <summary>
    /// Rejected request message.
    /// Encoded/decoded by serializers as "ATMRequestReject".
    /// </summary>
    [EnumMember(Value = "RJAQ")]
    [IsoId("_e61o_a1xEeWMg5rOByfExw")]
    [Description(@"Rejected request message.")]
    ATMRequestReject,
    
    /// <summary>
    /// Rejected response message.
    /// Encoded/decoded by serializers as "ATMResponseReject".
    /// </summary>
    [EnumMember(Value = "RJAP")]
    [IsoId("_e61o_61xEeWMg5rOByfExw")]
    [Description(@"Rejected response message.")]
    ATMResponseReject,
    
    /// <summary>
    /// Response of a withdrawal transaction.
    /// Encoded/decoded by serializers as "ATMWithdrawalAdvice".
    /// </summary>
    [EnumMember(Value = "WITV")]
    [IsoId("_e61pAa1xEeWMg5rOByfExw")]
    [Description(@"Response of a withdrawal transaction.")]
    ATMWithdrawalAdvice,
    
    /// <summary>
    /// Acknowledgement of a withdrawal transaction advice.
    /// Encoded/decoded by serializers as "ATMWithdrawalAknowledgement".
    /// </summary>
    [EnumMember(Value = "WITK")]
    [IsoId("_e61pA61xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a withdrawal transaction advice.")]
    ATMWithdrawalAknowledgement,
    
    /// <summary>
    /// Request for a withdrawal transaction.
    /// Encoded/decoded by serializers as "ATMWithdrawalRequest".
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_e61pBa1xEeWMg5rOByfExw")]
    [Description(@"Request for a withdrawal transaction.")]
    ATMWithdrawalRequest,
    
    /// <summary>
    /// Response to a withdrawal transaction request.
    /// Encoded/decoded by serializers as "ATMWithdrawalResponse".
    /// </summary>
    [EnumMember(Value = "WITP")]
    [IsoId("_e61pB61xEeWMg5rOByfExw")]
    [Description(@"Response to a withdrawal transaction request.")]
    ATMWithdrawalResponse,
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as "CountersInquiry".
    /// </summary>
    [EnumMember(Value = "INQC")]
    [IsoId("_e61pCa1xEeWMg5rOByfExw")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry,
    
    /// <summary>
    /// Acknowledgement of a request from a host to an ATM for contacting.
    /// Encoded/decoded by serializers as "HostToATMAcknowledgement".
    /// </summary>
    [EnumMember(Value = "H2AP")]
    [IsoId("_e61pC61xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a request from a host to an ATM for contacting.")]
    HostToATMAcknowledgement,
    
    /// <summary>
    /// Request from a host to an ATM to be contacted by this ATM.
    /// Encoded/decoded by serializers as "HostToATMRequest".
    /// </summary>
    [EnumMember(Value = "H2AQ")]
    [IsoId("_e61pDa1xEeWMg5rOByfExw")]
    [Description(@"Request from a host to an ATM to be contacted by this ATM.")]
    HostToATMRequest,
    
    /// <summary>
    /// Logical or physical operation on the ATM.
    /// Encoded/decoded by serializers as "ATMOperation".
    /// </summary>
    [EnumMember(Value = "TMOP")]
    [IsoId("_e61pD61xEeWMg5rOByfExw")]
    [Description(@"Logical or physical operation on the ATM.")]
    ATMOperation,
    
    /// <summary>
    /// Security Commands.
    /// Encoded/decoded by serializers as "SecurityControl".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_e61pEa1xEeWMg5rOByfExw")]
    [Description(@"Security Commands.")]
    SecurityControl,
    
    /// <summary>
    /// Security detailed report.
    /// Encoded/decoded by serializers as "SecurityDetails".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_e61pE61xEeWMg5rOByfExw")]
    [Description(@"Security detailed report.")]
    SecurityDetails,
    
    /// <summary>
    /// Result of the key download with the status of the downloaded keys including key check values.
    /// Encoded/decoded by serializers as "SecurityKeyCompletion".
    /// </summary>
    [EnumMember(Value = "SKSC")]
    [IsoId("_e61pFa1xEeWMg5rOByfExw")]
    [Description(@"Result of the key download with the status of the downloaded keys including key check values.")]
    SecurityKeyCompletion,
    
    /// <summary>
    /// Status of cryptographic keys.
    /// Encoded/decoded by serializers as "SecurityKeyStatus".
    /// </summary>
    [EnumMember(Value = "SSTS")]
    [IsoId("_e61pF61xEeWMg5rOByfExw")]
    [Description(@"Status of cryptographic keys.")]
    SecurityKeyStatus,
    
    /// <summary>
    /// Acknowledgement of a deposit completion advice.
    /// Encoded/decoded by serializers as "ATMDepositCompletionAcknowledgement".
    /// </summary>
    [EnumMember(Value = "DPSK")]
    [IsoId("_lLyCga1xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of a deposit completion advice.")]
    ATMDepositCompletionAcknowledgement,
    
    /// <summary>
    /// Advice of an ATM deposit transaction completion.
    /// Encoded/decoded by serializers as "ATMDepositCompletionAdvice".
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_lT-VMa1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM deposit transaction completion.")]
    ATMDepositCompletionAdvice,
    
    /// <summary>
    /// Request for a deposit.
    /// Encoded/decoded by serializers as "ATMDepositRequest".
    /// </summary>
    [EnumMember(Value = "DPSQ")]
    [IsoId("_ld0Nsa1xEeWMg5rOByfExw")]
    [Description(@"Request for a deposit.")]
    ATMDepositRequest,
    
    /// <summary>
    /// Response to a deposit request.
    /// Encoded/decoded by serializers as "ATMDepositResponse".
    /// </summary>
    [EnumMember(Value = "DPSP")]
    [IsoId("_lmAgYa1xEeWMg5rOByfExw")]
    [Description(@"Response to a deposit request.")]
    ATMDepositResponse,
    
    /// <summary>
    /// Acknowledgement of an exception advice.
    /// Encoded/decoded by serializers as "ATMExceptionAcknowledgement".
    /// </summary>
    [EnumMember(Value = "EXPK")]
    [IsoId("_mGqWYa1xEeWMg5rOByfExw")]
    [Description(@"Acknowledgement of an exception advice.")]
    ATMExceptionAcknowledgement,
    
    /// <summary>
    /// Advice of an ATM exception.
    /// Encoded/decoded by serializers as "ATMExceptionAdvice".
    /// </summary>
    [EnumMember(Value = "EXPV")]
    [IsoId("_mOakMa1xEeWMg5rOByfExw")]
    [Description(@"Advice of an ATM exception.")]
    ATMExceptionAdvice,
    
    /// <summary>
    /// Request for a fund transfer.
    /// Encoded/decoded by serializers as "ATMTransferRequest".
    /// </summary>
    [EnumMember(Value = "TRFQ")]
    [IsoId("_n5vdka1xEeWMg5rOByfExw")]
    [Description(@"Request for a fund transfer.")]
    ATMTransferRequest,
    
    /// <summary>
    /// Response to a fund transfer request.
    /// Encoded/decoded by serializers as "ATMTransferResponse".
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_oCFhQa1xEeWMg5rOByfExw")]
    [Description(@"Response to a fund transfer request.")]
    ATMTransferResponse,
    
    /// <summary>
    /// Provide the value of the ATM counters, no reinitialisation of the counters.
    /// Encoded/decoded by serializers as "CountersReport".
    /// </summary>
    [EnumMember(Value = "RPTC")]
    [IsoId("_rsA1Ua1xEeWMg5rOByfExw")]
    [Description(@"Provide the value of the ATM counters, no reinitialisation of the counters.")]
    CountersReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction11CodeMetadataExtensions
{
    private static readonly MessageFunction11CodeDropdownSource _dropdownSource = new MessageFunction11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction11CodeDropdownRow GetMetadata(this MessageFunction11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


