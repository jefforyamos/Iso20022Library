﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FileActionType1Code.  ISO2002 ID# _9p8WwFDqEee94_dUz-hvgw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines the type of file action service.
/// ISO 8583:87 bit 91; ISO 8583:93/2003 bit 24
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9p8WwFDqEee94_dUz-hvgw")]
[Description(@"Determines the type of file action service. ISO 8583:87 bit 91; ISO 8583:93/2003 bit 24")]
[DerivedFrom(typeof(FileActionTypeCode))]
public enum FileActionType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Add".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EN-rgVDrEee94_dUz-hvgw")]
    [Description(@"??")]
    Add,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Delete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EZL18lDrEee94_dUz-hvgw")]
    [Description(@"??")]
    Delete,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enquire".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EllTMlDrEee94_dUz-hvgw")]
    [Description(@"??")]
    Enquire,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ExLfMlDrEee94_dUz-hvgw")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_E_JCslDrEee94_dUz-hvgw")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Replace".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FHxaQlDrEee94_dUz-hvgw")]
    [Description(@"??")]
    Replace,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Update".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FUKQclDrEee94_dUz-hvgw")]
    [Description(@"??")]
    Update,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BulkReplacement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UkIbwekVEemeDPHh-U9b6w")]
    [Description(@"??")]
    BulkReplacement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeleteRecordSystemPurge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ux-DcukVEemeDPHh-U9b6w")]
    [Description(@"??")]
    DeleteRecordSystemPurge,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FileActionType1CodeMetadataExtensions
{
    private static readonly FileActionType1CodeDropdownSource _dropdownSource = new FileActionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFileActionType1CodeDropdownRow GetMetadata(this FileActionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

