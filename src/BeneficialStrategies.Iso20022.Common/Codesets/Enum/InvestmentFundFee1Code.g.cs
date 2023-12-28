﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundFee1Code.  ISO2002 ID# _YL5_oDiCEeaH-93K5JKmzw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a fee e is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YL5_oDiCEeaH-93K5JKmzw")]
[Description(@"Specifies the type of service for which a fee e is asked or paid.")]
[DerivedFrom(typeof(InvestmentFundFeeCode))]
public enum InvestmentFundFee1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BackEndLoad".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cAfrkTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    BackEndLoad,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BrokerageFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cKKk8TiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    BrokerageFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Commission".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cT1eUTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    Commission,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommissionDePlacement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cdqIsTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    CommissionDePlacement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContingentDeferredSalesCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cnL4ITiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    ContingentDeferredSalesCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorrespondentBankCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cxmYYTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    CorrespondentBankCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DilutionLevy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dFFVETiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    DilutionLevy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FrontEndLoad".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dkB64TiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    FrontEndLoad,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InitialCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dx3ikTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    InitialCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AdditionalFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_d-N8gTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    AdditionalFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PostageCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eLBCYTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    PostageCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Premium".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eU1FsTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    Premium,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ServiceProvisionFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eezhETiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    ServiceProvisionFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShippingCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eoeacTiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    ShippingCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ex_i0TiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    Switch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UCITSCommission".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_fU9F8TiCEeaH-93K5JKmzw")]
    [Description(@"??")]
    UCITSCommission,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegulatoryFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EtSw8TkpEeapUO0vUIo9Xw")]
    [Description(@"??")]
    RegulatoryFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Penalty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z5oZoa2aEea0Qtj9EW8okQ")]
    [Description(@"??")]
    Penalty,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundFee1CodeMetadataExtensions
{
    private static readonly InvestmentFundFee1CodeDropdownSource _dropdownSource = new InvestmentFundFee1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundFee1CodeDropdownRow GetMetadata(this InvestmentFundFee1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

