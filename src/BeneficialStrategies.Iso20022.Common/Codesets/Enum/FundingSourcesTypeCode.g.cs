﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundingSourcesTypeCode.  ISO2002 ID# _9_E2EFXIEeeUQbJN-rt4dg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Information on Funding sources used to finance margin loans.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9_E2EFXIEeeUQbJN-rt4dg")]
[Description(@"Information on Funding sources used to finance margin loans.")]
public enum FundingSourcesTypeCode
{
    /// <summary>
    /// Type of a funding source is repo or buy sell back.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_kDhdkFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is repo or buy sell back.")]
    RepoOrBSB,
    
    /// <summary>
    /// Type of a funding source is cash collateral from securities lending. 
    /// Encoded/decoded by serializers as "SECL".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_mnICwFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is cash collateral from securities lending. ")]
    CashCollateralFromSecuritiesLending,
    
    /// <summary>
    /// Type of a funding source is free credits. 
    /// Encoded/decoded by serializers as "FREE".
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_q0pzIFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is free credits. ")]
    FreeCredits,
    
    /// <summary>
    /// Type of a funding source is proceeds from customer short sales. 
    /// Encoded/decoded by serializers as "CSHS".
    /// </summary>
    [EnumMember(Value = "CSHS")]
    [IsoId("_s9P3UFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from customer short sales. ")]
    ProceedsFromCustomerShortSales,
    
    /// <summary>
    /// Type of a funding source is proceeds from broker short sales. 
    /// Encoded/decoded by serializers as "BSHS".
    /// </summary>
    [EnumMember(Value = "BSHS")]
    [IsoId("_vKS9sFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from broker short sales. ")]
    ProceedsFromBrokerShortSales,
    
    /// <summary>
    /// Type of a funding source is unsecured borrowing. 
    /// Encoded/decoded by serializers as "UBOR".
    /// </summary>
    [EnumMember(Value = "UBOR")]
    [IsoId("_xedYsFXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is unsecured borrowing. ")]
    UnsecuredBorrowing,
    
    /// <summary>
    /// Other type of a funding source.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_zwYYAFXJEeeUQbJN-rt4dg")]
    [Description(@"Other type of a funding source.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundingSourcesTypeCodeMetadataExtensions
{
    private static readonly FundingSourcesTypeCodeDropdownSource _dropdownSource = new FundingSourcesTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundingSourcesTypeCodeDropdownRow GetMetadata(this FundingSourcesTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


