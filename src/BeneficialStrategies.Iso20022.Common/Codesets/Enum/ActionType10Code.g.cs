﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType10Code.  ISO2002 ID# _FgF8gE0uEeea0Mdu1TOzDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_MS5GAU0uEeea0Mdu1TOzDQ")]
    [Description(@"Activate device or service.")]
    Activate = ActionTypeCode.Activate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deactivate device or service.
    /// Encoded/decoded by serializers as "DEAC".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_NWZxck0uEeea0Mdu1TOzDQ")]
    [Description(@"Deactivate device or service.")]
    Deactivate = ActionTypeCode.Deactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as "DISP".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_OQieck0uEeea0Mdu1TOzDQ")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update a data file.
    /// Encoded/decoded by serializers as "FUPD".
    /// </summary>
    [EnumMember(Value = "FUPD")]
    [IsoId("_PDBEQk0uEeea0Mdu1TOzDQ")]
    [Description(@"Update a data file.")]
    FileUpdate = ActionTypeCode.FileUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as "PRNT".
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_QG8mck0uEeea0Mdu1TOzDQ")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Send a message.
    /// Encoded/decoded by serializers as "SNDM".
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_QxFvok0uEeea0Mdu1TOzDQ")]
    [Description(@"Send a message.")]
    SendMessage = ActionTypeCode.SendMessage, // same ordinal as derivation source for type conversions
    
}
