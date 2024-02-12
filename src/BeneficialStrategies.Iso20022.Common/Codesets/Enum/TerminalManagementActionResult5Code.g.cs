﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementActionResult5Code.  ISO2002 ID# _hI3NIVFNEeyApZmLzm74zA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hI3NIVFNEeyApZmLzm74zA")]
[Description(@"Final result of the processed terminal management action.")]
[DerivedFrom(typeof(TerminalManagementActionResultCode))]
public enum TerminalManagementActionResult5Code
{
    /// <summary>
    /// Access is denied while performing the action.
    /// Encoded/decoded by serializers as "ACCD".
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_hPDUsVFNEeyApZmLzm74zA")]
    [Description(@"Access is denied while performing the action.")]
    AccessDenied = TerminalManagementActionResultCode.AccessDenied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as "CNTE".
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_hPDUs1FNEeyApZmLzm74zA")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError = TerminalManagementActionResultCode.ConnectionError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as "FMTE".
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_hPDUtVFNEeyApZmLzm74zA")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError = TerminalManagementActionResultCode.FormatError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Content of the data is invalid.
    /// Encoded/decoded by serializers as "INVC".
    /// </summary>
    [EnumMember(Value = "INVC")]
    [IsoId("_hPDUt1FNEeyApZmLzm74zA")]
    [Description(@"Content of the data is invalid.")]
    InvalidContent = TerminalManagementActionResultCode.InvalidContent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong length.
    /// Encoded/decoded by serializers as "LENE".
    /// </summary>
    [EnumMember(Value = "LENE")]
    [IsoId("_hPDUuVFNEeyApZmLzm74zA")]
    [Description(@"Data transferred has a wrong length.")]
    LengthError = TerminalManagementActionResultCode.LengthError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Memory to store the date exceeded.
    /// Encoded/decoded by serializers as "OVER".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_hPDUu1FNEeyApZmLzm74zA")]
    [Description(@"Memory to store the date exceeded.")]
    MemoryOverflow = TerminalManagementActionResultCode.MemoryOverflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data set to be maintained is missing.
    /// Encoded/decoded by serializers as "MISS".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_hPDUvVFNEeyApZmLzm74zA")]
    [Description(@"Data set to be maintained is missing.")]
    MissingFile = TerminalManagementActionResultCode.MissingFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as "NSUP".
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_hPDUv1FNEeyApZmLzm74zA")]
    [Description(@"Action is not supported.")]
    NotSupported = TerminalManagementActionResultCode.NotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong digital signature.
    /// Encoded/decoded by serializers as "SIGE".
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_hPDUwVFNEeyApZmLzm74zA")]
    [Description(@"Data transferred has a wrong digital signature.")]
    SignatureError = TerminalManagementActionResultCode.SignatureError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action was performed but some warnings arose.
    /// Encoded/decoded by serializers as "WARN".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_hPDUw1FNEeyApZmLzm74zA")]
    [Description(@"Action was performed but some warnings arose.")]
    SuccessWithWarning = TerminalManagementActionResultCode.SuccessWithWarning, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as "SYNE".
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_hPDUxVFNEeyApZmLzm74zA")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError = TerminalManagementActionResultCode.SyntaxError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as "TIMO".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_hPDUx1FNEeyApZmLzm74zA")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout = TerminalManagementActionResultCode.Timeout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data set identification invalid.
    /// Encoded/decoded by serializers as "UKDT".
    /// </summary>
    [EnumMember(Value = "UKDT")]
    [IsoId("_hPDUyVFNEeyApZmLzm74zA")]
    [Description(@"Data set identification invalid.")]
    UnknownData = TerminalManagementActionResultCode.UnknownData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as "UKRF".
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_hPDUy1FNEeyApZmLzm74zA")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference = TerminalManagementActionResultCode.UnknownKeyReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delegation Proof transmitted by the delegated TMS is not the one expected.
    /// Encoded/decoded by serializers as "INDP".
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_hPDUzVFNEeyApZmLzm74zA")]
    [Description(@"Delegation Proof transmitted by the delegated TMS is not the one expected.")]
    InvalidDelegationProof = TerminalManagementActionResultCode.InvalidDelegationProof, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.
    /// Encoded/decoded by serializers as "IDMP".
    /// </summary>
    [EnumMember(Value = "IDMP")]
    [IsoId("_hPDUz1FNEeyApZmLzm74zA")]
    [Description(@"One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.")]
    InvalidDelegationInManagementPlan = TerminalManagementActionResultCode.InvalidDelegationInManagementPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.
    /// Encoded/decoded by serializers as "DPRU".
    /// </summary>
    [EnumMember(Value = "DPRU")]
    [IsoId("_hPDU0VFNEeyApZmLzm74zA")]
    [Description(@"The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.")]
    DelegationParametersReceivedUnauthorized = TerminalManagementActionResultCode.DelegationParametersReceivedUnauthorized, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// This code value means all TerminalManagementActionResultCode except "Any Error" and "Unlisted Error".
    /// Encoded/decoded by serializers as "AERR".
    /// </summary>
    [EnumMember(Value = "AERR")]
    [IsoId("_hPDU01FNEeyApZmLzm74zA")]
    [Description(@"This code value means all TerminalManagementActionResultCode except ""Any Error"" and ""Unlisted Error"".")]
    AnyError = TerminalManagementActionResultCode.AnyError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Error in communication once the connection has been established.
    /// Encoded/decoded by serializers as "CMER".
    /// </summary>
    [EnumMember(Value = "CMER")]
    [IsoId("_hPDU1VFNEeyApZmLzm74zA")]
    [Description(@"Error in communication once the connection has been established.")]
    CommunicationError = TerminalManagementActionResultCode.CommunicationError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any error that is not defined by a code value inside the TerminalManagementActionResultCode.
    /// Encoded/decoded by serializers as "ULER".
    /// </summary>
    [EnumMember(Value = "ULER")]
    [IsoId("_hPDU11FNEeyApZmLzm74zA")]
    [Description(@"Any error that is not defined by a code value inside the TerminalManagementActionResultCode.")]
    UnlistedError = TerminalManagementActionResultCode.UnlistedError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as "SUCC".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_2NuuEVFNEeyApZmLzm74zA")]
    [Description(@"Action was successfully performed.")]
    Success = TerminalManagementActionResultCode.Success, // same ordinal as derivation source for type conversions
    
}
