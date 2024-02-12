﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OwnershipLegalRestrictionsCode.  ISO2002 ID# _ZxJH-Np-Ed-ak6NoX_4Aeg_-853156966.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory restrictions applicable to a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxJH-Np-Ed-ak6NoX_4Aeg_-853156966")]
[Description(@"Specifies the regulatory restrictions applicable to a financial instrument.")]
[Derivations(typeof(OwnershipLegalRestrictions1Code))]
public enum OwnershipLegalRestrictionsCode
{
    /// <summary>
    /// Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.
    /// Encoded/decoded by serializers as "A144".
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_ZxSR4Np-Ed-ak6NoX_4Aeg_-853156948")]
    [Description(@"Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.")]
    USLegal144A,
    
    /// <summary>
    /// Ownership or transfer of a security that is not subject to restrictions.
    /// Encoded/decoded by serializers as "NRST".
    /// </summary>
    [EnumMember(Value = "NRST")]
    [IsoId("_ZxSR4dp-Ed-ak6NoX_4Aeg_-853156940")]
    [Description(@"Ownership or transfer of a security that is not subject to restrictions.")]
    NoRestrictions,
    
    /// <summary>
    /// Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.
    /// Encoded/decoded by serializers as "RSTR".
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZxSR4tp-Ed-ak6NoX_4Aeg_-853156923")]
    [Description(@"Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.")]
    Restrictions,
    
}
