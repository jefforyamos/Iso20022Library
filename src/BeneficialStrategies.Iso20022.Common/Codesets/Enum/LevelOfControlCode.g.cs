﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LevelOfControlCode.  ISO2002 ID# _Y7LFQCDDEeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of control.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y7LFQCDDEeWPMvNwVtiMsA")]
[Description(@"Specifies the level of control.")]
[Derivations(typeof(LevelOfControl1Code))]
public enum LevelOfControlCode
{
    /// <summary>
    /// Account may be viewed only.
    /// Encoded/decoded by serializers as "VIEW".
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_dyic0CDDEeWPMvNwVtiMsA")]
    [Description(@"Account may be viewed only.")]
    View,
    
    /// <summary>
    /// Transactions are permitted on the account.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_gcSGQCDDEeWPMvNwVtiMsA")]
    [Description(@"Transactions are permitted on the account.")]
    Transactions,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LevelOfControlCodeMetadataExtensions
{
    private static readonly LevelOfControlCodeDropdownSource _dropdownSource = new LevelOfControlCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILevelOfControlCodeDropdownRow GetMetadata(this LevelOfControlCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


