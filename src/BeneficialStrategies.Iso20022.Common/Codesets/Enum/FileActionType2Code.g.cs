﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FileActionType2Code.  ISO2002 ID# _7EJK0Jb6Eeuc6pwKtqbEVQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines the type of file action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7EJK0Jb6Eeuc6pwKtqbEVQ")]
[Description(@"Determines the type of file action.")]
[DerivedFrom(typeof(FileActionTypeCode))]
public enum FileActionType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Add".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_A7LPoZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    Add,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BulkReplacement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BDlkwZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    BulkReplacement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Delete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BJ62QZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    Delete,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeleteRecordSystemPurge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BPhvAZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    DeleteRecordSystemPurge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enquire".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BV3AgZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    Enquire,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BcMSAZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BiAmIZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Replace".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BnuMkZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    Replace,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Request".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BuMA8Zb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    Request,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Update".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_B0JfAZb7Eeuc6pwKtqbEVQ")]
    [Description(@"??")]
    Update,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FileActionType2CodeMetadataExtensions
{
    private static readonly FileActionType2CodeDropdownSource _dropdownSource = new FileActionType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFileActionType2CodeDropdownRow GetMetadata(this FileActionType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


