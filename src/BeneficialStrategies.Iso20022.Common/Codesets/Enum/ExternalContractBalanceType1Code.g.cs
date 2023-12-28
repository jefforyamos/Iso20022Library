﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalContractBalanceType1Code.  ISO2002 ID# _cjg1wQtKEeWkxvNyFrBT8Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a contract balance type code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cjg1wQtKEeWkxvNyFrBT8Q")]
[Description(@"Specifies a contract balance type code, as published in the external ISO 20022 external code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalContractBalanceTypeCode))]
public enum ExternalContractBalanceType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CurrentUtilisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uUDndfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CurrentUtilisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TotalUtilisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uUDnePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TotalUtilisation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalContractBalanceType1CodeMetadataExtensions
{
    private static readonly ExternalContractBalanceType1CodeDropdownSource _dropdownSource = new ExternalContractBalanceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalContractBalanceType1CodeDropdownRow GetMetadata(this ExternalContractBalanceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


