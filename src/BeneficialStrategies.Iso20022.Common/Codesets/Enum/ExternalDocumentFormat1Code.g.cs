﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDocumentFormat1Code.  ISO2002 ID# _-MOeE27iEeKo25nLKvGr8w_969448361.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeE27iEeKo25nLKvGr8w_969448361")]
[Description(@"Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDocumentFormatCode))]
public enum ExternalDocumentFormat1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PDF".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uPIrNfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PDF,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "XML".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uPIrOPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    XML,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Spreadsheet".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uPIrO_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Spreadsheet,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Word".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uPIrPvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Word,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "XSLT".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uPScMvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    XSLT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDocumentFormat1CodeMetadataExtensions
{
    private static readonly ExternalDocumentFormat1CodeDropdownSource _dropdownSource = new ExternalDocumentFormat1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDocumentFormat1CodeDropdownRow GetMetadata(this ExternalDocumentFormat1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

