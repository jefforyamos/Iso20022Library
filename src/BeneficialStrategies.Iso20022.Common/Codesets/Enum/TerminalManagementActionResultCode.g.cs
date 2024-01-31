﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementActionResultCode.  ISO2002 ID# _KT7Xp31DEeCF8NjrBemJWQ_-1645762165.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KT7Xp31DEeCF8NjrBemJWQ_-1645762165")]
[Description(@"Final result of the processed terminal management action.")]
[Derivations(typeof(TerminalManagementActionResult4Code),typeof(TerminalManagementActionResult1Code),typeof(TerminalManagementActionResult3Code),typeof(TerminalManagementActionResult2Code),typeof(TerminalManagementActionResult5Code))]
public enum TerminalManagementActionResultCode
{
    /// <summary>
    /// Access is denied while performing the action.
    /// Encoded/decoded by serializers as "ACCD".
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_KT7XqH1DEeCF8NjrBemJWQ_562595362")]
    [Description(@"Access is denied while performing the action.")]
    AccessDenied,
    
    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as "CNTE".
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_KT7XqX1DEeCF8NjrBemJWQ_-1659901414")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError,
    
    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as "FMTE".
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_KUFIoH1DEeCF8NjrBemJWQ_-1951859152")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError,
    
    /// <summary>
    /// Content of the data is invalid.
    /// Encoded/decoded by serializers as "INVC".
    /// </summary>
    [EnumMember(Value = "INVC")]
    [IsoId("_KUFIoX1DEeCF8NjrBemJWQ_1559667715")]
    [Description(@"Content of the data is invalid.")]
    InvalidContent,
    
    /// <summary>
    /// Data transferred has a wrong length.
    /// Encoded/decoded by serializers as "LENE".
    /// </summary>
    [EnumMember(Value = "LENE")]
    [IsoId("_KUFIon1DEeCF8NjrBemJWQ_854553100")]
    [Description(@"Data transferred has a wrong length.")]
    LengthError,
    
    /// <summary>
    /// Memory to store the date exceeded.
    /// Encoded/decoded by serializers as "OVER".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_KUFIo31DEeCF8NjrBemJWQ_-776668127")]
    [Description(@"Memory to store the date exceeded.")]
    MemoryOverflow,
    
    /// <summary>
    /// Data set to be maintained is missing.
    /// Encoded/decoded by serializers as "MISS".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_KUFIpH1DEeCF8NjrBemJWQ_676434428")]
    [Description(@"Data set to be maintained is missing.")]
    MissingFile,
    
    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as "NSUP".
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_KUFIpX1DEeCF8NjrBemJWQ_-662829061")]
    [Description(@"Action is not supported.")]
    NotSupported,
    
    /// <summary>
    /// Data transferred has a wrong digital signature.
    /// Encoded/decoded by serializers as "SIGE".
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_KUFIpn1DEeCF8NjrBemJWQ_-1773740480")]
    [Description(@"Data transferred has a wrong digital signature.")]
    SignatureError,
    
    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as "SUCC".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_KUOSkH1DEeCF8NjrBemJWQ_1737786387")]
    [Description(@"Action was successfully performed.")]
    Success,
    
    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as "SYNE".
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_KUOSkX1DEeCF8NjrBemJWQ_-1838020086")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError,
    
    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as "TIMO".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_KUOSkn1DEeCF8NjrBemJWQ_-954786799")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout,
    
    /// <summary>
    /// Data set identification invalid.
    /// Encoded/decoded by serializers as "UKDT".
    /// </summary>
    [EnumMember(Value = "UKDT")]
    [IsoId("_KUOSk31DEeCF8NjrBemJWQ_1459874857")]
    [Description(@"Data set identification invalid.")]
    UnknownData,
    
    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as "UKRF".
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_KUOSlH1DEeCF8NjrBemJWQ_1851625453")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference,
    
    /// <summary>
    /// Hardware error.
    /// Encoded/decoded by serializers as "HRDW".
    /// </summary>
    [EnumMember(Value = "HRDW")]
    [IsoId("_nNcFUIr3EeSvuOJS0mmL0g")]
    [Description(@"Hardware error.")]
    Hardware,
    
    /// <summary>
    /// Security error.
    /// Encoded/decoded by serializers as "SECR".
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_pcvOcIr3EeSvuOJS0mmL0g")]
    [Description(@"Security error.")]
    Security,
    
    /// <summary>
    /// The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.
    /// Encoded/decoded by serializers as "DPRU".
    /// </summary>
    [EnumMember(Value = "DPRU")]
    [IsoId("_Lp01ULC2EeamYaqfhG1ZuA")]
    [Description(@"The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.")]
    DelegationParametersReceivedUnauthorized,
    
    /// <summary>
    /// One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.
    /// Encoded/decoded by serializers as "IDMP".
    /// </summary>
    [EnumMember(Value = "IDMP")]
    [IsoId("_SKgUELC2EeamYaqfhG1ZuA")]
    [Description(@"One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.")]
    InvalidDelegationInManagementPlan,
    
    /// <summary>
    /// Delegation Proof transmitted by the delegated TMS is not the one expected.
    /// Encoded/decoded by serializers as "INDP".
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_W57QkLC2EeamYaqfhG1ZuA")]
    [Description(@"Delegation Proof transmitted by the delegated TMS is not the one expected.")]
    InvalidDelegationProof,
    
    /// <summary>
    /// Error in communication once the connection has been established.
    /// Encoded/decoded by serializers as "CMER".
    /// </summary>
    [EnumMember(Value = "CMER")]
    [IsoId("_oEEf4NwmEeeKpa-yxjuKzQ")]
    [Description(@"Error in communication once the connection has been established.")]
    CommunicationError,
    
    /// <summary>
    /// This code value means all TerminalManagementActionResultCode except "Any Error" and "Unlisted Error".
    /// Encoded/decoded by serializers as "AERR".
    /// </summary>
    [EnumMember(Value = "AERR")]
    [IsoId("_s3_h4NwmEeeKpa-yxjuKzQ")]
    [Description(@"This code value means all TerminalManagementActionResultCode except ""Any Error"" and ""Unlisted Error"".")]
    AnyError,
    
    /// <summary>
    /// Any error that is not defined by a code value inside the TerminalManagementActionResultCode.
    /// Encoded/decoded by serializers as "ULER".
    /// </summary>
    [EnumMember(Value = "ULER")]
    [IsoId("_v9It4NwmEeeKpa-yxjuKzQ")]
    [Description(@"Any error that is not defined by a code value inside the TerminalManagementActionResultCode.")]
    UnlistedError,
    
    /// <summary>
    /// Action was performed but some warnings arose.
    /// Encoded/decoded by serializers as "WARN".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_YVer8FFNEeyApZmLzm74zA")]
    [Description(@"Action was performed but some warnings arose.")]
    SuccessWithWarning,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementActionResultCodeMetadataExtensions
{
    private static readonly TerminalManagementActionResultCodeDropdownSource _dropdownSource = new TerminalManagementActionResultCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementActionResultCodeDropdownRow GetMetadata(this TerminalManagementActionResultCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


