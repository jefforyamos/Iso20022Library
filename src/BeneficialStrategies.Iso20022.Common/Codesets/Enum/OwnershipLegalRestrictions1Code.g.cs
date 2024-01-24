﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OwnershipLegalRestrictions1Code.  ISO2002 ID# _ZxJH9Np-Ed-ak6NoX_4Aeg_1692772034.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regulatory restrictions applicable to a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxJH9Np-Ed-ak6NoX_4Aeg_1692772034")]
[Description(@"Specifies the regulatory restrictions applicable to a financial instrument.")]
[DerivedFrom(typeof(OwnershipLegalRestrictionsCode))]
public enum OwnershipLegalRestrictions1Code
{
    /// <summary>
    /// Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.
    /// Encoded/decoded by serializers as "A144".
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_ZxJH9dp-Ed-ak6NoX_4Aeg_1752799563")]
    [Description(@"Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.")]
    USLegal144A = OwnershipLegalRestrictionsCode.USLegal144A, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ownership or transfer of a security that is not subject to restrictions.
    /// Encoded/decoded by serializers as "NRST".
    /// </summary>
    [EnumMember(Value = "NRST")]
    [IsoId("_ZxJH9tp-Ed-ak6NoX_4Aeg_1767574892")]
    [Description(@"Ownership or transfer of a security that is not subject to restrictions.")]
    NoRestrictions = OwnershipLegalRestrictionsCode.NoRestrictions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZxJH99p-Ed-ak6NoX_4Aeg_1780503706")]
    [Description(@"Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.")]
    Restrictions = OwnershipLegalRestrictionsCode.Restrictions, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OwnershipLegalRestrictions1CodeMetadataExtensions
{
    private static readonly OwnershipLegalRestrictions1CodeDropdownSource _dropdownSource = new OwnershipLegalRestrictions1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOwnershipLegalRestrictions1CodeDropdownRow GetMetadata(this OwnershipLegalRestrictions1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


