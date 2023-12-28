﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementAction5Code.  ISO2002 ID# _GO0LkSiyEeurkfo6MpvKDA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GO0LkSiyEeurkfo6MpvKDA")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
public enum TerminalManagementAction5Code
{
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Deactivate".
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_GmJtgSiyEeurkfo6MpvKDA")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate,
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Delete".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_GmJtgyiyEeurkfo6MpvKDA")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete,
    
    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Download".
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_GmJthSiyEeurkfo6MpvKDA")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download,
    
    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Install".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_GmJthyiyEeurkfo6MpvKDA")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install,
    
    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Restart".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_GmJtiSiyEeurkfo6MpvKDA")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart,
    
    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Upload".
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_GmJtiyiyEeurkfo6MpvKDA")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload,
    
    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Update".
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_GmKUkSiyEeurkfo6MpvKDA")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update,
    
    /// <summary>
    /// Request sent to a POI to bind with a server.
    /// Encoded/decoded by serializers as "Bind".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_GmKUkyiyEeurkfo6MpvKDA")]
    [Description(@"Request sent to a POI to bind with a server.")]
    Bind,
    
    /// <summary>
    /// Request sent to a POI to rebind with a server.
    /// Encoded/decoded by serializers as "Rebind".
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_GmKUlSiyEeurkfo6MpvKDA")]
    [Description(@"Request sent to a POI to rebind with a server.")]
    Rebind,
    
    /// <summary>
    /// Request sent to a POI to unbind with a server.
    /// Encoded/decoded by serializers as "Unbind".
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_GmKUlyiyEeurkfo6MpvKDA")]
    [Description(@"Request sent to a POI to unbind with a server.")]
    Unbind,
    
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "Activate".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_GmKUmSiyEeurkfo6MpvKDA")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate,
    
    /// <summary>
    /// Request to execute a device request.
    /// Encoded/decoded by serializers as "DeviceRequest".
    /// </summary>
    [EnumMember(Value = "DEVR")]
    [IsoId("_Mam_cSiyEeurkfo6MpvKDA")]
    [Description(@"Request to execute a device request.")]
    DeviceRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementAction5CodeMetadataExtensions
{
    private static readonly TerminalManagementAction5CodeDropdownSource _dropdownSource = new TerminalManagementAction5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementAction5CodeDropdownRow GetMetadata(this TerminalManagementAction5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


