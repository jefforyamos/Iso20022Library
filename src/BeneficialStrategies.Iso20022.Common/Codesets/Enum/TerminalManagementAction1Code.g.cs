﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementAction1Code.  ISO2002 ID# _KTertX1DEeCF8NjrBemJWQ_-2129666460.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTertX1DEeCF8NjrBemJWQ_-2129666460")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
public enum TerminalManagementAction1Code
{
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_KTertn1DEeCF8NjrBemJWQ_393182414")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate = TerminalManagementActionCode.Activate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DCTV".
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_KTert31DEeCF8NjrBemJWQ_328902808")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate = TerminalManagementActionCode.Deactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DELT".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_KTeruH1DEeCF8NjrBemJWQ_1632653045")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete = TerminalManagementActionCode.Delete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DWNL".
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_KTeruX1DEeCF8NjrBemJWQ_1504093833")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download = TerminalManagementActionCode.Download, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_KTocsH1DEeCF8NjrBemJWQ_-782008611")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install = TerminalManagementActionCode.Install, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_KTocsX1DEeCF8NjrBemJWQ_1696932651")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart = TerminalManagementActionCode.Restart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPLD".
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_KTocsn1DEeCF8NjrBemJWQ_-1487123226")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload = TerminalManagementActionCode.Upload, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementAction1CodeMetadataExtensions
{
    private static readonly TerminalManagementAction1CodeDropdownSource _dropdownSource = new TerminalManagementAction1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementAction1CodeDropdownRow GetMetadata(this TerminalManagementAction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


