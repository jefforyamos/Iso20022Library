﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InputCommandCode.  ISO2002 ID# _jBTTwN6nEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of requested input.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jBTTwN6nEeiwsev40qZGEQ")]
[Description(@"Type of requested input.")]
[Derivations(typeof(InputCommand1Code))]
// External derivations that should be provided by the proper interface are: 
public enum InputCommandCode
{
    /// <summary>
    /// Wait for a key pressed on the Terminal, to be able to read the message displayed on the Terminal.
    /// Encoded/decoded by serializers as "GAKY".
    /// </summary>
    [EnumMember(Value = "GAKY")]
    [IsoId("_mrXKsN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a key pressed on the Terminal, to be able to read the message displayed on the Terminal.")]
    GetAnyKey,
    
    /// <summary>
    /// Wait for a confirmation Yes (Y) or No (N) on the Sale System. Wait for a confirmation (Valid or Cancel button) on the POI Terminal. The result of the command is a Boolean: True or False.
    /// Encoded/decoded by serializers as "GCNF".
    /// </summary>
    [EnumMember(Value = "GCNF")]
    [IsoId("_pVzXsN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a confirmation Yes (Y) or No (N) on the Sale System. Wait for a confirmation (Valid or Cancel button) on the POI Terminal. The result of the command is a Boolean: True or False.")]
    GetConfirmation,
    
    /// <summary>
    /// Wait for a confirmation Yes (Y) or No (N) of the Site Manager on the Sale System.
    /// Encoded/decoded by serializers as "SITE".
    /// </summary>
    [EnumMember(Value = "SITE")]
    [IsoId("_s944sN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a confirmation Yes (Y) or No (N) of the Site Manager on the Sale System.")]
    SiteManager,
    
    /// <summary>
    /// Wait for a string of alphanumeric characters.
    /// Encoded/decoded by serializers as "TXSG".
    /// </summary>
    [EnumMember(Value = "TXSG")]
    [IsoId("_vvbMMN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a string of alphanumeric characters.")]
    TextString,
    
    /// <summary>
    /// Wait for a string of digit characters.
    /// Encoded/decoded by serializers as "DGSG".
    /// </summary>
    [EnumMember(Value = "DGSG")]
    [IsoId("_x6DQsN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a string of digit characters.")]
    DigitString,
    
    /// <summary>
    /// Wait for a string of digit characters with a decimal point, the length range could be specified.
    /// Encoded/decoded by serializers as "DCSG".
    /// </summary>
    [EnumMember(Value = "DCSG")]
    [IsoId("_0N_CMN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a string of digit characters with a decimal point, the length range could be specified.")]
    DecimalString,
    
    /// <summary>
    /// Wait for a function key pressed on the Terminal: From POI, Valid, Clear, Correct, Generic Function key number. From Sale, Generic Function key.
    /// Encoded/decoded by serializers as "GFKY".
    /// </summary>
    [EnumMember(Value = "GFKY")]
    [IsoId("_288i0N6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a function key pressed on the Terminal: From POI, Valid, Clear, Correct, Generic Function key number. From Sale, Generic Function key.")]
    GetFunctionKey,
    
    /// <summary>
    /// To choose an entry among a list of entries (all of them are not necessary selectable). The OutputFormat has to be MenuEntry.
    /// Encoded/decoded by serializers as "GMNE".
    /// </summary>
    [EnumMember(Value = "GMNE")]
    [IsoId("_6XNDMN6nEeiwsev40qZGEQ")]
    [Description(@"To choose an entry among a list of entries (all of them are not necessary selectable). The OutputFormat has to be MenuEntry.")]
    GetMenuEntry,
    
    /// <summary>
    /// Request to enter a password with masked characters while typing the password.
    /// Encoded/decoded by serializers as "PSWD".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_9Gc3sN6nEeiwsev40qZGEQ")]
    [Description(@"Request to enter a password with masked characters while typing the password.")]
    Password,
    
    /// <summary>
    /// Wait for a XHTML data.
    /// Encoded/decoded by serializers as "HTML".
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("__gt6sN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a XHTML data.")]
    XHTMLText,
    
    /// <summary>
    /// Request to wait for signature.
    /// Encoded/decoded by serializers as "SIGN".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_jDqpoO2tEei-V5h0ja04AA")]
    [Description(@"Request to wait for signature.")]
    Signature,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InputCommandCodeMetadataExtensions
{
    private static readonly InputCommandCodeDropdownSource _dropdownSource = new InputCommandCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInputCommandCodeDropdownRow GetMetadata(this InputCommandCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


