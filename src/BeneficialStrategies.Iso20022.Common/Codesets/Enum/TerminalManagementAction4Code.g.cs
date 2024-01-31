﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementAction4Code.  ISO2002 ID# _dOBBgd6FEeeCre2qFaLC2A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dOBBgd6FEeeCre2qFaLC2A")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
public enum TerminalManagementAction4Code
{
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DCTV".
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_dXUHc96FEeeCre2qFaLC2A")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate = TerminalManagementActionCode.Deactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DELT".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_dXUHdd6FEeeCre2qFaLC2A")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete = TerminalManagementActionCode.Delete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DWNL".
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_dXUHd96FEeeCre2qFaLC2A")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download = TerminalManagementActionCode.Download, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_dXUHed6FEeeCre2qFaLC2A")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install = TerminalManagementActionCode.Install, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_dXUHe96FEeeCre2qFaLC2A")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart = TerminalManagementActionCode.Restart, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPLD".
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_dXUHfd6FEeeCre2qFaLC2A")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload = TerminalManagementActionCode.Upload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPDT".
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_dXUHf96FEeeCre2qFaLC2A")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update = TerminalManagementActionCode.Update, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request sent to a POI to bind with a server.
    /// Encoded/decoded by serializers as "BIND".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_ekYXgd6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to bind with a server.")]
    Bind = TerminalManagementActionCode.Bind, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request sent to a POI to rebind with a server.
    /// Encoded/decoded by serializers as "RBND".
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_e-L-od6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to rebind with a server.")]
    Rebind = TerminalManagementActionCode.Rebind, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request sent to a POI to unbind with a server.
    /// Encoded/decoded by serializers as "UBND".
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_fKLzQd6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to unbind with a server.")]
    Unbind = TerminalManagementActionCode.Unbind, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_hFFZsd6FEeeCre2qFaLC2A")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate = TerminalManagementActionCode.Activate, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementAction4CodeMetadataExtensions
{
    private static readonly TerminalManagementAction4CodeDropdownSource _dropdownSource = new TerminalManagementAction4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementAction4CodeDropdownRow GetMetadata(this TerminalManagementAction4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


