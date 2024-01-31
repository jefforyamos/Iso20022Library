﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalContractBalanceTypeCode.  ISO2002 ID# _kvoGMJGAEeeBGrZP1w0opg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a contract balance type code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kvoGMJGAEeeBGrZP1w0opg")]
[Description(@"Specifies a contract balance type code, as published in the external ISO 20022 external code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalContractBalanceType1Code))]
public enum ExternalContractBalanceTypeCode
{
    /// <summary>
    /// Revolver loan current utilisation (applicable on loan contracts types)
    /// Encoded/decoded by serializers as "EXPC".
    /// </summary>
    [EnumMember(Value = "EXPC")]
    [IsoId("_uUDnc_RYEeuLhpyIdtJzwg")]
    [Description(@"Revolver loan current utilisation (applicable on loan contracts types)")]
    CurrentUtilisation,
    
    /// <summary>
    /// Total loan utilisation for loans with total loan limit  (applicable on loan contracts types)
    /// Encoded/decoded by serializers as "EXPT".
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_uUDndvRYEeuLhpyIdtJzwg")]
    [Description(@"Total loan utilisation for loans with total loan limit  (applicable on loan contracts types)")]
    TotalUtilisation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalContractBalanceTypeCodeMetadataExtensions
{
    private static readonly ExternalContractBalanceTypeCodeDropdownSource _dropdownSource = new ExternalContractBalanceTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalContractBalanceTypeCodeDropdownRow GetMetadata(this ExternalContractBalanceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


