﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SupportDocumentTypeCode.  ISO2002 ID# _3DrUQNnSEeS--7IJLPC9lw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of supporting document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3DrUQNnSEeS--7IJLPC9lw")]
[Description(@"Specifies a type of supporting document.")]
[Derivations(typeof(SupportDocumentType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum SupportDocumentTypeCode
{
    /// <summary>
    /// Document is a supporting document.
    /// Encoded/decoded by serializers as "SUPP".
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_5BhhANnSEeS--7IJLPC9lw")]
    [Description(@"Document is a supporting document.")]
    SupportingDocument,
    
    /// <summary>
    /// Document is a letter from the bank.
    /// Encoded/decoded by serializers as "LFBK".
    /// </summary>
    [EnumMember(Value = "LFBK")]
    [IsoId("_-KQVYNnSEeS--7IJLPC9lw")]
    [Description(@"Document is a letter from the bank.")]
    LetterFromBank,
    
    /// <summary>
    /// Document is a letter to the bank.
    /// Encoded/decoded by serializers as "LTBK".
    /// </summary>
    [EnumMember(Value = "LTBK")]
    [IsoId("_C6ACAdnTEeS--7IJLPC9lw")]
    [Description(@"Document is a letter to the bank.")]
    LetterToBank,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SupportDocumentTypeCodeMetadataExtensions
{
    private static readonly SupportDocumentTypeCodeDropdownSource _dropdownSource = new SupportDocumentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISupportDocumentTypeCodeDropdownRow GetMetadata(this SupportDocumentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


