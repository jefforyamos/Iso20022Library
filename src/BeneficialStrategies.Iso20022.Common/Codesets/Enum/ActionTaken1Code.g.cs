﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionTaken1Code.  ISO2002 ID# _ui-W4HdmEeeKH6vrEwvLHA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Reported fraud was accepted
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_ykWhoXdmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was accepted")]
    Accepted = ActionTakenCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported fraud led to actions defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_yzE6IndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud led to actions defined at national level.")]
    OtherNational = ActionTakenCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported fraud led to actions defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_y8mpkndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud led to actions defined at private level.")]
    OtherPrivate = ActionTakenCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported fraud was rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_zNj2sndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was rejected.")]
    Rejected = ActionTakenCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported fraud was accepted with warnings.
    /// Encoded/decoded by serializers as "WARN".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_zZUawndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was accepted with warnings.")]
    Warning = ActionTakenCode.Warning, // same ordinal as derivation source for type conversions
    
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


