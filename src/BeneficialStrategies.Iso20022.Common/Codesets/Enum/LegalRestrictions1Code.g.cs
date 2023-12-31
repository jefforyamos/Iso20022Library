﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LegalRestrictions1Code.  ISO2002 ID# _ad1159p-Ed-ak6NoX_4Aeg_-752434714.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regulatory restrictions applicable to a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad1159p-Ed-ak6NoX_4Aeg_-752434714")]
[Description(@"Specifies the regulatory restrictions applicable to a security.")]
[DerivedFrom(typeof(LegalRestrictionsCode))]
public enum LegalRestrictions1Code
{
    /// <summary>
    /// Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.
    /// Encoded/decoded by serializers as "USLegal144A".
    /// </summary>
    [EnumMember(Value = "USLE")]
    [IsoId("_ad_m4Np-Ed-ak6NoX_4Aeg_-481845169")]
    [Description(@"Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.")]
    USLegal144A,
    
    /// <summary>
    /// Ownership or transfer of a security that is not subject to restrictions.
    /// Encoded/decoded by serializers as "NoRestrictions".
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_ad_m4dp-Ed-ak6NoX_4Aeg_-234340489")]
    [Description(@"Ownership or transfer of a security that is not subject to restrictions.")]
    NoRestrictions,
    
    /// <summary>
    /// Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.
    /// Encoded/decoded by serializers as "Restrictions".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ad_m4tp-Ed-ak6NoX_4Aeg_-8075812")]
    [Description(@"Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.")]
    Restrictions,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LegalRestrictions1CodeMetadataExtensions
{
    private static readonly LegalRestrictions1CodeDropdownSource _dropdownSource = new LegalRestrictions1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILegalRestrictions1CodeDropdownRow GetMetadata(this LegalRestrictions1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


