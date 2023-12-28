﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementActionResult3Code.  ISO2002 ID# _3OO64bC1EeamYaqfhG1ZuA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Final result of the processed terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3OO64bC1EeamYaqfhG1ZuA")]
[Description(@"Final result of the processed terminal management action.")]
[DerivedFrom(typeof(TerminalManagementActionResultCode))]
public enum TerminalManagementActionResult3Code
{
    /// <summary>
    /// Access is denied while performing the action.
    /// Encoded/decoded by serializers as "AccessDenied".
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_3duIYbC1EeamYaqfhG1ZuA")]
    [Description(@"Access is denied while performing the action.")]
    AccessDenied,
    
    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as "ConnectionError".
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_3duIY7C1EeamYaqfhG1ZuA")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError,
    
    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as "FormatError".
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_3duIZbC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError,
    
    /// <summary>
    /// Content of the data is invalid.
    /// Encoded/decoded by serializers as "InvalidContent".
    /// </summary>
    [EnumMember(Value = "INVC")]
    [IsoId("_3duIZ7C1EeamYaqfhG1ZuA")]
    [Description(@"Content of the data is invalid.")]
    InvalidContent,
    
    /// <summary>
    /// Data transferred has a wrong length.
    /// Encoded/decoded by serializers as "LengthError".
    /// </summary>
    [EnumMember(Value = "LENE")]
    [IsoId("_3duIabC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong length.")]
    LengthError,
    
    /// <summary>
    /// Memory to store the date exceeded.
    /// Encoded/decoded by serializers as "MemoryOverflow".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_3duIa7C1EeamYaqfhG1ZuA")]
    [Description(@"Memory to store the date exceeded.")]
    MemoryOverflow,
    
    /// <summary>
    /// Data set to be maintained is missing.
    /// Encoded/decoded by serializers as "MissingFile".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_3duIbbC1EeamYaqfhG1ZuA")]
    [Description(@"Data set to be maintained is missing.")]
    MissingFile,
    
    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as "NotSupported".
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_3duIb7C1EeamYaqfhG1ZuA")]
    [Description(@"Action is not supported.")]
    NotSupported,
    
    /// <summary>
    /// Data transferred has a wrong digital signature.
    /// Encoded/decoded by serializers as "SignatureError".
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_3duIcbC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong digital signature.")]
    SignatureError,
    
    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as "Success".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_3duIc7C1EeamYaqfhG1ZuA")]
    [Description(@"Action was successfully performed.")]
    Success,
    
    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as "SyntaxError".
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_3duIdbC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError,
    
    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as "Timeout".
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_3duId7C1EeamYaqfhG1ZuA")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout,
    
    /// <summary>
    /// Data set identification invalid.
    /// Encoded/decoded by serializers as "UnknownData".
    /// </summary>
    [EnumMember(Value = "UKDT")]
    [IsoId("_3duIebC1EeamYaqfhG1ZuA")]
    [Description(@"Data set identification invalid.")]
    UnknownData,
    
    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as "UnknownKeyReference".
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_3duIe7C1EeamYaqfhG1ZuA")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference,
    
    /// <summary>
    /// Delegation Proof transmitted by the delegated TMS is not the one expected.
    /// Encoded/decoded by serializers as "InvalidDelegationProof".
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_wgTYYbC3EeamYaqfhG1ZuA")]
    [Description(@"Delegation Proof transmitted by the delegated TMS is not the one expected.")]
    InvalidDelegationProof,
    
    /// <summary>
    /// One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.
    /// Encoded/decoded by serializers as "InvalidDelegationInManagementPlan".
    /// </summary>
    [EnumMember(Value = "IDMP")]
    [IsoId("_wuOfobC3EeamYaqfhG1ZuA")]
    [Description(@"One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.")]
    InvalidDelegationInManagementPlan,
    
    /// <summary>
    /// The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.
    /// Encoded/decoded by serializers as "DelegationParametersReceivedUnauthorized".
    /// </summary>
    [EnumMember(Value = "DPRU")]
    [IsoId("_w_M64bC3EeamYaqfhG1ZuA")]
    [Description(@"The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.")]
    DelegationParametersReceivedUnauthorized,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementActionResult3CodeMetadataExtensions
{
    private static readonly TerminalManagementActionResult3CodeDropdownSource _dropdownSource = new TerminalManagementActionResult3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementActionResult3CodeDropdownRow GetMetadata(this TerminalManagementActionResult3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


