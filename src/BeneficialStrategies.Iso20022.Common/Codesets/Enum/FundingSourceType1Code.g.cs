﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundingSourceType1Code.  ISO2002 ID# _7yTnEFXJEeeUQbJN-rt4dg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of a funding used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7yTnEFXJEeeUQbJN-rt4dg")]
[Description(@"Type of a funding used.")]
[DerivedFrom(typeof(FundingSourcesTypeCode))]
public enum FundingSourceType1Code
{
    /// <summary>
    /// Type of a funding source is cash collateral from securities lending. 
    /// Encoded/decoded by serializers as "SECL".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_9FUuIVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is cash collateral from securities lending. ")]
    CashCollateralFromSecuritiesLending = FundingSourcesTypeCode.CashCollateralFromSecuritiesLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of a funding source is free credits. 
    /// Encoded/decoded by serializers as "FREE".
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_9KwnwVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is free credits. ")]
    FreeCredits = FundingSourcesTypeCode.FreeCredits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of a funding source.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9PbsYVXJEeeUQbJN-rt4dg")]
    [Description(@"Other type of a funding source.")]
    Other = FundingSourcesTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of a funding source is proceeds from broker short sales. 
    /// Encoded/decoded by serializers as "BSHS".
    /// </summary>
    [EnumMember(Value = "BSHS")]
    [IsoId("_9UZE4VXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from broker short sales. ")]
    ProceedsFromBrokerShortSales = FundingSourcesTypeCode.ProceedsFromBrokerShortSales, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of a funding source is proceeds from customer short sales. 
    /// Encoded/decoded by serializers as "CSHS".
    /// </summary>
    [EnumMember(Value = "CSHS")]
    [IsoId("_9Zu34VXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is proceeds from customer short sales. ")]
    ProceedsFromCustomerShortSales = FundingSourcesTypeCode.ProceedsFromCustomerShortSales, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of a funding source is repo or buy sell back.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_9eBiAVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is repo or buy sell back.")]
    RepoOrBSB = FundingSourcesTypeCode.RepoOrBSB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of a funding source is unsecured borrowing. 
    /// Encoded/decoded by serializers as "UBOR".
    /// </summary>
    [EnumMember(Value = "UBOR")]
    [IsoId("_9j12IVXJEeeUQbJN-rt4dg")]
    [Description(@"Type of a funding source is unsecured borrowing. ")]
    UnsecuredBorrowing = FundingSourcesTypeCode.UnsecuredBorrowing, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundingSourceType1CodeMetadataExtensions
{
    private static readonly FundingSourceType1CodeDropdownSource _dropdownSource = new FundingSourceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundingSourceType1CodeDropdownRow GetMetadata(this FundingSourceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


