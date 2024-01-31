﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalLetterType1Code.  ISO2002 ID# _REvvQLTLEeuzjuBeu7kFjQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the letter type as published in an external letter type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_REvvQLTLEeuzjuBeu7kFjQ")]
[Description(@"Specifies the letter type as published in an external letter type code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalLetterTypeCode))]
public enum ExternalLetterType1Code
{
    /// <summary>
    /// Document is a letter from the bank.
    /// Encoded/decoded by serializers as "LFBK".
    /// </summary>
    [EnumMember(Value = "LFBK")]
    [IsoId("_T0320SqmEeyXnMF3dld6dw")]
    [Description(@"Document is a letter from the bank.")]
    LetterFromBank = ExternalLetterTypeCode.LetterFromBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a letter to the bank.
    /// Encoded/decoded by serializers as "LTBK".
    /// </summary>
    [EnumMember(Value = "LTBK")]
    [IsoId("_T63xISqmEeyXnMF3dld6dw")]
    [Description(@"Document is a letter to the bank.")]
    LetterToBank = ExternalLetterTypeCode.LetterToBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a supporting document.
    /// Encoded/decoded by serializers as "SUPP".
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_UDEq4SqmEeyXnMF3dld6dw")]
    [Description(@"Document is a supporting document.")]
    SupportingDocument = ExternalLetterTypeCode.SupportingDocument, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalLetterType1CodeMetadataExtensions
{
    private static readonly ExternalLetterType1CodeDropdownSource _dropdownSource = new ExternalLetterType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalLetterType1CodeDropdownRow GetMetadata(this ExternalLetterType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


