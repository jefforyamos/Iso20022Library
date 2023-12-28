﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalReceivedReason1Code.  ISO2002 ID# _BRBXUFjsEeOnqqBHs8Gasw.
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
[IsoId("_BRBXUFjsEeOnqqBHs8Gasw")]
[Description(@"Specifies the reason for a received status.| The list of valid codes is an external code list published separately.  External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalReceivedReasonCode))]
public enum ExternalReceivedReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotStraightThroughProcessing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uVGJSPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NotStraightThroughProcessing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalReceivedReason1CodeMetadataExtensions
{
    private static readonly ExternalReceivedReason1CodeDropdownSource _dropdownSource = new ExternalReceivedReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalReceivedReason1CodeDropdownRow GetMetadata(this ExternalReceivedReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

