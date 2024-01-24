﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalManagementActionCode.  ISO2002 ID# _KTocs31DEeCF8NjrBemJWQ_1816233839.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTocs31DEeCF8NjrBemJWQ_1816233839")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[Derivations(typeof(TerminalManagementAction1Code),typeof(TerminalManagementAction4Code),typeof(TerminalManagementAction3Code),typeof(TerminalManagementAction2Code),typeof(TerminalManagementAction5Code))]
public enum TerminalManagementActionCode
{
    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_KToctH1DEeCF8NjrBemJWQ_144688973")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate,
    
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DCTV".
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_KToctX1DEeCF8NjrBemJWQ_-139344905")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate,
    
    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DELT".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_KToctn1DEeCF8NjrBemJWQ_-484952670")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete,
    
    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "DWNL".
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_KToct31DEeCF8NjrBemJWQ_1240301516")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download,
    
    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_KTocuH1DEeCF8NjrBemJWQ_-958484136")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install,
    
    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_KTocuX1DEeCF8NjrBemJWQ_-1341808276")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart,
    
    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPLD".
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_KTxmoH1DEeCF8NjrBemJWQ_482605373")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload,
    
    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "UPDT".
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_Dyi3AI3iEeW32YMP0mBeyw")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update,
    
    /// <summary>
    /// Request to create or add the element identified inside the message exchange.
    /// Encoded/decoded by serializers as "CREA".
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_i61isI34EeWRwov1g9WL_A")]
    [Description(@"Request to create or add the element identified inside the message exchange.")]
    Create,
    
    /// <summary>
    /// Request sent to a POI to bind with a server.
    /// Encoded/decoded by serializers as "BIND".
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_RHCooN6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to bind with a server.")]
    Bind,
    
    /// <summary>
    /// Request sent to a POI to unbind with a server.
    /// Encoded/decoded by serializers as "UBND".
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_UT4_IN6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to unbind with a server.")]
    Unbind,
    
    /// <summary>
    /// Request sent to a POI to rebind with a server.
    /// Encoded/decoded by serializers as "RBND".
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_XS2qoN6FEeeCre2qFaLC2A")]
    [Description(@"Request sent to a POI to rebind with a server.")]
    Rebind,
    
    /// <summary>
    /// Request to execute a device request.
    /// Encoded/decoded by serializers as "DEVR".
    /// </summary>
    [EnumMember(Value = "DEVR")]
    [IsoId("_0cc9MCixEeurkfo6MpvKDA")]
    [Description(@"Request to execute a device request.")]
    DeviceRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalManagementActionCodeMetadataExtensions
{
    private static readonly TerminalManagementActionCodeDropdownSource _dropdownSource = new TerminalManagementActionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalManagementActionCodeDropdownRow GetMetadata(this TerminalManagementActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


