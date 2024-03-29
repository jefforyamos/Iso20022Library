﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnitOfMeasure10Code.  ISO2002 ID# _vfbbYF_pEee-csPAW1txwQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of measure expressed in miles and kilometres.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vfbbYF_pEee-csPAW1txwQ")]
[Description(@"Unit of measure expressed in miles and kilometres.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
public enum UnitOfMeasure10Code
{
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_l6goQX0mEemfrNOe0zHQyg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_l6goQ30mEemfrNOe0zHQyg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions
    
}
