﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionTaken1Code.  ISO2002 ID# _ui-W4HdmEeeKH6vrEwvLHA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action taken as a disposition of a reported card payment fraud.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ui-W4HdmEeeKH6vrEwvLHA")]
[Description(@"Type of action taken as a disposition of a reported card payment fraud.")]
[DerivedFrom(typeof(ActionTakenCode))]
public enum ActionTaken1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ykWhoXdmEeeKH6vrEwvLHA")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yzE6IndmEeeKH6vrEwvLHA")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y8mpkndmEeeKH6vrEwvLHA")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zNj2sndmEeeKH6vrEwvLHA")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Warning".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zZUawndmEeeKH6vrEwvLHA")]
    [Description(@"??")]
    Warning,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionTaken1CodeMetadataExtensions
{
    private static readonly ActionTaken1CodeDropdownSource _dropdownSource = new ActionTaken1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionTaken1CodeDropdownRow GetMetadata(this ActionTaken1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

