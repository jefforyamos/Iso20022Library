﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RedemptionCompletionCode.  ISO2002 ID# _yPkKwDwwEeaFzejt0Yw_3A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the redemption status of the redemption order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yPkKwDwwEeaFzejt0Yw_3A")]
[Description(@"Specifies the redemption status of the redemption order.")]
[Derivations(typeof(RedemptionCompletion1Code))]
// External derivations that should be provided by the proper interface are: 
public enum RedemptionCompletionCode
{
    /// <summary>
    /// Additional redemption order instructions must be sent to the executing party order to have the rest of the redemption executed.
    /// Encoded/decoded by serializers as "RED1".
    /// </summary>
    [EnumMember(Value = "RED1")]
    [IsoId("_41Ma8DwwEeaFzejt0Yw_3A")]
    [Description(@"Additional redemption order instructions must be sent to the executing party order to have the rest of the redemption executed.")]
    RedemptionYes,
    
    /// <summary>
    /// It is not necessary to send more redemption order instructions to the executing party to complete the redemption, the executing will generate redemption confirmations automatically.
    /// Encoded/decoded by serializers as "RED0".
    /// </summary>
    [EnumMember(Value = "RED0")]
    [IsoId("_76Bd4DwwEeaFzejt0Yw_3A")]
    [Description(@"It is not necessary to send more redemption order instructions to the executing party to complete the redemption, the executing will generate redemption confirmations automatically.")]
    RedemptionNo,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RedemptionCompletionCodeMetadataExtensions
{
    private static readonly RedemptionCompletionCodeDropdownSource _dropdownSource = new RedemptionCompletionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRedemptionCompletionCodeDropdownRow GetMetadata(this RedemptionCompletionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


