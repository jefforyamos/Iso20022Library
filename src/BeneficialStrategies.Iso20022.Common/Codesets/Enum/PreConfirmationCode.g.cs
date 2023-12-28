﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PreConfirmationCode.  ISO2002 ID# _aIFoUtp-Ed-ak6NoX_4Aeg_1034952016.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if there is a pre-confirmation of cash or securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIFoUtp-Ed-ak6NoX_4Aeg_1034952016")]
[Description(@"Specifies if there is a pre-confirmation of cash or securities.")]
public enum PreConfirmationCode
{
    /// <summary>
    /// Pre-confirmation of the movement of the cash, pending the movement of securities.
    /// Encoded/decoded by serializers as "PRCA".
    /// </summary>
    [EnumMember(Value = "PRCA")]
    [IsoId("_aIFoU9p-Ed-ak6NoX_4Aeg_-1927375439")]
    [Description(@"Pre-confirmation of the movement of the cash, pending the movement of securities.")]
    PreConfirmCash,
    
    /// <summary>
    /// Pre-confirmation of the movement of the securities, pending the movement of cash.
    /// Encoded/decoded by serializers as "PRSE".
    /// </summary>
    [EnumMember(Value = "PRSE")]
    [IsoId("_aIFoVNp-Ed-ak6NoX_4Aeg_-1628151846")]
    [Description(@"Pre-confirmation of the movement of the securities, pending the movement of cash.")]
    PreConfirmSecurities,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PreConfirmationCodeMetadataExtensions
{
    private static readonly PreConfirmationCodeDropdownSource _dropdownSource = new PreConfirmationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPreConfirmationCodeDropdownRow GetMetadata(this PreConfirmationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

