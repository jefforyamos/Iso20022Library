﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementAction2Code.  ISO2002 ID# _9nm-wY3hEeW32YMP0mBeyw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9nm-wY3hEeW32YMP0mBeyw")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
public enum TerminalManagementAction2Code
{
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_9yfZEY3hEeW32YMP0mBeyw")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate = TerminalManagementActionCode.Activate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DCTV".
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_9yfZE43hEeW32YMP0mBeyw")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate = TerminalManagementActionCode.Deactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DELT".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_9yfZFY3hEeW32YMP0mBeyw")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete = TerminalManagementActionCode.Delete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DWNL".
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_9yfZF43hEeW32YMP0mBeyw")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download = TerminalManagementActionCode.Download, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_9yfZGY3hEeW32YMP0mBeyw")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install = TerminalManagementActionCode.Install, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_9yfZG43hEeW32YMP0mBeyw")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart = TerminalManagementActionCode.Restart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPLD".
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_9yfZHY3hEeW32YMP0mBeyw")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload = TerminalManagementActionCode.Upload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPDT".
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_GKkeUY3iEeW32YMP0mBeyw")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update = TerminalManagementActionCode.Update, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementAction2CodeMetadataExtensions
{
    private static readonly TerminalManagementAction2CodeDropdownSource _dropdownSource = new TerminalManagementAction2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementAction2CodeDropdownRow GetMetadata(this TerminalManagementAction2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


