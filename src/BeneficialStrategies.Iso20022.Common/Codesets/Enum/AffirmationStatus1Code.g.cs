﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AffirmationStatus1Code.  ISO2002 ID# _bnTYWNp-Ed-ak6NoX_4Aeg_519503215.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the affirmation status of a trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnTYWNp-Ed-ak6NoX_4Aeg_519503215")]
[Description(@"Specifies the affirmation status of a trade.")]
[DerivedFrom(typeof(AffirmationStatusCode))]
public enum AffirmationStatus1Code
{
    /// <summary>
    /// Status of the transaction is affirmed.
    /// Encoded/decoded by serializers as "Affirmed".
    /// </summary>
    [EnumMember(Value = "AFFI")]
    [IsoId("_bndJUNp-Ed-ak6NoX_4Aeg_589689024")]
    [Description(@"Status of the transaction is affirmed.")]
    Affirmed,
    
    /// <summary>
    /// Status of the transaction is unaffirmed.
    /// Encoded/decoded by serializers as "Unaffirmed".
    /// </summary>
    [EnumMember(Value = "NAFI")]
    [IsoId("_bndJUdp-Ed-ak6NoX_4Aeg_618318083")]
    [Description(@"Status of the transaction is unaffirmed.")]
    Unaffirmed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AffirmationStatus1CodeMetadataExtensions
{
    private static readonly AffirmationStatus1CodeDropdownSource _dropdownSource = new AffirmationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAffirmationStatus1CodeDropdownRow GetMetadata(this AffirmationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


