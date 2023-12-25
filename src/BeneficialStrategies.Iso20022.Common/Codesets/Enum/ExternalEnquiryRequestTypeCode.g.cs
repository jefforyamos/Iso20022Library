﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalEnquiryRequestTypeCode.  ISO2002 ID# _lY1lkZIgEeect698_YsnIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lY1lkZIgEeect698_YsnIA")]
[Description(@"Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code set published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalEnquiryRequestTypeCode
{
    /// <summary>
    /// Type is an enquiry on the bank's position.
    /// </summary>
    [EnumMember(Value = "RT11")]
    [IsoId("_ud444PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on the bank's position.")]
    RT11,
    
    /// <summary>
    /// Type is an enquiry on a specific transaction.
    /// </summary>
    [EnumMember(Value = "RT12")]
    [IsoId("_ud444_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on a specific transaction.")]
    RT12,
    
    /// <summary>
    /// Type is an enquiry on a queued transaction.
    /// </summary>
    [EnumMember(Value = "RT13")]
    [IsoId("_ueCp4PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on a queued transaction.")]
    RT13,
    
    /// <summary>
    /// Type is an enquiry on a suspicious transaction.
    /// </summary>
    [EnumMember(Value = "RT14")]
    [IsoId("_ueCp4_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on a suspicious transaction.")]
    RT14,
    
    /// <summary>
    /// Type is an enquiry on the system date and/or time.
    /// </summary>
    [EnumMember(Value = "RT16")]
    [IsoId("_ueCp5vRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on the system date and/or time.")]
    RT16,
    
    /// <summary>
    /// Type is an enquiry on pending inward credits.
    /// </summary>
    [EnumMember(Value = "RT15")]
    [IsoId("_ueCp6fRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on pending inward credits.")]
    RT15,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalEnquiryRequestTypeCodeMetadataExtensions
{
    private static readonly ExternalEnquiryRequestTypeCodeDropdownSource _dropdownSource = new ExternalEnquiryRequestTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalEnquiryRequestTypeCodeDropdownRow GetMetadata(this ExternalEnquiryRequestTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


