﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FileActionScope1Code.  ISO2002 ID# _O_lBYDEmEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Action applies to a file
    /// Encoded/decoded by serializers as "FILE".
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_SafpETEmEemzCpWiCwK4aQ")]
    [Description(@"Action applies to a file")]
    File = FileActionScopeCode.File, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action applies to a record
    /// Encoded/decoded by serializers as "RECD".
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_Sv9iwTEmEemzCpWiCwK4aQ")]
    [Description(@"Action applies to a record")]
    Record = FileActionScopeCode.Record, // same ordinal as derivation source for type conversions
    
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


