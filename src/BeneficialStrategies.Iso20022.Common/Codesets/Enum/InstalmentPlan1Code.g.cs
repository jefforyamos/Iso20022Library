﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstalmentPlan1Code.  ISO2002 ID# _RYB8MDDhEeO9waS4ina8CA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of instalment plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RYB8MDDhEeO9waS4ina8CA")]
[Description(@"Type of instalment plan.")]
[DerivedFrom(typeof(InstalmentPlanCode))]
public enum InstalmentPlan1Code
{
    /// <summary>
    /// The payment is split in several instalments of equal amounts.
    /// Encoded/decoded by serializers as "EqualPayment".
    /// </summary>
    [EnumMember(Value = "EQPM")]
    [IsoId("_VzJcoTDhEeO9waS4ina8CA")]
    [Description(@"The payment is split in several instalments of equal amounts.")]
    EqualPayment,
    
    /// <summary>
    /// The payment is split in several instalments of different amounts.
    /// Encoded/decoded by serializers as "InequalPayment".
    /// </summary>
    [EnumMember(Value = "NQPM")]
    [IsoId("_V4pnsTDhEeO9waS4ina8CA")]
    [Description(@"The payment is split in several instalments of different amounts.")]
    InequalPayment,
    
    /// <summary>
    /// The first instalment is deferred.
    /// Encoded/decoded by serializers as "DeferredInstalment".
    /// </summary>
    [EnumMember(Value = "DFRI")]
    [IsoId("_31iVITGrEeOVuYdyXoFwuA")]
    [Description(@"The first instalment is deferred.")]
    DeferredInstalment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstalmentPlan1CodeMetadataExtensions
{
    private static readonly InstalmentPlan1CodeDropdownSource _dropdownSource = new InstalmentPlan1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstalmentPlan1CodeDropdownRow GetMetadata(this InstalmentPlan1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


