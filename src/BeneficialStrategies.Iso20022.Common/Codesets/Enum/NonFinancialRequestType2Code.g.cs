﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NonFinancialRequestType2Code.  ISO2002 ID# _hbH7sXC8Ee2bmOA3bkVsMg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbH7sXC8Ee2bmOA3bkVsMg")]
[Description(@"Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.")]
[DerivedFrom(typeof(NonFinancialRequestTypeCode))]
public enum NonFinancialRequestType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerSelection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hiZBUXC8Ee2bmOA3bkVsMg")]
    [Description(@"??")]
    AcquirerSelection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hiZBU3C8Ee2bmOA3bkVsMg")]
    [Description(@"??")]
    ParRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RiskManagement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hiZBVXC8Ee2bmOA3bkVsMg")]
    [Description(@"??")]
    RiskManagement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TokenRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hiZBV3C8Ee2bmOA3bkVsMg")]
    [Description(@"??")]
    TokenRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AdditionalRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mQM0QXC8Ee2bmOA3bkVsMg")]
    [Description(@"??")]
    AdditionalRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstalmentPlanRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_maVnsXC8Ee2bmOA3bkVsMg")]
    [Description(@"??")]
    InstalmentPlanRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NonFinancialRequestType2CodeMetadataExtensions
{
    private static readonly NonFinancialRequestType2CodeDropdownSource _dropdownSource = new NonFinancialRequestType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INonFinancialRequestType2CodeDropdownRow GetMetadata(this NonFinancialRequestType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


