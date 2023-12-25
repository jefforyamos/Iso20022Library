﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EligibleCode.  ISO2002 ID# _cJMIICC9EeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the item is eligible or not eligible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cJMIICC9EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is eligible or not eligible.")]
public enum EligibleCode
{
    /// <summary>
    /// Item is eligible.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_iJlkUCC9EeWPMvNwVtiMsA")]
    [Description(@"Item is eligible.")]
    ELIG,
    
    /// <summary>
    /// Item is not eligible.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_lRvoECC9EeWPMvNwVtiMsA")]
    [Description(@"Item is not eligible.")]
    NELI,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EligibleCodeMetadataExtensions
{
    private static readonly EligibleCodeDropdownSource _dropdownSource = new EligibleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEligibleCodeDropdownRow GetMetadata(this EligibleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


