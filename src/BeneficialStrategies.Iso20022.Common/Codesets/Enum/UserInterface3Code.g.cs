﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UserInterface3Code.  ISO2002 ID# _c6sBIIO6EeSWSLYdc10LRg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c6sBIIO6EeSWSLYdc10LRg")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface3Code
{
    /// <summary>
    /// Acquirer.
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "ACQU")]
    [IsoId("_ecl4wYO6EeSWSLYdc10LRg")]
    [Description(@"Acquirer.")]
    Acquirer,
    
    /// <summary>
    /// Agent.
    /// Encoded/decoded by serializers as "Agent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_ejvpoYO6EeSWSLYdc10LRg")]
    [Description(@"Agent.")]
    Agent,
    
    /// <summary>
    /// Issuer.
    /// Encoded/decoded by serializers as "Issuer".
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_euVJAYO6EeSWSLYdc10LRg")]
    [Description(@"Issuer.")]
    Issuer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UserInterface3CodeMetadataExtensions
{
    private static readonly UserInterface3CodeDropdownSource _dropdownSource = new UserInterface3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUserInterface3CodeDropdownRow GetMetadata(this UserInterface3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


