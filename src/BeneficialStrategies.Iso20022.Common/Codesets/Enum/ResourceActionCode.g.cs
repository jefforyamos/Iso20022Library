﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResourceActionCode.  ISO2002 ID# _LI9QYC7_Eeu125Ip9zFcsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to perform on a media resource.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LI9QYC7_Eeu125Ip9zFcsQ")]
[Description(@"Type of action to perform on a media resource.")]
public enum ResourceActionCode
{
    /// <summary>
    /// Set the default volume of sounds.
    /// </summary>
    [EnumMember(Value = "DVOL")]
    [IsoId("_f977MS7_Eeu125Ip9zFcsQ")]
    [Description(@"Set the default volume of sounds.")]
    DVOL,
    
    /// <summary>
    /// Start the media resource as specified in the message.
    /// </summary>
    [EnumMember(Value = "STAS")]
    [IsoId("_mCpPoS7_Eeu125Ip9zFcsQ")]
    [Description(@"Start the media resource as specified in the message.")]
    STAS,
    
    /// <summary>
    /// Play in a loop the media resource as specified in the message.
    /// </summary>
    [EnumMember(Value = "LOOP")]
    [IsoId("_m1zK4S7_Eeu125Ip9zFcsQ")]
    [Description(@"Play in a loop the media resource as specified in the message.")]
    LOOP,
    
    /// <summary>
    /// Stop the media resource in progress.
    /// </summary>
    [EnumMember(Value = "STOS")]
    [IsoId("_89VCsS7_Eeu125Ip9zFcsQ")]
    [Description(@"Stop the media resource in progress.")]
    STOS,
    
    /// <summary>
    /// Pause the media resource in progress as specified in the message.
    /// </summary>
    [EnumMember(Value = "PAUS")]
    [IsoId("_DYgWYS8AEeu125Ip9zFcsQ")]
    [Description(@"Pause the media resource in progress as specified in the message.")]
    PAUS,
    
    /// <summary>
    /// Resume the progress of the media resource as specified in the message.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_D5h_0S8AEeu125Ip9zFcsQ")]
    [Description(@"Resume the progress of the media resource as specified in the message.")]
    RESU,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResourceActionCodeMetadataExtensions
{
    private static readonly ResourceActionCodeDropdownSource _dropdownSource = new ResourceActionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResourceActionCodeDropdownRow GetMetadata(this ResourceActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


