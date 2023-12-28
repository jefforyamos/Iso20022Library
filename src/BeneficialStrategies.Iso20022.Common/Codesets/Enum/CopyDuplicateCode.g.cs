﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CopyDuplicateCode.  ISO2002 ID# _bCWRJ9p-Ed-ak6NoX_4Aeg_-1110982463.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCWRJ9p-Ed-ak6NoX_4Aeg_-1110982463")]
[Description(@"Specifies if this document is a copy, a duplicate, or a duplicate of a copy.")]
[Derivations(typeof(CopyDuplicate1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CopyDuplicateCode
{
    /// <summary>
    /// Message is being sent as a copy to a party other than the account owner, for information purposes and the message is a duplicate of a message previously sent.
    /// Encoded/decoded by serializers as "CODU".
    /// </summary>
    [EnumMember(Value = "CODU")]
    [IsoId("_bCWRKNp-Ed-ak6NoX_4Aeg_-683393794")]
    [Description(@"Message is being sent as a copy to a party other than the account owner, for information purposes and the message is a duplicate of a message previously sent.")]
    CopyDuplicate,
    
    /// <summary>
    /// Message is being sent as a copy to a party other than the account owner, for information purposes.
    /// Encoded/decoded by serializers as "COPY".
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_bCgCINp-Ed-ak6NoX_4Aeg_-623363428")]
    [Description(@"Message is being sent as a copy to a party other than the account owner, for information purposes.")]
    Copy,
    
    /// <summary>
    /// Message is for information/confirmation purposes. It is a duplicate of a message previously sent.
    /// Encoded/decoded by serializers as "DUPL".
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bCgCIdp-Ed-ak6NoX_4Aeg_-621515903")]
    [Description(@"Message is for information/confirmation purposes. It is a duplicate of a message previously sent.")]
    Duplicate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CopyDuplicateCodeMetadataExtensions
{
    private static readonly CopyDuplicateCodeDropdownSource _dropdownSource = new CopyDuplicateCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICopyDuplicateCodeDropdownRow GetMetadata(this CopyDuplicateCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


