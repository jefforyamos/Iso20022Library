﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FileActionScope1Code.  ISO2002 ID# _O_lBYDEmEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O_lBYDEmEemzCpWiCwK4aQ")]
[Description(@"Indicates whether the action applies to a file or a record.")]
[DerivedFrom(typeof(FileActionScopeCode))]
public enum FileActionScope1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "File".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SafpETEmEemzCpWiCwK4aQ")]
    [Description(@"??")]
    File,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Record".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Sv9iwTEmEemzCpWiCwK4aQ")]
    [Description(@"??")]
    Record,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FileActionScope1CodeMetadataExtensions
{
    private static readonly FileActionScope1CodeDropdownSource _dropdownSource = new FileActionScope1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFileActionScope1CodeDropdownRow GetMetadata(this FileActionScope1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


