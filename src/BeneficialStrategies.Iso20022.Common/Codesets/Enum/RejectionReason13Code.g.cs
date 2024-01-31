﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason13Code.  ISO2002 ID# _Zgv7idp-Ed-ak6NoX_4Aeg_1920640283.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of a movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zgv7idp-Ed-ak6NoX_4Aeg_1920640283")]
[Description(@"Specifies the reason of a rejection of a movement.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason13Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zg5FcNp-Ed-ak6NoX_4Aeg_-1186004164")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as "SAID".
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Zg5Fcdp-Ed-ak6NoX_4Aeg_-1186004134")]
    [Description(@"Several message with the same identification.")]
    SameIdentification = RejectionReasonCode.SameIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as "INID".
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_Zg5Fctp-Ed-ak6NoX_4Aeg_-1186004103")]
    [Description(@"Instruction contains an invalid message identification, identification is unknown.")]
    InvalidIdentification = RejectionReasonCode.InvalidIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as "REFI".
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_Zg5Fc9p-Ed-ak6NoX_4Aeg_-1186004102")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification = RejectionReasonCode.InvalidCAIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer CA Identification does not correspond with the Corporate Action Identification supplied.
    /// Encoded/decoded by serializers as "MICA".
    /// </summary>
    [EnumMember(Value = "MICA")]
    [IsoId("_Zg5FdNp-Ed-ak6NoX_4Aeg_-1186004072")]
    [Description(@"Issuer CA Identification does not correspond with the Corporate Action Identification supplied.")]
    MismatchedCAIdentification = RejectionReasonCode.MismatchedCAIdentification, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason13CodeMetadataExtensions
{
    private static readonly RejectionReason13CodeDropdownSource _dropdownSource = new RejectionReason13CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason13CodeDropdownRow GetMetadata(this RejectionReason13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


