﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionDestinationCode.  ISO2002 ID# _DsgNEE0wEeea0Mdu1TOzDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of destination for a specific action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DsgNEE0wEeea0Mdu1TOzDQ")]
[Description(@"Type of destination for a specific action.")]
[Derivations(typeof(ActionDestination1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ActionDestinationCode
{
    /// <summary>
    /// Personal computer.
    /// Encoded/decoded by serializers as "PECR".
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_JiPRYE0wEeea0Mdu1TOzDQ")]
    [Description(@"Personal computer.")]
    PersonalComputer,
    
    /// <summary>
    /// Mobile telephone
    /// Encoded/decoded by serializers as "MOBL".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_RgGf0U0wEeea0Mdu1TOzDQ")]
    [Description(@"Mobile telephone")]
    Mobile,
    
    /// <summary>
    /// Point of sale terminal.
    /// Encoded/decoded by serializers as "POFS".
    /// </summary>
    [EnumMember(Value = "POFS")]
    [IsoId("_XwLWwE0wEeea0Mdu1TOzDQ")]
    [Description(@"Point of sale terminal.")]
    PointOfSale,
    
    /// <summary>
    /// Data file
    /// Encoded/decoded by serializers as "FILE".
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_eYyCcE0wEeea0Mdu1TOzDQ")]
    [Description(@"Data file")]
    File,
    
    /// <summary>
    /// Other type of destination for action defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_jyGQgE0wEeea0Mdu1TOzDQ")]
    [Description(@"Other type of destination for action defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of destination for action defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_o2RVAE0wEeea0Mdu1TOzDQ")]
    [Description(@"Other type of destination for action defined at private level.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionDestinationCodeMetadataExtensions
{
    private static readonly ActionDestinationCodeDropdownSource _dropdownSource = new ActionDestinationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionDestinationCodeDropdownRow GetMetadata(this ActionDestinationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


