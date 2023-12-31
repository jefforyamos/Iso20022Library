﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType10Code.  ISO2002 ID# _FgF8gE0uEeea0Mdu1TOzDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of additional action to be performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FgF8gE0uEeea0Mdu1TOzDQ")]
[Description(@"Type of additional action to be performed.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType10Code
{
    /// <summary>
    /// Activate device or service.
    /// Encoded/decoded by serializers as "Activate".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_MS5GAU0uEeea0Mdu1TOzDQ")]
    [Description(@"Activate device or service.")]
    Activate,
    
    /// <summary>
    /// Deactivate device or service.
    /// Encoded/decoded by serializers as "Deactivate".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_NWZxck0uEeea0Mdu1TOzDQ")]
    [Description(@"Deactivate device or service.")]
    Deactivate,
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as "DisplayMessage".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_OQieck0uEeea0Mdu1TOzDQ")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage,
    
    /// <summary>
    /// Update a data file.
    /// Encoded/decoded by serializers as "FileUpdate".
    /// </summary>
    [EnumMember(Value = "FUPD")]
    [IsoId("_PDBEQk0uEeea0Mdu1TOzDQ")]
    [Description(@"Update a data file.")]
    FileUpdate,
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as "PrintMessage".
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_QG8mck0uEeea0Mdu1TOzDQ")]
    [Description(@"Print a message.")]
    PrintMessage,
    
    /// <summary>
    /// Send a message.
    /// Encoded/decoded by serializers as "SendMessage".
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_QxFvok0uEeea0Mdu1TOzDQ")]
    [Description(@"Send a message.")]
    SendMessage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionType10CodeMetadataExtensions
{
    private static readonly ActionType10CodeDropdownSource _dropdownSource = new ActionType10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionType10CodeDropdownRow GetMetadata(this ActionType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


