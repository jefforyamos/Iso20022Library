﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InputSource1Code.  ISO2002 ID# _m9EHgMmMEeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the input source for the generation of the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m9EHgMmMEeWAGphE2LvqeA")]
[Description(@"Specifies the input source for the generation of the file.")]
[DerivedFrom(typeof(InputSourceCode))]
public enum InputSource1Code
{
    /// <summary>
    /// File has been encoded.
    /// Encoded/decoded by serializers as "Encoded".
    /// </summary>
    [EnumMember(Value = "NCOD")]
    [IsoId("_uWkrscmMEeWAGphE2LvqeA")]
    [Description(@"File has been encoded.")]
    Encoded,
    
    /// <summary>
    /// File has been uploaded manually.
    /// Encoded/decoded by serializers as "UploadedManually".
    /// </summary>
    [EnumMember(Value = "UMNL")]
    [IsoId("_uiBGssmMEeWAGphE2LvqeA")]
    [Description(@"File has been uploaded manually.")]
    UploadedManually,
    
    /// <summary>
    /// File has been uploaded through the CIS (Customer Identification System) system.
    /// Encoded/decoded by serializers as "UploadedViaCIS".
    /// </summary>
    [EnumMember(Value = "UCIS")]
    [IsoId("_utUXwsmMEeWAGphE2LvqeA")]
    [Description(@"File has been uploaded through the CIS (Customer Identification System) system.")]
    UploadedViaCIS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InputSource1CodeMetadataExtensions
{
    private static readonly InputSource1CodeDropdownSource _dropdownSource = new InputSource1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInputSource1CodeDropdownRow GetMetadata(this InputSource1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


