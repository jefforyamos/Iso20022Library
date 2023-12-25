﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReceivedReasonCode.  ISO2002 ID# _n0f5oVjrEeOnqqBHs8Gasw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a received status.|
/// The list of valid codes is an external code list published separately. 
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n0f5oVjrEeOnqqBHs8Gasw")]
[Description(@"Specifies the reason for a received status.| The list of valid codes is an external code list published separately.  External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalReceivedReasonCode
{
    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_uVGJRvRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction was not straight through processing and had to be processed manually")]
    NSTP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReceivedReasonCodeMetadataExtensions
{
    private static readonly ExternalReceivedReasonCodeDropdownSource _dropdownSource = new ExternalReceivedReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReceivedReasonCodeDropdownRow GetMetadata(this ExternalReceivedReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


