﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstalmentPlanCode.  ISO2002 ID# _pQ8HgDDgEeO9waS4ina8CA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of instalment plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pQ8HgDDgEeO9waS4ina8CA")]
[Description(@"Type of instalment plan.")]
[Derivations(typeof(InstalmentPlan1Code))]
public enum InstalmentPlanCode
{
    /// <summary>
    /// The payment is split in several instalments of equal amounts.
    /// Encoded/decoded by serializers as "EQPM".
    /// </summary>
    [EnumMember(Value = "EQPM")]
    [IsoId("_-LwUkDDgEeO9waS4ina8CA")]
    [Description(@"The payment is split in several instalments of equal amounts.")]
    EqualPayment,
    
    /// <summary>
    /// The payment is split in several instalments of different amounts.
    /// Encoded/decoded by serializers as "NQPM".
    /// </summary>
    [EnumMember(Value = "NQPM")]
    [IsoId("_CtHm8DDhEeO9waS4ina8CA")]
    [Description(@"The payment is split in several instalments of different amounts.")]
    InequalPayment,
    
    /// <summary>
    /// The first instalment is deferred.
    /// Encoded/decoded by serializers as "DFRI".
    /// </summary>
    [EnumMember(Value = "DFRI")]
    [IsoId("_gt1ZwDGrEeOVuYdyXoFwuA")]
    [Description(@"The first instalment is deferred.")]
    DeferredInstalment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstalmentPlanCodeMetadataExtensions
{
    private static readonly InstalmentPlanCodeDropdownSource _dropdownSource = new InstalmentPlanCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstalmentPlanCodeDropdownRow GetMetadata(this InstalmentPlanCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


